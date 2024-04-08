using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.CodeDom;

namespace ммонетка
{
    public partial class Form2_Menu : Form
    {
        Thread th;
        Thread tg;
        public Form2_Menu()
        {

            InitializeComponent();
            button1.Text = "Начать игру";
            button2.Text = "Выбрать уровень";
            button3.Text = "Настройки";
            button4.Text = "Выйти из игры";
            button5.Text = "Авторы";
        }
        public void SumCoins(int coins1, int coins5, int coins6)
        {
            int totalCoins = coins1 + coins5 + coins6;
        }
            private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void open(object obj)
        {
            Application.Run(new Form1_Lv1());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            tg = new Thread(open2);
            tg.SetApartmentState(ApartmentState.STA);
            tg.Start();
        }
        public void open2(object obj)
        {
            Application.Run(new Form3_ChooseLv());
        }

        public void open3(object obj)
        {
            Application.Run(new Form4_Settings());
        }
        private void button3_Click_1(object sender, EventArgs e)

        {
            this.Close();
            tg = new Thread(open3);
            tg.SetApartmentState(ApartmentState.STA);
            tg.Start();

        }
        public void open4(object obj)
        {
            Application.Run(new Form7());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
            tg = new Thread(open4);
            tg.SetApartmentState(ApartmentState.STA);
            tg.Start();

        }
    }
}
