using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acIDS
{
    //This class will hold all of the CPU monitoring related methods
    public class CPUMonitor
    {
        public static float CPUCounter { get; set; }
        public static float LowestCPU { get; set; } = 100;
        public static float HighestCPU { get; set; } = 0;
        public static float AverageCPU { get; set; }
        public static float TotalCPU { get; set; }
        public static int Counter { get; set; }

        public static void StartMonitoring(TextBox usageTextBox, TextBox warningTextBox, int minutes, int seconds)
        {
            Task.Run(() => { CPUAnomalies.SetNormalUsageByTime(minutes, seconds); });
            Task.Run(() => { CPUMonitoring(usageTextBox, warningTextBox); });
        }
        //Function will read and display current CPU usage
        public static async void CPUMonitoring(TextBox usageTextBox, TextBox warningTextBox)
        {

            PerformanceCounter cpuCounter = new PerformanceCounter();
            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";

            while (true)
            {
                //First value always returns a 0
                var unused = cpuCounter.NextValue();
                await Task.Delay(1000);

                usageTextBox.Invoke(new Action(() =>
                {
                    CPUCounter = cpuCounter.NextValue();
                    usageTextBox.Text = CPUCounter.ToString("F2") + "%";
                }));
                CPUCalculations();
                CPUAnomalies.StartAnomalyDetection(warningTextBox);

                if (mainMenu.done)
                    break;
            }
        }

        public static void CPUCalculations()
        {
            if (HighestCPU < CPUCounter)
                HighestCPU = CPUCounter;

            else if (LowestCPU > CPUCounter)
                LowestCPU = CPUCounter;

            Counter++;
            TotalCPU += CPUCounter;
            AverageCPU = TotalCPU / Counter;
        }
    }
}
