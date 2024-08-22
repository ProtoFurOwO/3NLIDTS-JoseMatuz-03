using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3NLIDTS_JoseMatuz_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            celdato.Text = string.Empty;
            farendato.Text = string.Empty;
        }

        private void ctf_Click(object sender, EventArgs e)
        {
            float cel = float.Parse(celdato.Text);
            float far = (cel * 9f / 5f) + 32;
            farendato.Text = far.ToString();
        }

        private void ftc_Click(object sender, EventArgs e)
        {
            float far = float.Parse(farendato.Text);
            float cel = (far - 32) * 5f / 9f;
            celdato.Text = cel.ToString();
        }

        private void welcom_Click(object sender, EventArgs e)
        {

        }
    }
}
