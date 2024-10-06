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
    public partial class ApacheLogsViewer_5_x : Form
    {
        public ApacheLogsViewer_5_x()
        {
            InitializeComponent();
        }

        public static string GenerateUnlockCode()
        {
            var random = new Random();
            var result = new StringBuilder();
            result.Append("F");
            result.Append(random.Next(256).ToString("X2"));
            result.Append("IALV");
            result.Append(random.Next(1000).ToString("D4"));
            result.Append((random.Next(10) <= 4) ? "2" : "3");

            int num = 0;
            byte[] bytes = Encoding.ASCII.GetBytes(result.ToString().Insert(1, ":").Insert(5, ":").Insert(9, ":").Insert(13, ":"));

            for (int i = 0; i < bytes.Length; i++)
            {
                if (bytes[i] % 2 == 0)
                    num++;
            }

            result.Append(num.ToString("D2"));
            bytes = Encoding.ASCII.GetBytes(result.ToString());
            result.Clear();
            num = 1;

            foreach (byte b in bytes)
            {
                result.Append(b.ToString("X2"));

                if (num < 14 && (num++ % 2) == 0)
                    result.Append("-");
            }

            return result.ToString();
        }

        private void ApacheLogsViewer_5_x_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text = GenerateUnlockCode();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Text = GenerateUnlockCode();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
