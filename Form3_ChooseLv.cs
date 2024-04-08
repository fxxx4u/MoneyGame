using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ммонетка
{
    public partial class Form3_ChooseLv : Form
    {
        Thread th;
        Thread tg;
        public Form3_ChooseLv()
        {
            InitializeComponent();
            button1.Text = "Первый уровень";
            button2.Text = "Второй уровень";
            button5.Text = "Вернуться";
            button3.Text = "Третий уровень";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void open1(object obj)
        {
            Application.Run(new Form1_Lv1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void open3(object obj)
        {
            Application.Run(new Form5_Lv2());
        }

        public void open2(object obj)
        {
            Application.Run(new Form2_Menu());
        }
        private void button5_Click(object sender, EventArgs e)

        {
            this.Close();
            tg = new Thread(open2);
            tg.SetApartmentState(ApartmentState.STA);
            tg.Start();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open4);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void open4(object obj)
        {
            Application.Run(new Form6_Lv3());
        }
    }
}
