namespace RealTimeTracking
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.m_trackBarValueMin = new System.Windows.Forms.TrackBar();
            this.m_trackBarValueMax = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.m_trackBarSaturationMin = new System.Windows.Forms.TrackBar();
            this.m_trackBarSaturationMax = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m_trackBarHueMin = new System.Windows.Forms.TrackBar();
            this.m_trackBarHueMax = new System.Windows.Forms.TrackBar();
            this.m_labelHueMin = new System.Windows.Forms.Label();
            this.m_labelHueMax = new System.Windows.Forms.Label();
            this.m_backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.m_timer = new System.Windows.Forms.Timer(this.components);
            this.m_panelCamera = new System.Windows.Forms.Panel();
            this.m_panelHSV = new System.Windows.Forms.Panel();
            this.m_panelTreshould = new System.Windows.Forms.Panel();
            this.m_checkBoxTrackObject = new System.Windows.Forms.CheckBox();
            this.m_checkBoxUseMorphOps = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBarValueMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBarValueMax)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBarSaturationMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBarSaturationMax)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBarHueMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBarHueMax)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_checkBoxUseMorphOps);
            this.groupBox1.Controls.Add(this.m_checkBoxTrackObject);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtre";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.m_trackBarValueMin);
            this.groupBox4.Controls.Add(this.m_trackBarValueMax);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(6, 173);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(315, 73);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Value";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // m_trackBarValueMin
            // 
            this.m_trackBarValueMin.Location = new System.Drawing.Point(48, 26);
            this.m_trackBarValueMin.Maximum = 500;
            this.m_trackBarValueMin.Name = "m_trackBarValueMin";
            this.m_trackBarValueMin.Size = new System.Drawing.Size(104, 45);
            this.m_trackBarValueMin.TabIndex = 0;
            this.m_trackBarValueMin.TickStyle = System.Windows.Forms.TickStyle.None;
            this.m_trackBarValueMin.Scroll += new System.EventHandler(this.trackBars_Scroll);
            // 
            // m_trackBarValueMax
            // 
            this.m_trackBarValueMax.Location = new System.Drawing.Point(197, 26);
            this.m_trackBarValueMax.Maximum = 500;
            this.m_trackBarValueMax.Name = "m_trackBarValueMax";
            this.m_trackBarValueMax.Size = new System.Drawing.Size(104, 45);
            this.m_trackBarValueMax.TabIndex = 0;
            this.m_trackBarValueMax.TickStyle = System.Windows.Forms.TickStyle.None;
            this.m_trackBarValueMax.Scroll += new System.EventHandler(this.trackBars_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Min :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Max :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.m_trackBarSaturationMin);
            this.groupBox3.Controls.Add(this.m_trackBarSaturationMax);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(6, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 73);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Saturation";
            // 
            // m_trackBarSaturationMin
            // 
            this.m_trackBarSaturationMin.Location = new System.Drawing.Point(48, 26);
            this.m_trackBarSaturationMin.Maximum = 500;
            this.m_trackBarSaturationMin.Name = "m_trackBarSaturationMin";
            this.m_trackBarSaturationMin.Size = new System.Drawing.Size(104, 45);
            this.m_trackBarSaturationMin.TabIndex = 0;
            this.m_trackBarSaturationMin.TickStyle = System.Windows.Forms.TickStyle.None;
            this.m_trackBarSaturationMin.Scroll += new System.EventHandler(this.trackBars_Scroll);
            // 
            // m_trackBarSaturationMax
            // 
            this.m_trackBarSaturationMax.Location = new System.Drawing.Point(197, 26);
            this.m_trackBarSaturationMax.Maximum = 500;
            this.m_trackBarSaturationMax.Name = "m_trackBarSaturationMax";
            this.m_trackBarSaturationMax.Size = new System.Drawing.Size(104, 45);
            this.m_trackBarSaturationMax.TabIndex = 0;
            this.m_trackBarSaturationMax.TickStyle = System.Windows.Forms.TickStyle.None;
            this.m_trackBarSaturationMax.Scroll += new System.EventHandler(this.trackBars_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Min :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.m_trackBarHueMin);
            this.groupBox2.Controls.Add(this.m_trackBarHueMax);
            this.groupBox2.Controls.Add(this.m_labelHueMin);
            this.groupBox2.Controls.Add(this.m_labelHueMax);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hue";
            // 
            // m_trackBarHueMin
            // 
            this.m_trackBarHueMin.Location = new System.Drawing.Point(48, 26);
            this.m_trackBarHueMin.Maximum = 500;
            this.m_trackBarHueMin.Name = "m_trackBarHueMin";
            this.m_trackBarHueMin.Size = new System.Drawing.Size(104, 45);
            this.m_trackBarHueMin.TabIndex = 0;
            this.m_trackBarHueMin.TickStyle = System.Windows.Forms.TickStyle.None;
            this.m_trackBarHueMin.Scroll += new System.EventHandler(this.trackBars_Scroll);
            // 
            // m_trackBarHueMax
            // 
            this.m_trackBarHueMax.Location = new System.Drawing.Point(197, 26);
            this.m_trackBarHueMax.Maximum = 500;
            this.m_trackBarHueMax.Name = "m_trackBarHueMax";
            this.m_trackBarHueMax.Size = new System.Drawing.Size(104, 45);
            this.m_trackBarHueMax.TabIndex = 0;
            this.m_trackBarHueMax.TickStyle = System.Windows.Forms.TickStyle.None;
            this.m_trackBarHueMax.Scroll += new System.EventHandler(this.trackBars_Scroll);
            // 
            // m_labelHueMin
            // 
            this.m_labelHueMin.AutoSize = true;
            this.m_labelHueMin.Location = new System.Drawing.Point(12, 26);
            this.m_labelHueMin.Name = "m_labelHueMin";
            this.m_labelHueMin.Size = new System.Drawing.Size(30, 13);
            this.m_labelHueMin.TabIndex = 1;
            this.m_labelHueMin.Text = "Min :";
            this.m_labelHueMin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // m_labelHueMax
            // 
            this.m_labelHueMax.AutoSize = true;
            this.m_labelHueMax.Location = new System.Drawing.Point(158, 30);
            this.m_labelHueMax.Name = "m_labelHueMax";
            this.m_labelHueMax.Size = new System.Drawing.Size(33, 13);
            this.m_labelHueMax.TabIndex = 1;
            this.m_labelHueMax.Text = "Max :";
            // 
            // m_backgroundWorker
            // 
            this.m_backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.m_backgroundWorker_DoWork);
            // 
            // m_timer
            // 
            this.m_timer.Enabled = true;
            this.m_timer.Tick += new System.EventHandler(this.m_timer_Tick);
            // 
            // m_panelCamera
            // 
            this.m_panelCamera.Location = new System.Drawing.Point(12, 12);
            this.m_panelCamera.Name = "m_panelCamera";
            this.m_panelCamera.Size = new System.Drawing.Size(340, 280);
            this.m_panelCamera.TabIndex = 1;
            // 
            // m_panelHSV
            // 
            this.m_panelHSV.Location = new System.Drawing.Point(358, 12);
            this.m_panelHSV.Name = "m_panelHSV";
            this.m_panelHSV.Size = new System.Drawing.Size(340, 280);
            this.m_panelHSV.TabIndex = 1;
            // 
            // m_panelTreshould
            // 
            this.m_panelTreshould.Location = new System.Drawing.Point(358, 298);
            this.m_panelTreshould.Name = "m_panelTreshould";
            this.m_panelTreshould.Size = new System.Drawing.Size(340, 280);
            this.m_panelTreshould.TabIndex = 2;
            // 
            // m_checkBoxTrackObject
            // 
            this.m_checkBoxTrackObject.AutoSize = true;
            this.m_checkBoxTrackObject.Location = new System.Drawing.Point(6, 252);
            this.m_checkBoxTrackObject.Name = "m_checkBoxTrackObject";
            this.m_checkBoxTrackObject.Size = new System.Drawing.Size(54, 17);
            this.m_checkBoxTrackObject.TabIndex = 3;
            this.m_checkBoxTrackObject.Text = "Track";
            this.m_checkBoxTrackObject.UseVisualStyleBackColor = true;
            // 
            // m_checkBoxUseMorphOps
            // 
            this.m_checkBoxUseMorphOps.AutoSize = true;
            this.m_checkBoxUseMorphOps.Location = new System.Drawing.Point(265, 252);
            this.m_checkBoxUseMorphOps.Name = "m_checkBoxUseMorphOps";
            this.m_checkBoxUseMorphOps.Size = new System.Drawing.Size(56, 17);
            this.m_checkBoxUseMorphOps.TabIndex = 4;
            this.m_checkBoxUseMorphOps.Text = "Morph";
            this.m_checkBoxUseMorphOps.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 586);
            this.Controls.Add(this.m_panelTreshould);
            this.Controls.Add(this.m_panelHSV);
            this.Controls.Add(this.m_panelCamera);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Real Time Color Tracking";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBarValueMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBarValueMax)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBarSaturationMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBarSaturationMax)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBarHueMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_trackBarHueMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar m_trackBarHueMax;
        private System.Windows.Forms.TrackBar m_trackBarHueMin;
        private System.ComponentModel.BackgroundWorker m_backgroundWorker;
        private System.Windows.Forms.Timer m_timer;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar m_trackBarValueMin;
        private System.Windows.Forms.TrackBar m_trackBarValueMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar m_trackBarSaturationMin;
        private System.Windows.Forms.TrackBar m_trackBarSaturationMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label m_labelHueMin;
        private System.Windows.Forms.Label m_labelHueMax;
        private System.Windows.Forms.Panel m_panelCamera;
        private System.Windows.Forms.Panel m_panelHSV;
        private System.Windows.Forms.Panel m_panelTreshould;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox m_checkBoxUseMorphOps;
        private System.Windows.Forms.CheckBox m_checkBoxTrackObject;
    }
}

