using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acIDS
{
    class Anomaly
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
        public async void StartAnomalyDetection(TextBox warningTextBox, float currentUsage)
        {
            CurrentUsage = currentUsage;

            if (DoneSettingUsage)
            {
                await Task.Run(() => ThrowWarning(warningTextBox));
            }
        }

        public void ThrowWarning(TextBox warningTextBox)
        {
            if (true)
            {
                if (warningTextBox.Text.Length == 0)
                {
                    warningTextBox.Invoke(new Action(() =>
                    {
                        warningTextBox.Text = "Usage: " + CurrentUsage.ToString("F2") + "%";
                        WarningUsage = warningTextBox.Text;
                    }));
                }
                else
                {
                    warningTextBox.Invoke(new Action(() =>
                    {
                        warningTextBox.AppendText("\r\nUsage: " + CurrentUsage.ToString("F2") + "%");
                        WarningUsage = warningTextBox.Text;
                    }));
                }
            }

        }

        public async void SetNormalUsageByTime(int minutes, int seconds)
        {
            await Task.Delay(10000);
            Stopwatch timer = new Stopwatch();
            timer.Start();
            TimeSpan elapsed = timer.Elapsed;
            await Task.Run(() =>
            {
                while (elapsed.Seconds <= seconds && elapsed.Minutes <= minutes)
                {
                    elapsed = timer.Elapsed;
                    TotalUsage += CurrentUsage;
                    Counter++;
                    NormalUsage = TotalUsage / Counter;
                }
            });
            DoneSettingUsage = true;
        }
    }
}

