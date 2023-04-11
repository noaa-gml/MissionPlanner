
namespace MissionPlanner.Controls
{
    partial class HORUS_PreFlight
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
            this.BUT_arm = new MissionPlanner.Controls.MyButton();
            this.BUT_asCal = new MissionPlanner.Controls.MyButton();
            this.BUT_loadTO = new MissionPlanner.Controls.MyButton();
            this.TXT_msgBox = new System.Windows.Forms.RichTextBox();
            this.TXT_info = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BUT_SET_AUTO = new MissionPlanner.Controls.MyButton();
            this.CB_pilotReady = new System.Windows.Forms.CheckBox();
            this.CB_IsArmed = new System.Windows.Forms.CheckBox();
            this.CB_notFlying = new System.Windows.Forms.CheckBox();
            this.CB_notAuto = new System.Windows.Forms.CheckBox();
            this.CB_payload_rdy = new System.Windows.Forms.CheckBox();
            this.CB_paco_rdy = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BUT_arm
            // 
            this.BUT_arm.Enabled = false;
            this.BUT_arm.Location = new System.Drawing.Point(5, 66);
            this.BUT_arm.Margin = new System.Windows.Forms.Padding(4);
            this.BUT_arm.Name = "BUT_arm";
            this.BUT_arm.Size = new System.Drawing.Size(100, 28);
            this.BUT_arm.TabIndex = 0;
            this.BUT_arm.Text = "ARM";
            this.BUT_arm.UseVisualStyleBackColor = true;
            this.BUT_arm.Click += new System.EventHandler(this.BUT_arm_Click);
            // 
            // BUT_asCal
            // 
            this.BUT_asCal.Location = new System.Drawing.Point(6, 2);
            this.BUT_asCal.Margin = new System.Windows.Forms.Padding(4);
            this.BUT_asCal.Name = "BUT_asCal";
            this.BUT_asCal.Size = new System.Drawing.Size(100, 28);
            this.BUT_asCal.TabIndex = 1;
            this.BUT_asCal.Text = "Airsped Cal";
            this.BUT_asCal.UseVisualStyleBackColor = true;
            this.BUT_asCal.Click += new System.EventHandler(this.BUT_asCal_Click);
            // 
            // BUT_loadTO
            // 
            this.BUT_loadTO.Location = new System.Drawing.Point(5, 131);
            this.BUT_loadTO.Margin = new System.Windows.Forms.Padding(4);
            this.BUT_loadTO.Name = "BUT_loadTO";
            this.BUT_loadTO.Size = new System.Drawing.Size(100, 28);
            this.BUT_loadTO.TabIndex = 2;
            this.BUT_loadTO.Text = "Load Takeoff";
            this.BUT_loadTO.UseVisualStyleBackColor = true;
            this.BUT_loadTO.Click += new System.EventHandler(this.BUT_loadTO_Click);
            // 
            // TXT_msgBox
            // 
            this.TXT_msgBox.Location = new System.Drawing.Point(11, 313);
            this.TXT_msgBox.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_msgBox.Name = "TXT_msgBox";
            this.TXT_msgBox.Size = new System.Drawing.Size(528, 102);
            this.TXT_msgBox.TabIndex = 4;
            this.TXT_msgBox.Text = "";
            // 
            // TXT_info
            // 
            this.TXT_info.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_info.Location = new System.Drawing.Point(167, 5);
            this.TXT_info.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_info.Name = "TXT_info";
            this.TXT_info.Size = new System.Drawing.Size(372, 301);
            this.TXT_info.TabIndex = 5;
            this.TXT_info.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BUT_SET_AUTO
            // 
            this.BUT_SET_AUTO.Enabled = false;
            this.BUT_SET_AUTO.Location = new System.Drawing.Point(11, 277);
            this.BUT_SET_AUTO.Margin = new System.Windows.Forms.Padding(4);
            this.BUT_SET_AUTO.Name = "BUT_SET_AUTO";
            this.BUT_SET_AUTO.Size = new System.Drawing.Size(100, 28);
            this.BUT_SET_AUTO.TabIndex = 6;
            this.BUT_SET_AUTO.Text = "Set Auto";
            this.BUT_SET_AUTO.UseVisualStyleBackColor = true;
            this.BUT_SET_AUTO.Click += new System.EventHandler(this.BUT_SET_AUTO_Click);
            // 
            // CB_pilotReady
            // 
            this.CB_pilotReady.AutoSize = true;
            this.CB_pilotReady.Enabled = false;
            this.CB_pilotReady.Location = new System.Drawing.Point(11, 249);
            this.CB_pilotReady.Name = "CB_pilotReady";
            this.CB_pilotReady.Size = new System.Drawing.Size(116, 21);
            this.CB_pilotReady.TabIndex = 10;
            this.CB_pilotReady.Text = "Pilot is Ready";
            this.CB_pilotReady.UseVisualStyleBackColor = true;
            // 
            // CB_IsArmed
            // 
            this.CB_IsArmed.AutoSize = true;
            this.CB_IsArmed.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CB_IsArmed.Location = new System.Drawing.Point(6, 101);
            this.CB_IsArmed.Name = "CB_IsArmed";
            this.CB_IsArmed.Size = new System.Drawing.Size(71, 21);
            this.CB_IsArmed.TabIndex = 12;
            this.CB_IsArmed.Text = "Armed";
            this.CB_IsArmed.UseVisualStyleBackColor = false;
            // 
            // CB_notFlying
            // 
            this.CB_notFlying.AutoSize = true;
            this.CB_notFlying.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CB_notFlying.Location = new System.Drawing.Point(11, 227);
            this.CB_notFlying.Name = "CB_notFlying";
            this.CB_notFlying.Size = new System.Drawing.Size(93, 21);
            this.CB_notFlying.TabIndex = 13;
            this.CB_notFlying.Text = "Not Flying";
            this.CB_notFlying.UseVisualStyleBackColor = false;
            // 
            // CB_notAuto
            // 
            this.CB_notAuto.AutoSize = true;
            this.CB_notAuto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CB_notAuto.Location = new System.Drawing.Point(4, 37);
            this.CB_notAuto.Name = "CB_notAuto";
            this.CB_notAuto.Size = new System.Drawing.Size(124, 21);
            this.CB_notAuto.TabIndex = 14;
            this.CB_notAuto.Text = "Mode Not Auto";
            this.CB_notAuto.UseVisualStyleBackColor = false;
            // 
            // CB_payload_rdy
            // 
            this.CB_payload_rdy.AutoSize = true;
            this.CB_payload_rdy.Location = new System.Drawing.Point(11, 166);
            this.CB_payload_rdy.Name = "CB_payload_rdy";
            this.CB_payload_rdy.Size = new System.Drawing.Size(126, 21);
            this.CB_payload_rdy.TabIndex = 15;
            this.CB_payload_rdy.Text = "Payload Ready";
            this.CB_payload_rdy.UseVisualStyleBackColor = true;
            // 
            // CB_paco_rdy
            // 
            this.CB_paco_rdy.AutoSize = true;
            this.CB_paco_rdy.Location = new System.Drawing.Point(11, 193);
            this.CB_paco_rdy.Name = "CB_paco_rdy";
            this.CB_paco_rdy.Size = new System.Drawing.Size(133, 21);
            this.CB_paco_rdy.TabIndex = 16;
            this.CB_paco_rdy.Text = "PAC-O Checklist";
            this.CB_paco_rdy.UseVisualStyleBackColor = true;
            // 
            // IRISS_PreFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CB_paco_rdy);
            this.Controls.Add(this.CB_payload_rdy);
            this.Controls.Add(this.CB_notAuto);
            this.Controls.Add(this.CB_notFlying);
            this.Controls.Add(this.CB_IsArmed);
            this.Controls.Add(this.CB_pilotReady);
            this.Controls.Add(this.BUT_SET_AUTO);
            this.Controls.Add(this.TXT_info);
            this.Controls.Add(this.TXT_msgBox);
            this.Controls.Add(this.BUT_loadTO);
            this.Controls.Add(this.BUT_asCal);
            this.Controls.Add(this.BUT_arm);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IRISS_PreFlight";
            this.Size = new System.Drawing.Size(583, 470);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyButton BUT_arm;
        private MyButton BUT_asCal;
        private MyButton BUT_loadTO;
        private System.Windows.Forms.RichTextBox TXT_msgBox;
        private System.Windows.Forms.RichTextBox TXT_info;
        private System.Windows.Forms.Timer timer1;
        private MyButton BUT_SET_AUTO;
        private System.Windows.Forms.CheckBox CB_pilotReady;
        private System.Windows.Forms.CheckBox CB_IsArmed;
        private System.Windows.Forms.CheckBox CB_notFlying;
        private System.Windows.Forms.CheckBox CB_notAuto;
        private System.Windows.Forms.CheckBox CB_payload_rdy;
        private System.Windows.Forms.CheckBox CB_paco_rdy;
    }
}
