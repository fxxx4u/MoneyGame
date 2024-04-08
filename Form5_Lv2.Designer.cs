using System;

namespace ммонетка
{
    partial class Form5_Lv2
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.coin = new System.Windows.Forms.Label();
            this.character5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.coins5 = new System.Windows.Forms.Label();
            this.labelCoins = new System.Windows.Forms.Label();
            this.portal = new System.Windows.Forms.Label();
            this.svitok = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.Color.Transparent;
            this.coin.Image = global::ммонетка.Properties.Resources.gratis_png_dibujo_de_monedas_de_;
            this.coin.Location = new System.Drawing.Point(-550, 401);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(50, 25);
            this.coin.TabIndex = 2;
            // 
            // character5
            // 
            this.character5.BackColor = System.Drawing.Color.Transparent;
            this.character5.Image = global::ммонетка.Properties.Resources._8c6c6c40949011_57931d719e13a;
            this.character5.Location = new System.Drawing.Point(16, 276);
            this.character5.Name = "character5";
            this.character5.Size = new System.Drawing.Size(100, 100);
            this.character5.TabIndex = 1;
            this.character5.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox5.Image = global::ммонетка.Properties.Resources._1644513641_20_abrakadabra_fun_p_fon_dlya_klikera_24;
            this.pictureBox5.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(794, 415);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // coins5
            // 
            this.coins5.BackColor = System.Drawing.Color.Transparent;
            this.coins5.Cursor = System.Windows.Forms.Cursors.No;
            this.coins5.Image = global::ммонетка.Properties.Resources._65e84855db0e3_1709721753_65e84855db0dd__1_;
            this.coins5.Location = new System.Drawing.Point(375, 319);
            this.coins5.Name = "coins5";
            this.coins5.Size = new System.Drawing.Size(30, 25);
            this.coins5.TabIndex = 3;
            this.coins5.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelCoins
            // 
            this.labelCoins.AutoSize = true;
            this.labelCoins.BackColor = System.Drawing.Color.LightSeaGreen;
            this.labelCoins.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoins.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCoins.Location = new System.Drawing.Point(3, 8);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.Size = new System.Drawing.Size(113, 28);
            this.labelCoins.TabIndex = 4;
            this.labelCoins.Text = "Монеты: 0";
            this.labelCoins.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // portal
            // 
            this.portal.BackColor = System.Drawing.Color.Transparent;
            this.portal.Image = global::ммонетка.Properties.Resources._65f04974498ef_1710246326_65f04974498e3;
            this.portal.Location = new System.Drawing.Point(659, 246);
            this.portal.Name = "portal";
            this.portal.Size = new System.Drawing.Size(130, 130);
            this.portal.TabIndex = 13;
            // 
            // svitok
            // 
            this.svitok.BackColor = System.Drawing.Color.Transparent;
            this.svitok.Image = global::ммонетка.Properties.Resources._65f04d118da9e_1710247239_65f04d118da8f;
            this.svitok.Location = new System.Drawing.Point(398, 222);
            this.svitok.Name = "svitok";
            this.svitok.Size = new System.Drawing.Size(80, 75);
            this.svitok.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(232, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Игра приостановлена";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSalmon;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(331, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 37);
            this.button2.TabIndex = 18;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(331, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 34);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(786, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.svitok);
            this.Controls.Add(this.portal);
            this.Controls.Add(this.labelCoins);
            this.Controls.Add(this.coins5);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.character5);
            this.Controls.Add(this.pictureBox5);
            this.Name = "Form5";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form5_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fon;
        private System.Windows.Forms.Label person;
        private System.Windows.Forms.Label character5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label coin;
        private System.Windows.Forms.Label coins5;
        private System.Windows.Forms.Label labelCoins;
        private System.Windows.Forms.Label portal;
        private System.Windows.Forms.Label svitok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

