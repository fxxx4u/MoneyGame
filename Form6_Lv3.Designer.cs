namespace ммонетка
{
    partial class Form6_Lv3
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
            this.labelCoins = new System.Windows.Forms.Label();
            this.Heath = new System.Windows.Forms.Label();
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.enemyHealthBar = new System.Windows.Forms.ProgressBar();
            this.Health2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vrag = new System.Windows.Forms.Label();
            this.coins = new System.Windows.Forms.Label();
            this.coin = new System.Windows.Forms.Label();
            this.character6 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.svitok = new System.Windows.Forms.Label();
            this.portal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
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
            this.labelCoins.Click += new System.EventHandler(this.labelCoins_Click);
            // 
            // Heath
            // 
            this.Heath.AutoSize = true;
            this.Heath.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Heath.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Heath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Heath.Location = new System.Drawing.Point(154, 8);
            this.Heath.Name = "Heath";
            this.Heath.Size = new System.Drawing.Size(70, 26);
            this.Heath.TabIndex = 6;
            this.Heath.Text = "Health";
            this.Heath.Click += new System.EventHandler(this.Heath_Click);
            // 
            // HealthBar
            // 
            this.HealthBar.Location = new System.Drawing.Point(230, 8);
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Size = new System.Drawing.Size(152, 26);
            this.HealthBar.TabIndex = 7;
            this.HealthBar.Value = 100;
            // 
            // enemyHealthBar
            // 
            this.enemyHealthBar.Location = new System.Drawing.Point(556, 8);
            this.enemyHealthBar.Name = "enemyHealthBar";
            this.enemyHealthBar.Size = new System.Drawing.Size(150, 21);
            this.enemyHealthBar.TabIndex = 8;
            this.enemyHealthBar.Value = 100;
            // 
            // Health2
            // 
            this.Health2.AutoSize = true;
            this.Health2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Health2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Health2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Health2.Location = new System.Drawing.Point(446, 9);
            this.Health2.Name = "Health2";
            this.Health2.Size = new System.Drawing.Size(104, 20);
            this.Health2.TabIndex = 9;
            this.Health2.Text = "Enemy Health";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(165, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Нажимайте пробел, чтобы убить противника";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(230, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "Игра приостановлена";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // vrag
            // 
            this.vrag.BackColor = System.Drawing.Color.Transparent;
            this.vrag.ForeColor = System.Drawing.Color.Transparent;
            this.vrag.Image = global::ммонетка.Properties.Resources._65e8459795dc5_1709721069_65e8459795dbe;
            this.vrag.Location = new System.Drawing.Point(480, 296);
            this.vrag.Name = "vrag";
            this.vrag.Size = new System.Drawing.Size(86, 80);
            this.vrag.TabIndex = 5;
            // 
            // coins
            // 
            this.coins.BackColor = System.Drawing.Color.Transparent;
            this.coins.Cursor = System.Windows.Forms.Cursors.No;
            this.coins.ForeColor = System.Drawing.Color.Transparent;
            this.coins.Image = global::ммонетка.Properties.Resources._65e84855db0e3_1709721753_65e84855db0dd__1_;
            this.coins.Location = new System.Drawing.Point(375, 319);
            this.coins.Name = "coins";
            this.coins.Size = new System.Drawing.Size(30, 25);
            this.coins.TabIndex = 3;
            this.coins.Click += new System.EventHandler(this.label1_Click_1);
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
            // character6
            // 
            this.character6.BackColor = System.Drawing.Color.Transparent;
            this.character6.Image = global::ммонетка.Properties.Resources._8c6c6c40949011_57931d719e13a;
            this.character6.Location = new System.Drawing.Point(28, 276);
            this.character6.Name = "character6";
            this.character6.Size = new System.Drawing.Size(100, 100);
            this.character6.TabIndex = 1;
            this.character6.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox7.Image = global::ммонетка.Properties.Resources._1644513641_20_abrakadabra_fun_p_fon_dlya_klikera_24;
            this.pictureBox7.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(794, 415);
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSalmon;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(338, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 37);
            this.button2.TabIndex = 19;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(338, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 34);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // svitok
            // 
            this.svitok.BackColor = System.Drawing.Color.Transparent;
            this.svitok.Image = global::ммонетка.Properties.Resources._65f04d118da9e_1710247239_65f04d118da8f;
            this.svitok.Location = new System.Drawing.Point(264, 204);
            this.svitok.Name = "svitok";
            this.svitok.Size = new System.Drawing.Size(80, 75);
            this.svitok.TabIndex = 21;
            // 
            // portal
            // 
            this.portal.BackColor = System.Drawing.Color.Transparent;
            this.portal.Image = global::ммонетка.Properties.Resources._65f04974498ef_1710246326_65f04974498e3;
            this.portal.Location = new System.Drawing.Point(659, 246);
            this.portal.Name = "portal";
            this.portal.Size = new System.Drawing.Size(130, 130);
            this.portal.TabIndex = 22;
            // 
            // Form6
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(786, 411);
            this.Controls.Add(this.portal);
            this.Controls.Add(this.svitok);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Health2);
            this.Controls.Add(this.enemyHealthBar);
            this.Controls.Add(this.HealthBar);
            this.Controls.Add(this.Heath);
            this.Controls.Add(this.vrag);
            this.Controls.Add(this.labelCoins);
            this.Controls.Add(this.coins);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.character6);
            this.Controls.Add(this.pictureBox7);
            this.Name = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form6_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fon;
        private System.Windows.Forms.Label person;
        private System.Windows.Forms.Label character6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label coin;
        private System.Windows.Forms.Label coins;
        private System.Windows.Forms.Label labelCoins;
        private System.Windows.Forms.Label vrag;
        private System.Windows.Forms.Label Heath;
        private System.Windows.Forms.ProgressBar HealthBar;
        private System.Windows.Forms.ProgressBar enemyHealthBar;
        private System.Windows.Forms.Label Health2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label svitok;
        private System.Windows.Forms.Label portal;
    }
}
