using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace acIDS
{
    public class RAMMonitor
    {
        public static float RAMCounter { get; set; }
        public static float LowestRAM { get; set; } = 1000000;
        public static float HighestRAM { get; set; } = 0;
        public static float AverageRAM { get; set; }
        public static float TotalRAM { get; set; }
        public static float Counter { get; set; }

        public static void Startmonitoring(TextBox usageTextBox)
        {
            Task.Run(() => { RAMMonitoring(usageTextBox); });
        }

        public static async void RAMMonitoring(TextBox usageTextBox)
        {
            PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");

            while (true)
            {
                await Task.Delay(1000);

                usageTextBox.Invoke(new Action(() =>
               {
                   RAMCounter = ramCounter.NextValue();
                   usageTextBox.Text = RAMCounter + "MB";
               }));

                RAMCalculations();

                if (mainMenu.done)
                    break;
            }
        }

        public static void RAMCalculations()
        {
            if (HighestRAM < RAMCounter)
                HighestRAM = RAMCounter;

            else if (LowestRAM > RAMCounter)
                LowestRAM = RAMCounter;

            Counter++;
            TotalRAM += RAMCounter;
            AverageRAM = TotalRAM / Counter;
        }

    }
}
