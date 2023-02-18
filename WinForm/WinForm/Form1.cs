using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            textBox.Text = "31 января 2023 год!";
            button2.Enabled = true;
            button3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
