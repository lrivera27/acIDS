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

        public static void StartMonitoring(TextBox usageTextBox)
        {
            var monitoring = new Thread(o => CPUMonitoring((TextBox)o));
            monitoring.Start(usageTextBox);

        }
        //Function will read and display current CPU usage
        public static void CPUMonitoring(TextBox usageTextBox)
        {

            PerformanceCounter cpuCounter = new PerformanceCounter();
            cpuCounter.CategoryName = "Processor";
            cpuCounter.CounterName = "% Processor Time";
            cpuCounter.InstanceName = "_Total";

            while (!mainMenu.done)
            {
                var unused = cpuCounter.NextValue();
                Thread.Sleep(1000);

                usageTextBox.Invoke((Action)delegate
                {
                    CPUCounter = cpuCounter.NextValue();
                    usageTextBox.Text = CPUCounter.ToString("F2") + "%";
                });
                CPUCalculations();
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
