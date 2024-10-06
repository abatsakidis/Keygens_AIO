using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keygens_AIO.Keygens
{


    public partial class Data_Loader_Activator : Form
    {
        private const string AppEXEName = "\\DataLoader.exe";

        private int GetRandomIntNotEqualTo(int max, int value)
        {
            int result;
            var rnd = new Random();

            do
            {
                result = rnd.Next(max);
            } while (result == value);

            return result;
        }


        public Data_Loader_Activator()
        {
            InitializeComponent();
        }

        private void Data_Loader_Activator_Load(object sender, EventArgs e)
        {
            Text = Application.ProductName;
            folderBrowserDialog.SelectedPath = Application.StartupPath;

            foreach (var db in License_Data_Loader.DBList)
            {
                cboSourceDB.Items.Add(db.Key);
                cboTargetDB.Items.Add(db.Key);
            }

            if (cboSourceDB.Items.Count > 0)
                cboSourceDB.SelectedIndex = GetRandomIntNotEqualTo(cboSourceDB.Items.Count, -1);

            if (cboTargetDB.Items.Count > 0)
                cboTargetDB.SelectedIndex = GetRandomIntNotEqualTo(cboSourceDB.Items.Count, cboSourceDB.SelectedIndex);

            int index = 0;

            foreach (var edition in License_Data_Loader.EditionList)
            {
                cboEdition.Items.Add(edition.Key);

                if (edition.Value == License_Data_Loader.EditionType.Enterprise)
                    index = License_Data_Loader.EditionList.IndexOf(edition);
            }

            if (cboEdition.Items.Count > 0)
                cboEdition.SelectedIndex = index;
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (cboEdition.SelectedIndex >= 0 && cboSourceDB.SelectedIndex >= 0 && cboTargetDB.SelectedIndex >= 0)
            {
                string path = Application.StartupPath;

                if (!File.Exists(path + AppEXEName))
                    path = folderBrowserDialog.SelectedPath;

                if (!File.Exists(path + AppEXEName))
                {
                    while (true)
                    {
                        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                        {
                            path = folderBrowserDialog.SelectedPath;

                            if (string.IsNullOrEmpty(path))
                                return;

                            if (path[path.Length - 1] == '\\')
                                path = path.Remove(path.Length - 1, 1);

                            if (File.Exists(path + AppEXEName))
                                break;

                            MessageBox.Show(string.Format("{0} is not a valid Data Loader installation folder!", path), Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                            return;
                    }
                }

                License_Data_Loader.EditionType edition = License_Data_Loader.EditionList[cboEdition.SelectedIndex].Value;
                License_Data_Loader.DBType sourceDB = License_Data_Loader.DBList[cboSourceDB.SelectedIndex].Value;
                License_Data_Loader.DBType targetDB = License_Data_Loader.DBList[cboTargetDB.SelectedIndex].Value;

                if (License_Data_Loader.Activate(path, edition, sourceDB, targetDB))
                    MessageBox.Show("Data Loader successfully activated.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Cannot activate Data Loader!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void DBSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSourceDB.SelectedIndex == cboTargetDB.SelectedIndex)
            {
                int index = GetRandomIntNotEqualTo(cboSourceDB.Items.Count, cboSourceDB.SelectedIndex);

                if (sender == cboSourceDB)
                    cboTargetDB.SelectedIndex = index;
                else
                    cboSourceDB.SelectedIndex = index;
            }
        }

        private void cboEdition_SelectedIndexChanged(object sender, EventArgs e)
        {
            gboDBType.Enabled = (cboEdition.SelectedIndex >= 0 && License_Data_Loader.EditionList[cboEdition.SelectedIndex].Value == License_Data_Loader.EditionType.DataLoader);
        }
    }
}
