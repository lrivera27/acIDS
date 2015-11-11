using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace acIDS
{
    //Contains all monitoring methods for the Hosted IDS
    public class Monitor
    {
        public float CounterMonitor { get; set; }
        public float LowestMonitor { get; set; }
        public float HighestMonitor { get; set; }
        public float AverageMonitor { get; set; }
        public float TotalMonitor { get; set; }
        public float WarningsMonitor { get; set; }
        public float Counter { get; set; }
        
        //Enums to tell the method what its monitoring
        public enum PC { CPU, RAM, PROCESSES}

        //Calls the monitoring methods by running new tasks
        public void StartMonitoring(TextBox usageTextBox, TextBox warningTextBox, PC monitor)
        {
            PerformanceCounter performanceCounter = new PerformanceCounter();

            switch (monitor)
            {
                case PC.CPU:
                    
                    performanceCounter.CategoryName = "Processor";
                    performanceCounter.CounterName = "% Processor Time";
                    performanceCounter.InstanceName = "_Total";  
                                 
                    break;

                case PC.RAM:
                    performanceCounter.CategoryName = "Memory";
                    performanceCounter.CounterName = "Available MBytes";
                    break;

                case PC.PROCESSES:

                    break;

                default:
                    MessageBox.Show("Didn't work");
                    break;
            }

            Task.Run(() => { Monitoring(usageTextBox, warningTextBox, performanceCounter); });

        }

        public async void Monitoring(TextBox usageTextBox, TextBox warningTextBox, PerformanceCounter performanceCounter)
        {
            while (true)
            {
                //First value always returns a 0
                var unused = performanceCounter.NextValue();
                await Task.Delay(1000);

                usageTextBox.Invoke(new Action(() =>
                {
                    CounterMonitor = performanceCounter.NextValue();
                    usageTextBox.Text = CounterMonitor.ToString("F2") + "%";
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
    }
}
