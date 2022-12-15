namespace WindowsFormsApp1.minesense.feature.overlays
{
    partial class watermark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(watermark));
            this.shadowLabel1 = new SkeetUI.shadowLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.shadowLabel2 = new SkeetUI.shadowLabel();
            this.shadowLabel3 = new SkeetUI.shadowLabel();
            this.SuspendLayout();
            // 
            // shadowLabel1
            // 
            this.shadowLabel1.AutoSize = true;
            this.shadowLabel1.BackColor = System.Drawing.Color.Transparent;
            this.shadowLabel1.EnableShadow = false;
            this.shadowLabel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowLabel1.ForeColor = System.Drawing.Color.White;
            this.shadowLabel1.Location = new System.Drawing.Point(15, 16);
            this.shadowLabel1.Name = "shadowLabel1";
            this.shadowLabel1.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel1.ShadowOffset = 1;
            this.shadowLabel1.Size = new System.Drawing.Size(106, 13);
            this.shadowLabel1.TabIndex = 0;
            this.shadowLabel1.Text = "minesense beta |";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // shadowLabel2
            // 
            this.shadowLabel2.AutoSize = true;
            this.shadowLabel2.BackColor = System.Drawing.Color.Transparent;
            this.shadowLabel2.EnableShadow = false;
            this.shadowLabel2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowLabel2.ForeColor = System.Drawing.Color.White;
            this.shadowLabel2.Location = new System.Drawing.Point(120, 16);
            this.shadowLabel2.Name = "shadowLabel2";
            this.shadowLabel2.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel2.ShadowOffset = 1;
            this.shadowLabel2.Size = new System.Drawing.Size(86, 13);
            this.shadowLabel2.TabIndex = 1;
            this.shadowLabel2.Text = "USER_NAME |";
            this.shadowLabel2.Click += new System.EventHandler(this.shadowLabel2_Click);
            // 
            // shadowLabel3
            // 
            this.shadowLabel3.AutoSize = true;
            this.shadowLabel3.BackColor = System.Drawing.Color.Transparent;
            this.shadowLabel3.EnableShadow = false;
            this.shadowLabel3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowLabel3.ForeColor = System.Drawing.Color.White;
            this.shadowLabel3.Location = new System.Drawing.Point(212, 16);
            this.shadowLabel3.Name = "shadowLabel3";
            this.shadowLabel3.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel3.ShadowOffset = 1;
            this.shadowLabel3.Size = new System.Drawing.Size(59, 13);
            this.shadowLabel3.TabIndex = 2;
            this.shadowLabel3.Text = "21:14:20";
            // 
            // watermark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(297, 43);
            this.Controls.Add(this.shadowLabel3);
            this.Controls.Add(this.shadowLabel2);
            this.Controls.Add(this.shadowLabel1);
            this.Name = "watermark";
            this.Text = "m1n3s3n53";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SkeetUI.shadowLabel shadowLabel1;
        private SkeetUI.shadowLabel shadowLabel2;
        private SkeetUI.shadowLabel shadowLabel3;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}