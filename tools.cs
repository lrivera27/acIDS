using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acIDS
{
    public class tools
    {
        public static string Path { get; set; }
        public static string Filename { get; set; }

        public static bool validateString(string str)
        {
            Regex regex = new Regex(@"\W+");
            Match match = regex.Match(str);
            if (str.Length > 10)
                return false;
            else if (match.Success)
                return false;

            return true;
        }

        public static void AskForPath()
        {
            Stream myStream;
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Filter = "txt files (*txt)|*.txt|All files (*.*)|*.*";
            saveFile.FilterIndex = 2;
            saveFile.RestoreDirectory = true;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFile.OpenFile()) != null)
                {
                    string path = saveFile.FileName;
                    myStream.Close();

                    exportData(path + ".txt");
                }
            }
        }

        public static void exportData(string path)
        {
            string dataToExport =
                $@"
                Hosted Intrusion Detection Data 
                -----------------------------------

                CPU Stats: 

                Current CPU Usage: {CPUMonitor.CPUCounter.ToString("F2")} %

                Highest CPU Usage: {CPUMonitor.HighestCPU.ToString("F2")} %

                Lowest CPU Usage:  {CPUMonitor.LowestCPU.ToString("F2")}  %

                Average CPU Usage: {CPUMonitor.AverageCPU.ToString("F2")} %

                Warnings: 
                NotYetSet

                -----------------------------------

                RAM Stats: 

                Current RAM Available: {RAMMonitor.RAMCounter} MB

                Highest RAM Available: {RAMMonitor.HighestRAM} MB

                Lowest RAM Available:  {RAMMonitor.LowestRAM}  MB

                Average RAM Available: {RAMMonitor.AverageRAM} MB

                Warnings:
  
                NotYetSet

                -----------------------------------  

                Processes Stats:     

                Current number of Processes: {ProcessMonitor.ProcessCounter}

                List of Current Running Processes: 

                {ProcessMonitor.ReadProcessesAsString()}";

            File.WriteAllText(path, dataToExport);
            string test = File.ReadAllText(path);
            MessageBox.Show(test);
        }
    }
}
