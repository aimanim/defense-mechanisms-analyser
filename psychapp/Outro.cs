using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace psychapp
{
    public partial class Outro : Form
    {
        public Outro(int[] mechanisms)
        {
            InitializeComponent();
            string[] names = { "Denial", "Regression", "Sublimation", "Suppression", "Humor", "Rationalization", "Displacement", "Projection" };
            string display = "";
            for(int i=0; i < 8; i++)
            {
                display += names[i] + ":\n";
            }
            box2.Text = display;
            display = "";
            for (int i=0; i < 8; i++)
            {
                for (int j = 0; j < mechanisms[i]; j++)
                    display += "██";
                display += "\n";
            }
            box.Text = display;
            
        }

        private void Outro_Load(object sender, EventArgs e)
        {
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
