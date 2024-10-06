using System;
using System.Windows.Forms;

namespace Keygens_AIO.Keygens
{
    public partial class File_Viewer_Plus_3x_LicGen : Form
    {
        private const string HostsFileEntry = "sharpened.com";

        public File_Viewer_Plus_3x_LicGen()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (License_File_Viewer.GenerateLicenseFile())
                MessageBox.Show("License file has been created successfully", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Cannot create license file!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnPatch_Click(object sender, EventArgs e)
        {
            if (HostFile.PatchHostsFile(HostsFileEntry))
            {
                if (HostFile.IsHostsFilePatched(HostsFileEntry))
                {
                    btnPatch.Enabled = false;
                    MessageBox.Show("Hosts file has been patched successfully", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MessageBox.Show("Cannot patch hosts file!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void File_Viewer_Plus_3x_LicGen_Load(object sender, EventArgs e)
        {
            Text = Application.ProductName;
            btnPatch.Enabled = !HostFile.IsHostsFilePatched(HostsFileEntry);
        }
    }
}
