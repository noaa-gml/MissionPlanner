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
            this.led_hb1 = new Bulb.LedBulb();
            this.led_tx1 = new Bulb.LedBulb();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.led_ftp1 = new Bulb.LedBulb();
            this.led_ack1 = new Bulb.LedBulb();
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OpenCOM1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(493, 740);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Open TCP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // led_hb1
            // 
            this.led_hb1.Location = new System.Drawing.Point(19, 12);
            this.led_hb1.Name = "led_hb1";
            this.led_hb1.On = true;
            this.led_hb1.Size = new System.Drawing.Size(35, 32);
            this.led_hb1.TabIndex = 2;
            this.led_hb1.Text = "ledBulb1";
            // 
            // led_tx1
            // 
            this.led_tx1.Color = System.Drawing.Color.Red;
            this.led_tx1.Location = new System.Drawing.Point(60, 12);
            this.led_tx1.Name = "led_tx1";
            this.led_tx1.On = true;
            this.led_tx1.Size = new System.Drawing.Size(35, 32);
            this.led_tx1.TabIndex = 3;
            this.led_tx1.Text = "ledBulb1";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // led_ftp1
            // 
            this.led_ftp1.Color = System.Drawing.Color.Blue;
            this.led_ftp1.Location = new System.Drawing.Point(101, 12);
            this.led_ftp1.Name = "led_ftp1";
            this.led_ftp1.On = true;
            this.led_ftp1.Size = new System.Drawing.Size(35, 32);
            this.led_ftp1.TabIndex = 4;
            this.led_ftp1.Text = "ledBulb1";
            // 
            // led_ack1
            // 
            this.led_ack1.Color = System.Drawing.Color.Aqua;
            this.led_ack1.Location = new System.Drawing.Point(142, 12);
            this.led_ack1.Name = "led_ack1";
            this.led_ack1.On = true;
            this.led_ack1.Size = new System.Drawing.Size(35, 32);
            this.led_ack1.TabIndex = 5;
            this.led_ack1.Text = "ledBulb1";
            // 
            // bar_com1
            // 
            this.bar_com1.Location = new System.Drawing.Point(19, 59);
            this.bar_com1.Name = "bar_com1";
            this.bar_com1.Size = new System.Drawing.Size(158, 23);
            this.bar_com1.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "OpenCOM2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbl_com1_status
            // 
            this.lbl_com1_status.AutoSize = true;
            this.lbl_com1_status.Location = new System.Drawing.Point(196, 12);
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
            this.lbl_com2_status.Location = new System.Drawing.Point(196, 215);
            this.lbl_com2_status.Name = "lbl_com2_status";
            this.lbl_com2_status.Size = new System.Drawing.Size(44, 16);
            this.lbl_com2_status.TabIndex = 9;
            this.lbl_com2_status.Text = "label1";
            // 
            // bar_com2
            // 
            this.bar_com2.Location = new System.Drawing.Point(19, 262);
            this.bar_com2.Name = "bar_com2";
            this.bar_com2.Size = new System.Drawing.Size(158, 23);
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
            // DualTelem_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 775);
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
    }
}