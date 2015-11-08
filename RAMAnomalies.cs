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
    public class RAMAnomalies
    {
        public static float NormalRAM { get; set; }
        public static float Counter { get; set; }
        public static float TotalRAM { get; set; }
        public static bool DoneSettingNormalUsage { set; get; }
        public static string RAMWarnings { get; set; }

        public static void StartAnomalyDetection(TextBox warningTextBox)
        {
            if (DoneSettingNormalUsage)
            {
                if(true)
                {
                    if(warningTextBox.Text.Length == 0)
                    {
                        warningTextBox.Invoke(new Action(() =>
                        {
                            warningTextBox.Text = $"Warning! RAM Usage: {RAMMonitor.RAMCounter} MB";
                        }));
                    } else
                    {
                        warningTextBox.Invoke(new Action(() =>
                        {
                            warningTextBox.AppendText($"\r\nWarning! RAM Usage: {RAMMonitor.RAMCounter} MB");
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
                TotalRAM += RAMMonitor.AverageRAM;
                Counter++;
                NormalRAM = TotalRAM / Counter;
            }
            DoneSettingNormalUsage = true;
        }
    }
}
