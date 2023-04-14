namespace MissionPlanner
{
    partial class HORUS_Panel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCommStats = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAHRS1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblGliderCalcs = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.horusControlMode1 = new MissionPlanner.Controls.HORUSControlMode();
            this.ledHB = new Bulb.LedBulb();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ledHB);
            this.groupBox1.Controls.Add(this.lblCommStats);
            this.groupBox1.Location = new System.Drawing.Point(4, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 81);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comms Stats";
            // 
            // lblCommStats
            // 
            this.lblCommStats.AutoSize = true;
            this.lblCommStats.Font = new System.Drawing.Font("Lucida Sans Typewriter", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommStats.Location = new System.Drawing.Point(7, 16);
            this.lblCommStats.Name = "lblCommStats";
            this.lblCommStats.Size = new System.Drawing.Size(35, 10);
            this.lblCommStats.TabIndex = 2;
            this.lblCommStats.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(3, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 81);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mission Stats";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblAHRS1);
            this.groupBox3.Location = new System.Drawing.Point(4, 464);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 102);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "AHRS";
            // 
            // lblAHRS1
            // 
            this.lblAHRS1.AutoSize = true;
            this.lblAHRS1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAHRS1.Location = new System.Drawing.Point(7, 20);
            this.lblAHRS1.Name = "lblAHRS1";
            this.lblAHRS1.Size = new System.Drawing.Size(35, 10);
            this.lblAHRS1.TabIndex = 0;
            this.lblAHRS1.Text = "label1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblGliderCalcs);
            this.groupBox4.Location = new System.Drawing.Point(3, 356);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(216, 102);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Glide Calcs";
            // 
            // lblGliderCalcs
            // 
            this.lblGliderCalcs.AutoSize = true;
            this.lblGliderCalcs.Font = new System.Drawing.Font("Lucida Sans Typewriter", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGliderCalcs.Location = new System.Drawing.Point(8, 16);
            this.lblGliderCalcs.Name = "lblGliderCalcs";
            this.lblGliderCalcs.Size = new System.Drawing.Size(35, 10);
            this.lblGliderCalcs.TabIndex = 1;
            this.lblGliderCalcs.Text = "label1";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(4, 572);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(216, 79);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Messages";
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // horusControlMode1
            // 
            this.horusControlMode1.BackColor = System.Drawing.Color.Transparent;
            this.horusControlMode1.Location = new System.Drawing.Point(4, 4);
            this.horusControlMode1.Name = "horusControlMode1";
            this.horusControlMode1.Size = new System.Drawing.Size(223, 180);
            this.horusControlMode1.TabIndex = 0;
            // 
            // ledHB
            // 
            this.ledHB.Location = new System.Drawing.Point(194, 8);
            this.ledHB.Name = "ledHB";
            this.ledHB.On = true;
            this.ledHB.Size = new System.Drawing.Size(21, 18);
            this.ledHB.TabIndex = 3;
            this.ledHB.Text = "ledBulb1";
            // 
            // HORUS_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.horusControlMode1);
            this.Name = "HORUS_Panel";
            this.Size = new System.Drawing.Size(234, 663);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.HORUSControlMode horusControlMode1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblAHRS1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblGliderCalcs;
        private System.Windows.Forms.Label lblCommStats;
        private Bulb.LedBulb ledHB;
    }
}
