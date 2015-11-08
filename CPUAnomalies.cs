using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace acIDS
{
    public class CPUAnomalies
    {
        public static float NormalCPU { get; set; }
        public static int Counter { get; set; }
        public static float TotalCPU { get; set; }
        public static bool DoneSettingNormalUsage { get; set; } = false;

        public static void StartAnomalyDetection(TextBox warningTextBox)
        {     
            if (DoneSettingNormalUsage)
            {
                if (CPUMonitor.CPUCounter > NormalCPU)
                {
                    if (warningTextBox.Text.Length == 0)
                    {
                        warningTextBox.Invoke(new Action(() =>
                        {
                            warningTextBox.Text = "CPU Usage: " + CPUMonitor.CPUCounter.ToString("F2") + "%";
                            CPUMonitor.CPUWarnings = warningTextBox.Text;
                        }));
                    }
                    else
                    {
                        warningTextBox.Invoke(new Action(() =>
                        {
                        warningTextBox.AppendText("\r\nCPU Usage: " + CPUMonitor.CPUCounter.ToString("F2") + "%");
                            CPUMonitor.CPUWarnings = warningTextBox.Text;
                        }));
                    }
                }
            }
        }

        public static async void SetNormalUsageByTime(int minutes, int seconds)
        {
            await Task.Delay(10000);
            Stopwatch timer = new Stopwatch();
            timer.Start();
            TimeSpan elapsed = timer.Elapsed;
            while (elapsed.Seconds <= seconds && elapsed.Minutes <= minutes)
            {
                elapsed = timer.Elapsed;
                TotalCPU += CPUMonitor.AverageCPU;
                Counter++;
                NormalCPU = TotalCPU / Counter;
            }
            DoneSettingNormalUsage = true;
        }
    }
}