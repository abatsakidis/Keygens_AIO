namespace Keygens_AIO.Keygens
{
    partial class Goldilogs_1x_LicGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Goldilogs_1x_LicGen));
            this.lblLicense = new System.Windows.Forms.Label();
            this.lblMaxUsers = new System.Windows.Forms.Label();
            this.lblEMail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMaxUsers = new System.Windows.Forms.NumericUpDown();
            this.cboLicense = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.picBanner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLicense
            // 
            this.lblLicense.Location = new System.Drawing.Point(7, 84);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(48, 20);
            this.lblLicense.TabIndex = 10;
            this.lblLicense.Text = "License:";
            this.lblLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaxUsers
            // 
            this.lblMaxUsers.Location = new System.Drawing.Point(235, 84);
            this.lblMaxUsers.Name = "lblMaxUsers";
            this.lblMaxUsers.Size = new System.Drawing.Size(60, 20);
            this.lblMaxUsers.TabIndex = 13;
            this.lblMaxUsers.Text = "Max Users:";
            this.lblMaxUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEMail
            // 
            this.lblEMail.Location = new System.Drawing.Point(7, 144);
            this.lblEMail.Name = "lblEMail";
            this.lblEMail.Size = new System.Drawing.Size(48, 20);
            this.lblEMail.TabIndex = 17;
            this.lblEMail.Text = "EMail:";
            this.lblEMail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(7, 114);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 20);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(55, 144);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(312, 20);
            this.txtEMail.TabIndex = 18;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(55, 114);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(312, 20);
            this.txtName.TabIndex = 16;
            // 
            // txtMaxUsers
            // 
            this.txtMaxUsers.Location = new System.Drawing.Point(295, 84);
            this.txtMaxUsers.Name = "txtMaxUsers";
            this.txtMaxUsers.Size = new System.Drawing.Size(72, 20);
            this.txtMaxUsers.TabIndex = 14;
            this.txtMaxUsers.ValueChanged += new System.EventHandler(this.OnChange);
            // 
            // cboLicense
            // 
            this.cboLicense.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLicense.FormattingEnabled = true;
            this.cboLicense.Location = new System.Drawing.Point(55, 84);
            this.cboLicense.Name = "cboLicense";
            this.cboLicense.Size = new System.Drawing.Size(174, 21);
            this.cboLicense.TabIndex = 12;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(247, 177);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(120, 24);
            this.btnGenerate.TabIndex = 19;
            this.btnGenerate.Text = "Generate License File";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // picBanner
            // 
            this.picBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBanner.Image = ((System.Drawing.Image)(resources.GetObject("picBanner.Image")));
            this.picBanner.Location = new System.Drawing.Point(0, 0);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(379, 78);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBanner.TabIndex = 11;
            this.picBanner.TabStop = false;
            // 
            // Goldilogs_1x_LicGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 213);
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.lblMaxUsers);
            this.Controls.Add(this.lblEMail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtEMail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMaxUsers);
            this.Controls.Add(this.cboLicense);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.picBanner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Goldilogs_1x_LicGen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goldilogs 1.x LicGen";
            this.Load += new System.EventHandler(this.Goldilogs_1x_LicGen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.Label lblMaxUsers;
        private System.Windows.Forms.Label lblEMail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown txtMaxUsers;
        private System.Windows.Forms.ComboBox cboLicense;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.PictureBox picBanner;
    }
}