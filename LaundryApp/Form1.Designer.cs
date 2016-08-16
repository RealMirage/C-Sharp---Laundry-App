namespace LaundryApp
{
    partial class FrmMain
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
            this.label4 = new System.Windows.Forms.Label();
            this.washCycleTimeSetting = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tWasherTimeSetting = new System.Windows.Forms.TextBox();
            this.tDryerTimeSetting = new System.Windows.Forms.TextBox();
            this.bStartUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tNumberOfCycles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWasherTimeRemaining = new System.Windows.Forms.Label();
            this.tiWasherTimeRemaining = new System.Windows.Forms.Timer(this.components);
            this.tiDryerTimeRemaining = new System.Windows.Forms.Timer(this.components);
            this.lblDryerTimeRemaining = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Laundry App v1.0";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // washCycleTimeSetting
            // 
            this.washCycleTimeSetting.Location = new System.Drawing.Point(12, 39);
            this.washCycleTimeSetting.Name = "washCycleTimeSetting";
            this.washCycleTimeSetting.Size = new System.Drawing.Size(101, 17);
            this.washCycleTimeSetting.TabIndex = 2;
            this.washCycleTimeSetting.Text = "Washer Cycle Time";
            this.washCycleTimeSetting.Click += new System.EventHandler(this.washCycleTimeSetting_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(223, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dryer Cycle Time";
            // 
            // tWasherTimeSetting
            // 
            this.tWasherTimeSetting.Location = new System.Drawing.Point(15, 60);
            this.tWasherTimeSetting.Name = "tWasherTimeSetting";
            this.tWasherTimeSetting.Size = new System.Drawing.Size(100, 20);
            this.tWasherTimeSetting.TabIndex = 5;
            // 
            // tDryerTimeSetting
            // 
            this.tDryerTimeSetting.Location = new System.Drawing.Point(226, 59);
            this.tDryerTimeSetting.Name = "tDryerTimeSetting";
            this.tDryerTimeSetting.Size = new System.Drawing.Size(100, 20);
            this.tDryerTimeSetting.TabIndex = 6;
            // 
            // bStartUpdate
            // 
            this.bStartUpdate.Location = new System.Drawing.Point(15, 155);
            this.bStartUpdate.Name = "bStartUpdate";
            this.bStartUpdate.Size = new System.Drawing.Size(98, 23);
            this.bStartUpdate.TabIndex = 7;
            this.bStartUpdate.Text = "Start / Update";
            this.bStartUpdate.UseVisualStyleBackColor = true;
            this.bStartUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "# Cycles (optional)";
            // 
            // tNumberOfCycles
            // 
            this.tNumberOfCycles.Location = new System.Drawing.Point(15, 120);
            this.tNumberOfCycles.Name = "tNumberOfCycles";
            this.tNumberOfCycles.Size = new System.Drawing.Size(100, 20);
            this.tNumberOfCycles.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Washer Time Remaining";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dryer Time Remaining";
            // 
            // lblWasherTimeRemaining
            // 
            this.lblWasherTimeRemaining.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWasherTimeRemaining.Location = new System.Drawing.Point(15, 221);
            this.lblWasherTimeRemaining.Name = "lblWasherTimeRemaining";
            this.lblWasherTimeRemaining.Size = new System.Drawing.Size(176, 23);
            this.lblWasherTimeRemaining.TabIndex = 19;
            // 
            // tiWasherTimeRemaining
            // 
            this.tiWasherTimeRemaining.Interval = 1000;
            this.tiWasherTimeRemaining.Tick += new System.EventHandler(this.tiWasherTimeRemaining_Tick);
            // 
            // tiDryerTimeRemaining
            // 
            this.tiDryerTimeRemaining.Interval = 1000;
            this.tiDryerTimeRemaining.Tick += new System.EventHandler(this.tiDryerTimeRemaining_Tick);
            // 
            // lblDryerTimeRemaining
            // 
            this.lblDryerTimeRemaining.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDryerTimeRemaining.Location = new System.Drawing.Point(12, 281);
            this.lblDryerTimeRemaining.Name = "lblDryerTimeRemaining";
            this.lblDryerTimeRemaining.Size = new System.Drawing.Size(176, 23);
            this.lblDryerTimeRemaining.TabIndex = 20;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 335);
            this.Controls.Add(this.lblDryerTimeRemaining);
            this.Controls.Add(this.lblWasherTimeRemaining);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tNumberOfCycles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bStartUpdate);
            this.Controls.Add(this.tDryerTimeSetting);
            this.Controls.Add(this.tWasherTimeSetting);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.washCycleTimeSetting);
            this.Controls.Add(this.label4);
            this.Name = "FrmMain";
            this.Text = "Laundry App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label washCycleTimeSetting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tWasherTimeSetting;
        private System.Windows.Forms.TextBox tDryerTimeSetting;
        private System.Windows.Forms.Button bStartUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tNumberOfCycles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWasherTimeRemaining;
        private System.Windows.Forms.Timer tiWasherTimeRemaining;
        private System.Windows.Forms.Timer tiDryerTimeRemaining;
        private System.Windows.Forms.Label lblDryerTimeRemaining;
    }
}

