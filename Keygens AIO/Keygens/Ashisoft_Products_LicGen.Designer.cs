namespace Keygens_AIO.Keygens
{
    partial class Ashisoft_Products_LicGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ashisoft_Products_LicGen));
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.btnGenerateLicFile = new System.Windows.Forms.Button();
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // cboProduct
            // 
            this.cboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(52, 79);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(186, 21);
            this.cboProduct.TabIndex = 11;
            // 
            // lblProduct
            // 
            this.lblProduct.Location = new System.Drawing.Point(4, 79);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(48, 18);
            this.lblProduct.TabIndex = 9;
            this.lblProduct.Text = "&Product:";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGenerateLicFile
            // 
            this.btnGenerateLicFile.Location = new System.Drawing.Point(142, 117);
            this.btnGenerateLicFile.Name = "btnGenerateLicFile";
            this.btnGenerateLicFile.Size = new System.Drawing.Size(96, 23);
            this.btnGenerateLicFile.TabIndex = 12;
            this.btnGenerateLicFile.Text = "&Generate Lic File";
            this.btnGenerateLicFile.UseVisualStyleBackColor = true;
            this.btnGenerateLicFile.Click += new System.EventHandler(this.btnGenerateLicFile_Click);
            // 
            // picBanner
            // 
            this.picBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBanner.Image = ((System.Drawing.Image)(resources.GetObject("picBanner.Image")));
            this.picBanner.Location = new System.Drawing.Point(0, 0);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(259, 64);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBanner.TabIndex = 10;
            this.picBanner.TabStop = false;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Title = "Save License File As";
            // 
            // Ashisoft_Products_LicGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 162);
            this.Controls.Add(this.cboProduct);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.btnGenerateLicFile);
            this.Controls.Add(this.picBanner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ashisoft_Products_LicGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ashisoft Products LicGen";
            this.Load += new System.EventHandler(this.Ashisoft_Products_LicGen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Button btnGenerateLicFile;
        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}