namespace JOBBOERSE
{
    partial class DataShow
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
            this.addresBookDataSet = new JOBBOERSE.AddresBookDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.addresBookDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // addresBookDataSet
            // 
            this.addresBookDataSet.DataSetName = "AddresBookDataSet";
            this.addresBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 332);
            this.Name = "DataShow";
            this.Text = "DataShow";
            
            ((System.ComponentModel.ISupportInitialize)(this.addresBookDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AddresBookDataSet addresBookDataSet;
    }
}