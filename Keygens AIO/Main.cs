using Keygens_AIO.Keygens;
using System;
using System.Windows.Forms;

namespace Keygens_AIO
{
    public partial class Main : Form
    {
       
        public Main()
        {
            InitializeComponent();
        }


        private void closeallforms()
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm != Parent)
                {
                    frm.Close();
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox2.SelectedItem.ToString().Trim() == "AntiPlagiarism.NET Keygen")
            {
                closeallforms();

                AntiPlagiarism objfrmMChild = new AntiPlagiarism();

                objfrmMChild.MdiParent = this;

                objfrmMChild.Show();

                objfrmMChild.BringToFront();
            }

            if (toolStripComboBox2.SelectedItem.ToString().Trim() == "Apache Logs Viewer 5.x")
            {
                closeallforms();

                ApacheLogsViewer_5_x objfrmMChild = new ApacheLogsViewer_5_x();

                objfrmMChild.MdiParent = this;

                objfrmMChild.Show();

                objfrmMChild.BringToFront();
            }
            
            if (toolStripComboBox2.SelectedItem.ToString().Trim() == "Batch PDF Pro License Keys Reader")
            {
                closeallforms();

                BatchPDFProLicenseKeysReader objfrmMChild = new BatchPDFProLicenseKeysReader();

                objfrmMChild.MdiParent = this;

                objfrmMChild.Show();

                objfrmMChild.BringToFront();
            }
            if (toolStripComboBox2.SelectedItem.ToString().Trim() == "Ashisoft Products LicGen")
            {
                closeallforms();

                Ashisoft_Products_LicGen objfrmMChild = new Ashisoft_Products_LicGen();

                objfrmMChild.MdiParent = this;

                objfrmMChild.Show();

                objfrmMChild.BringToFront();
            }
           
            if (toolStripComboBox2.SelectedItem.ToString().Trim() == "Data Loader Activator")
            {
                closeallforms();

                Data_Loader_Activator objfrmMChild = new Data_Loader_Activator();

                objfrmMChild.MdiParent = this;

                objfrmMChild.Show();

                objfrmMChild.BringToFront();
            }
            
            if (toolStripComboBox2.SelectedItem.ToString().Trim() == "File Viewer Plus 3.x LicGen")
            {
                closeallforms();

                File_Viewer_Plus_3x_LicGen objfrmMChild = new File_Viewer_Plus_3x_LicGen();

                objfrmMChild.MdiParent = this;

                objfrmMChild.Show();

                objfrmMChild.BringToFront();
            }

            if (toolStripComboBox2.SelectedItem.ToString().Trim() == "Goldilogs 1.x LicGen")
            {
                closeallforms();

                Goldilogs_1x_LicGen objfrmMChild = new Goldilogs_1x_LicGen();

                objfrmMChild.MdiParent = this;

                objfrmMChild.Show();

                objfrmMChild.BringToFront();
            }

            if (toolStripComboBox2.SelectedItem.ToString().Trim() == "Jitbit Macro Recorder Keygen")
            {
                closeallforms();

                Jitbit_Macro_Recorder_Keygen objfrmMChild = new Jitbit_Macro_Recorder_Keygen();

                objfrmMChild.MdiParent = this;

                objfrmMChild.Show();

                objfrmMChild.BringToFront();
            }


        }

        private void Main_Load(object sender, EventArgs e)
        {
            toolStripComboBox2.Sorted = true;
            toolStripComboBox2.SelectedIndex = 0;

            closeallforms();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //closeallforms();

            About objfrmMChild = new About();

            objfrmMChild.MdiParent = this;

            objfrmMChild.Show();

            objfrmMChild.BringToFront();
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
                toolStripButton1.PerformClick();
        }
    }
}
