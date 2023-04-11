
namespace MissionPlanner.Controls
{
    partial class IRISSControlMode
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
            this.setFBWA = new MissionPlanner.Controls.MyButton();
            this.setAuto = new MissionPlanner.Controls.MyButton();
            this.setGuided = new MissionPlanner.Controls.MyButton();
            this.setRTL = new MissionPlanner.Controls.MyButton();
            this.BUT_ALT_M50 = new MissionPlanner.Controls.MyButton();
            this.BUT_ALT_P50 = new MissionPlanner.Controls.MyButton();
            this.BUT_ALT_500 = new MissionPlanner.Controls.MyButton();
            this.BUT_ALT_400 = new MissionPlanner.Controls.MyButton();
            this.BUT_ALT_300 = new MissionPlanner.Controls.MyButton();
            this.BUT_ALT_200 = new MissionPlanner.Controls.MyButton();
            this.BUT_ALT_100 = new MissionPlanner.Controls.MyButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TXT_target_alt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // setFBWA
            // 
            this.setFBWA.Location = new System.Drawing.Point(6, 22);
            this.setFBWA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.setFBWA.Name = "setFBWA";
            this.setFBWA.Size = new System.Drawing.Size(99, 74);
            this.setFBWA.TabIndex = 0;
            this.setFBWA.Text = "Set FBWA";
            this.setFBWA.UseVisualStyleBackColor = true;
            this.setFBWA.Click += new System.EventHandler(this.setFBWA_Click);
            // 
            // setAuto
            // 
            this.setAuto.Location = new System.Drawing.Point(6, 105);
            this.setAuto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.setAuto.Name = "setAuto";
            this.setAuto.Size = new System.Drawing.Size(99, 74);
            this.setAuto.TabIndex = 1;
            this.setAuto.Text = "Set AUTO";
            this.setAuto.UseVisualStyleBackColor = true;
            this.setAuto.Click += new System.EventHandler(this.setAuto_Click);
            // 
            // setGuided
            // 
            this.setGuided.Location = new System.Drawing.Point(4, 188);
            this.setGuided.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.setGuided.Name = "setGuided";
            this.setGuided.Size = new System.Drawing.Size(100, 74);
            this.setGuided.TabIndex = 2;
            this.setGuided.Text = "Set Guided";
            this.setGuided.UseVisualStyleBackColor = true;
            this.setGuided.Click += new System.EventHandler(this.setGuided_Click);
            // 
            // setRTL
            // 
            this.setRTL.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.setRTL.BGGradTop = System.Drawing.Color.Red;
            this.setRTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setRTL.Location = new System.Drawing.Point(4, 271);
            this.setRTL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.setRTL.Name = "setRTL";
            this.setRTL.Size = new System.Drawing.Size(100, 74);
            this.setRTL.TabIndex = 3;
            this.setRTL.Text = "Set RTL";
            this.setRTL.UseVisualStyleBackColor = true;
            this.setRTL.Click += new System.EventHandler(this.setRTL_Click);
            // 
            // BUT_ALT_M50
            // 
            this.BUT_ALT_M50.Location = new System.Drawing.Point(6, 390);
            this.BUT_ALT_M50.Name = "BUT_ALT_M50";
            this.BUT_ALT_M50.Size = new System.Drawing.Size(98, 51);
            this.BUT_ALT_M50.TabIndex = 13;
            this.BUT_ALT_M50.Text = "ALT -50m";
            this.BUT_ALT_M50.UseVisualStyleBackColor = true;
            this.BUT_ALT_M50.Click += new System.EventHandler(this.BUT_ALT_M50_Click);
            // 
            // BUT_ALT_P50
            // 
            this.BUT_ALT_P50.Location = new System.Drawing.Point(6, 732);
            this.BUT_ALT_P50.Name = "BUT_ALT_P50";
            this.BUT_ALT_P50.Size = new System.Drawing.Size(98, 51);
            this.BUT_ALT_P50.TabIndex = 12;
            this.BUT_ALT_P50.Text = "ALT +50m";
            this.BUT_ALT_P50.UseVisualStyleBackColor = true;
            this.BUT_ALT_P50.Click += new System.EventHandler(this.BUT_ALT_P50_Click);
            // 
            // BUT_ALT_500
            // 
            this.BUT_ALT_500.Location = new System.Drawing.Point(6, 675);
            this.BUT_ALT_500.Name = "BUT_ALT_500";
            this.BUT_ALT_500.Size = new System.Drawing.Size(98, 51);
            this.BUT_ALT_500.TabIndex = 11;
            this.BUT_ALT_500.Text = "ALT 500m";
            this.BUT_ALT_500.UseVisualStyleBackColor = true;
            this.BUT_ALT_500.Click += new System.EventHandler(this.BUT_ALT_500_Click);
            // 
            // BUT_ALT_400
            // 
            this.BUT_ALT_400.Location = new System.Drawing.Point(6, 618);
            this.BUT_ALT_400.Name = "BUT_ALT_400";
            this.BUT_ALT_400.Size = new System.Drawing.Size(98, 51);
            this.BUT_ALT_400.TabIndex = 10;
            this.BUT_ALT_400.Text = "ALT 400m";
            this.BUT_ALT_400.UseVisualStyleBackColor = true;
            this.BUT_ALT_400.Click += new System.EventHandler(this.BUT_ALT_400_Click);
            // 
            // BUT_ALT_300
            // 
            this.BUT_ALT_300.Location = new System.Drawing.Point(6, 561);
            this.BUT_ALT_300.Name = "BUT_ALT_300";
            this.BUT_ALT_300.Size = new System.Drawing.Size(98, 51);
            this.BUT_ALT_300.TabIndex = 9;
            this.BUT_ALT_300.Text = "ALT 300m";
            this.BUT_ALT_300.UseVisualStyleBackColor = true;
            this.BUT_ALT_300.Click += new System.EventHandler(this.BUT_ALT_300_Click);
            // 
            // BUT_ALT_200
            // 
            this.BUT_ALT_200.Location = new System.Drawing.Point(6, 504);
            this.BUT_ALT_200.Name = "BUT_ALT_200";
            this.BUT_ALT_200.Size = new System.Drawing.Size(98, 51);
            this.BUT_ALT_200.TabIndex = 8;
            this.BUT_ALT_200.Text = "ALT 200m";
            this.BUT_ALT_200.UseVisualStyleBackColor = true;
            this.BUT_ALT_200.Click += new System.EventHandler(this.BUT_ALT_200_Click);
            // 
            // BUT_ALT_100
            // 
            this.BUT_ALT_100.Location = new System.Drawing.Point(6, 447);
            this.BUT_ALT_100.Name = "BUT_ALT_100";
            this.BUT_ALT_100.Size = new System.Drawing.Size(98, 51);
            this.BUT_ALT_100.TabIndex = 7;
            this.BUT_ALT_100.Text = "ALT 100m";
            this.BUT_ALT_100.UseVisualStyleBackColor = true;
            this.BUT_ALT_100.Click += new System.EventHandler(this.BUT_ALT_100_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TXT_target_alt
            // 
            this.TXT_target_alt.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TXT_target_alt.Location = new System.Drawing.Point(6, 353);
            this.TXT_target_alt.Name = "TXT_target_alt";
            this.TXT_target_alt.Size = new System.Drawing.Size(100, 31);
            this.TXT_target_alt.TabIndex = 14;
            this.TXT_target_alt.Text = "";
            // 
            // IRISSControlMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TXT_target_alt);
            this.Controls.Add(this.BUT_ALT_M50);
            this.Controls.Add(this.BUT_ALT_P50);
            this.Controls.Add(this.BUT_ALT_500);
            this.Controls.Add(this.BUT_ALT_400);
            this.Controls.Add(this.BUT_ALT_300);
            this.Controls.Add(this.BUT_ALT_200);
            this.Controls.Add(this.BUT_ALT_100);
            this.Controls.Add(this.setRTL);
            this.Controls.Add(this.setGuided);
            this.Controls.Add(this.setAuto);
            this.Controls.Add(this.setFBWA);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IRISSControlMode";
            this.Size = new System.Drawing.Size(110, 800);
            this.Load += new System.EventHandler(this.IRISSControlMode_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MyButton setFBWA;
        private MyButton setAuto;
        private MyButton setGuided;
        private MyButton setRTL;
        private MyButton BUT_ALT_M50;
        private MyButton BUT_ALT_P50;
        private MyButton BUT_ALT_500;
        private MyButton BUT_ALT_400;
        private MyButton BUT_ALT_300;
        private MyButton BUT_ALT_200;
        private MyButton BUT_ALT_100;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox TXT_target_alt;
    }
}
