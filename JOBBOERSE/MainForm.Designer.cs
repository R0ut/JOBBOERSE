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
            this.btnGetContact = new System.Windows.Forms.Button();
            this.picInternetStatus = new System.Windows.Forms.PictureBox();
            this.webDownload = new System.Windows.Forms.WebBrowser();
            this.btnViewWeb = new System.Windows.Forms.Button();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.addresBookDataSet = new JOBBOERSE.AddresBookDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.picInternetStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addresBookDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetContact
            // 
            this.btnGetContact.Location = new System.Drawing.Point(50, 37);
            this.btnGetContact.Name = "btnGetContact";
            this.btnGetContact.Size = new System.Drawing.Size(75, 41);
            this.btnGetContact.TabIndex = 0;
            this.btnGetContact.Text = "Get contact info";
            this.btnGetContact.UseVisualStyleBackColor = true;
            this.btnGetContact.Click += new System.EventHandler(this.button1_Click);
            // 
            // picInternetStatus
            // 
            this.picInternetStatus.Location = new System.Drawing.Point(66, 96);
            this.picInternetStatus.Name = "picInternetStatus";
            this.picInternetStatus.Size = new System.Drawing.Size(41, 41);
            this.picInternetStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInternetStatus.TabIndex = 1;
            this.picInternetStatus.TabStop = false;
            // 
            // webDownload
            // 
            this.webDownload.Location = new System.Drawing.Point(234, 12);
            this.webDownload.MinimumSize = new System.Drawing.Size(20, 20);
            this.webDownload.Name = "webDownload";
            this.webDownload.Size = new System.Drawing.Size(525, 487);
            this.webDownload.TabIndex = 3;
            this.webDownload.Url = new System.Uri("http://jobboerse.arbeitsagentur.de/vamJB/startseite.html?kgr=as&aa=1&m=1&vorschla" +
        "gsfunktionaktiv=true", System.UriKind.Absolute);
            // 
            // btnViewWeb
            // 
            this.btnViewWeb.Location = new System.Drawing.Point(50, 157);
            this.btnViewWeb.Name = "btnViewWeb";
            this.btnViewWeb.Size = new System.Drawing.Size(75, 42);
            this.btnViewWeb.TabIndex = 4;
            this.btnViewWeb.Text = "Web Side view";
            this.btnViewWeb.UseVisualStyleBackColor = true;
            this.btnViewWeb.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(4, 262);
            this.txtContact.Multiline = true;
            this.txtContact.Name = "txtContact";
            this.txtContact.ReadOnly = true;
            this.txtContact.Size = new System.Drawing.Size(224, 147);
            this.txtContact.TabIndex = 5;
            // 
            // addresBookDataSet
            // 
            this.addresBookDataSet.DataSetName = "AddresBookDataSet";
            this.addresBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 536);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.btnViewWeb);
            this.Controls.Add(this.webDownload);
            this.Controls.Add(this.picInternetStatus);
            this.Controls.Add(this.btnGetContact);
            this.Name = "MainForm";
            this.Text = "JOBBOERSE";
            ((System.ComponentModel.ISupportInitialize)(this.picInternetStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addresBookDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetContact;
        private System.Windows.Forms.PictureBox picInternetStatus;
        private System.Windows.Forms.WebBrowser webDownload;
        private System.Windows.Forms.Button btnViewWeb;
        private System.Windows.Forms.TextBox txtContact;
        private AddresBookDataSet addresBookDataSet;
    }
}

