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
            this.AcArLst = new SkeetUI.shadowLabel();
            this.ReachArLst = new SkeetUI.shadowLabel();
            this.VeloArLst = new SkeetUI.shadowLabel();
            this.FakeLagArLst = new SkeetUI.shadowLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // AcArLst
            // 
            this.AcArLst.AutoSize = true;
            this.AcArLst.EnableShadow = false;
            this.AcArLst.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcArLst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(197)))), ((int)(((byte)(39)))));
            this.AcArLst.Location = new System.Drawing.Point(9, 69);
            this.AcArLst.Name = "AcArLst";
            this.AcArLst.ShadowColor = System.Drawing.Color.LightGray;
            this.AcArLst.ShadowOffset = 1;
            this.AcArLst.Size = new System.Drawing.Size(55, 32);
            this.AcArLst.TabIndex = 0;
            this.AcArLst.Text = "AC";
            // 
            // ReachArLst
            // 
            this.ReachArLst.AutoSize = true;
            this.ReachArLst.EnableShadow = false;
            this.ReachArLst.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReachArLst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(197)))), ((int)(((byte)(39)))));
            this.ReachArLst.Location = new System.Drawing.Point(9, 39);
            this.ReachArLst.Name = "ReachArLst";
            this.ReachArLst.ShadowColor = System.Drawing.Color.LightGray;
            this.ReachArLst.ShadowOffset = 1;
            this.ReachArLst.Size = new System.Drawing.Size(78, 32);
            this.ReachArLst.TabIndex = 1;
            this.ReachArLst.Text = "RCH";
            // 
            // VeloArLst
            // 
            this.VeloArLst.AutoSize = true;
            this.VeloArLst.EnableShadow = false;
            this.VeloArLst.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VeloArLst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(197)))), ((int)(((byte)(39)))));
            this.VeloArLst.Location = new System.Drawing.Point(9, 9);
            this.VeloArLst.Name = "VeloArLst";
            this.VeloArLst.ShadowColor = System.Drawing.Color.LightGray;
            this.VeloArLst.ShadowOffset = 1;
            this.VeloArLst.Size = new System.Drawing.Size(70, 32);
            this.VeloArLst.TabIndex = 2;
            this.VeloArLst.Text = "VEL";
            // 
            // FakeLagArLst
            // 
            this.FakeLagArLst.AutoSize = true;
            this.FakeLagArLst.EnableShadow = false;
            this.FakeLagArLst.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FakeLagArLst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(197)))), ((int)(((byte)(39)))));
            this.FakeLagArLst.Location = new System.Drawing.Point(9, 101);
            this.FakeLagArLst.Name = "FakeLagArLst";
            this.FakeLagArLst.ShadowColor = System.Drawing.Color.LightGray;
            this.FakeLagArLst.ShadowOffset = 1;
            this.FakeLagArLst.Size = new System.Drawing.Size(92, 32);
            this.FakeLagArLst.TabIndex = 3;
            this.FakeLagArLst.Text = "FAKE";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // arraylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(113, 143);
            this.Controls.Add(this.FakeLagArLst);
            this.Controls.Add(this.VeloArLst);
            this.Controls.Add(this.ReachArLst);
            this.Controls.Add(this.AcArLst);
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

        public SkeetUI.shadowLabel AcArLst;
        public SkeetUI.shadowLabel ReachArLst;
        public SkeetUI.shadowLabel VeloArLst;
        public SkeetUI.shadowLabel FakeLagArLst;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}