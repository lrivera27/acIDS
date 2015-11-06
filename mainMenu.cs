using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace acIDS
{
    public partial class mainMenu : Form
    {
        public static bool done = false;
        public float _ramCounter;
        public string _warnings = "No Warnings";
        public float _bytesSent;
        public float _bytesReceived;

        public mainMenu()
        {
            InitializeComponent();
        }

        private void hidsBtn_Click(object sender, EventArgs e)
        {
            hidsPanel.Visible = true;
            mainPanel.Visible = false;
            this.Text = "HIDS Menu";
            
            Thread ramThread = new Thread(new ThreadStart(ramMonitoring));
            Thread pMonitorThread = new Thread(new ThreadStart(processesMonitoring));
            CPUMonitor.StartMonitoring(cpuUsageTxt);
            pMonitorThread.Start();
            ramThread.Start();
        }

        private void outputBtn_Click(object sender, EventArgs e)
        {
            tools.AskForPath();
        }

        private void nidsBtn_Click(object sender, EventArgs e)
        {
            this.Text = "NIDS Menu";
            mainPanel.Visible = false;
            nidsPanel.Visible = true;
        }

        private void exitBtn_Click(object sender, EventArgs e) // exit_button Test
        {
            loginForm ss = new loginForm();
            this.Close();
            ss.Show();
        }

        private void backBtn_Click(object sender, EventArgs e) //Back Button in HIDS panel
        {
            //Changing back to Main Menu, need to change the text
            this.Text = "Main Menu";

            //Just to make sure every panel is not visible
            hidsPanel.Visible = false;
            nidsPanel.Visible = false;
            mainPanel.Visible = true;

            DoneUpdate(sender, e);
        }

        private void button2_Click(object sender, EventArgs e) // Back Button in NIDS panel
        {
            DoneUpdate(sender, e);
            backBtn_Click(sender, e);
        }

        private void DoneUpdate(object sender, EventArgs e)
        {
            done = true;
        }

        private void processesMonitoring()
        {
            string[] data;
            pRunningTxt.Invoke((Action)delegate
            {
                Program.phandler.currentNumberProcceses();
                pRunningTxt.Text = Program.phandler.TotalProcesses + "";
            });

            plistTxt.Invoke((Action)delegate
            {
                data = Program.phandler.readProcesses();
                plistTxt.Text = "";
                foreach (string pData in data)
                {
                    if (plistTxt.Text.Length < 0)
                        plistTxt.Text = pData;
                    else
                    {
                        plistTxt.AppendText("\r\n" + pData);
                    }
                }
            });
        }
        private void anomalyCPU(float percentageCPU)
        {

            if (percentageCPU > 10)
            {
                if (cpuWarningTxt.Text.Length == 0)
                {
                    cpuWarningTxt.Text = "Warning! CPU Usage: " + percentageCPU;
                }
                else
                {
                    cpuWarningTxt.AppendText("\r\n" + "Warning! CPU Usage: " + percentageCPU);
                }
                _warnings = cpuWarningTxt.Text;
            }
        }

        private void ramMonitoring()
        {
            PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            
            while (true)
            {
                Thread.Sleep(1000); // wait a second, then try again
                ramMonitorTxt.Invoke((Action)delegate
                {
                    _ramCounter = ramCounter.NextValue();
                    ramMonitorTxt.Text = _ramCounter + "MB";
                });
                if (done)
                {
                    break;
                }
            }
            MessageBox.Show("Ram Thread should be dead");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread pMonitorThread = new Thread(new ThreadStart(processesMonitoring));
            pMonitorThread.Start();
        }
    }
}