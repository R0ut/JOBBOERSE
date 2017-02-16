namespace JOBBOERSE
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
            this.button1 = new System.Windows.Forms.Button();
            this.picInternetStatus = new System.Windows.Forms.PictureBox();
            this.webDownload = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.picInternetStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picInternetStatus
            // 
            this.picInternetStatus.Image = global::JOBBOERSE.Properties.Resources.unknown;
            this.picInternetStatus.Location = new System.Drawing.Point(12, 92);
            this.picInternetStatus.Name = "picInternetStatus";
            this.picInternetStatus.Size = new System.Drawing.Size(41, 41);
            this.picInternetStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInternetStatus.TabIndex = 1;
            this.picInternetStatus.TabStop = false;
            // 
            // webDownload
            // 
            this.webDownload.Location = new System.Drawing.Point(139, 12);
            this.webDownload.MinimumSize = new System.Drawing.Size(20, 20);
            this.webDownload.Name = "webDownload";
            this.webDownload.Size = new System.Drawing.Size(484, 487);
            this.webDownload.TabIndex = 3;
            this.webDownload.Url = new System.Uri("http://jobboerse.arbeitsagentur.de/vamJB/startseite.html?kgr=as&aa=1&m=1&vorschla" +
        "gsfunktionaktiv=true", System.UriKind.Absolute);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 536);
            this.Controls.Add(this.webDownload);
            this.Controls.Add(this.picInternetStatus);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "JOBBOERSE";
            ((System.ComponentModel.ISupportInitialize)(this.picInternetStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picInternetStatus;
        private System.Windows.Forms.WebBrowser webDownload;
    }
}

