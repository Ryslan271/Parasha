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
        private int run = 0;
        ArrayList array = new ArrayList();
        private int r = 0;
        private int g = 0;
        private int b = 0;
        private int[] colors;
        private int count = 0;
        private bool gameStart = false;
        private int step = 0;
        private int countRet = 5; //количество повторений (кнопки сколько раз загараются)

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(step == countRet)
            {
                label1.Text = "Повезло-повезло";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            gameStart = false;
            timer1.Enabled = true;
            count = 0;
            run = 0;
            step = 0;
            array.Clear();
        }

        private void play()
        {
            this.run = this.rn.Next(1, 5);
            r = rn.Next(0,255); 
            g = rn.Next(0,255); 
            b = rn.Next(0,255); 

            if (run == 1)
            {
                button1.BackColor = Color.FromArgb(100, r,g,b);
            }
            else if (run == 2)
            {
                button2.BackColor = Color.FromArgb(100, r, g, b);
            }
            else if (run == 3)
            {
                button3.BackColor = Color.FromArgb(100, r, g, b);
            }
            else if (run == 4)
            {
                button4.BackColor = Color.FromArgb(100, r, g, b);
            }
            else if (run == 5)
            {
                button5.BackColor = Color.FromArgb(100, r, g, b);
            }
            this.array.Add(this.run);

            if (count < countRet)
            {
                label1.Text = "Начнём";
                timer1.Enabled = true;
            }
            else
            {
                label1.Text = "Отгадывай";
                timer1.Enabled = false;
                button1.BackColor = Color.Black;
                button2.BackColor = Color.Black;
                button3.BackColor = Color.Black;
                button4.BackColor = Color.Black;
                button5.BackColor = Color.Black;
            }
            count++;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (1 != (int)array[step])
            {
                gameStart = false;
                label1.Text = "ты проиграл ахаххаха ботяра";
            }
            else
            {
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Black;
                button3.BackColor = Color.Black;
                button4.BackColor = Color.Black;
                button5.BackColor = Color.Black;
                step++;
            }
            if (step >= countRet)
            {
                label1.Text = "Неожидал";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (2 != (int)array[step])
            {
                gameStart = false;
                label1.Text = "ты проиграл ахаххаха ботяра";
            }
            else
            {
                button1.BackColor = Color.Black;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Black;
                button4.BackColor = Color.Black;
                button5.BackColor = Color.Black;
                step++;
            }
            if (step >= countRet)
            {
                label1.Text = "Неожидал";
            }
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (3 != (int)array[step])
            {
                gameStart = false;
                label1.Text = "ты проиграл ахаххаха ботяра";
            }
            else
            {
                button1.BackColor = Color.Black;
                button2.BackColor = Color.Black;
                button3.BackColor = Color.Gray;
                button4.BackColor = Color.Black;
                button5.BackColor = Color.Black;
                step++;
            }
            if (step >= countRet)
            {
                label1.Text = "Неожидал";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (4 != (int)array[step])
            {
                gameStart = false;
                label1.Text = "ты проиграл ахаххаха ботяра";
            }
            else
            {
                button1.BackColor = Color.Black;
                button2.BackColor = Color.Black;
                button3.BackColor = Color.Black;
                button4.BackColor = Color.Gray;
                button5.BackColor = Color.Black;
                step++;
            }
            if (step >= countRet)
            {
                label1.Text = "Неожидал";
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (5 != (int)array[step])
            {
                gameStart = false;
                label1.Text = "ты проиграл ахаххаха ботяра";
            }
            else
            {
                button1.BackColor = Color.Black;
                button2.BackColor = Color.Black;
                button3.BackColor = Color.Black;
                button4.BackColor = Color.Black;
                button5.BackColor = Color.Gray;
                step++;
            }
            if (step >= countRet)
            {
                label1.Text = "Неожидал";
            }
            
        }
    }
}
