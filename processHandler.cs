using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace acIDS
{
    public class processHandler
    {
        //Gets & Sets

        //Total number of processes running
        public int TotalProcesses { get; set; }
        public int MaxNumberOfProcesses { get; set; }
        public int MinNumberOfProcesses { get; set; }
        public float AveNumberOfProcesses { get; set; }

        public processHandler()
        {
            currentNumberProcceses();
            MaxNumberOfProcesses = TotalProcesses;
            MinNumberOfProcesses = TotalProcesses;
        }

        public void currentNumberProcceses()
        {
            Process[] numProcess = Process.GetProcesses();
            TotalProcesses = numProcess.Length;
        }

        public void StartProcessesCounter(int minutes, int seconds)
        {
            int counter = 0;
            int total = 0;
            Process[] numProcess = Process.GetProcesses();
            int max = -1;
            int min = 100000000;
            Stopwatch timer = new Stopwatch();
            timer.Start();
            TimeSpan elapsed = timer.Elapsed;

            while (elapsed.Seconds <= seconds && elapsed.Minutes <= minutes)
            {
                numProcess = Process.GetProcesses();
                total += numProcess.Length;
                counter++;
                elapsed = timer.Elapsed;

                if (numProcess.Length > max)
                    max = numProcess.Length;

                else if (numProcess.Length < min)
                    min = numProcess.Length;
            }

            AveNumberOfProcesses = total / counter;
            MinNumberOfProcesses = min;
            MaxNumberOfProcesses = max;
            timer.Stop();
        }

        public string[] readProcesses()
        {
            Process[] allProcesesses = Process.GetProcesses();
            
            string[] data = new string[allProcesesses.Length];

            for (int i = 0; i < allProcesesses.Length; i++)
                data[i] = allProcesesses[i].ProcessName;
            return data;

        }

        public void exportProcesses(string filename, string path, string[] data)
        {  
            path = @"C:\Users\HerpDerp\Desktop\" + filename + ".txt";
            File.WriteAllLines(path, data);
        }
    }
}
