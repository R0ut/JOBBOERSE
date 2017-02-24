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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnGetContact = new System.Windows.Forms.Button();
            this.picInternetStatus = new System.Windows.Forms.PictureBox();
            this.webDownload = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowData = new System.Windows.Forms.Button();
            this.progBarDwonload = new System.Windows.Forms.ProgressBar();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picInternetStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetContact
            // 
            this.btnGetContact.Enabled = false;
            this.btnGetContact.Location = new System.Drawing.Point(15, 30);
            this.btnGetContact.Name = "btnGetContact";
            this.btnGetContact.Size = new System.Drawing.Size(75, 41);
            this.btnGetContact.TabIndex = 0;
            this.btnGetContact.Text = "Get contact info";
            this.btnGetContact.UseVisualStyleBackColor = true;
            this.btnGetContact.Click += new System.EventHandler(this.button1_Click);
            // 
            // picInternetStatus
            // 
            this.picInternetStatus.Location = new System.Drawing.Point(31, 365);
            this.picInternetStatus.Name = "picInternetStatus";
            this.picInternetStatus.Size = new System.Drawing.Size(41, 41);
            this.picInternetStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInternetStatus.TabIndex = 1;
            this.picInternetStatus.TabStop = false;
            // 
            // webDownload
            // 
            this.webDownload.Location = new System.Drawing.Point(108, 2);
            this.webDownload.MinimumSize = new System.Drawing.Size(20, 20);
            this.webDownload.Name = "webDownload";
            this.webDownload.Size = new System.Drawing.Size(526, 430);
            this.webDownload.TabIndex = 3;
            this.webDownload.Url = new System.Uri("http://jobboerse.arbeitsagentur.de/vamJB/startseite.html?kgr=as&aa=1&m=1&vorschla" +
        "gsfunktionaktiv=true", System.UriKind.Absolute);
            this.webDownload.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webDownload_DocumentCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Internet Status";
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(15, 77);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(75, 41);
            this.btnShowData.TabIndex = 5;
            this.btnShowData.Text = "Show Data";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // progBarDwonload
            // 
            this.progBarDwonload.Location = new System.Drawing.Point(9, 259);
            this.progBarDwonload.Maximum = 20;
            this.progBarDwonload.Name = "progBarDwonload";
            this.progBarDwonload.Size = new System.Drawing.Size(90, 23);
            this.progBarDwonload.Step = 1;
            this.progBarDwonload.TabIndex = 7;
            this.progBarDwonload.Visible = false;
            // 
            // picLoading
            // 
            this.picLoading.Image = global::JOBBOERSE.Properties.Resources.loading;
            this.picLoading.Location = new System.Drawing.Point(15, 178);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(75, 75);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoading.TabIndex = 8;
            this.picLoading.TabStop = false;
            this.picLoading.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(15, 124);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 41);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 431);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.progBarDwonload);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webDownload);
            this.Controls.Add(this.picInternetStatus);
            this.Controls.Add(this.btnGetContact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "JOBBOERSE";
            ((System.ComponentModel.ISupportInitialize)(this.picInternetStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetContact;
        private System.Windows.Forms.PictureBox picInternetStatus;
        private System.Windows.Forms.WebBrowser webDownload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.ProgressBar progBarDwonload;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.Button btnExit;
    }
}

