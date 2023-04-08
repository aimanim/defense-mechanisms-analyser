using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace psychapp
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            questions f3 = new questions();
            f3.ShowDialog();
            this.Close();
        }

        private void Intro_Load(object sender, EventArgs e)
        {

        }
    }
}
