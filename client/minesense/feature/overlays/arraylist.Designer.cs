namespace WindowsFormsApp1.minesense.feature.overlays
{
    partial class arraylist
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
            this.VeloArLst = new SkeetUI.shadowLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AcArLst = new SkeetUI.shadowLabel();
            this.ReachArLst = new SkeetUI.shadowLabel();
            this.FakeLagArLst = new SkeetUI.shadowLabel();
            this.ReachAmt = new SkeetUI.shadowLabel();
            this.CpsAmt = new SkeetUI.shadowLabel();
            this.VelocityAmt = new SkeetUI.shadowLabel();
            this.LagAmt = new SkeetUI.shadowLabel();
            this.veloPanel = new System.Windows.Forms.Panel();
            this.fakeLagPanel = new System.Windows.Forms.Panel();
            this.clickerPanel = new System.Windows.Forms.Panel();
            this.reachPanel = new System.Windows.Forms.Panel();
            this.ModuleHandler = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // VeloArLst
            // 
            this.VeloArLst.AutoSize = true;
            this.VeloArLst.EnableShadow = false;
            this.VeloArLst.Font = new System.Drawing.Font("Panton-Trial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VeloArLst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(197)))), ((int)(((byte)(39)))));
            this.VeloArLst.Location = new System.Drawing.Point(8, 8);
            this.VeloArLst.Name = "VeloArLst";
            this.VeloArLst.ShadowColor = System.Drawing.Color.LightGray;
            this.VeloArLst.ShadowOffset = 1;
            this.VeloArLst.Size = new System.Drawing.Size(90, 26);
            this.VeloArLst.TabIndex = 2;
            this.VeloArLst.Text = "Velocity";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // AcArLst
            // 
            this.AcArLst.AutoSize = true;
            this.AcArLst.EnableShadow = false;
            this.AcArLst.Font = new System.Drawing.Font("Panton-Trial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcArLst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(197)))), ((int)(((byte)(39)))));
            this.AcArLst.Location = new System.Drawing.Point(9, 63);
            this.AcArLst.Name = "AcArLst";
            this.AcArLst.ShadowColor = System.Drawing.Color.LightGray;
            this.AcArLst.ShadowOffset = 1;
            this.AcArLst.Size = new System.Drawing.Size(78, 26);
            this.AcArLst.TabIndex = 4;
            this.AcArLst.Text = "Clicker";
            // 
            // ReachArLst
            // 
            this.ReachArLst.AutoSize = true;
            this.ReachArLst.EnableShadow = false;
            this.ReachArLst.Font = new System.Drawing.Font("Panton-Trial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReachArLst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(197)))), ((int)(((byte)(39)))));
            this.ReachArLst.Location = new System.Drawing.Point(9, 89);
            this.ReachArLst.Name = "ReachArLst";
            this.ReachArLst.ShadowColor = System.Drawing.Color.LightGray;
            this.ReachArLst.ShadowOffset = 1;
            this.ReachArLst.Size = new System.Drawing.Size(72, 26);
            this.ReachArLst.TabIndex = 5;
            this.ReachArLst.Text = "Reach";
            this.ReachArLst.Click += new System.EventHandler(this.shadowLabel2_Click);
            // 
            // FakeLagArLst
            // 
            this.FakeLagArLst.AutoSize = true;
            this.FakeLagArLst.EnableShadow = false;
            this.FakeLagArLst.Font = new System.Drawing.Font("Panton-Trial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakeLagArLst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(197)))), ((int)(((byte)(39)))));
            this.FakeLagArLst.Location = new System.Drawing.Point(9, 35);
            this.FakeLagArLst.Name = "FakeLagArLst";
            this.FakeLagArLst.ShadowColor = System.Drawing.Color.LightGray;
            this.FakeLagArLst.ShadowOffset = 1;
            this.FakeLagArLst.Size = new System.Drawing.Size(91, 26);
            this.FakeLagArLst.TabIndex = 6;
            this.FakeLagArLst.Text = "FakeLag";
            // 
            // ReachAmt
            // 
            this.ReachAmt.AutoSize = true;
            this.ReachAmt.EnableShadow = false;
            this.ReachAmt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReachAmt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.ReachAmt.Location = new System.Drawing.Point(79, 86);
            this.ReachAmt.Name = "ReachAmt";
            this.ReachAmt.ShadowColor = System.Drawing.Color.LightGray;
            this.ReachAmt.ShadowOffset = 1;
            this.ReachAmt.Size = new System.Drawing.Size(40, 30);
            this.ReachAmt.TabIndex = 7;
            this.ReachAmt.Text = "3.0";
            // 
            // CpsAmt
            // 
            this.CpsAmt.AutoSize = true;
            this.CpsAmt.EnableShadow = false;
            this.CpsAmt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpsAmt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.CpsAmt.Location = new System.Drawing.Point(84, 60);
            this.CpsAmt.Name = "CpsAmt";
            this.CpsAmt.ShadowColor = System.Drawing.Color.LightGray;
            this.CpsAmt.ShadowOffset = 1;
            this.CpsAmt.Size = new System.Drawing.Size(51, 30);
            this.CpsAmt.TabIndex = 8;
            this.CpsAmt.Text = "13.0";
            // 
            // VelocityAmt
            // 
            this.VelocityAmt.AutoSize = true;
            this.VelocityAmt.EnableShadow = false;
            this.VelocityAmt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VelocityAmt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.VelocityAmt.Location = new System.Drawing.Point(96, 5);
            this.VelocityAmt.Name = "VelocityAmt";
            this.VelocityAmt.ShadowColor = System.Drawing.Color.LightGray;
            this.VelocityAmt.ShadowOffset = 1;
            this.VelocityAmt.Size = new System.Drawing.Size(107, 30);
            this.VelocityAmt.TabIndex = 9;
            this.VelocityAmt.Text = "H100V100";
            // 
            // LagAmt
            // 
            this.LagAmt.AutoSize = true;
            this.LagAmt.EnableShadow = false;
            this.LagAmt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LagAmt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.LagAmt.Location = new System.Drawing.Point(98, 32);
            this.LagAmt.Name = "LagAmt";
            this.LagAmt.ShadowColor = System.Drawing.Color.LightGray;
            this.LagAmt.ShadowOffset = 1;
            this.LagAmt.Size = new System.Drawing.Size(73, 30);
            this.LagAmt.TabIndex = 10;
            this.LagAmt.Text = "600ms";
            // 
            // veloPanel
            // 
            this.veloPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(197)))), ((int)(((byte)(39)))));
            this.veloPanel.Location = new System.Drawing.Point(0, 6);
            this.veloPanel.Name = "veloPanel";
            this.veloPanel.Size = new System.Drawing.Size(5, 28);
            this.veloPanel.TabIndex = 11;
            // 
            // fakeLagPanel
            // 
            this.fakeLagPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(197)))), ((int)(((byte)(39)))));
            this.fakeLagPanel.Location = new System.Drawing.Point(0, 34);
            this.fakeLagPanel.Name = "fakeLagPanel";
            this.fakeLagPanel.Size = new System.Drawing.Size(5, 28);
            this.fakeLagPanel.TabIndex = 12;
            // 
            // clickerPanel
            // 
            this.clickerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(197)))), ((int)(((byte)(39)))));
            this.clickerPanel.Location = new System.Drawing.Point(0, 62);
            this.clickerPanel.Name = "clickerPanel";
            this.clickerPanel.Size = new System.Drawing.Size(5, 28);
            this.clickerPanel.TabIndex = 13;
            // 
            // reachPanel
            // 
            this.reachPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(197)))), ((int)(((byte)(39)))));
            this.reachPanel.Location = new System.Drawing.Point(0, 90);
            this.reachPanel.Name = "reachPanel";
            this.reachPanel.Size = new System.Drawing.Size(5, 28);
            this.reachPanel.TabIndex = 14;
            // 
            // ModuleHandler
            // 
            this.ModuleHandler.Tick += new System.EventHandler(this.ModuleHandler_Tick);
            // 
            // arraylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(225, 132);
            this.Controls.Add(this.reachPanel);
            this.Controls.Add(this.clickerPanel);
            this.Controls.Add(this.fakeLagPanel);
            this.Controls.Add(this.veloPanel);
            this.Controls.Add(this.LagAmt);
            this.Controls.Add(this.VelocityAmt);
            this.Controls.Add(this.CpsAmt);
            this.Controls.Add(this.ReachAmt);
            this.Controls.Add(this.FakeLagArLst);
            this.Controls.Add(this.ReachArLst);
            this.Controls.Add(this.AcArLst);
            this.Controls.Add(this.VeloArLst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "arraylist";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.arraylist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public SkeetUI.shadowLabel VeloArLst;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public SkeetUI.shadowLabel AcArLst;
        public SkeetUI.shadowLabel ReachArLst;
        public SkeetUI.shadowLabel FakeLagArLst;
        public SkeetUI.shadowLabel ReachAmt;
        public SkeetUI.shadowLabel CpsAmt;
        public SkeetUI.shadowLabel VelocityAmt;
        public SkeetUI.shadowLabel LagAmt;
        private System.Windows.Forms.Timer ModuleHandler;
        public System.Windows.Forms.Panel veloPanel;
        public System.Windows.Forms.Panel fakeLagPanel;
        public System.Windows.Forms.Panel clickerPanel;
        public System.Windows.Forms.Panel reachPanel;
    }
}