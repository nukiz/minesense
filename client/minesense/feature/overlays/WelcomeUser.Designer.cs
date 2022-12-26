namespace WindowsFormsApp1.minesense.feature.overlays
{
    partial class WelcomeUser
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
            this.shadowLabel2 = new SkeetUI.shadowLabel();
            this.shadowLabel1 = new SkeetUI.shadowLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // shadowLabel2
            // 
            this.shadowLabel2.AutoSize = true;
            this.shadowLabel2.EnableShadow = false;
            this.shadowLabel2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(197)))), ((int)(((byte)(39)))));
            this.shadowLabel2.Location = new System.Drawing.Point(89, 4);
            this.shadowLabel2.Name = "shadowLabel2";
            this.shadowLabel2.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel2.ShadowOffset = 1;
            this.shadowLabel2.Size = new System.Drawing.Size(70, 16);
            this.shadowLabel2.TabIndex = 3;
            this.shadowLabel2.Text = "Welcome ";
            // 
            // shadowLabel1
            // 
            this.shadowLabel1.AutoSize = true;
            this.shadowLabel1.EnableShadow = false;
            this.shadowLabel1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shadowLabel1.ForeColor = System.Drawing.Color.White;
            this.shadowLabel1.Location = new System.Drawing.Point(157, 4);
            this.shadowLabel1.Name = "shadowLabel1";
            this.shadowLabel1.ShadowColor = System.Drawing.Color.LightGray;
            this.shadowLabel1.ShadowOffset = 1;
            this.shadowLabel1.Size = new System.Drawing.Size(83, 16);
            this.shadowLabel1.TabIndex = 4;
            this.shadowLabel1.Text = "USERNAME ";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // WelcomeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(349, 26);
            this.Controls.Add(this.shadowLabel1);
            this.Controls.Add(this.shadowLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WelcomeUser";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.WelcomeUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public SkeetUI.shadowLabel shadowLabel2;
        public SkeetUI.shadowLabel shadowLabel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}