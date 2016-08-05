namespace comp123_s2016_assignment6
{
    partial class SplashScreen
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
            this.MasterTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LoadingLabel = new System.Windows.Forms.Label();
            this.SplashScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.SplashArtPictureBox = new System.Windows.Forms.PictureBox();
            this.MasterTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplashArtPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MasterTableLayoutPanel
            // 
            this.MasterTableLayoutPanel.ColumnCount = 1;
            this.MasterTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MasterTableLayoutPanel.Controls.Add(this.TitleLabel, 0, 0);
            this.MasterTableLayoutPanel.Controls.Add(this.LoadingLabel, 0, 2);
            this.MasterTableLayoutPanel.Controls.Add(this.SplashArtPictureBox, 0, 1);
            this.MasterTableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.MasterTableLayoutPanel.Name = "MasterTableLayoutPanel";
            this.MasterTableLayoutPanel.RowCount = 3;
            this.MasterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.94505F));
            this.MasterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.20574F));
            this.MasterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.96172F));
            this.MasterTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MasterTableLayoutPanel.Size = new System.Drawing.Size(280, 418);
            this.MasterTableLayoutPanel.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(3, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(274, 62);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "BMI Calculator";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.AutoSize = true;
            this.LoadingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadingLabel.Location = new System.Drawing.Point(3, 367);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(274, 51);
            this.LoadingLabel.TabIndex = 1;
            this.LoadingLabel.Text = "Loading...";
            this.LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashScreenTimer
            // 
            this.SplashScreenTimer.Enabled = true;
            this.SplashScreenTimer.Interval = 3000;
            this.SplashScreenTimer.Tick += new System.EventHandler(this.SplashScreenTimer_Tick);
            // 
            // SplashArtPictureBox
            // 
            this.SplashArtPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SplashArtPictureBox.Image = global::comp123_s2016_assignment6.Properties.Resources.Capture;
            this.SplashArtPictureBox.Location = new System.Drawing.Point(48, 122);
            this.SplashArtPictureBox.Name = "SplashArtPictureBox";
            this.SplashArtPictureBox.Size = new System.Drawing.Size(184, 185);
            this.SplashArtPictureBox.TabIndex = 2;
            this.SplashArtPictureBox.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.ControlBox = false;
            this.Controls.Add(this.MasterTableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.MasterTableLayoutPanel.ResumeLayout(false);
            this.MasterTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplashArtPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MasterTableLayoutPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label LoadingLabel;
        private System.Windows.Forms.Timer SplashScreenTimer;
        private System.Windows.Forms.PictureBox SplashArtPictureBox;
    }
}