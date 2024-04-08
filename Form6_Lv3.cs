using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ммонетка
{
    public partial class Form6_Lv3 : Form
    {
        public int countCoins6 = 0;

        int downcount = 0;
        int playerHealth = 100;
        int enemyHealth = 100;

        private int jumpCount = 1;
        private int originalY;
        private int h = 3;
        private int w = 3;

        private DateTime lastKeyPressTime = DateTime.MinValue;
        private DateTime lastIntersectionTime = DateTime.MinValue;
        private TimeSpan intersectionInterval = TimeSpan.FromSeconds(0.5);

        private Random rand = new Random();
        private Timer timer = new Timer();

        bool isjumping = false;
        bool gameOver = false;
        bool isPause = false;
        bool movevrag = true;
        bool svitokVis = true;

        public Form6_Lv3()
        {
            InitializeComponent();
            ResetCoinLocation();

            timer.Interval = 16;
            timer.Tick += TimerTick;
            timer.Start();

            character6.Parent = pictureBox7;
            character6.BackColor = Color.Transparent;

            coins.Parent = pictureBox7;
            coins.BackColor = Color.Transparent;

            vrag.Parent = pictureBox7;
            vrag.BackColor = Color.Transparent;

            svitok.Parent = pictureBox7;
            svitok.BackColor = Color.Transparent;
            svitok.Visible = false;

            portal.Parent = pictureBox7;
            portal.BackColor = Color.Transparent;
            portal.Visible = false;
            portal.Enabled = false;

            label1.Parent = pictureBox7;
            label1.BackColor = Color.Transparent;

            label2.Parent = pictureBox7;
            label2.BackColor = Color.Transparent;
            label2.Visible = false;

            button1.Text = "Настройки";
            button1.Visible = false;

            button2.Text = "Продолжить";
            button2.Visible = false;
        }
        //
        // управление персонажем и взаимодействие с кнопками
        //
        private void Form6_KeyDown(object sender, KeyEventArgs e)
        {
            int charSpeed = 5;
            
            if (!isPause)
            {
                if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && character6.Left > 2)
                {
                    character6.Left -= charSpeed;
                    sbor();
                    Svitok();
                }
                else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && character6.Right < 800)
                {
                    character6.Left += charSpeed;
                    sbor();
                    Svitok();
                }
                else if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.W) && !isjumping)
                {
                    originalY = character6.Location.Y;
                    Jump();
                    sbor();
                    Svitok();
                    isjumping = true;
                }
                else if (e.KeyCode == Keys.R && gameOver)
                {
                    ResetGame();
                }
                else if (e.KeyCode == Keys.Space)
                {
                    if ((DateTime.Now - lastKeyPressTime).TotalSeconds >= 0.5)
                    {
                        lastKeyPressTime = DateTime.Now;
                        enemyHealth -= 20;
                        enemyHealthBar.Value = enemyHealth;

                        if (enemyHealth <= 0)
                        {
                            vrag.Enabled = false;
                            vrag.Visible = false;
                            vrag.Bounds = new Rectangle(0, 0, 0, 0);
                        }
                    }
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
            int x = character6.Location.X;
            int y = character6.Location.Y;

            sbor();

            if (jumpCount < 23)
            {
                jumpCount++;
                character6.Location = new Point(character6.Location.X + w, character6.Location.Y - h);
            }
            else
            {
                if (downcount < 23)
                {
                    downcount++;
                    character6.Location = new Point(character6.Location.X + w, character6.Location.Y + h);
                }
                else
                {
                    character6.Location = new Point(x, originalY);
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
            if (countCoins6 >= 8)
            {
                svitok.Visible = true;
                coins.Visible = false;
                coins.Enabled = false;
                coins.Bounds = new Rectangle(0, 0, 0, 0);

                if (character6.Bounds.IntersectsWith(svitok.Bounds) && svitokVis == true)
                {
                    svitokVis = false;
                    svitok.Visible = false;
                    svitok.Enabled = false;
                    portal.Visible = true;
                    portal.Enabled = true;
                    svitok.Bounds = new Rectangle(0, 0, 0, 0);
                }

                if (character6.Bounds.IntersectsWith(portal.Bounds))
                {
                    character6.Visible = false;
                    var result = MessageBox.Show("Выберите действие:", "Победа!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Form2_Menu form2 = new Form2_Menu();
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        Form6_Lv3 form6 = new Form6_Lv3();
                        form6.Show();
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
                movevrag = false;
                label2.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
            }
            else
            {
                movevrag = true;
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
            coins.Left = rand.Next(0, 415);
            coins.Top = rand.Next(240, 290);
        }
        //
        // сбор монет
        //
        private void sbor()
        {
            if (character6.Bounds.IntersectsWith(coins.Bounds))
            {
                countCoins6++;
                Controls.Remove(coins);
                ResetCoinLocation();
                labelCoins.Text = "Монеты:" + countCoins6.ToString();
            }
        }
        //
        // коллизия с противником
        //
        private void CheckCollision()
        {
            if (character6.Bounds.IntersectsWith(vrag.Bounds))
            {
                if ((DateTime.Now - lastIntersectionTime) >= intersectionInterval)
                {
                    lastIntersectionTime = DateTime.Now;
                    playerHealth -= 5;
                }

                HealthBar.Value = playerHealth;

                if (playerHealth <= 0)
                {
                    gameOver = true;
                    character6.Visible = false;
                    timer.Stop();
                    var result = MessageBox.Show("Выберите действие:", "Game Over", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        Form2_Menu form2 = new Form2_Menu(); form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        ResetGame();
                    }
                }
            }
        }
        //
        // перезапуск уровня
        //
        private void ResetGame()
        {
            character6.Visible = true;
            playerHealth = 100;
            enemyHealth = 100; 
            countCoins6 = 0;
            labelCoins.Text = "Монеты: 0";
            HealthBar.Value = playerHealth = 100; 
            enemyHealthBar.Value = enemyHealth = 100; 
            ResetCoinLocation();
            gameOver = false;
            timer.Start();
        }
        //
        // движение противника
        //
        private void MoveVrag()
        {
            if (!gameOver && movevrag == true)
            {
                if (character6.Left < vrag.Left)
                {
                    vrag.Left -= 1; // Set vrag speed to 1
                }
                else if (character6.Left > vrag.Left)
                {
                    vrag.Left += 1; // Set vrag speed to 1
                }
            }
        }
        //
        // кнопки и прочее
        //
        private void TimerTick(object sender, EventArgs e)
        {
            MineTimerEvent(sender, e);
            MoveVrag();
            CheckCollision();

            if (isjumping)
                Jump();
        }

        private void MineTimerEvent(object sender, EventArgs e)
        {
            if (playerHealth > 1)
                HealthBar.Value = playerHealth;
        }

        private void labelCoins_Click(object sender, EventArgs e)
        { }

        private void label1_Click_1(object sender, EventArgs e)
        { }

        private void pictureBox1_Click(object sender, EventArgs e)
        { }

        private void label1_Click(object sender, EventArgs e)
        { }

        private void Form6_Load(object sender, EventArgs e)
        { }

        private void Heath_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            isPause = false;
            label2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            movevrag = true;
            this.Focus();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4_Settings form4 = new Form4_Settings();
            form4.Show();
        }
    }
}