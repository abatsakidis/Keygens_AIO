namespace Keygens_AIO.Keygens
{
    partial class Data_Loader_Activator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data_Loader_Activator));
            this.gboDBType = new System.Windows.Forms.GroupBox();
            this.cboTargetDB = new System.Windows.Forms.ComboBox();
            this.lblTargetDB = new System.Windows.Forms.Label();
            this.cboSourceDB = new System.Windows.Forms.ComboBox();
            this.lblSourceDB = new System.Windows.Forms.Label();
            this.btnActivate = new System.Windows.Forms.Button();
            this.cboEdition = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.gboDBType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // gboDBType
            // 
            this.gboDBType.Controls.Add(this.cboTargetDB);
            this.gboDBType.Controls.Add(this.lblTargetDB);
            this.gboDBType.Controls.Add(this.cboSourceDB);
            this.gboDBType.Controls.Add(this.lblSourceDB);
            this.gboDBType.Location = new System.Drawing.Point(19, 110);
            this.gboDBType.Name = "gboDBType";
            this.gboDBType.Size = new System.Drawing.Size(210, 72);
            this.gboDBType.TabIndex = 3;
            this.gboDBType.TabStop = false;
            this.gboDBType.Text = "Database Types (DataLoader Edition)";
            // 
            // cboTargetDB
            // 
            this.cboTargetDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTargetDB.FormattingEnabled = true;
            this.cboTargetDB.Location = new System.Drawing.Point(54, 42);
            this.cboTargetDB.Name = "cboTargetDB";
            this.cboTargetDB.Size = new System.Drawing.Size(150, 21);
            this.cboTargetDB.TabIndex = 3;
            this.cboTargetDB.SelectedIndexChanged += new System.EventHandler(this.DBSelectedIndexChanged);
            // 
            // lblTargetDB
            // 
            this.lblTargetDB.Location = new System.Drawing.Point(6, 42);
            this.lblTargetDB.Name = "lblTargetDB";
            this.lblTargetDB.Size = new System.Drawing.Size(48, 20);
            this.lblTargetDB.TabIndex = 2;
            this.lblTargetDB.Text = "Target:";
            this.lblTargetDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboSourceDB
            // 
            this.cboSourceDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSourceDB.FormattingEnabled = true;
            this.cboSourceDB.Location = new System.Drawing.Point(54, 18);
            this.cboSourceDB.Name = "cboSourceDB";
            this.cboSourceDB.Size = new System.Drawing.Size(150, 21);
            this.cboSourceDB.TabIndex = 1;
            this.cboSourceDB.SelectedIndexChanged += new System.EventHandler(this.DBSelectedIndexChanged);
            // 
            // lblSourceDB
            // 
            this.lblSourceDB.Location = new System.Drawing.Point(6, 18);
            this.lblSourceDB.Name = "lblSourceDB";
            this.lblSourceDB.Size = new System.Drawing.Size(48, 20);
            this.lblSourceDB.TabIndex = 0;
            this.lblSourceDB.Text = "Source:";
            this.lblSourceDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(157, 194);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(72, 23);
            this.btnActivate.TabIndex = 7;
            this.btnActivate.Text = "Activate";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // cboEdition
            // 
            this.cboEdition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEdition.FormattingEnabled = true;
            this.cboEdition.Location = new System.Drawing.Point(73, 80);
            this.cboEdition.Name = "cboEdition";
            this.cboEdition.Size = new System.Drawing.Size(156, 21);
            this.cboEdition.TabIndex = 6;
            this.cboEdition.SelectedIndexChanged += new System.EventHandler(this.cboEdition_SelectedIndexChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.Location = new System.Drawing.Point(19, 80);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(54, 20);
            this.lblProduct.TabIndex = 4;
            this.lblProduct.Text = "Edition:";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picBanner
            // 
            this.picBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBanner.Image = ((System.Drawing.Image)(resources.GetObject("picBanner.Image")));
            this.picBanner.Location = new System.Drawing.Point(0, 0);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(241, 65);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBanner.TabIndex = 5;
            this.picBanner.TabStop = false;
            // 
            // Data_Loader_Activator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 229);
            this.Controls.Add(this.gboDBType);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.cboEdition);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.picBanner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Data_Loader_Activator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Loader Activator";
            this.Load += new System.EventHandler(this.Data_Loader_Activator_Load);
            this.gboDBType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboDBType;
        private System.Windows.Forms.ComboBox cboTargetDB;
        private System.Windows.Forms.Label lblTargetDB;
        private System.Windows.Forms.ComboBox cboSourceDB;
        private System.Windows.Forms.Label lblSourceDB;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.ComboBox cboEdition;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}