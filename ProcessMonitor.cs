using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acIDS
{
    public class ProcessMonitor
    {
        public static int ProcessCounter { get; set; }
        public static int LowestProccess { get; set; }
        public static int HighestProcess { get; set; }
        public static int AverageProcess { get; set; }
        public static int TotalProcesses { get; set; }
        public static int Counter { get; set; }

        public static void Startmonitoring(TextBox usageTextBox, TextBox listTextBox)
        {
            Task.Run(() => { ProcessMonitoring(usageTextBox, listTextBox); });
        }

        public static async void ProcessMonitoring(TextBox usageTextBox, TextBox listTextBox)
        {
            int changed = ProcessCounter;
            string[] data;
            while (true)
            {
                await Task.Delay(1000);
                CurrentNumberProcesses();
                usageTextBox.Invoke(new Action(() =>
                {
                    usageTextBox.Text = ProcessCounter + "";
                }));

                if (changed != ProcessCounter)
                {
                    changed = ProcessCounter;
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
        public static void CurrentNumberProcesses()
        {
            Process[] numProcess = Process.GetProcesses();
            ProcessCounter = numProcess.Length;
        }

        public static string[] ReadProcesses()
        {
            Process[] allProcesesses = Process.GetProcesses();

            string[] data = new string[allProcesesses.Length];

            for (int i = 0; i < allProcesesses.Length; i++)
                data[i] = allProcesesses[i].ProcessName;
            return data;
        }

        public static void ProcessCalculations()
        {
            if (HighestProcess < ProcessCounter)
                HighestProcess = ProcessCounter;
            else if (LowestProccess > ProcessCounter)
                LowestProccess = ProcessCounter;

            Counter++;
            TotalProcesses += ProcessCounter;
            AverageProcess = TotalProcesses / Counter;
        }

        public static string ReadProcessesAsString()
        {
            var output = "";
            bool first = true;
            foreach (var str in ReadProcesses())
            {
                if (!first)
                    output += "                " + str + Environment.NewLine;
                else
                {
                    output += str + Environment.NewLine;
                    first = false;
                }
            }
            return output;
        }
    }
}
