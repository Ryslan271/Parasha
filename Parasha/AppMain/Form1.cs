using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace AppMain
{
    public partial class Form1 : Form
    {
        private Random rn = new Random();
        private int run;
        ArrayList array = new ArrayList();
        private int[] colors;
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void play()
        {
            this.run = this.rn.Next(1, 5);

            if (run == 1)
            {
                button1.BackColor = Color.Red;
            }
            else if (run == 2)
            {
                button2.BackColor = Color.Red;
            }
            else if (run == 3)
            {
                button3.BackColor = Color.Red;
            }
            else if (run == 4)
            {
                button4.BackColor = Color.Red;
            }
            else if (run == 5)
            {
                button5.BackColor = Color.Red;
            }
            this.array.Add(this.run);

            if (count < 5)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
                button1.BackColor = Color.Black;
                button2.BackColor = Color.Black;
                button3.BackColor = Color.Black;
                button4.BackColor = Color.Black;
                button5.BackColor = Color.Black;
            }
            count++;
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            play();
        }
    }
}
