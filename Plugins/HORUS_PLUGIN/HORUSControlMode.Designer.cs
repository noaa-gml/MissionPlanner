
namespace MissionPlanner.Controls
{
    partial class HORUSControlMode
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
            this.setFBWA = new MissionPlanner.Controls.MyButton();
            this.setAuto = new MissionPlanner.Controls.MyButton();
            this.setGuided = new MissionPlanner.Controls.MyButton();
            this.setRTL = new MissionPlanner.Controls.MyButton();
            this.butBalloon = new MissionPlanner.Controls.MyButton();
            this.myButton2 = new MissionPlanner.Controls.MyButton();
            this.myButton1 = new MissionPlanner.Controls.MyButton();
            this.SuspendLayout();
            // 
            // setFBWA
            // 
            this.setFBWA.Location = new System.Drawing.Point(4, 14);
            this.setFBWA.Name = "setFBWA";
            this.setFBWA.Size = new System.Drawing.Size(66, 48);
            this.setFBWA.TabIndex = 0;
            this.setFBWA.Text = "Set FBWA";
            this.setFBWA.TextColor = System.Drawing.Color.Black;
            this.setFBWA.TextColorNotEnabled = System.Drawing.Color.Black;
            this.setFBWA.UseVisualStyleBackColor = true;
            this.setFBWA.Click += new System.EventHandler(this.setFBWA_Click);
            // 
            // setAuto
            // 
            this.setAuto.Location = new System.Drawing.Point(76, 14);
            this.setAuto.Name = "setAuto";
            this.setAuto.Size = new System.Drawing.Size(66, 48);
            this.setAuto.TabIndex = 1;
            this.setAuto.Text = "Set AUTO";
            this.setAuto.TextColor = System.Drawing.Color.Black;
            this.setAuto.TextColorNotEnabled = System.Drawing.Color.Black;
            this.setAuto.UseVisualStyleBackColor = true;
            this.setAuto.Click += new System.EventHandler(this.setAuto_Click);
            // 
            // setGuided
            // 
            this.setGuided.Location = new System.Drawing.Point(148, 14);
            this.setGuided.Name = "setGuided";
            this.setGuided.Size = new System.Drawing.Size(67, 48);
            this.setGuided.TabIndex = 2;
            this.setGuided.Text = "Set Manual";
            this.setGuided.TextColor = System.Drawing.Color.Black;
            this.setGuided.TextColorNotEnabled = System.Drawing.Color.Black;
            this.setGuided.UseVisualStyleBackColor = true;
            this.setGuided.Click += new System.EventHandler(this.setGuided_Click);
            // 
            // setRTL
            // 
            this.setRTL.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.setRTL.BGGradTop = System.Drawing.Color.DarkOrange;
            this.setRTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setRTL.Location = new System.Drawing.Point(4, 122);
            this.setRTL.Name = "setRTL";
            this.setRTL.Size = new System.Drawing.Size(67, 48);
            this.setRTL.TabIndex = 3;
            this.setRTL.Text = "Set RTL";
            this.setRTL.TextColor = System.Drawing.Color.Black;
            this.setRTL.TextColorNotEnabled = System.Drawing.Color.Black;
            this.setRTL.UseVisualStyleBackColor = true;
            this.setRTL.Click += new System.EventHandler(this.setRTL_Click);
            // 
            // butBalloon
            // 
            this.butBalloon.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.butBalloon.BGGradTop = System.Drawing.Color.Red;
            this.butBalloon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBalloon.Location = new System.Drawing.Point(77, 122);
            this.butBalloon.Name = "butBalloon";
            this.butBalloon.Size = new System.Drawing.Size(67, 48);
            this.butBalloon.TabIndex = 4;
            this.butBalloon.Text = "Release\r\nBalloon";
            this.butBalloon.TextColor = System.Drawing.Color.Black;
            this.butBalloon.TextColorNotEnabled = System.Drawing.Color.Black;
            this.butBalloon.UseVisualStyleBackColor = true;
            this.butBalloon.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // myButton2
            // 
            this.myButton2.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.myButton2.BGGradTop = System.Drawing.Color.Red;
            this.myButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton2.Location = new System.Drawing.Point(148, 122);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(67, 48);
            this.myButton2.TabIndex = 5;
            this.myButton2.Text = "Parachute";
            this.myButton2.TextColor = System.Drawing.Color.Black;
            this.myButton2.TextColorNotEnabled = System.Drawing.Color.Black;
            this.myButton2.UseVisualStyleBackColor = true;
            // 
            // myButton1
            // 
            this.myButton1.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.myButton1.BGGradTop = System.Drawing.Color.DarkSlateBlue;
            this.myButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myButton1.Location = new System.Drawing.Point(75, 68);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(67, 48);
            this.myButton1.TabIndex = 6;
            this.myButton1.Text = "Command\r\nPullup";
            this.myButton1.TextColor = System.Drawing.Color.Black;
            this.myButton1.TextColorNotEnabled = System.Drawing.Color.Black;
            this.myButton1.UseVisualStyleBackColor = true;
            // 
            // HORUSControlMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.myButton1);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.butBalloon);
            this.Controls.Add(this.setRTL);
            this.Controls.Add(this.setGuided);
            this.Controls.Add(this.setAuto);
            this.Controls.Add(this.setFBWA);
            this.Name = "HORUSControlMode";
            this.Size = new System.Drawing.Size(223, 180);
            this.Load += new System.EventHandler(this.IRISSControlMode_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MyButton setFBWA;
        private MyButton setAuto;
        private MyButton setGuided;
        private MyButton setRTL;
        private MyButton butBalloon;
        private MyButton myButton2;
        private MyButton myButton1;
    }
}
