using System.Drawing;
using System.Windows.Forms;
using System;
using System.Reflection.Emit;

namespace ммонетка
{
    public partial class Form1_Lv1: Form
    {
        public int countCoins5 = 0;

        int downcount = 0;

        private int jumpCount = 1;
        private int originalY;
        private int h = 3;
        private int w = 3;

        private Random rand = new Random();
        private Timer timer = new Timer();
        
        bool svitokVis = true;
        bool isjumping = false;
        bool isPause = false;

        public Form1_Lv1()
        {
            InitializeComponent();
            ResetCoinLocation();

            timer.Interval = 16;
            timer.Tick += TimerTick;
            timer.Start();

            character1.Parent = pictureBox1;
            character1.BackColor = Color.Transparent;

            coins1.Parent = pictureBox1;
            coins1.BackColor = Color.Transparent;

            svitok.Parent = pictureBox1;
            svitok.BackColor = Color.Transparent;
            svitok.Visible = false;

            portal.Parent = pictureBox1;
            portal.BackColor = Color.Transparent;
            portal.Visible = false;
            portal.Enabled = false;

            label2.Visible = false;

            button1.Text = "Настройки";
            button1.Visible = false;

            button2.Text = "Продолжить";
            button2.Visible = false;
        }
        //
        // управление персонажем и взаимодействие с кнопками
        //
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int charSpeed = 5;

            if (!isPause)
            {
                if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && character1.Left > 2)
                {
                    character1.Left -= charSpeed;
                    sbor();
                    Svitok();
                }
                else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && character1.Right < 800)
                {
                    character1.Left += charSpeed;
                    sbor();
                    Svitok();
                }
                else if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.W) && !isjumping)
                {
                    originalY = character1.Location.Y;
                    Jump();
                    sbor();
                    isjumping = true;
                    Svitok();
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    pause();
                }
            }
        }
        //
        // прыжок
        //
        private void Jump()
        {
            int x = character1.Location.X;
            int y = character1.Location.Y;

            sbor();


            if (jumpCount < 23) // число итераций прыжка (можно изменить)
            {
                jumpCount++;
                character1.Location = new Point(character1.Location.X + w, character1.Location.Y - h);
            }
            else
            {
                if (downcount < 23)
                {

                    downcount++;
                    character1.Location = new Point(character1.Location.X + w, character1.Location.Y + h);
                }
                else
                {
                    character1.Location = new Point(x, originalY);

                    jumpCount = 0;
                    downcount = 0;
                    isjumping = false;
                }
            }
        }
        //
        // свиток и прохождение уровня
        //
        private void Svitok()
        {
            if (countCoins5 >= 8)
            {
                svitok.Visible = true;
                coins1.Visible = false;
                coins1.Enabled = false;
                coins1.Bounds = new Rectangle(0, 0, 0, 0);
                if (character1.Bounds.IntersectsWith(svitok.Bounds) && svitokVis == true)
                {
                    svitokVis = false;
                    svitok.Visible = false;
                    svitok.Enabled = false;
                    portal.Visible = true;
                    portal.Enabled = true;
                    svitok.Bounds = new Rectangle(0, 0, 0, 0);
                }
                if (character1.Bounds.IntersectsWith(portal.Bounds))
                {
                    character1.Visible = false;
                    var result = MessageBox.Show("Выберите действие:", "Победа!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Form2_Menu form2 = new Form2_Menu();
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        Form1_Lv1 form1 = new Form1_Lv1();
                        form1.Show();
                        this.Hide();
                    }
                }
            }
        }
        //
        // пауза на уровне
        //
        private void pause()
        {
            isPause = !isPause;

            if (isPause)
            {
                label2.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
            }
            else
            {
                label2.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
            }
        }
        //
        // монеты, их спавн
        //
        private void ResetCoinLocation()
        {
            coins1.Left = rand.Next(0, 415);
            coins1.Top = rand.Next(240, 290);
        }
        //
        // сбор монет
        //
        private void sbor()
        {
            if (character1.Bounds.IntersectsWith(coins1.Bounds))
            {
                countCoins5++;
                Controls.Remove(coins1);
                ResetCoinLocation();
                labelCoins.Text = "Монеты:" + countCoins5.ToString();
            }
        }
        //
        // кнопки и прочее
        //
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (isjumping)
                Jump();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4_Settings form4 = new Form4_Settings();
            form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isPause = false;
            label2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            this.Focus();
        }

        private void labelCoins_Click(object sender, EventArgs e)
        {

        }
    }
}
