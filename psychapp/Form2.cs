using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace psychapp
{
    public partial class Form2 : Form
    {
        string[] scenario = { "This is scenario1", "scenario 2" };
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = scenario[0];
            string huh = "huh";
            rb1.Text = huh;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = scenario[1];
        }
    }
}
