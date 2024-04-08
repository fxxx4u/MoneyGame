using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ммонетка
{
    public partial class Form5_Lv2 : Form
    {
        public int countCoins5 = 0;

        int downcount = 0;

        private int jumpCount = 1;
        private int originalY;
        private int h = 3;
        private int w = 3;

        private Timer timer = new Timer();
        private Random rand = new Random();

        bool isjumping = false;
        bool isPause = false;
        bool svitokVis = true;

        public Form5_Lv2()
        {
            InitializeComponent();
            ResetCoinLocation();

            timer.Interval = 16;
            timer.Tick += TimerTick;
            timer.Start();

            character5.Parent = pictureBox5;
            character5.BackColor = Color.Transparent;

            coins5.Parent = pictureBox5;
            coins5.BackColor = Color.Transparent;

            svitok.Parent = pictureBox5;
            svitok.BackColor = Color.Transparent;
            svitok.Visible = false;

            portal.Parent = pictureBox5;
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
        private void Form5_KeyDown(object sender, KeyEventArgs e)
        {
            int charSpeed = 5;

            if (!isPause)
            {
                if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && character5.Left > 2)
                {
                    character5.Left -= charSpeed;
                    sbor();
                    Svitok();
                }
                else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && character5.Right < 800)
                {
                    character5.Left += charSpeed;
                    sbor();
                    Svitok();
                }
                else if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.W) && !isjumping)
                {
                    originalY = character5.Location.Y;
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
            int x = character5.Location.X;
            int y = character5.Location.Y;

            sbor();

            if (jumpCount < 23)
            {
                jumpCount++;
                character5.Location = new Point(character5.Location.X + w, character5.Location.Y - h);
            }
            else
            {
                if (downcount < 23)
                {

                    downcount++;
                    character5.Location = new Point(character5.Location.X + w, character5.Location.Y + h);
                }
                else
                {
                    character5.Location = new Point(x, originalY);

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
                coins5.Visible = false;
                coins5.Enabled = false;
                coins5.Bounds = new Rectangle(0, 0, 0, 0);
                if (character5.Bounds.IntersectsWith(svitok.Bounds) && svitokVis == true)
                {
                    svitokVis = false;
                    svitok.Visible = false;
                    svitok.Enabled = false;
                    portal.Visible = true;
                    portal.Enabled = true;
                    svitok.Bounds = new Rectangle(0, 0, 0, 0);
                }
                if (character5.Bounds.IntersectsWith(portal.Bounds))
                {
                    character5.Visible = false;
                    var result = MessageBox.Show("Выберите действие:", "Победа!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Form2_Menu form2 = new Form2_Menu();
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        Form5_Lv2 form5 = new Form5_Lv2();
                        form5.Show();
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
            coins5.Left = rand.Next(0, 415);
            coins5.Top = rand.Next(240, 290);
        }
        //
        // сбор монет
        //
        private void sbor()
        {
            if (character5.Bounds.IntersectsWith(coins5.Bounds))
            {
                countCoins5++;
                Controls.Remove(coins5);
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

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            isPause = false;
            label2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            this.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4_Settings form4 = new Form4_Settings();
            form4.Show();
        }
    }
}