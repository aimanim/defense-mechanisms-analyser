using System;
using System.CodeDom;
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
        public int j = 4,i=1;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (rb1.Checked) check(keys[(i - 1) * 4]);
            if (rb2.Checked) check(keys[((i - 1) * 4) + 1]);
            if (rb3.Checked) check(keys[((i - 1) * 4) + 2]);
            if (rb4.Checked) check(keys[((i - 1) * 4) + 3]);
            rbs_false();
            if (i == 14)
            {
                button1.Text = "- Submit -";
            }
            if (i == 15)
            {

                int[] arr = new int[8];
                arr[0] = denial;
                arr[1] = regression;
                arr[2] = sublimation;
                arr[3] = suppression;
                arr[4] = humor;
                arr[5] = rationalization;
                arr[6] = displacement;
                arr[7] = projection;
                
                Outro hehe = new Outro(arr);
                this.Hide();
                hehe.ShowDialog();
                this.Close();
            }
            question.Text = Questions[i++];
            rb1.Text = answers[j++];
            rb2.Text = answers[j++];
            rb3.Text = answers[j++];
            rb4.Text = answers[j++];
            
        }

        public questions()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            question.Text = Questions[0];
            rb1.Text = answers[0];
            rb2.Text = answers[1];
            rb3.Text = answers[2];
            rb4.Text = answers[3];
        }

        void rbs_false()
        {
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = false;
        }
        string[] Questions = { "1. Your close family member dies.",
                               "2. It is your birthday, and your friends have not acknowledged it.",
                               "3. Your friend points out your lazy attitude.",
                               "4. You had a breakup due to your temper.",
                               "5. You are a compulsive eater, people tell you it is bad for your health.",
                               "6. Ali won an award in school and has to give a speech but he is anxious about speaking in public.",
                               "7. You make a mistake at work that costs the company money.",
                               "8. You have a fear of spiders.",
                               "9. Your mobile phone got snatched at gunpoint.",
                               "10. You are rejected for a job after reaching late for the interview.",
                               "11. Your code has been found 60% plagiarized because you copied it from a friend.",
                               "12. You are scolded for speaking loudly.",
                               "13. You are unhappy with your career although you opted for it.",
                               "14. You are addicted to drugs.",
                               "15. Your important document has been spoiled by a relative’s kid as it was lying on the dining table."
        };
        string[] answers = {  "You continue to set a place for them at the dinner table",
                              "You avoid thinking about it",
                              "You lock yourself in a room and cry",
                              "You engage yourself in some activity to cope with the grief",
                              "You joke about how no one wished you a Happy Birthday yet",
                              "You tell yourself that maybe they're just planning a surprise party",
                              "You bake yourself a cake",
                              "You snap at your parents when they ask you how your day is going",
                              "Start crying or feel upset",
                              "Act like you don't know what they're talking about and deny it",
                              "Accuse them of being more lazy",
                              "Laugh it off",
                              "You think it was because your partner never liked you",
                              "You slam the door.",
                              "You think your partner was crazy and had anger issues",
                              "You cry yourself to sleep",
                              "You think everyone is jealous of your appetite",
                              "You don’t think it will affect your health ",
                              "You don’t want to talk about it",
                              "You yell at the person who tells you not to eat",
                              "He sucks his thumb",
                              "He doesn’t think he has stage fright",
                              "He jokes about his anxiety",
                              "He uses foul language to his peers",
                              "You accuse your coworker of distracting you or not doing their part",
                              "You feel like a failure and want to quit your job",
                              "You try to forget about the mistake and avoid thinking about it",
                              "You work twice as hard to try to make up for the mistake",
                              "You deny that you have a fear of spiders and insist that you can handle them",
                              "You avoid any situation that might involve spiders",
                              "You scream and run away when you see a spider",
                              "You channel your fear into learning more about spiders and their behavior",
                              "You take your anger out on your friends",
                              "You whine about losing your data",
                              "You joke about it with friends ",
                              "You don’t telling anyone about it to avoid thinking about your loss",
                              "You say you got rejected because of company politics ",
                              "You don’t talk about it",
                              "You are more careful to not be late for future job interviews",
                              "You punch a wall when you see the rejection email ",
                              "You feel guilty for it and avoid doing it in the future",
                              "You say it was necessary to copy to meet the deadline",
                              "You deny that it was copied",
                              "You blame your friend for copying your work",
                              "You decide to use this skill and become a public speaker",
                              "You slam the door",
                              "You deny that you were loud.",
                              "You throw a tantrum for being scolded",
                              "You blame your lack of success on colleagues",
                              "You start smoking cigarettes for stress relief",
                              "You deny that you are unhappy",
                              "You start a side business you enjoy",
                              "You say you’re not addicted and you can leave anytime",
                              "You blame your peers",
                              "You believe that your addiction is only because studies stressed you out",
                              "You start a fight with the person who called out your addiction",
                              "You mumble angry words in private",
                              "You try to act like the document wasn’t important and it’s not an issue",
                              "You hit the kid on his head when his mother wasn’t there",
                              "You believe it’s not your fault as you thought the document was safe there"
        };

        int denial = 0,  suppression = 0, sublimation = 0, humor = 0, projection = 0, regression = 0,
            displacement = 0, rationalization = 0;

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        void check(string hehe)
        {
            switch (hehe)
            {
                case "D":
                    denial++;
                    break;
                case "S":
                    suppression++;
                    break;
                case "R":
                    regression++;
                    break;
                case "Su":
                    sublimation++;
                    break;
                case "H":
                    humor++;
                    break;
                case "Di":
                    displacement++;
                    break;
                case "Ra":
                    rationalization++;
                    break;
                case "P":
                    projection++;
                    break;
            }
        }
        /*denial = "D"
        suppression = "S"
        regression = "R"
        sublimation = "Su"
        Humor = "H"
        Displacement = "Di"
        rationalization = "Ra"
        Projection = "P"
       */
        string[] keys =
        {
            "D","S","R","Su",
            "H","Ra","Su","Di",
            "R","D","P","H",
            "Ra","Di","P","R",
            "Ra","D","S","Di",
            "R","D","H","Di",
            "P","R","S","Su",
            "D","S","R","Su",
            "Di","R","H","S",
            "Ra","S","Su","Di",
            "Su","Ra","D","P",
            "Su","Di","D","R",
            "P","Di","D","Su",
            "D","P","Ra","Di",
            "R","D","Di","Ra"
        };

    }
}
