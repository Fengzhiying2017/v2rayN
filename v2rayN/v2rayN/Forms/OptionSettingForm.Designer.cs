﻿namespace v2rayN.Forms
{
    partial class OptionSettingForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAutoSyncTime = new System.Windows.Forms.CheckBox();
            this.chkAutoRun = new System.Windows.Forms.CheckBox();
            this.chkmuxEnabled = new System.Windows.Forms.CheckBox();
            this.chkAllowIn2 = new System.Windows.Forms.CheckBox();
            this.chkudpEnabled2 = new System.Windows.Forms.CheckBox();
            this.cmbprotocol2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlocalPort2 = new System.Windows.Forms.TextBox();
            this.cmbprotocol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkudpEnabled = new System.Windows.Forms.CheckBox();
            this.chklogEnabled = new System.Windows.Forms.CheckBox();
            this.cmbloglevel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtlocalPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtUseragent = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtUserdirect = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtUserblock = new System.Windows.Forms.TextBox();
            this.chkBypassChinasites = new System.Windows.Forms.CheckBox();
            this.chkBypassChinaip = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPACServerPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(473, 20);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 29);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "取消(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(704, 621);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(696, 592);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "  基础设置  ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPACServerPort);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chkAutoSyncTime);
            this.groupBox1.Controls.Add(this.chkAutoRun);
            this.groupBox1.Controls.Add(this.chkmuxEnabled);
            this.groupBox1.Controls.Add(this.chkAllowIn2);
            this.groupBox1.Controls.Add(this.chkudpEnabled2);
            this.groupBox1.Controls.Add(this.cmbprotocol2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtlocalPort2);
            this.groupBox1.Controls.Add(this.cmbprotocol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkudpEnabled);
            this.groupBox1.Controls.Add(this.chklogEnabled);
            this.groupBox1.Controls.Add(this.cmbloglevel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtlocalPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(688, 584);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // chkAutoSyncTime
            // 
            this.chkAutoSyncTime.AutoSize = true;
            this.chkAutoSyncTime.Location = new System.Drawing.Point(17, 309);
            this.chkAutoSyncTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkAutoSyncTime.Name = "chkAutoSyncTime";
            this.chkAutoSyncTime.Size = new System.Drawing.Size(345, 19);
            this.chkAutoSyncTime.TabIndex = 22;
            this.chkAutoSyncTime.Text = "启动时自动从网络同步本地时间(可能会不成功)";
            this.chkAutoSyncTime.UseVisualStyleBackColor = true;
            // 
            // chkAutoRun
            // 
            this.chkAutoRun.AutoSize = true;
            this.chkAutoRun.Location = new System.Drawing.Point(17, 275);
            this.chkAutoRun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkAutoRun.Name = "chkAutoRun";
            this.chkAutoRun.Size = new System.Drawing.Size(225, 19);
            this.chkAutoRun.TabIndex = 21;
            this.chkAutoRun.Text = "开机自动启动(可能会不成功)";
            this.chkAutoRun.UseVisualStyleBackColor = true;
            // 
            // chkmuxEnabled
            // 
            this.chkmuxEnabled.AutoSize = true;
            this.chkmuxEnabled.Location = new System.Drawing.Point(17, 198);
            this.chkmuxEnabled.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkmuxEnabled.Name = "chkmuxEnabled";
            this.chkmuxEnabled.Size = new System.Drawing.Size(219, 19);
            this.chkmuxEnabled.TabIndex = 20;
            this.chkmuxEnabled.Text = "开启Mux多路复用(默认开启)";
            this.chkmuxEnabled.UseVisualStyleBackColor = true;
            // 
            // chkAllowIn2
            // 
            this.chkAllowIn2.AutoSize = true;
            this.chkAllowIn2.Location = new System.Drawing.Point(17, 81);
            this.chkAllowIn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkAllowIn2.Name = "chkAllowIn2";
            this.chkAllowIn2.Size = new System.Drawing.Size(127, 19);
            this.chkAllowIn2.TabIndex = 19;
            this.chkAllowIn2.Text = "本地监听端口2";
            this.chkAllowIn2.UseVisualStyleBackColor = true;
            this.chkAllowIn2.CheckedChanged += new System.EventHandler(this.chkAllowIn2_CheckedChanged);
            // 
            // chkudpEnabled2
            // 
            this.chkudpEnabled2.AutoSize = true;
            this.chkudpEnabled2.Location = new System.Drawing.Point(492, 80);
            this.chkudpEnabled2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkudpEnabled2.Name = "chkudpEnabled2";
            this.chkudpEnabled2.Size = new System.Drawing.Size(83, 19);
            this.chkudpEnabled2.TabIndex = 18;
            this.chkudpEnabled2.Text = "开启UDP";
            this.chkudpEnabled2.UseVisualStyleBackColor = true;
            // 
            // cmbprotocol2
            // 
            this.cmbprotocol2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbprotocol2.FormattingEnabled = true;
            this.cmbprotocol2.Items.AddRange(new object[] {
            "socks",
            "http"});
            this.cmbprotocol2.Location = new System.Drawing.Point(343, 78);
            this.cmbprotocol2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbprotocol2.Name = "cmbprotocol2";
            this.cmbprotocol2.Size = new System.Drawing.Size(128, 23);
            this.cmbprotocol2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "协议";
            // 
            // txtlocalPort2
            // 
            this.txtlocalPort2.Location = new System.Drawing.Point(165, 78);
            this.txtlocalPort2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtlocalPort2.Name = "txtlocalPort2";
            this.txtlocalPort2.Size = new System.Drawing.Size(103, 25);
            this.txtlocalPort2.TabIndex = 14;
            // 
            // cmbprotocol
            // 
            this.cmbprotocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbprotocol.FormattingEnabled = true;
            this.cmbprotocol.Items.AddRange(new object[] {
            "socks",
            "http"});
            this.cmbprotocol.Location = new System.Drawing.Point(343, 31);
            this.cmbprotocol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbprotocol.Name = "cmbprotocol";
            this.cmbprotocol.Size = new System.Drawing.Size(128, 23);
            this.cmbprotocol.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "协议";
            // 
            // chkudpEnabled
            // 
            this.chkudpEnabled.AutoSize = true;
            this.chkudpEnabled.Location = new System.Drawing.Point(492, 34);
            this.chkudpEnabled.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkudpEnabled.Name = "chkudpEnabled";
            this.chkudpEnabled.Size = new System.Drawing.Size(83, 19);
            this.chkudpEnabled.TabIndex = 10;
            this.chkudpEnabled.Text = "开启UDP";
            this.chkudpEnabled.UseVisualStyleBackColor = true;
            // 
            // chklogEnabled
            // 
            this.chklogEnabled.AutoSize = true;
            this.chklogEnabled.Location = new System.Drawing.Point(17, 236);
            this.chklogEnabled.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chklogEnabled.Name = "chklogEnabled";
            this.chklogEnabled.Size = new System.Drawing.Size(195, 19);
            this.chklogEnabled.TabIndex = 9;
            this.chklogEnabled.Text = "记录本地日志(默认关闭)";
            this.chklogEnabled.UseVisualStyleBackColor = true;
            // 
            // cmbloglevel
            // 
            this.cmbloglevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbloglevel.FormattingEnabled = true;
            this.cmbloglevel.Items.AddRange(new object[] {
            "debug",
            "info",
            "warning",
            "error",
            "none"});
            this.cmbloglevel.Location = new System.Drawing.Point(343, 234);
            this.cmbloglevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbloglevel.Name = "cmbloglevel";
            this.cmbloglevel.Size = new System.Drawing.Size(128, 23);
            this.cmbloglevel.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "日志等级";
            // 
            // txtlocalPort
            // 
            this.txtlocalPort.Location = new System.Drawing.Point(165, 31);
            this.txtlocalPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtlocalPort.Name = "txtlocalPort";
            this.txtlocalPort.Size = new System.Drawing.Size(103, 25);
            this.txtlocalPort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "本地监听端口";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(696, 591);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "  路由设置  ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tabControl2);
            this.groupBox2.Controls.Add(this.chkBypassChinasites);
            this.groupBox2.Controls.Add(this.chkBypassChinaip);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(4, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(688, 583);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(17, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "*设置的网址或IP，用逗号(,)隔开，可以一行多个";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl2.Location = new System.Drawing.Point(4, 107);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(680, 472);
            this.tabControl2.TabIndex = 12;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtUseragent);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(672, 443);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "  代理的网址或IP  ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtUseragent
            // 
            this.txtUseragent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUseragent.Location = new System.Drawing.Point(4, 4);
            this.txtUseragent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUseragent.Multiline = true;
            this.txtUseragent.Name = "txtUseragent";
            this.txtUseragent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUseragent.Size = new System.Drawing.Size(664, 435);
            this.txtUseragent.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtUserdirect);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Size = new System.Drawing.Size(669, 443);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "  直连的网址或IP  ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtUserdirect
            // 
            this.txtUserdirect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserdirect.Location = new System.Drawing.Point(4, 4);
            this.txtUserdirect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserdirect.Multiline = true;
            this.txtUserdirect.Name = "txtUserdirect";
            this.txtUserdirect.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUserdirect.Size = new System.Drawing.Size(661, 435);
            this.txtUserdirect.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtUserblock);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage5.Size = new System.Drawing.Size(669, 443);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "  阻止的网址或IP  ";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtUserblock
            // 
            this.txtUserblock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserblock.Location = new System.Drawing.Point(4, 4);
            this.txtUserblock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserblock.Multiline = true;
            this.txtUserblock.Name = "txtUserblock";
            this.txtUserblock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUserblock.Size = new System.Drawing.Size(661, 435);
            this.txtUserblock.TabIndex = 1;
            // 
            // chkBypassChinasites
            // 
            this.chkBypassChinasites.AutoSize = true;
            this.chkBypassChinasites.Location = new System.Drawing.Point(20, 25);
            this.chkBypassChinasites.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkBypassChinasites.Name = "chkBypassChinasites";
            this.chkBypassChinasites.Size = new System.Drawing.Size(119, 19);
            this.chkBypassChinasites.TabIndex = 10;
            this.chkBypassChinasites.Text = "绕过大陆地址";
            this.chkBypassChinasites.UseVisualStyleBackColor = true;
            // 
            // chkBypassChinaip
            // 
            this.chkBypassChinaip.AutoSize = true;
            this.chkBypassChinaip.Location = new System.Drawing.Point(20, 52);
            this.chkBypassChinaip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkBypassChinaip.Name = "chkBypassChinaip";
            this.chkBypassChinaip.Size = new System.Drawing.Size(105, 19);
            this.chkBypassChinaip.TabIndex = 11;
            this.chkBypassChinaip.Text = "绕过大陆IP";
            this.chkBypassChinaip.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 633);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 75);
            this.panel2.TabIndex = 11;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(356, 20);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 29);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 12);
            this.panel1.TabIndex = 9;
            // 
            // txtPACServerPort
            // 
            this.txtPACServerPort.Location = new System.Drawing.Point(165, 117);
            this.txtPACServerPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPACServerPort.Name = "txtPACServerPort";
            this.txtPACServerPort.Size = new System.Drawing.Size(103, 25);
            this.txtPACServerPort.TabIndex = 25;
            this.txtPACServerPort.Text = "8888";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "PAC服务器端口";
            // 
            // OptionSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(704, 708);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "OptionSettingForm";
            this.Text = "参数设置";
            this.Load += new System.EventHandler(this.OptionSettingForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbloglevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtlocalPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chklogEnabled;
        private System.Windows.Forms.CheckBox chkudpEnabled;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkBypassChinasites;
        private System.Windows.Forms.CheckBox chkBypassChinaip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbprotocol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbprotocol2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlocalPort2;
        private System.Windows.Forms.CheckBox chkudpEnabled2;
        private System.Windows.Forms.CheckBox chkAllowIn2;
        private System.Windows.Forms.CheckBox chkmuxEnabled;
        private System.Windows.Forms.CheckBox chkAutoRun;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUseragent;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtUserdirect;
        private System.Windows.Forms.TextBox txtUserblock;
        private System.Windows.Forms.CheckBox chkAutoSyncTime;
        private System.Windows.Forms.TextBox txtPACServerPort;
        private System.Windows.Forms.Label label6;
    }
}