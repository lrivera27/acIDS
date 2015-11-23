namespace acIDS
{
    partial class mainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.hidsBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.hidsPanel = new System.Windows.Forms.Panel();
            this.expertHids = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.plistTxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pRunningTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ramWarningTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ramMonitorTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cpuWarningTxt = new System.Windows.Forms.TextBox();
            this.cpuUsageTxt = new System.Windows.Forms.TextBox();
            this.outputBtn = new System.Windows.Forms.Button();
            this.hidsBackBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nidsBtn = new System.Windows.Forms.Button();
            this.nidsPanel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.networkWarningTxt = new System.Windows.Forms.TextBox();
            this.bytesReceivedTxt = new System.Windows.Forms.TextBox();
            this.bytesSentTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nidsBackBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.hidsPanel.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.nidsPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.label1.Location = new System.Drawing.Point(220, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Intrusion Detection System Menu";
            // 
            // hidsBtn
            // 
            this.hidsBtn.Font = new System.Drawing.Font("Tahoma", 15F);
            this.hidsBtn.Location = new System.Drawing.Point(497, 159);
            this.hidsBtn.Name = "hidsBtn";
            this.hidsBtn.Size = new System.Drawing.Size(462, 222);
            this.hidsBtn.TabIndex = 1;
            this.hidsBtn.Text = "Hosted IDS";
            this.hidsBtn.UseVisualStyleBackColor = true;
            this.hidsBtn.Click += new System.EventHandler(this.hidsBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Font = new System.Drawing.Font("Tahoma", 15F);
            this.aboutBtn.Location = new System.Drawing.Point(12, 387);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(479, 222);
            this.aboutBtn.TabIndex = 3;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Tahoma", 15F);
            this.exitBtn.Location = new System.Drawing.Point(497, 387);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(462, 222);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "EXIT / LOGOUT";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // hidsPanel
            // 
            this.hidsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.hidsPanel.Controls.Add(this.expertHids);
            this.hidsPanel.Controls.Add(this.groupBox4);
            this.hidsPanel.Controls.Add(this.panel1);
            this.hidsPanel.Controls.Add(this.groupBox2);
            this.hidsPanel.Controls.Add(this.groupBox1);
            this.hidsPanel.Controls.Add(this.outputBtn);
            this.hidsPanel.Controls.Add(this.hidsBackBtn);
            this.hidsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hidsPanel.Location = new System.Drawing.Point(0, 0);
            this.hidsPanel.Name = "hidsPanel";
            this.hidsPanel.Size = new System.Drawing.Size(971, 651);
            this.hidsPanel.TabIndex = 5;
            this.hidsPanel.Visible = false;
            // 
            // expertHids
            // 
            this.expertHids.Font = new System.Drawing.Font("Tahoma", 10F);
            this.expertHids.Location = new System.Drawing.Point(665, 592);
            this.expertHids.Name = "expertHids";
            this.expertHids.Size = new System.Drawing.Size(144, 47);
            this.expertHids.TabIndex = 25;
            this.expertHids.Text = "Expert Mode";
            this.expertHids.UseVisualStyleBackColor = true;
            this.expertHids.Click += new System.EventHandler(this.expertHids_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.plistTxt);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.pRunningTxt);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(28, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(379, 533);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Processes";
            // 
            // plistTxt
            // 
            this.plistTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plistTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plistTxt.Location = new System.Drawing.Point(21, 155);
            this.plistTxt.Multiline = true;
            this.plistTxt.Name = "plistTxt";
            this.plistTxt.ReadOnly = true;
            this.plistTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.plistTxt.Size = new System.Drawing.Size(338, 339);
            this.plistTxt.TabIndex = 13;
            this.plistTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label13.Location = new System.Drawing.Point(131, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 21);
            this.label13.TabIndex = 14;
            this.label13.Text = "Process List";
            // 
            // pRunningTxt
            // 
            this.pRunningTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pRunningTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pRunningTxt.Location = new System.Drawing.Point(253, 56);
            this.pRunningTxt.Name = "pRunningTxt";
            this.pRunningTxt.ReadOnly = true;
            this.pRunningTxt.Size = new System.Drawing.Size(106, 28);
            this.pRunningTxt.TabIndex = 13;
            this.pRunningTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label12.Location = new System.Drawing.Point(6, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 21);
            this.label12.TabIndex = 13;
            this.label12.Text = "Running Processes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(200)))), ((int)(((byte)(181)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 100);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(200)))), ((int)(((byte)(181)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.label2.Location = new System.Drawing.Point(220, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(540, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hosted Intrusion Detection System";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ramWarningTxt);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.ramMonitorTxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(515, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 212);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RAM Monitor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Warnings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Available RAM";
            // 
            // ramWarningTxt
            // 
            this.ramWarningTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ramWarningTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ramWarningTxt.Location = new System.Drawing.Point(97, 108);
            this.ramWarningTxt.Multiline = true;
            this.ramWarningTxt.Name = "ramWarningTxt";
            this.ramWarningTxt.ReadOnly = true;
            this.ramWarningTxt.Size = new System.Drawing.Size(292, 76);
            this.ramWarningTxt.TabIndex = 9;
            this.ramWarningTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 15F);
            this.button1.Location = new System.Drawing.Point(-534, -10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(479, 222);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hosted IDS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.hidsBtn_Click);
            // 
            // ramMonitorTxt
            // 
            this.ramMonitorTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ramMonitorTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ramMonitorTxt.Location = new System.Drawing.Point(283, 39);
            this.ramMonitorTxt.Name = "ramMonitorTxt";
            this.ramMonitorTxt.ReadOnly = true;
            this.ramMonitorTxt.Size = new System.Drawing.Size(106, 28);
            this.ramMonitorTxt.TabIndex = 8;
            this.ramMonitorTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label5.Location = new System.Drawing.Point(-534, -106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(518, 41);
            this.label5.TabIndex = 0;
            this.label5.Text = "Intrusion Detection System Menu";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cpuWarningTxt);
            this.groupBox1.Controls.Add(this.cpuUsageTxt);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(515, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 212);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPU Monitor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.Location = new System.Drawing.Point(6, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Warnings";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label8.Location = new System.Drawing.Point(12, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 21);
            this.label8.TabIndex = 10;
            this.label8.Text = "Current CPU usage";
            // 
            // cpuWarningTxt
            // 
            this.cpuWarningTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cpuWarningTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpuWarningTxt.Location = new System.Drawing.Point(97, 108);
            this.cpuWarningTxt.Multiline = true;
            this.cpuWarningTxt.Name = "cpuWarningTxt";
            this.cpuWarningTxt.ReadOnly = true;
            this.cpuWarningTxt.Size = new System.Drawing.Size(292, 76);
            this.cpuWarningTxt.TabIndex = 9;
            this.cpuWarningTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cpuUsageTxt
            // 
            this.cpuUsageTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cpuUsageTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpuUsageTxt.Location = new System.Drawing.Point(283, 35);
            this.cpuUsageTxt.Name = "cpuUsageTxt";
            this.cpuUsageTxt.ReadOnly = true;
            this.cpuUsageTxt.Size = new System.Drawing.Size(106, 28);
            this.cpuUsageTxt.TabIndex = 8;
            this.cpuUsageTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // outputBtn
            // 
            this.outputBtn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.outputBtn.Location = new System.Drawing.Point(515, 592);
            this.outputBtn.Name = "outputBtn";
            this.outputBtn.Size = new System.Drawing.Size(144, 47);
            this.outputBtn.TabIndex = 8;
            this.outputBtn.Text = "Export Data";
            this.outputBtn.UseVisualStyleBackColor = true;
            this.outputBtn.Click += new System.EventHandler(this.outputBtn_Click);
            // 
            // hidsBackBtn
            // 
            this.hidsBackBtn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.hidsBackBtn.Location = new System.Drawing.Point(815, 592);
            this.hidsBackBtn.Name = "hidsBackBtn";
            this.hidsBackBtn.Size = new System.Drawing.Size(144, 47);
            this.hidsBackBtn.TabIndex = 1;
            this.hidsBackBtn.Text = "Back";
            this.hidsBackBtn.UseVisualStyleBackColor = true;
            this.hidsBackBtn.Click += new System.EventHandler(this.hidsBackBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Controls.Add(this.nidsBtn);
            this.mainPanel.Controls.Add(this.exitBtn);
            this.mainPanel.Controls.Add(this.aboutBtn);
            this.mainPanel.Controls.Add(this.hidsBtn);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(971, 651);
            this.mainPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(200)))), ((int)(((byte)(181)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 100);
            this.panel2.TabIndex = 15;
            // 
            // nidsBtn
            // 
            this.nidsBtn.Font = new System.Drawing.Font("Tahoma", 15F);
            this.nidsBtn.Location = new System.Drawing.Point(12, 159);
            this.nidsBtn.Name = "nidsBtn";
            this.nidsBtn.Size = new System.Drawing.Size(479, 222);
            this.nidsBtn.TabIndex = 5;
            this.nidsBtn.Text = "Network IDS";
            this.nidsBtn.UseVisualStyleBackColor = true;
            this.nidsBtn.Click += new System.EventHandler(this.nidsBtn_Click);
            // 
            // nidsPanel
            // 
            this.nidsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.nidsPanel.Controls.Add(this.groupBox3);
            this.nidsPanel.Controls.Add(this.nidsBackBtn);
            this.nidsPanel.Controls.Add(this.panel3);
            this.nidsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nidsPanel.Location = new System.Drawing.Point(0, 0);
            this.nidsPanel.Name = "nidsPanel";
            this.nidsPanel.Size = new System.Drawing.Size(971, 651);
            this.nidsPanel.TabIndex = 1;
            this.nidsPanel.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.networkWarningTxt);
            this.groupBox3.Controls.Add(this.bytesReceivedTxt);
            this.groupBox3.Controls.Add(this.bytesSentTxt);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(18, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 251);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Network Traffic";
            // 
            // networkWarningTxt
            // 
            this.networkWarningTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.networkWarningTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.networkWarningTxt.Location = new System.Drawing.Point(108, 137);
            this.networkWarningTxt.Multiline = true;
            this.networkWarningTxt.Name = "networkWarningTxt";
            this.networkWarningTxt.ReadOnly = true;
            this.networkWarningTxt.Size = new System.Drawing.Size(261, 76);
            this.networkWarningTxt.TabIndex = 19;
            // 
            // bytesReceivedTxt
            // 
            this.bytesReceivedTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bytesReceivedTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bytesReceivedTxt.Location = new System.Drawing.Point(210, 87);
            this.bytesReceivedTxt.Name = "bytesReceivedTxt";
            this.bytesReceivedTxt.ReadOnly = true;
            this.bytesReceivedTxt.Size = new System.Drawing.Size(159, 28);
            this.bytesReceivedTxt.TabIndex = 20;
            // 
            // bytesSentTxt
            // 
            this.bytesSentTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bytesSentTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bytesSentTxt.Location = new System.Drawing.Point(210, 37);
            this.bytesSentTxt.Name = "bytesSentTxt";
            this.bytesSentTxt.ReadOnly = true;
            this.bytesSentTxt.Size = new System.Drawing.Size(159, 28);
            this.bytesSentTxt.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 21);
            this.label11.TabIndex = 2;
            this.label11.Text = "Warnings";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "Bytes Received";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Bytes Sent";
            // 
            // nidsBackBtn
            // 
            this.nidsBackBtn.Font = new System.Drawing.Font("Tahoma", 10F);
            this.nidsBackBtn.Location = new System.Drawing.Point(815, 592);
            this.nidsBackBtn.Name = "nidsBackBtn";
            this.nidsBackBtn.Size = new System.Drawing.Size(144, 47);
            this.nidsBackBtn.TabIndex = 17;
            this.nidsBackBtn.Text = "Back";
            this.nidsBackBtn.UseVisualStyleBackColor = true;
            this.nidsBackBtn.Click += new System.EventHandler(this.nidsBackBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(200)))), ((int)(((byte)(181)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(971, 100);
            this.panel3.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.label7.Location = new System.Drawing.Point(220, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(571, 41);
            this.label7.TabIndex = 0;
            this.label7.Text = "Network Intrustion Detection System";
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(971, 651);
            this.Controls.Add(this.hidsPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.nidsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(989, 698);
            this.MinimumSize = new System.Drawing.Size(989, 698);
            this.Name = "mainMenu";
            this.Text = "Main Menu";
            this.hidsPanel.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.nidsPanel.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hidsBtn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel hidsPanel;
        private System.Windows.Forms.Button hidsBackBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ramWarningTxt;
        private System.Windows.Forms.TextBox ramMonitorTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cpuWarningTxt;
        private System.Windows.Forms.TextBox cpuUsageTxt;
        private System.Windows.Forms.Button outputBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button nidsBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel nidsPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button nidsBackBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox networkWarningTxt;
        private System.Windows.Forms.TextBox bytesReceivedTxt;
        private System.Windows.Forms.TextBox bytesSentTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button expertHids;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox plistTxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox pRunningTxt;
        private System.Windows.Forms.Label label12;
    }
}