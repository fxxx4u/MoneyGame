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
    public partial class Form4_Settings : Form
    {
        Thread th;
        Thread tg;
        public Form4_Settings()
        {
            InitializeComponent();
            button1.Text = "Вернуться";
        }

        public void open2(object obj)
        {
            Application.Run(new Form2_Menu());
        }
        private void button1_Click(object sender, EventArgs e)

        {
            this.Close();
            tg = new Thread(open2);
            tg.SetApartmentState(ApartmentState.STA);
            tg.Start();
        }
    }
}
