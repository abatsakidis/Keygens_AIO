using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keygens_AIO.Keygens
{
    public partial class BatchPDFProLicenseKeysReader : Form
    {
        public BatchPDFProLicenseKeysReader()
        {
            InitializeComponent();
        }

        private const string TargetFileName = "Main.exe";

        private string GetTargetFile()
        {
            string fileName = Path.Combine(Environment.CurrentDirectory, TargetFileName);

            if (!File.Exists(fileName))
            {
                openFileDialog.Filter = TargetFileName + "|" + TargetFileName;
                fileName = openFileDialog.ShowDialog() != DialogResult.Cancel ? openFileDialog.FileName : string.Empty;
            }

            return fileName;
        }

        private string[] ReadLicenseKeys(string fileName)
        {
            string[] keys = null;

            try
            {
                var assembly = Assembly.LoadFrom(fileName);

                if (assembly != null)
                {
                    var type = assembly.GetType("BatchPDFPro.Licensing.LicenseKeys");

                    if (type != null)
                    {
                        var field = type.GetField("Keys", BindingFlags.NonPublic | BindingFlags.Static);

                        if (field != null)
                            keys = (field.GetValue(null) as string[]);
                    }
                }
            }
            catch
            {
                keys = null;
            }

            return keys;
        }

        private void BtnReadKeys_Click(object sender, EventArgs e)
        {
            var fileName = GetTargetFile();

            if (!string.IsNullOrEmpty(fileName))
            {
                var keys = ReadLicenseKeys(fileName);

                if (keys != null)
                {
                    lbKeys.Items.Clear();
                    lbKeys.Items.AddRange(keys);
                    lblKeys.Text = string.Format("License &Keys ({0}):", lbKeys.Items.Count);
                    lbKeys.Enabled = lbKeys.Items.Count > 0;
                }
                else
                    MessageBox.Show("Error while reading license keys from file or keys not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnCopySelected_Click(object sender, EventArgs e)
        {
            if (lbKeys.SelectedItem != null)
            {
                try
                {
                    Clipboard.SetText(lbKeys.SelectedItem.ToString());
                }
                catch
                {
                    MessageBox.Show("Cannot copy selected key to clipboard!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void lbKeys_MouseClick(object sender, MouseEventArgs e)
        {
            BtnCopySelected.PerformClick();
        }

        private void lbKeys_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnCopySelected.Enabled = lbKeys.SelectedItem != null;
        }
    }
}
