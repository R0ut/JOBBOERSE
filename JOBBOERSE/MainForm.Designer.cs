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
            this.addresBookDataSet = new JOBBOERSE.AddresBookDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picInternetStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addresBookDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetContact
            // 
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
            // 
            // addresBookDataSet
            // 
            this.addresBookDataSet.DataSetName = "AddresBookDataSet";
            this.addresBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnShowData.Location = new System.Drawing.Point(13, 78);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(75, 41);
            this.btnShowData.TabIndex = 5;
            this.btnShowData.Text = "Show Data";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 431);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webDownload);
            this.Controls.Add(this.picInternetStatus);
            this.Controls.Add(this.btnGetContact);
            this.MaximizeBox = false;
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
        private AddresBookDataSet addresBookDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowData;
    }
}

