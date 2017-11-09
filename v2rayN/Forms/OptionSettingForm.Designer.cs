namespace v2rayN.Forms
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
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.GroupBox groupBoxCoreKcpSetting;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.GroupBox groupBoxCoreRouting;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.GroupBox groupBoxV2RaySetting;
            System.Windows.Forms.Label label12;
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.chkmuxEnabled = new System.Windows.Forms.CheckBox();
            this.chklogEnabled = new System.Windows.Forms.CheckBox();
            this.cmbloglevel = new System.Windows.Forms.ComboBox();
            this.groupBoxCoreBaseSetting = new System.Windows.Forms.GroupBox();
            this.txtlocalPort = new System.Windows.Forms.TextBox();
            this.cmbprotocol = new System.Windows.Forms.ComboBox();
            this.chkudpEnabled = new System.Windows.Forms.CheckBox();
            this.chkKcpcongestion = new System.Windows.Forms.CheckBox();
            this.txtKcpwriteBufferSize = new System.Windows.Forms.TextBox();
            this.txtKcpreadBufferSize = new System.Windows.Forms.TextBox();
            this.txtKcpdownlinkCapacity = new System.Windows.Forms.TextBox();
            this.txtKcpuplinkCapacity = new System.Windows.Forms.TextBox();
            this.txtKcptti = new System.Windows.Forms.TextBox();
            this.txtKcpmtu = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtUseragent = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtUserdirect = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtUserblock = new System.Windows.Forms.TextBox();
            this.chkBypassChinasites = new System.Windows.Forms.CheckBox();
            this.chkBypassChinaip = new System.Windows.Forms.CheckBox();
            this.txturlGFWList = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chkAutoRun = new System.Windows.Forms.CheckBox();
            label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupBoxCoreKcpSetting = new System.Windows.Forms.GroupBox();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            groupBoxCoreRouting = new System.Windows.Forms.GroupBox();
            label4 = new System.Windows.Forms.Label();
            groupBoxV2RaySetting = new System.Windows.Forms.GroupBox();
            label12 = new System.Windows.Forms.Label();
            this.groupBoxCoreBaseSetting.SuspendLayout();
            groupBoxCoreKcpSetting.SuspendLayout();
            groupBoxCoreRouting.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            groupBoxV2RaySetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(536, 426);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 46);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "取消(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(437, 426);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 46);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chkmuxEnabled
            // 
            this.chkmuxEnabled.AutoSize = true;
            this.chkmuxEnabled.Location = new System.Drawing.Point(13, 100);
            this.chkmuxEnabled.Name = "chkmuxEnabled";
            this.chkmuxEnabled.Size = new System.Drawing.Size(114, 16);
            this.chkmuxEnabled.TabIndex = 29;
            this.chkmuxEnabled.Text = "开启Mux多路复用";
            this.chkmuxEnabled.UseVisualStyleBackColor = true;
            // 
            // chklogEnabled
            // 
            this.chklogEnabled.AutoSize = true;
            this.chklogEnabled.Location = new System.Drawing.Point(13, 121);
            this.chklogEnabled.Name = "chklogEnabled";
            this.chklogEnabled.Size = new System.Drawing.Size(96, 16);
            this.chklogEnabled.TabIndex = 25;
            this.chklogEnabled.Text = "记录本地日志";
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
            this.cmbloglevel.Location = new System.Drawing.Point(77, 155);
            this.cmbloglevel.Name = "cmbloglevel";
            this.cmbloglevel.Size = new System.Drawing.Size(97, 20);
            this.cmbloglevel.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(13, 158);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(53, 12);
            label5.TabIndex = 24;
            label5.Text = "日志等级";
            // 
            // groupBoxCoreBaseSetting
            // 
            this.groupBoxCoreBaseSetting.Controls.Add(label2);
            this.groupBoxCoreBaseSetting.Controls.Add(this.txtlocalPort);
            this.groupBoxCoreBaseSetting.Controls.Add(label1);
            this.groupBoxCoreBaseSetting.Controls.Add(this.cmbprotocol);
            this.groupBoxCoreBaseSetting.Controls.Add(this.chklogEnabled);
            this.groupBoxCoreBaseSetting.Controls.Add(this.cmbloglevel);
            this.groupBoxCoreBaseSetting.Controls.Add(this.chkudpEnabled);
            this.groupBoxCoreBaseSetting.Controls.Add(label5);
            this.groupBoxCoreBaseSetting.Controls.Add(this.chkmuxEnabled);
            this.groupBoxCoreBaseSetting.Location = new System.Drawing.Point(437, 12);
            this.groupBoxCoreBaseSetting.Name = "groupBoxCoreBaseSetting";
            this.groupBoxCoreBaseSetting.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxCoreBaseSetting.Size = new System.Drawing.Size(189, 188);
            this.groupBoxCoreBaseSetting.TabIndex = 30;
            this.groupBoxCoreBaseSetting.TabStop = false;
            this.groupBoxCoreBaseSetting.Text = "Core: 基础设置";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 26);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(77, 12);
            label2.TabIndex = 36;
            label2.Text = "本地监听端口";
            // 
            // txtlocalPort
            // 
            this.txtlocalPort.Location = new System.Drawing.Point(96, 23);
            this.txtlocalPort.Name = "txtlocalPort";
            this.txtlocalPort.Size = new System.Drawing.Size(78, 21);
            this.txtlocalPort.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 53);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(29, 12);
            label1.TabIndex = 34;
            label1.Text = "协议";
            // 
            // cmbprotocol
            // 
            this.cmbprotocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbprotocol.Enabled = false;
            this.cmbprotocol.FormattingEnabled = true;
            this.cmbprotocol.Items.AddRange(new object[] {
            "socks",
            "http"});
            this.cmbprotocol.Location = new System.Drawing.Point(96, 50);
            this.cmbprotocol.Name = "cmbprotocol";
            this.cmbprotocol.Size = new System.Drawing.Size(78, 20);
            this.cmbprotocol.TabIndex = 35;
            // 
            // chkudpEnabled
            // 
            this.chkudpEnabled.AutoSize = true;
            this.chkudpEnabled.Location = new System.Drawing.Point(13, 79);
            this.chkudpEnabled.Name = "chkudpEnabled";
            this.chkudpEnabled.Size = new System.Drawing.Size(66, 16);
            this.chkudpEnabled.TabIndex = 33;
            this.chkudpEnabled.Text = "开启UDP";
            this.chkudpEnabled.UseVisualStyleBackColor = true;
            // 
            // groupBoxCoreKcpSetting
            // 
            groupBoxCoreKcpSetting.Controls.Add(this.chkKcpcongestion);
            groupBoxCoreKcpSetting.Controls.Add(this.txtKcpwriteBufferSize);
            groupBoxCoreKcpSetting.Controls.Add(label10);
            groupBoxCoreKcpSetting.Controls.Add(this.txtKcpreadBufferSize);
            groupBoxCoreKcpSetting.Controls.Add(label11);
            groupBoxCoreKcpSetting.Controls.Add(this.txtKcpdownlinkCapacity);
            groupBoxCoreKcpSetting.Controls.Add(label8);
            groupBoxCoreKcpSetting.Controls.Add(this.txtKcpuplinkCapacity);
            groupBoxCoreKcpSetting.Controls.Add(label9);
            groupBoxCoreKcpSetting.Controls.Add(this.txtKcptti);
            groupBoxCoreKcpSetting.Controls.Add(label7);
            groupBoxCoreKcpSetting.Controls.Add(this.txtKcpmtu);
            groupBoxCoreKcpSetting.Controls.Add(label6);
            groupBoxCoreKcpSetting.Location = new System.Drawing.Point(437, 206);
            groupBoxCoreKcpSetting.Name = "groupBoxCoreKcpSetting";
            groupBoxCoreKcpSetting.Padding = new System.Windows.Forms.Padding(10);
            groupBoxCoreKcpSetting.Size = new System.Drawing.Size(189, 214);
            groupBoxCoreKcpSetting.TabIndex = 31;
            groupBoxCoreKcpSetting.TabStop = false;
            groupBoxCoreKcpSetting.Text = "Core: KCP 设置";
            // 
            // chkKcpcongestion
            // 
            this.chkKcpcongestion.AutoSize = true;
            this.chkKcpcongestion.Location = new System.Drawing.Point(13, 189);
            this.chkKcpcongestion.Name = "chkKcpcongestion";
            this.chkKcpcongestion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkKcpcongestion.Size = new System.Drawing.Size(84, 16);
            this.chkKcpcongestion.TabIndex = 33;
            this.chkKcpcongestion.Text = "congestion";
            this.chkKcpcongestion.UseVisualStyleBackColor = true;
            // 
            // txtKcpwriteBufferSize
            // 
            this.txtKcpwriteBufferSize.Location = new System.Drawing.Point(119, 161);
            this.txtKcpwriteBufferSize.Name = "txtKcpwriteBufferSize";
            this.txtKcpwriteBufferSize.Size = new System.Drawing.Size(55, 21);
            this.txtKcpwriteBufferSize.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(13, 165);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(95, 12);
            label10.TabIndex = 31;
            label10.Text = "writeBufferSize";
            // 
            // txtKcpreadBufferSize
            // 
            this.txtKcpreadBufferSize.Location = new System.Drawing.Point(119, 76);
            this.txtKcpreadBufferSize.Name = "txtKcpreadBufferSize";
            this.txtKcpreadBufferSize.Size = new System.Drawing.Size(55, 21);
            this.txtKcpreadBufferSize.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(13, 80);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(89, 12);
            label11.TabIndex = 29;
            label11.Text = "readBufferSize";
            // 
            // txtKcpdownlinkCapacity
            // 
            this.txtKcpdownlinkCapacity.Location = new System.Drawing.Point(119, 133);
            this.txtKcpdownlinkCapacity.Name = "txtKcpdownlinkCapacity";
            this.txtKcpdownlinkCapacity.Size = new System.Drawing.Size(55, 21);
            this.txtKcpdownlinkCapacity.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(13, 137);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(101, 12);
            label8.TabIndex = 27;
            label8.Text = "downlinkCapacity";
            // 
            // txtKcpuplinkCapacity
            // 
            this.txtKcpuplinkCapacity.Location = new System.Drawing.Point(119, 48);
            this.txtKcpuplinkCapacity.Name = "txtKcpuplinkCapacity";
            this.txtKcpuplinkCapacity.Size = new System.Drawing.Size(55, 21);
            this.txtKcpuplinkCapacity.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(13, 52);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(89, 12);
            label9.TabIndex = 25;
            label9.Text = "uplinkCapacity";
            // 
            // txtKcptti
            // 
            this.txtKcptti.Location = new System.Drawing.Point(119, 105);
            this.txtKcptti.Name = "txtKcptti";
            this.txtKcptti.Size = new System.Drawing.Size(55, 21);
            this.txtKcptti.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(13, 109);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(23, 12);
            label7.TabIndex = 23;
            label7.Text = "tti";
            // 
            // txtKcpmtu
            // 
            this.txtKcpmtu.Location = new System.Drawing.Point(119, 20);
            this.txtKcpmtu.Name = "txtKcpmtu";
            this.txtKcpmtu.Size = new System.Drawing.Size(55, 21);
            this.txtKcpmtu.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(13, 24);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(23, 12);
            label6.TabIndex = 21;
            label6.Text = "mtu";
            // 
            // groupBoxCoreRouting
            // 
            groupBoxCoreRouting.Controls.Add(label4);
            groupBoxCoreRouting.Controls.Add(this.tabControl2);
            groupBoxCoreRouting.Controls.Add(this.chkBypassChinasites);
            groupBoxCoreRouting.Controls.Add(this.chkBypassChinaip);
            groupBoxCoreRouting.Location = new System.Drawing.Point(12, 179);
            groupBoxCoreRouting.Name = "groupBoxCoreRouting";
            groupBoxCoreRouting.Padding = new System.Windows.Forms.Padding(10);
            groupBoxCoreRouting.Size = new System.Drawing.Size(419, 293);
            groupBoxCoreRouting.TabIndex = 32;
            groupBoxCoreRouting.TabStop = false;
            groupBoxCoreRouting.Text = "Core: 路由设置";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.Brown;
            label4.Location = new System.Drawing.Point(13, 51);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(269, 12);
            label4.TabIndex = 13;
            label4.Text = "*设置的网址或IP，用逗号(,)隔开，可以一行多个";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl2.Location = new System.Drawing.Point(10, 75);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(399, 208);
            this.tabControl2.TabIndex = 12;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtUseragent);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(391, 160);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "  代理的网址或IP  ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtUseragent
            // 
            this.txtUseragent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUseragent.Location = new System.Drawing.Point(3, 3);
            this.txtUseragent.Multiline = true;
            this.txtUseragent.Name = "txtUseragent";
            this.txtUseragent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUseragent.Size = new System.Drawing.Size(385, 154);
            this.txtUseragent.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtUserdirect);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(391, 182);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "  直连的网址或IP  ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtUserdirect
            // 
            this.txtUserdirect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserdirect.Location = new System.Drawing.Point(3, 3);
            this.txtUserdirect.Multiline = true;
            this.txtUserdirect.Name = "txtUserdirect";
            this.txtUserdirect.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUserdirect.Size = new System.Drawing.Size(385, 176);
            this.txtUserdirect.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtUserblock);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(618, 160);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "  阻止的网址或IP  ";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtUserblock
            // 
            this.txtUserblock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserblock.Location = new System.Drawing.Point(3, 3);
            this.txtUserblock.Multiline = true;
            this.txtUserblock.Name = "txtUserblock";
            this.txtUserblock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUserblock.Size = new System.Drawing.Size(612, 154);
            this.txtUserblock.TabIndex = 1;
            // 
            // chkBypassChinasites
            // 
            this.chkBypassChinasites.AutoSize = true;
            this.chkBypassChinasites.Location = new System.Drawing.Point(13, 25);
            this.chkBypassChinasites.Name = "chkBypassChinasites";
            this.chkBypassChinasites.Size = new System.Drawing.Size(96, 16);
            this.chkBypassChinasites.TabIndex = 10;
            this.chkBypassChinasites.Text = "绕过大陆地址";
            this.chkBypassChinasites.UseVisualStyleBackColor = true;
            // 
            // chkBypassChinaip
            // 
            this.chkBypassChinaip.AutoSize = true;
            this.chkBypassChinaip.Location = new System.Drawing.Point(115, 25);
            this.chkBypassChinaip.Name = "chkBypassChinaip";
            this.chkBypassChinaip.Size = new System.Drawing.Size(84, 16);
            this.chkBypassChinaip.TabIndex = 11;
            this.chkBypassChinaip.Text = "绕过大陆IP";
            this.chkBypassChinaip.UseVisualStyleBackColor = true;
            // 
            // groupBoxV2RaySetting
            // 
            groupBoxV2RaySetting.Controls.Add(this.txturlGFWList);
            groupBoxV2RaySetting.Controls.Add(this.label13);
            groupBoxV2RaySetting.Controls.Add(label12);
            groupBoxV2RaySetting.Controls.Add(this.chkAutoRun);
            groupBoxV2RaySetting.Location = new System.Drawing.Point(12, 12);
            groupBoxV2RaySetting.Name = "groupBoxV2RaySetting";
            groupBoxV2RaySetting.Padding = new System.Windows.Forms.Padding(10);
            groupBoxV2RaySetting.Size = new System.Drawing.Size(419, 161);
            groupBoxV2RaySetting.TabIndex = 33;
            groupBoxV2RaySetting.TabStop = false;
            groupBoxV2RaySetting.Text = "V2RayN 设置";
            // 
            // txturlGFWList
            // 
            this.txturlGFWList.Location = new System.Drawing.Point(13, 74);
            this.txturlGFWList.Name = "txturlGFWList";
            this.txturlGFWList.Size = new System.Drawing.Size(396, 21);
            this.txturlGFWList.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(239, 12);
            this.label13.TabIndex = 32;
            this.label13.Text = "自定义GFWList地址(不需自定义请填空白)：";
            // 
            // label12
            // 
            label12.ForeColor = System.Drawing.Color.Brown;
            label12.Location = new System.Drawing.Point(11, 111);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(322, 42);
            label12.TabIndex = 31;
            label12.Text = "*启用系统代理:\r\n全局模式:端口=socks端口+1\r\nPAC 模式:端口=socks端口+2;优先级PAC > v2ray路由";
            // 
            // chkAutoRun
            // 
            this.chkAutoRun.AutoSize = true;
            this.chkAutoRun.Location = new System.Drawing.Point(13, 25);
            this.chkAutoRun.Name = "chkAutoRun";
            this.chkAutoRun.Size = new System.Drawing.Size(96, 16);
            this.chkAutoRun.TabIndex = 29;
            this.chkAutoRun.Text = "开机自动启动";
            this.chkAutoRun.UseVisualStyleBackColor = true;
            // 
            // OptionSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(634, 479);
            this.Controls.Add(groupBoxV2RaySetting);
            this.Controls.Add(groupBoxCoreRouting);
            this.Controls.Add(groupBoxCoreKcpSetting);
            this.Controls.Add(this.groupBoxCoreBaseSetting);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OptionSettingForm";
            this.Text = "参数设置";
            this.Load += new System.EventHandler(this.OptionSettingForm_Load);
            this.groupBoxCoreBaseSetting.ResumeLayout(false);
            this.groupBoxCoreBaseSetting.PerformLayout();
            groupBoxCoreKcpSetting.ResumeLayout(false);
            groupBoxCoreKcpSetting.PerformLayout();
            groupBoxCoreRouting.ResumeLayout(false);
            groupBoxCoreRouting.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            groupBoxV2RaySetting.ResumeLayout(false);
            groupBoxV2RaySetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox chkmuxEnabled;
        private System.Windows.Forms.CheckBox chklogEnabled;
        private System.Windows.Forms.ComboBox cmbloglevel;
        private System.Windows.Forms.GroupBox groupBoxCoreBaseSetting;
        private System.Windows.Forms.TextBox txtlocalPort;
        private System.Windows.Forms.ComboBox cmbprotocol;
        private System.Windows.Forms.CheckBox chkudpEnabled;
        private System.Windows.Forms.CheckBox chkKcpcongestion;
        private System.Windows.Forms.TextBox txtKcpwriteBufferSize;
        private System.Windows.Forms.TextBox txtKcpreadBufferSize;
        private System.Windows.Forms.TextBox txtKcpdownlinkCapacity;
        private System.Windows.Forms.TextBox txtKcpuplinkCapacity;
        private System.Windows.Forms.TextBox txtKcptti;
        private System.Windows.Forms.TextBox txtKcpmtu;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtUseragent;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtUserdirect;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtUserblock;
        private System.Windows.Forms.CheckBox chkBypassChinasites;
        private System.Windows.Forms.CheckBox chkBypassChinaip;
        private System.Windows.Forms.TextBox txturlGFWList;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkAutoRun;
    }
}