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
            this.CMB_baudrate = new System.Windows.Forms.ComboBox();
            this.BUT_connect = new MissionPlanner.Controls.MyButton();
            this.CMB_serialport = new System.Windows.Forms.ComboBox();
            this.lbl_com1_status = new System.Windows.Forms.Label();
            this.led_com1_rx = new Bulb.LedBulb();
            this.led_com1_tx = new Bulb.LedBulb();
            this.led_com1_ftp = new Bulb.LedBulb();
            this.vpb_com1 = new MissionPlanner.Controls.VerticalProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_TCP_Status = new System.Windows.Forms.Label();
            this.led_com1_ack = new Bulb.LedBulb();
            this.rt_log = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // CMB_baudrate
            // 
            this.CMB_baudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_baudrate.FormattingEnabled = true;
            this.CMB_baudrate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.CMB_baudrate.Location = new System.Drawing.Point(61, 111);
            this.CMB_baudrate.Margin = new System.Windows.Forms.Padding(4);
            this.CMB_baudrate.Name = "CMB_baudrate";
            this.CMB_baudrate.Size = new System.Drawing.Size(187, 24);
            this.CMB_baudrate.TabIndex = 16;
            // 
            // BUT_connect
            // 
            this.BUT_connect.Location = new System.Drawing.Point(61, 143);
            this.BUT_connect.Margin = new System.Windows.Forms.Padding(4);
            this.BUT_connect.Name = "BUT_connect";
            this.BUT_connect.Size = new System.Drawing.Size(187, 28);
            this.BUT_connect.TabIndex = 15;
            this.BUT_connect.Text = "Connect";
            this.BUT_connect.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.BUT_connect.UseVisualStyleBackColor = true;
            this.BUT_connect.Click += new System.EventHandler(this.BUT_connect_Click);
            // 
            // CMB_serialport
            // 
            this.CMB_serialport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_serialport.FormattingEnabled = true;
            this.CMB_serialport.Location = new System.Drawing.Point(61, 79);
            this.CMB_serialport.Margin = new System.Windows.Forms.Padding(4);
            this.CMB_serialport.Name = "CMB_serialport";
            this.CMB_serialport.Size = new System.Drawing.Size(187, 24);
            this.CMB_serialport.TabIndex = 14;
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
            this.led_com1_rx.Size = new System.Drawing.Size(109, 36);
            this.led_com1_rx.TabIndex = 19;
            this.led_com1_rx.Text = "ledBulb1";
            // 
            // led_com1_tx
            // 
            this.led_com1_tx.Color = System.Drawing.Color.Red;
            this.led_com1_tx.Location = new System.Drawing.Point(112, 36);
            this.led_com1_tx.Name = "led_com1_tx";
            this.led_com1_tx.On = false;
            this.led_com1_tx.Size = new System.Drawing.Size(109, 36);
            this.led_com1_tx.TabIndex = 20;
            this.led_com1_tx.Text = "ledBulb1";
            // 
            // led_com1_ftp
            // 
            this.led_com1_ftp.Color = System.Drawing.Color.Blue;
            this.led_com1_ftp.Location = new System.Drawing.Point(163, 36);
            this.led_com1_ftp.Name = "led_com1_ftp";
            this.led_com1_ftp.On = false;
            this.led_com1_ftp.Size = new System.Drawing.Size(58, 36);
            this.led_com1_ftp.TabIndex = 21;
            this.led_com1_ftp.Text = "ledBulb1";
            // 
            // vpb_com1
            // 
            this.vpb_com1.DrawLabel = true;
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
            this.label1.Location = new System.Drawing.Point(69, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "HB          TX          FTP        ACK";
            // 
            // lbl_TCP_Status
            // 
            this.lbl_TCP_Status.AutoSize = true;
            this.lbl_TCP_Status.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TCP_Status.Location = new System.Drawing.Point(10, 567);
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
            this.led_com1_ack.Size = new System.Drawing.Size(58, 36);
            this.led_com1_ack.TabIndex = 26;
            this.led_com1_ack.Text = "ledBulb1";
            // 
            // rt_log
            // 
            this.rt_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rt_log.Location = new System.Drawing.Point(13, 356);
            this.rt_log.Name = "rt_log";
            this.rt_log.Size = new System.Drawing.Size(717, 196);
            this.rt_log.TabIndex = 27;
            this.rt_log.Text = "";
            // 
            // Dual_Serial_Ports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rt_log);
            this.Controls.Add(this.led_com1_ack);
            this.Controls.Add(this.lbl_TCP_Status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vpb_com1);
            this.Controls.Add(this.led_com1_ftp);
            this.Controls.Add(this.led_com1_tx);
            this.Controls.Add(this.led_com1_rx);
            this.Controls.Add(this.lbl_com1_status);
            this.Controls.Add(this.CMB_baudrate);
            this.Controls.Add(this.BUT_connect);
            this.Controls.Add(this.CMB_serialport);
            this.Name = "Dual_Serial_Ports";
            this.Size = new System.Drawing.Size(747, 596);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CMB_baudrate;
        private Controls.MyButton BUT_connect;
        private System.Windows.Forms.ComboBox CMB_serialport;
        private System.Windows.Forms.Label lbl_com1_status;
        private Bulb.LedBulb led_com1_rx;
        private Bulb.LedBulb led_com1_tx;
        private Bulb.LedBulb led_com1_ftp;
        private Controls.VerticalProgressBar vpb_com1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_TCP_Status;
        private Bulb.LedBulb led_com1_ack;
        private System.Windows.Forms.RichTextBox rt_log;
    }
}
