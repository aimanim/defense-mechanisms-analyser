using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace psychapp
{
    public partial class questions : Form
    {
        int count, denial, regression, sublimation, suppression, humor, rationalization, displacement, projection;

        private void button1_Click(object sender, EventArgs e)
        {
            switch (count)
            {
                case 1:
                    if (rb1.Checked) denial++;
                    else if (rb2.Checked) suppression++;
                    else if (rb3.Checked) regression++;
                    else if (rb4.Checked) sublimation++;
                    count++;
                    question2();
                    break;
                case 2:
                    if (rb1.Checked) humor++;
                    else if (rb2.Checked) rationalization++;
                    else if (rb3.Checked) sublimation++;
                    else if (rb4.Checked) displacement++;
                    count++;
                    question3();
                    break;
                case 3:
                    if (rb1.Checked) regression++;
                    else if (rb2.Checked) denial++;
                    else if (rb3.Checked) projection++;
                    else if (rb4.Checked) humor++;
                    count++;
                    question4();
                    break;
                case 4:
                    if (rb1.Checked) rationalization++; 
                    else if (rb2.Checked) displacement++;
                    else if (rb3.Checked) projection++;
                    else if (rb4.Checked) regression++;
                    count++;
                    question5();
                    break;
                case 5:
                    if (rb1.Checked) rationalization++;
                    else if (rb2.Checked) denial++;
                    else if (rb3.Checked) suppression++;
                    else if (rb4.Checked) displacement++;
                    count++;
                    question6();
                    break;
                case 6:
                    if (rb1.Checked) regression++;
                    else if (rb2.Checked) denial++;
                    else if (rb3.Checked) humor++;
                    else if (rb4.Checked) displacement++;
                    count++;
                    question5();
                    break;
            }
        }

        public questions()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            count = 1;
            question1();
        }

        void rbs_false()
        {
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = false;
        }

        void question1()
        {
            question.Text = "1. Your close family member dies.";
            string[] opt = { "You continue to set a place for them at the dinner table", "You avoid thinking about it",
            "You lock yourself in a room and cry", "You engage yourself in some activity to cope with the grief"};
            rb1.Text = opt[0];
            rb2.Text = opt[1];
            rb3.Text = opt[2];
            rb4.Text = opt[3];
        }
        void question2()
        {
            rbs_false();
            question.Text = "2. It's your birthday, and your friends have not acknowledged it.";
            string[] opt = { "You joke about how no one wished you a Happy Birthday yet", "You tell yourself that maybe they're just planning a surprise party",
                "You bake yourself a cake", "You snap at your parents when they ask you how your day is going"};
            rb1.Text = opt[0];
            rb2.Text = opt[1];
            rb3.Text = opt[2];
            rb4.Text = opt[3];
        }

        void question3()
        {
            rbs_false();
            question.Text = "3. Your friend points out your lazy attitude.";
            string[] opt = { "Start crying or feel upset", "Act like you don't know what they're talking about and deny it",
                "Accuse them of being more lazy", "Laugh it off"};
            rb1.Text = opt[0];
            rb2.Text = opt[1];
            rb3.Text = opt[2];
            rb4.Text = opt[3];
        }
        void question4()
        {
            rbs_false();
            question.Text = "4. You had a breakup due to your temper.";
            string[] opt = { "You think it was because your partner never liked you", "You slam the door",
                "You think your partner was crazy and had anger issues", "You cry yourself to sleep" };
            rb1.Text = opt[0];
            rb2.Text = opt[1];
            rb3.Text = opt[2];
            rb4.Text = opt[3];
        }
        void question5()
        {
            rbs_false();
            question.Text = "5. You are a compulsive eater, and people tell you that it is bad for your health";
            string[] opt = { "You think everyone is jealous of your appetite", "You don’t think it will affect your health",
                "You don’t want to talk about it", "You yell at the person who tells you not to eat"};
            rb1.Text = opt[0];
            rb2.Text = opt[1];
            rb3.Text = opt[2];
            rb4.Text = opt[3];
        }
        void question6()
        {
            rbs_false();
            question.Text = "6. Ali won an award in school and has to give a speech but is anxious about speaking in public today.";
            string[] opt = { "He sucks his thumb", "He doesn’t think he has stage fright", "He jokes about his anxiety",
                 "He uses foul language to his peers"};
            rb1.Text = opt[0];
            rb2.Text = opt[1];
            rb3.Text = opt[2];
            rb4.Text = opt[3];
        }
    }
}
