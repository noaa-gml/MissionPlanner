namespace DualTelem
{
    partial class DualTelem_Main
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bar_com1 = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl_com1_status = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbl_com2_status = new System.Windows.Forms.Label();
            this.bar_com2 = new System.Windows.Forms.ProgressBar();
            this.led_ack2 = new Bulb.LedBulb();
            this.led_ftp2 = new Bulb.LedBulb();
            this.led_tx2 = new Bulb.LedBulb();
            this.led_hb2 = new Bulb.LedBulb();
            this.led_ack1 = new Bulb.LedBulb();
            this.led_ftp1 = new Bulb.LedBulb();
            this.led_tx1 = new Bulb.LedBulb();
            this.led_hb1 = new Bulb.LedBulb();
            this.zed_qos_plot = new ZedGraph.ZedGraphControl();
            this.CMB_serialport1 = new System.Windows.Forms.ComboBox();
            this.CMB_baudrate1 = new System.Windows.Forms.ComboBox();
            this.CMB_baudrate2 = new System.Windows.Forms.ComboBox();
            this.CMB_serialport2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.led_cmd1 = new Bulb.LedBulb();
            this.led_cmd2 = new Bulb.LedBulb();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.but_cmdMode = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_blkprm_com2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OpenCOM1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(487, 886);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Open TCP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bar_com1
            // 
            this.bar_com1.Location = new System.Drawing.Point(19, 71);
            this.bar_com1.Name = "bar_com1";
            this.bar_com1.Size = new System.Drawing.Size(201, 23);
            this.bar_com1.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "OpenCOM2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_com1_status
            // 
            this.lbl_com1_status.AutoSize = true;
            this.lbl_com1_status.Location = new System.Drawing.Point(243, 24);
            this.lbl_com1_status.Name = "lbl_com1_status";
            this.lbl_com1_status.Size = new System.Drawing.Size(44, 16);
            this.lbl_com1_status.TabIndex = 8;
            this.lbl_com1_status.Text = "label1";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbl_com2_status
            // 
            this.lbl_com2_status.AutoSize = true;
            this.lbl_com2_status.Location = new System.Drawing.Point(243, 215);
            this.lbl_com2_status.Name = "lbl_com2_status";
            this.lbl_com2_status.Size = new System.Drawing.Size(44, 16);
            this.lbl_com2_status.TabIndex = 9;
            this.lbl_com2_status.Text = "label1";
            // 
            // bar_com2
            // 
            this.bar_com2.Location = new System.Drawing.Point(19, 262);
            this.bar_com2.Name = "bar_com2";
            this.bar_com2.Size = new System.Drawing.Size(201, 23);
            this.bar_com2.TabIndex = 14;
            // 
            // led_ack2
            // 
            this.led_ack2.Color = System.Drawing.Color.Aqua;
            this.led_ack2.Location = new System.Drawing.Point(142, 215);
            this.led_ack2.Name = "led_ack2";
            this.led_ack2.On = true;
            this.led_ack2.Size = new System.Drawing.Size(35, 32);
            this.led_ack2.TabIndex = 13;
            this.led_ack2.Text = "ledBulb1";
            // 
            // led_ftp2
            // 
            this.led_ftp2.Color = System.Drawing.Color.Blue;
            this.led_ftp2.Location = new System.Drawing.Point(101, 215);
            this.led_ftp2.Name = "led_ftp2";
            this.led_ftp2.On = true;
            this.led_ftp2.Size = new System.Drawing.Size(35, 32);
            this.led_ftp2.TabIndex = 12;
            this.led_ftp2.Text = "ledBulb1";
            // 
            // led_tx2
            // 
            this.led_tx2.Color = System.Drawing.Color.Red;
            this.led_tx2.Location = new System.Drawing.Point(60, 215);
            this.led_tx2.Name = "led_tx2";
            this.led_tx2.On = true;
            this.led_tx2.Size = new System.Drawing.Size(35, 32);
            this.led_tx2.TabIndex = 11;
            this.led_tx2.Text = "ledBulb1";
            // 
            // led_hb2
            // 
            this.led_hb2.Location = new System.Drawing.Point(19, 215);
            this.led_hb2.Name = "led_hb2";
            this.led_hb2.On = true;
            this.led_hb2.Size = new System.Drawing.Size(35, 32);
            this.led_hb2.TabIndex = 10;
            this.led_hb2.Text = "ledBulb1";
            // 
            // led_ack1
            // 
            this.led_ack1.Color = System.Drawing.Color.Aqua;
            this.led_ack1.Location = new System.Drawing.Point(142, 24);
            this.led_ack1.Name = "led_ack1";
            this.led_ack1.On = true;
            this.led_ack1.Size = new System.Drawing.Size(35, 32);
            this.led_ack1.TabIndex = 5;
            this.led_ack1.Text = "ledBulb1";
            // 
            // led_ftp1
            // 
            this.led_ftp1.Color = System.Drawing.Color.Blue;
            this.led_ftp1.Location = new System.Drawing.Point(101, 24);
            this.led_ftp1.Name = "led_ftp1";
            this.led_ftp1.On = true;
            this.led_ftp1.Size = new System.Drawing.Size(35, 32);
            this.led_ftp1.TabIndex = 4;
            this.led_ftp1.Text = "ledBulb1";
            // 
            // led_tx1
            // 
            this.led_tx1.Color = System.Drawing.Color.Red;
            this.led_tx1.Location = new System.Drawing.Point(60, 24);
            this.led_tx1.Name = "led_tx1";
            this.led_tx1.On = true;
            this.led_tx1.Size = new System.Drawing.Size(35, 32);
            this.led_tx1.TabIndex = 3;
            this.led_tx1.Text = "ledBulb1";
            // 
            // led_hb1
            // 
            this.led_hb1.Location = new System.Drawing.Point(19, 24);
            this.led_hb1.Name = "led_hb1";
            this.led_hb1.On = true;
            this.led_hb1.Size = new System.Drawing.Size(35, 32);
            this.led_hb1.TabIndex = 2;
            this.led_hb1.Text = "ledBulb1";
            // 
            // zed_qos_plot
            // 
            this.zed_qos_plot.Location = new System.Drawing.Point(14, 439);
            this.zed_qos_plot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zed_qos_plot.Name = "zed_qos_plot";
            this.zed_qos_plot.ScrollGrace = 0D;
            this.zed_qos_plot.ScrollMaxX = 0D;
            this.zed_qos_plot.ScrollMaxY = 0D;
            this.zed_qos_plot.ScrollMaxY2 = 0D;
            this.zed_qos_plot.ScrollMinX = 0D;
            this.zed_qos_plot.ScrollMinY = 0D;
            this.zed_qos_plot.ScrollMinY2 = 0D;
            this.zed_qos_plot.Size = new System.Drawing.Size(624, 386);
            this.zed_qos_plot.TabIndex = 15;
            this.zed_qos_plot.UseExtendedPrintDialog = true;
            // 
            // CMB_serialport1
            // 
            this.CMB_serialport1.FormattingEnabled = true;
            this.CMB_serialport1.Location = new System.Drawing.Point(19, 100);
            this.CMB_serialport1.Name = "CMB_serialport1";
            this.CMB_serialport1.Size = new System.Drawing.Size(201, 24);
            this.CMB_serialport1.TabIndex = 16;
            this.CMB_serialport1.Enter += new System.EventHandler(this.CMB_serialport1_Enter);
            // 
            // CMB_baudrate1
            // 
            this.CMB_baudrate1.FormattingEnabled = true;
            this.CMB_baudrate1.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "28800",
            "57600",
            "115200"});
            this.CMB_baudrate1.Location = new System.Drawing.Point(19, 132);
            this.CMB_baudrate1.Name = "CMB_baudrate1";
            this.CMB_baudrate1.Size = new System.Drawing.Size(201, 24);
            this.CMB_baudrate1.TabIndex = 17;
            // 
            // CMB_baudrate2
            // 
            this.CMB_baudrate2.FormattingEnabled = true;
            this.CMB_baudrate2.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "28800",
            "57600",
            "115200"});
            this.CMB_baudrate2.Location = new System.Drawing.Point(19, 323);
            this.CMB_baudrate2.Name = "CMB_baudrate2";
            this.CMB_baudrate2.Size = new System.Drawing.Size(201, 24);
            this.CMB_baudrate2.TabIndex = 19;
            // 
            // CMB_serialport2
            // 
            this.CMB_serialport2.FormattingEnabled = true;
            this.CMB_serialport2.Location = new System.Drawing.Point(19, 291);
            this.CMB_serialport2.Name = "CMB_serialport2";
            this.CMB_serialport2.Size = new System.Drawing.Size(201, 24);
            this.CMB_serialport2.TabIndex = 18;
            this.CMB_serialport2.Enter += new System.EventHandler(this.CMB_serialport2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "HB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "TX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "FTP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "ACK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "CMD";
            // 
            // led_cmd1
            // 
            this.led_cmd1.Color = System.Drawing.Color.White;
            this.led_cmd1.Location = new System.Drawing.Point(183, 24);
            this.led_cmd1.Name = "led_cmd1";
            this.led_cmd1.On = true;
            this.led_cmd1.Size = new System.Drawing.Size(35, 32);
            this.led_cmd1.TabIndex = 25;
            this.led_cmd1.Text = "ledBulb1";
            // 
            // led_cmd2
            // 
            this.led_cmd2.Color = System.Drawing.Color.White;
            this.led_cmd2.Location = new System.Drawing.Point(186, 215);
            this.led_cmd2.Name = "led_cmd2";
            this.led_cmd2.On = false;
            this.led_cmd2.Size = new System.Drawing.Size(35, 32);
            this.led_cmd2.TabIndex = 26;
            this.led_cmd2.Text = "ledBulb2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "CMD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "ACK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "FTP";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "TX";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "HB";
            // 
            // but_cmdMode
            // 
            this.but_cmdMode.Location = new System.Drawing.Point(461, 12);
            this.but_cmdMode.Name = "but_cmdMode";
            this.but_cmdMode.Size = new System.Drawing.Size(167, 28);
            this.but_cmdMode.TabIndex = 32;
            this.but_cmdMode.Text = "CMD Mode: Auto";
            this.but_cmdMode.UseVisualStyleBackColor = true;
            this.but_cmdMode.Click += new System.EventHandler(this.but_cmdMode_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(467, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 60);
            this.label11.TabIndex = 33;
            this.label11.Text = "AUTO: Prioritizes COM 1\r\nSwitches to COM2 if \r\nCOM1 is weak. ";
            // 
            // cb_blkprm_com2
            // 
            this.cb_blkprm_com2.AutoSize = true;
            this.cb_blkprm_com2.Checked = true;
            this.cb_blkprm_com2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_blkprm_com2.Location = new System.Drawing.Point(19, 382);
            this.cb_blkprm_com2.Name = "cb_blkprm_com2";
            this.cb_blkprm_com2.Size = new System.Drawing.Size(251, 20);
            this.cb_blkprm_com2.TabIndex = 34;
            this.cb_blkprm_com2.Text = "Block Param and Mission Listing Req";
            this.cb_blkprm_com2.UseVisualStyleBackColor = true;
            // 
            // DualTelem_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 929);
            this.Controls.Add(this.cb_blkprm_com2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.but_cmdMode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.led_cmd2);
            this.Controls.Add(this.led_cmd1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CMB_baudrate2);
            this.Controls.Add(this.CMB_serialport2);
            this.Controls.Add(this.CMB_baudrate1);
            this.Controls.Add(this.CMB_serialport1);
            this.Controls.Add(this.zed_qos_plot);
            this.Controls.Add(this.bar_com2);
            this.Controls.Add(this.led_ack2);
            this.Controls.Add(this.led_ftp2);
            this.Controls.Add(this.led_tx2);
            this.Controls.Add(this.led_hb2);
            this.Controls.Add(this.lbl_com2_status);
            this.Controls.Add(this.lbl_com1_status);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bar_com1);
            this.Controls.Add(this.led_ack1);
            this.Controls.Add(this.led_ftp1);
            this.Controls.Add(this.led_tx1);
            this.Controls.Add(this.led_hb1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "DualTelem_Main";
            this.Text = "DualTelem_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Bulb.LedBulb led_hb1;
        private Bulb.LedBulb led_tx1;
        private System.Windows.Forms.Timer timer1;
        private Bulb.LedBulb led_ftp1;
        private Bulb.LedBulb led_ack1;
        private System.Windows.Forms.ProgressBar bar_com1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl_com1_status;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbl_com2_status;
        private System.Windows.Forms.ProgressBar bar_com2;
        private Bulb.LedBulb led_ack2;
        private Bulb.LedBulb led_ftp2;
        private Bulb.LedBulb led_tx2;
        private Bulb.LedBulb led_hb2;
        private ZedGraph.ZedGraphControl zed_qos_plot;
        private System.Windows.Forms.ComboBox CMB_serialport1;
        private System.Windows.Forms.ComboBox CMB_baudrate1;
        private System.Windows.Forms.ComboBox CMB_baudrate2;
        private System.Windows.Forms.ComboBox CMB_serialport2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bulb.LedBulb led_cmd1;
        private Bulb.LedBulb led_cmd2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button but_cmdMode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cb_blkprm_com2;
    }
}