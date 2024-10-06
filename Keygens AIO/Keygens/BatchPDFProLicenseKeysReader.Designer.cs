namespace Keygens_AIO.Keygens
{
    partial class BatchPDFProLicenseKeysReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatchPDFProLicenseKeysReader));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.BtnReadKeys = new System.Windows.Forms.Button();
            this.lbKeys = new System.Windows.Forms.ListBox();
            this.lblKeys = new System.Windows.Forms.Label();
            this.BtnCopySelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // BtnReadKeys
            // 
            this.BtnReadKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReadKeys.Location = new System.Drawing.Point(338, 260);
            this.BtnReadKeys.Name = "BtnReadKeys";
            this.BtnReadKeys.Size = new System.Drawing.Size(75, 23);
            this.BtnReadKeys.TabIndex = 1;
            this.BtnReadKeys.Text = "Read Keys";
            this.BtnReadKeys.UseVisualStyleBackColor = true;
            this.BtnReadKeys.Click += new System.EventHandler(this.BtnReadKeys_Click);
            // 
            // lbKeys
            // 
            this.lbKeys.FormattingEnabled = true;
            this.lbKeys.Location = new System.Drawing.Point(12, 42);
            this.lbKeys.Name = "lbKeys";
            this.lbKeys.Size = new System.Drawing.Size(401, 212);
            this.lbKeys.TabIndex = 2;
            this.lbKeys.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbKeys_MouseClick);
            this.lbKeys.SelectedIndexChanged += new System.EventHandler(this.lbKeys_SelectedIndexChanged);
            // 
            // lblKeys
            // 
            this.lblKeys.AutoSize = true;
            this.lblKeys.Location = new System.Drawing.Point(13, 23);
            this.lblKeys.Name = "lblKeys";
            this.lblKeys.Size = new System.Drawing.Size(0, 13);
            this.lblKeys.TabIndex = 3;
            // 
            // BtnCopySelected
            // 
            this.BtnCopySelected.Location = new System.Drawing.Point(13, 260);
            this.BtnCopySelected.Name = "BtnCopySelected";
            this.BtnCopySelected.Size = new System.Drawing.Size(98, 23);
            this.BtnCopySelected.TabIndex = 4;
            this.BtnCopySelected.Text = "Copy Selected";
            this.BtnCopySelected.UseVisualStyleBackColor = true;
            this.BtnCopySelected.Click += new System.EventHandler(this.BtnCopySelected_Click);
            // 
            // BatchPDFProLicenseKeysReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 291);
            this.Controls.Add(this.BtnCopySelected);
            this.Controls.Add(this.lblKeys);
            this.Controls.Add(this.lbKeys);
            this.Controls.Add(this.BtnReadKeys);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BatchPDFProLicenseKeysReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batch PDF Pro License Keys Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button BtnReadKeys;
        private System.Windows.Forms.ListBox lbKeys;
        private System.Windows.Forms.Label lblKeys;
        private System.Windows.Forms.Button BtnCopySelected;
    }
}