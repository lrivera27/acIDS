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

        public enum Panel { HidsPanel, NidsPanel, MainPanel};

        public mainMenu()
        {
            InitializeComponent();
        }

        private void hidsBtn_Click(object sender, EventArgs e)
        {
            changePanels(Panel.HidsPanel);
            RAMMonitor.Startmonitoring(ramMonitorTxt);

            //FIX::Hardcoded numbers
            CPUMonitor.StartMonitoring(cpuUsageTxt, cpuWarningTxt, 0, 5);
            ProcessMonitor.Startmonitoring(pRunningTxt, plistTxt);
        }

        private void outputBtn_Click(object sender, EventArgs e)
        {
            tools.AskForPath();
        }

        private void nidsBtn_Click(object sender, EventArgs e)
        {
            changePanels(Panel.NidsPanel);
        }

        private void changePanels(Panel panel)
        {
            mainPanel.Visible = false;
            hidsPanel.Visible = false;
            nidsPanel.Visible = false;
            done = false;

            switch (panel)
            {
                case Panel.HidsPanel:
                    hidsPanel.Visible = true;
                    Text = "HIDS Menu";
                    break;
                case Panel.NidsPanel:
                    nidsPanel.Visible = true;
                    Text = "NIDS Menu";
                    break;
                case Panel.MainPanel:
                    mainPanel.Visible = true;
                    Text = "Main Menu";
                    done = true;
                    break;
            }
        }

        private void hidsBackBtn_Click(object sender, EventArgs e) //Back Button in HIDS panel
        {
            changePanels(Panel.MainPanel);
        }

        private void nidsBackBtn_Click(object sender, EventArgs e)
        {
            changePanels(Panel.MainPanel);
        }

        private void exitBtn_Click(object sender, EventArgs e) // exit_button Test
        {
            loginForm ss = new loginForm();
            Close();
            ss.Show();
        }
    }
}