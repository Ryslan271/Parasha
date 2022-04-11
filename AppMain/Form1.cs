using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMain
{
    public partial class Form1 : Form
    {
        private Random rn = new Random();
        private int run;
        private int[] colors;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(205, 92, 92);
            button2.BackColor = Color.FromArgb(173, 255, 47);
            button3.BackColor = Color.FromArgb(255, 69, 0);
            button4.BackColor = Color.FromArgb(255, 255, 0);
            button5.BackColor = Color.FromArgb(255, 0, 255);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.run = this.rn.Next(1, 5);

            if (run == 1)
            {
                panel1.BackColor = Color.FromArgb(205, 92, 92);
                panel2.BackColor = Color.FromArgb(173, 255, 47);
                panel3.BackColor = Color.FromArgb(255, 69, 0);
                panel4.BackColor = Color.FromArgb(255, 255, 0);
                panel5.BackColor = Color.FromArgb(255, 0, 255);
            }

            else if (run == 2)
            {
                panel1.BackColor = Color.FromArgb(205, 92, 92);
                panel2.BackColor = Color.FromArgb(255, 0, 255);
                panel3.BackColor = Color.FromArgb(173, 255, 47);
                panel4.BackColor = Color.FromArgb(255, 69, 0);
                panel5.BackColor = Color.FromArgb(255, 255, 0);
            }
            else if (run == 3)
            {
                panel1.BackColor = Color.FromArgb(205, 92, 92);
                panel2.BackColor = Color.FromArgb(255, 0, 255);
                panel3.BackColor = Color.FromArgb(255, 255, 0);
                panel4.BackColor = Color.FromArgb(173, 255, 47);
                panel5.BackColor = Color.FromArgb(255, 69, 0);
            }
            else if (run == 4)
            {
                panel1.BackColor = Color.FromArgb(205, 92, 92);
                panel2.BackColor = Color.FromArgb(255, 0, 255);
                panel3.BackColor = Color.FromArgb(255, 255, 0);
                panel4.BackColor = Color.FromArgb(255, 69, 0);
                panel5.BackColor = Color.FromArgb(173, 255, 47);
            }
            else if (run == 5)
            {
                panel1.BackColor = Color.FromArgb(205, 92, 92);
                panel2.BackColor = Color.FromArgb(255, 69, 0);
                panel3.BackColor = Color.FromArgb(255, 0, 255);
                panel4.BackColor = Color.FromArgb(255, 255, 0);
                panel5.BackColor = Color.FromArgb(173, 255, 47);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
