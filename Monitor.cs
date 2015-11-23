using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace acIDS
{
    //Contains all monitoring methods for the Hosted IDS
    public class Monitor
    {
        private float CounterMonitor { get; set; }
        private float LowestMonitor { get; set; } 
        private float HighestMonitor { get; set; }
        private float AverageMonitor { get; set; }
        private float TotalMonitor { get; set; }
        private float Counter { get; set; }
        private string Postfix { get; set; }
        private string Test { get; set; }

        Anomaly anomaly = new Anomaly();

        //Enums to tell the method what its monitoring
        public enum PC { CPU, RAM, PROCESSES }

        public Monitor()
        {  
            LowestMonitor = 100000;
            HighestMonitor = 0;
        }

        public void SetString(string str)
        {
            Test = str;
        }

        public string ReturnString()
        {
            return Test;
        }
        //Calls the monitoring methods by running new tasks
        public void StartMonitoring(TextBox usageTextBox, TextBox warningTextBox, PC monitor, int minutes, int seconds)
        {
            Task.Run(() => anomaly.SetNormalUsageByTime(minutes, seconds));
            
            PerformanceCounter performanceCounter = new PerformanceCounter();
            bool processes = false;
            switch (monitor)
            {
                case PC.CPU:
                    performanceCounter.CategoryName = "Processor";
                    performanceCounter.CounterName = "% Processor Time";
                    performanceCounter.InstanceName = "_Total";
                    Postfix = "%";
                    break;

                case PC.RAM:
                    performanceCounter.CategoryName = "Memory";
                    performanceCounter.CounterName = "Available MBytes";
                    Postfix = "MB";
                    break;

                case PC.PROCESSES:
                    processes = true;
                    Task.Run(() => ProcessMonitoring(usageTextBox, warningTextBox));
                    break;

                default:
                    MessageBox.Show("Didn't work");
                    break;
            }
            if (!processes)
                Task.Run(() => { Monitoring(usageTextBox, warningTextBox, performanceCounter); });

        }

        public async void Monitoring(TextBox usageTextBox, TextBox warningTextBox, PerformanceCounter performanceCounter)
        {
            while (true)
            {
                anomaly.StartAnomalyDetection(warningTextBox, CounterMonitor, Postfix);
                //First value always returns a 0
                var unused = performanceCounter.NextValue();
                await Task.Delay(1000);

                usageTextBox.Invoke(new Action(() =>
                {
                    CounterMonitor = performanceCounter.NextValue();
                    usageTextBox.Text = tools.DoFormat(CounterMonitor) + Postfix;
                }));

                if (mainMenu.done)
                    break;
            }
        }
        //Calculates the Highest, Lowest and the Average for each PC monitoring
        public void MonitorCalculations()
        {
            if (HighestMonitor < CounterMonitor)
                HighestMonitor = CounterMonitor;

            else if (LowestMonitor > CounterMonitor)
                LowestMonitor = CounterMonitor;

            Counter++;
            TotalMonitor += CounterMonitor;
            AverageMonitor = TotalMonitor / Counter;

        }

        public async void ProcessMonitoring(TextBox usageTextBox, TextBox listTextBox)
        {
            CurrentNumberProcesses();
            float changed = CounterMonitor + 1;
            string[] data;

            while (true)
            {
                await Task.Delay(1000);
                CurrentNumberProcesses();
                usageTextBox.Invoke(new Action(() =>
                {
                    usageTextBox.Text = CounterMonitor + "";
                }));

                if (changed != CounterMonitor)
                {
                    changed = CounterMonitor;
                    listTextBox.Invoke(new Action(() =>
                    {
                        data = ReadProcesses();

                        foreach (string pData in data)
                        {
                            if (listTextBox.Text.Length < 0)
                                listTextBox.Text = pData;
                            else
                                listTextBox.AppendText($"\r\n{pData}");
                        }
                    }));
                }
            }
        }
        public void CurrentNumberProcesses()
        {
            Process[] numProcess = Process.GetProcesses();
            CounterMonitor = numProcess.Length;
        }

        public static string[] ReadProcesses()
        {
            Process[] allProcesesses = Process.GetProcesses();

            string[] data = new string[allProcesesses.Length];

            for (int i = 0; i < allProcesesses.Length; i++)
                data[i] = allProcesesses[i].ProcessName;
            return data;
        }

        public static string ReadProcessesAsString()
        {
            var output = "";
            foreach (var str in ReadProcesses())
            {
                output += str + Environment.NewLine;
            }
            return output;
        }

       
    }
}
