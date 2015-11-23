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
    public class Anomaly
    {
        private float NormalUsage { get; set; }
        private float Counter { get; set; }
        private float TotalUsage { get; set; }
        private bool DoneSettingUsage { get; set; }
        private string WarningUsage { get; set; }
        private float CurrentUsage { get; set; }

        public Anomaly()
        {
            DoneSettingUsage = false;
        }
        
        public async void StartAnomalyDetection(TextBox warningTextBox, float currentUsage, String postfix)
        {
            CurrentUsage = currentUsage;

            if (DoneSettingUsage)
            {
                await Task.Run(() => ThrowWarning(warningTextBox, postfix));
            }
        }

        public void ThrowWarning(TextBox warningTextBox, string postfix)
        {
            if (NormalUsage > CurrentUsage)
            {
                if (warningTextBox.Text.Length == 0)
                {
                    warningTextBox.Invoke(new Action(() =>
                    {
                        warningTextBox.Text = "Usage: " + tools.DoFormat(CurrentUsage) + postfix;
                        WarningUsage = warningTextBox.Text;
                    }));
                }
                else
                {
                    warningTextBox.Invoke(new Action(() =>
                    {
                        warningTextBox.AppendText("\r\nUsage: " + tools.DoFormat(CurrentUsage) + postfix);
                        WarningUsage = warningTextBox.Text;
                    }));
                }
            }

        }

        public async void SetNormalUsageByTime(int minutes, int seconds)
        {

            await Task.Delay(5000);
            Stopwatch timer = new Stopwatch();
            timer.Start();
            TimeSpan elapsed = timer.Elapsed;

            while (elapsed.Seconds <= seconds && elapsed.Minutes <= minutes)
            {
                await Task.Delay(20);
                elapsed = timer.Elapsed;
                TotalUsage += CurrentUsage;
                Counter++;
            }

            NormalUsage = TotalUsage / Counter;
            DoneSettingUsage = true;
        }
    }
}

