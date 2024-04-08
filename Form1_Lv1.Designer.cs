using System.Windows.Forms;
using System;

namespace ммонетка
{
    partial class Form1_Lv1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox fon;
        private System.Windows.Forms.Label person;
        private System.Windows.Forms.Label labelCoins;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelCoins = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.svitok = new System.Windows.Forms.Label();
            this.character1 = new System.Windows.Forms.Label();
            this.coins1 = new System.Windows.Forms.Label();
            this.portal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCoins
            // 
            this.labelCoins.AutoSize = true;
            this.labelCoins.BackColor = System.Drawing.Color.LightSeaGreen;
            this.labelCoins.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoins.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCoins.Location = new System.Drawing.Point(2, 8);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.Size = new System.Drawing.Size(113, 28);
            this.labelCoins.TabIndex = 4;
            this.labelCoins.Text = "Монеты: 0";
            this.labelCoins.Click += new System.EventHandler(this.labelCoins_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ммонетка.Properties.Resources._1644513641_20_abrakadabra_fun_p_fon_dlya_klikera_24;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(789, 412);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // svitok
            // 
            this.svitok.BackColor = System.Drawing.Color.Transparent;
            this.svitok.Image = global::ммонетка.Properties.Resources._65f04d118da9e_1710247239_65f04d118da8f;
            this.svitok.Location = new System.Drawing.Point(398, 290);
            this.svitok.Name = "svitok";
            this.svitok.Size = new System.Drawing.Size(80, 80);
            this.svitok.TabIndex = 9;
            // 
            // character1
            // 
            this.character1.BackColor = System.Drawing.Color.Transparent;
            this.character1.Image = global::ммонетка.Properties.Resources._8c6c6c40949011_57931d719e13a;
            this.character1.Location = new System.Drawing.Point(-3, 280);
            this.character1.Name = "character1";
            this.character1.Size = new System.Drawing.Size(100, 100);
            this.character1.TabIndex = 10;
            // 
            // coins1
            // 
            this.coins1.BackColor = System.Drawing.Color.Transparent;
            this.coins1.Image = global::ммонетка.Properties.Resources._65e84855db0e3_1709721753_65e84855db0dd__1_;
            this.coins1.Location = new System.Drawing.Point(329, 245);
            this.coins1.Name = "coins1";
            this.coins1.Size = new System.Drawing.Size(50, 50);
            this.coins1.TabIndex = 11;
            // 
            // portal
            // 
            this.portal.BackColor = System.Drawing.Color.Transparent;
            this.portal.Image = global::ммонетка.Properties.Resources._65f04974498ef_1710246326_65f04974498e3;
            this.portal.Location = new System.Drawing.Point(659, 240);
            this.portal.Name = "portal";
            this.portal.Size = new System.Drawing.Size(130, 130);
            this.portal.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "Игра приостановлена";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSalmon;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(318, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 37);
            this.button2.TabIndex = 19;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(318, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 34);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(786, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portal);
            this.Controls.Add(this.coins1);
            this.Controls.Add(this.character1);
            this.Controls.Add(this.svitok);
            this.Controls.Add(this.labelCoins);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private PictureBox pictureBox1;
        private Label svitok;
        private Label character1;
        private Label coins1;
        private Label portal;


        
        private void Form1_Load(object sender, EventArgs e)
        {
            // Code to execute when Form1 is loaded
        }

        /*private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Code to handle key down events in Form1
        }*/

        private void label1_Click_2(object sender, EventArgs e)
        {
            // Code to handle click events on labelCoins
        }

        private Label label2;
        private Button button2;
        private Button button1;
    }
}

