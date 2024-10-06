using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keygens_AIO.Keygens
{
    public partial class Goldilogs_1x_LicGen : Form
    {
        public Goldilogs_1x_LicGen()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (LicenseHandler.GenerateLicenseFile((LicenseType)cboLicense.SelectedIndex, (int)txtMaxUsers.Value, txtName.Text, txtEMail.Text))
                MessageBox.Show("License file has been created successfully", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Cannot create license file!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Goldilogs_1x_LicGen_Load(object sender, EventArgs e)
        {
            Text = Application.ProductName;

            cboLicense.Items.AddRange(LicenseHandler.LicenseTypes);

            if (cboLicense.Items.Count > 0)
                cboLicense.SelectedIndex = (int)LicenseType.Professional_edition;

            txtMaxUsers.Minimum = 1;
            txtMaxUsers.Maximum = int.MaxValue;
            txtMaxUsers.Value = 1000;
            txtName.Text = Environment.UserName;
            txtEMail.Text = "some@email.com";

            OnChange(null, null);
        }

        void OnChange(object sender, EventArgs e)
        {
            btnGenerate.Enabled = (cboLicense.SelectedIndex >= 0) &&
                                    (txtMaxUsers.Value > 0) &&
                                    (!string.IsNullOrEmpty(txtName.Text.Trim())) &&
                                    (!string.IsNullOrEmpty(txtEMail.Text.Trim()));
        }
    }
}
