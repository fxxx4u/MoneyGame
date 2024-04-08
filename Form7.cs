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
    public partial class Form7 : Form
    {
        Thread th;
        Thread tg;
        public Form7()
        {
            InitializeComponent();
            button1.Text = "Главное меню";
            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;
            label6.Parent = pictureBox1;
            label6.BackColor = Color.Transparent;
        }
        public void open1(object obj)
        {
            Application.Run(new Form2_Menu());
        }
        private void button1_Click_1(object sender, EventArgs e)

        {
            this.Close();
            tg = new Thread(open1);
            tg.SetApartmentState(ApartmentState.STA);
            tg.Start();
        }
    }
}
