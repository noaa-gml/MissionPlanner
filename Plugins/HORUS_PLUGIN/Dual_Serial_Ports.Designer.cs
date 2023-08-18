namespace MissionPlanner
{
    partial class Dual_Serial_Ports
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CMB_baudrate1 = new System.Windows.Forms.ComboBox();
            this.BUT_connect1 = new MissionPlanner.Controls.MyButton();
            this.CMB_serialport1 = new System.Windows.Forms.ComboBox();
            this.lbl_com1_status = new System.Windows.Forms.Label();
            this.led_com1_rx = new Bulb.LedBulb();
            this.led_com1_tx = new Bulb.LedBulb();
            this.led_com1_ftp = new Bulb.LedBulb();
            this.vpb_com1 = new MissionPlanner.Controls.VerticalProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_TCP_Status = new System.Windows.Forms.Label();
            this.led_com1_ack = new Bulb.LedBulb();
            this.rt_log = new System.Windows.Forms.RichTextBox();
            this.zed_com1 = new ZedGraph.ZedGraphControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.led_com2_ack = new Bulb.LedBulb();
            this.label8 = new System.Windows.Forms.Label();
            this.vpb_com2 = new MissionPlanner.Controls.VerticalProgressBar();
            this.led_com2_ftp = new Bulb.LedBulb();
            this.led_com2_tx = new Bulb.LedBulb();
            this.led_com2_rx = new Bulb.LedBulb();
            this.lbl_com2_status = new System.Windows.Forms.Label();
            this.CMB_baudrate2 = new System.Windows.Forms.ComboBox();
            this.BUT_connect2 = new MissionPlanner.Controls.MyButton();
            this.CMB_serialport2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CMB_baudrate1
            // 
            this.CMB_baudrate1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_baudrate1.FormattingEnabled = true;
            this.CMB_baudrate1.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.CMB_baudrate1.Location = new System.Drawing.Point(61, 111);
            this.CMB_baudrate1.Margin = new System.Windows.Forms.Padding(4);
            this.CMB_baudrate1.Name = "CMB_baudrate1";
            this.CMB_baudrate1.Size = new System.Drawing.Size(187, 24);
            this.CMB_baudrate1.TabIndex = 16;
            // 
            // BUT_connect1
            // 
            this.BUT_connect1.Location = new System.Drawing.Point(61, 143);
            this.BUT_connect1.Margin = new System.Windows.Forms.Padding(4);
            this.BUT_connect1.Name = "BUT_connect1";
            this.BUT_connect1.Size = new System.Drawing.Size(187, 28);
            this.BUT_connect1.TabIndex = 15;
            this.BUT_connect1.Text = "Connect";
            this.BUT_connect1.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.BUT_connect1.UseVisualStyleBackColor = true;
            this.BUT_connect1.Click += new System.EventHandler(this.BUT_connect_Click);
            // 
            // CMB_serialport1
            // 
            this.CMB_serialport1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_serialport1.FormattingEnabled = true;
            this.CMB_serialport1.Location = new System.Drawing.Point(61, 79);
            this.CMB_serialport1.Margin = new System.Windows.Forms.Padding(4);
            this.CMB_serialport1.Name = "CMB_serialport1";
            this.CMB_serialport1.Size = new System.Drawing.Size(187, 24);
            this.CMB_serialport1.TabIndex = 14;
            // 
            // lbl_com1_status
            // 
            this.lbl_com1_status.AutoSize = true;
            this.lbl_com1_status.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_com1_status.Location = new System.Drawing.Point(259, 36);
            this.lbl_com1_status.Name = "lbl_com1_status";
            this.lbl_com1_status.Size = new System.Drawing.Size(116, 17);
            this.lbl_com1_status.TabIndex = 18;
            this.lbl_com1_status.Text = "COM 1 Status";
            // 
            // led_com1_rx
            // 
            this.led_com1_rx.Location = new System.Drawing.Point(61, 36);
            this.led_com1_rx.Name = "led_com1_rx";
            this.led_com1_rx.On = false;
            this.led_com1_rx.Size = new System.Drawing.Size(45, 36);
            this.led_com1_rx.TabIndex = 19;
            this.led_com1_rx.Text = "ledBulb1";
            // 
            // led_com1_tx
            // 
            this.led_com1_tx.Color = System.Drawing.Color.Red;
            this.led_com1_tx.Location = new System.Drawing.Point(112, 36);
            this.led_com1_tx.Name = "led_com1_tx";
            this.led_com1_tx.On = false;
            this.led_com1_tx.Size = new System.Drawing.Size(45, 36);
            this.led_com1_tx.TabIndex = 20;
            this.led_com1_tx.Text = "ledBulb1";
            // 
            // led_com1_ftp
            // 
            this.led_com1_ftp.Color = System.Drawing.Color.Blue;
            this.led_com1_ftp.Location = new System.Drawing.Point(163, 36);
            this.led_com1_ftp.Name = "led_com1_ftp";
            this.led_com1_ftp.On = false;
            this.led_com1_ftp.Size = new System.Drawing.Size(43, 36);
            this.led_com1_ftp.TabIndex = 21;
            this.led_com1_ftp.Text = "ledBulb1";
            // 
            // vpb_com1
            // 
            this.vpb_com1.DrawLabel = false;
            this.vpb_com1.Label = null;
            this.vpb_com1.Location = new System.Drawing.Point(13, 36);
            this.vpb_com1.maxline = 0;
            this.vpb_com1.minline = 0;
            this.vpb_com1.Name = "vpb_com1";
            this.vpb_com1.Size = new System.Drawing.Size(41, 135);
            this.vpb_com1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "HB";
            // 
            // lbl_TCP_Status
            // 
            this.lbl_TCP_Status.AutoSize = true;
            this.lbl_TCP_Status.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TCP_Status.Location = new System.Drawing.Point(10, 1022);
            this.lbl_TCP_Status.Name = "lbl_TCP_Status";
            this.lbl_TCP_Status.Size = new System.Drawing.Size(82, 16);
            this.lbl_TCP_Status.TabIndex = 25;
            this.lbl_TCP_Status.Text = "TCP Status";
            // 
            // led_com1_ack
            // 
            this.led_com1_ack.Color = System.Drawing.Color.Aqua;
            this.led_com1_ack.Location = new System.Drawing.Point(212, 36);
            this.led_com1_ack.Name = "led_com1_ack";
            this.led_com1_ack.On = false;
            this.led_com1_ack.Size = new System.Drawing.Size(41, 36);
            this.led_com1_ack.TabIndex = 26;
            this.led_com1_ack.Text = "ledBulb1";
            // 
            // rt_log
            // 
            this.rt_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rt_log.Location = new System.Drawing.Point(13, 823);
            this.rt_log.Name = "rt_log";
            this.rt_log.Size = new System.Drawing.Size(717, 196);
            this.rt_log.TabIndex = 27;
            this.rt_log.Text = "";
            // 
            // zed_com1
            // 
            this.zed_com1.Location = new System.Drawing.Point(14, 440);
            this.zed_com1.Name = "zed_com1";
            this.zed_com1.ScrollGrace = 0D;
            this.zed_com1.ScrollMaxX = 0D;
            this.zed_com1.ScrollMaxY = 0D;
            this.zed_com1.ScrollMaxY2 = 0D;
            this.zed_com1.ScrollMinX = 0D;
            this.zed_com1.ScrollMinY = 0D;
            this.zed_com1.ScrollMinY2 = 0D;
            this.zed_com1.Size = new System.Drawing.Size(716, 377);
            this.zed_com1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "TX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "FTP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "ACK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "ACK";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "FTP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "TX";
            // 
            // led_com2_ack
            // 
            this.led_com2_ack.Color = System.Drawing.Color.Aqua;
            this.led_com2_ack.Location = new System.Drawing.Point(211, 224);
            this.led_com2_ack.Name = "led_com2_ack";
            this.led_com2_ack.On = false;
            this.led_com2_ack.Size = new System.Drawing.Size(41, 36);
            this.led_com2_ack.TabIndex = 41;
            this.led_com2_ack.Text = "ledBulb1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "HB";
            // 
            // vpb_com2
            // 
            this.vpb_com2.DrawLabel = false;
            this.vpb_com2.Label = null;
            this.vpb_com2.Location = new System.Drawing.Point(12, 224);
            this.vpb_com2.maxline = 0;
            this.vpb_com2.minline = 0;
            this.vpb_com2.Name = "vpb_com2";
            this.vpb_com2.Size = new System.Drawing.Size(41, 135);
            this.vpb_com2.TabIndex = 39;
            // 
            // led_com2_ftp
            // 
            this.led_com2_ftp.Color = System.Drawing.Color.Blue;
            this.led_com2_ftp.Location = new System.Drawing.Point(162, 224);
            this.led_com2_ftp.Name = "led_com2_ftp";
            this.led_com2_ftp.On = false;
            this.led_com2_ftp.Size = new System.Drawing.Size(43, 36);
            this.led_com2_ftp.TabIndex = 38;
            this.led_com2_ftp.Text = "ledBulb1";
            // 
            // led_com2_tx
            // 
            this.led_com2_tx.Color = System.Drawing.Color.Red;
            this.led_com2_tx.Location = new System.Drawing.Point(111, 224);
            this.led_com2_tx.Name = "led_com2_tx";
            this.led_com2_tx.On = false;
            this.led_com2_tx.Size = new System.Drawing.Size(45, 36);
            this.led_com2_tx.TabIndex = 37;
            this.led_com2_tx.Text = "ledBulb1";
            // 
            // led_com2_rx
            // 
            this.led_com2_rx.Location = new System.Drawing.Point(60, 224);
            this.led_com2_rx.Name = "led_com2_rx";
            this.led_com2_rx.On = false;
            this.led_com2_rx.Size = new System.Drawing.Size(45, 36);
            this.led_com2_rx.TabIndex = 36;
            this.led_com2_rx.Text = "ledBulb1";
            // 
            // lbl_com2_status
            // 
            this.lbl_com2_status.AutoSize = true;
            this.lbl_com2_status.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_com2_status.Location = new System.Drawing.Point(258, 224);
            this.lbl_com2_status.Name = "lbl_com2_status";
            this.lbl_com2_status.Size = new System.Drawing.Size(116, 17);
            this.lbl_com2_status.TabIndex = 35;
            this.lbl_com2_status.Text = "COM 1 Status";
            // 
            // CMB_baudrate2
            // 
            this.CMB_baudrate2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_baudrate2.FormattingEnabled = true;
            this.CMB_baudrate2.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.CMB_baudrate2.Location = new System.Drawing.Point(60, 299);
            this.CMB_baudrate2.Margin = new System.Windows.Forms.Padding(4);
            this.CMB_baudrate2.Name = "CMB_baudrate2";
            this.CMB_baudrate2.Size = new System.Drawing.Size(187, 24);
            this.CMB_baudrate2.TabIndex = 34;
            // 
            // BUT_connect2
            // 
            this.BUT_connect2.Location = new System.Drawing.Point(60, 331);
            this.BUT_connect2.Margin = new System.Windows.Forms.Padding(4);
            this.BUT_connect2.Name = "BUT_connect2";
            this.BUT_connect2.Size = new System.Drawing.Size(187, 28);
            this.BUT_connect2.TabIndex = 33;
            this.BUT_connect2.Text = "Connect";
            this.BUT_connect2.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.BUT_connect2.UseVisualStyleBackColor = true;
            // 
            // CMB_serialport2
            // 
            this.CMB_serialport2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_serialport2.FormattingEnabled = true;
            this.CMB_serialport2.Location = new System.Drawing.Point(60, 267);
            this.CMB_serialport2.Margin = new System.Windows.Forms.Padding(4);
            this.CMB_serialport2.Name = "CMB_serialport2";
            this.CMB_serialport2.Size = new System.Drawing.Size(187, 24);
            this.CMB_serialport2.TabIndex = 32;
            // 
            // Dual_Serial_Ports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 1048);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.led_com2_ack);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.vpb_com2);
            this.Controls.Add(this.led_com2_ftp);
            this.Controls.Add(this.led_com2_tx);
            this.Controls.Add(this.led_com2_rx);
            this.Controls.Add(this.lbl_com2_status);
            this.Controls.Add(this.CMB_baudrate2);
            this.Controls.Add(this.BUT_connect2);
            this.Controls.Add(this.CMB_serialport2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zed_com1);
            this.Controls.Add(this.rt_log);
            this.Controls.Add(this.led_com1_ack);
            this.Controls.Add(this.lbl_TCP_Status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vpb_com1);
            this.Controls.Add(this.led_com1_ftp);
            this.Controls.Add(this.led_com1_tx);
            this.Controls.Add(this.led_com1_rx);
            this.Controls.Add(this.lbl_com1_status);
            this.Controls.Add(this.CMB_baudrate1);
            this.Controls.Add(this.BUT_connect1);
            this.Controls.Add(this.CMB_serialport1);
            this.Name = "Dual_Serial_Ports";
            this.Text = "HORUS Dual Serial Port Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CMB_baudrate1;
        private Controls.MyButton BUT_connect1;
        private System.Windows.Forms.ComboBox CMB_serialport1;
        private System.Windows.Forms.Label lbl_com1_status;
        private Bulb.LedBulb led_com1_rx;
        private Bulb.LedBulb led_com1_tx;
        private Bulb.LedBulb led_com1_ftp;
        private Controls.VerticalProgressBar vpb_com1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_TCP_Status;
        private Bulb.LedBulb led_com1_ack;
        private System.Windows.Forms.RichTextBox rt_log;
        private ZedGraph.ZedGraphControl zed_com1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bulb.LedBulb led_com2_ack;
        private System.Windows.Forms.Label label8;
        private Controls.VerticalProgressBar vpb_com2;
        private Bulb.LedBulb led_com2_ftp;
        private Bulb.LedBulb led_com2_tx;
        private Bulb.LedBulb led_com2_rx;
        private System.Windows.Forms.Label lbl_com2_status;
        private System.Windows.Forms.ComboBox CMB_baudrate2;
        private Controls.MyButton BUT_connect2;
        private System.Windows.Forms.ComboBox CMB_serialport2;
    }
}
