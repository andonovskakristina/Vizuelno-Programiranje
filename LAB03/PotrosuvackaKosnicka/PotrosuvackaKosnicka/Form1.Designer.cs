namespace PotrosuvackaKosnicka
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbListaProdukti = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKategorija = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbKosnicka = new System.Windows.Forms.ListBox();
            this.btnDodadiVoKosnicka = new System.Windows.Forms.Button();
            this.btnIzbrisiOdKosnicka = new System.Windows.Forms.Button();
            this.btnDodadiNovProdukt = new System.Windows.Forms.Button();
            this.btnIzbrisiProdukt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVkupno = new System.Windows.Forms.TextBox();
            this.btnIsprazniListaProdukti = new System.Windows.Forms.Button();
            this.btnIsprazniKosnicka = new System.Windows.Forms.Button();
            this.nudKolicina = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // lbListaProdukti
            // 
            this.lbListaProdukti.FormattingEnabled = true;
            this.lbListaProdukti.Location = new System.Drawing.Point(15, 36);
            this.lbListaProdukti.Name = "lbListaProdukti";
            this.lbListaProdukti.Size = new System.Drawing.Size(238, 316);
            this.lbListaProdukti.TabIndex = 0;
            this.lbListaProdukti.SelectedIndexChanged += new System.EventHandler(this.lbListaProdukti_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Листа на продукти";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCena);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbKategorija);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbIme);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(259, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 159);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Детали за продуктот";
            // 
            // tbCena
            // 
            this.tbCena.Enabled = false;
            this.tbCena.Location = new System.Drawing.Point(10, 123);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(100, 20);
            this.tbCena.TabIndex = 5;
            this.tbCena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Цена:";
            // 
            // tbKategorija
            // 
            this.tbKategorija.Enabled = false;
            this.tbKategorija.Location = new System.Drawing.Point(10, 81);
            this.tbKategorija.Name = "tbKategorija";
            this.tbKategorija.Size = new System.Drawing.Size(210, 20);
            this.tbKategorija.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Категорија:";
            // 
            // tbIme
            // 
            this.tbIme.Enabled = false;
            this.tbIme.Location = new System.Drawing.Point(10, 37);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(210, 20);
            this.tbIme.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Име:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Кошничка";
            // 
            // lbKosnicka
            // 
            this.lbKosnicka.FormattingEnabled = true;
            this.lbKosnicka.Location = new System.Drawing.Point(491, 36);
            this.lbKosnicka.Name = "lbKosnicka";
            this.lbKosnicka.Size = new System.Drawing.Size(238, 264);
            this.lbKosnicka.TabIndex = 4;
            // 
            // btnDodadiVoKosnicka
            // 
            this.btnDodadiVoKosnicka.Location = new System.Drawing.Point(259, 201);
            this.btnDodadiVoKosnicka.Name = "btnDodadiVoKosnicka";
            this.btnDodadiVoKosnicka.Size = new System.Drawing.Size(167, 23);
            this.btnDodadiVoKosnicka.TabIndex = 5;
            this.btnDodadiVoKosnicka.Text = "Додади во кошничка >>";
            this.btnDodadiVoKosnicka.UseVisualStyleBackColor = true;
            this.btnDodadiVoKosnicka.Click += new System.EventHandler(this.btnDodadiVoKosnicka_Click);
            // 
            // btnIzbrisiOdKosnicka
            // 
            this.btnIzbrisiOdKosnicka.Location = new System.Drawing.Point(259, 239);
            this.btnIzbrisiOdKosnicka.Name = "btnIzbrisiOdKosnicka";
            this.btnIzbrisiOdKosnicka.Size = new System.Drawing.Size(226, 23);
            this.btnIzbrisiOdKosnicka.TabIndex = 6;
            this.btnIzbrisiOdKosnicka.Text = "Избриши од кошничка";
            this.btnIzbrisiOdKosnicka.UseVisualStyleBackColor = true;
            this.btnIzbrisiOdKosnicka.Click += new System.EventHandler(this.btnIzbrisiOdKosnicka_Click);
            // 
            // btnDodadiNovProdukt
            // 
            this.btnDodadiNovProdukt.Location = new System.Drawing.Point(259, 277);
            this.btnDodadiNovProdukt.Name = "btnDodadiNovProdukt";
            this.btnDodadiNovProdukt.Size = new System.Drawing.Size(226, 23);
            this.btnDodadiNovProdukt.TabIndex = 7;
            this.btnDodadiNovProdukt.Text = "Додади нов продукт";
            this.btnDodadiNovProdukt.UseVisualStyleBackColor = true;
            this.btnDodadiNovProdukt.Click += new System.EventHandler(this.btnDodadiNovProdukt_Click);
            // 
            // btnIzbrisiProdukt
            // 
            this.btnIzbrisiProdukt.Location = new System.Drawing.Point(259, 315);
            this.btnIzbrisiProdukt.Name = "btnIzbrisiProdukt";
            this.btnIzbrisiProdukt.Size = new System.Drawing.Size(226, 23);
            this.btnIzbrisiProdukt.TabIndex = 8;
            this.btnIzbrisiProdukt.Text = "Избриши продукт";
            this.btnIzbrisiProdukt.UseVisualStyleBackColor = true;
            this.btnIzbrisiProdukt.Click += new System.EventHandler(this.btnIzbrisiProdukt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Вкупно:";
            // 
            // tbVkupno
            // 
            this.tbVkupno.Enabled = false;
            this.tbVkupno.Location = new System.Drawing.Point(552, 317);
            this.tbVkupno.Name = "tbVkupno";
            this.tbVkupno.Size = new System.Drawing.Size(177, 20);
            this.tbVkupno.TabIndex = 10;
            this.tbVkupno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnIsprazniListaProdukti
            // 
            this.btnIsprazniListaProdukti.Location = new System.Drawing.Point(15, 372);
            this.btnIsprazniListaProdukti.Name = "btnIsprazniListaProdukti";
            this.btnIsprazniListaProdukti.Size = new System.Drawing.Size(238, 23);
            this.btnIsprazniListaProdukti.TabIndex = 11;
            this.btnIsprazniListaProdukti.Text = "Испразни ја листата со продукти?";
            this.btnIsprazniListaProdukti.UseVisualStyleBackColor = true;
            this.btnIsprazniListaProdukti.Click += new System.EventHandler(this.btnIsprazniListaProdukti_Click);
            // 
            // btnIsprazniKosnicka
            // 
            this.btnIsprazniKosnicka.Location = new System.Drawing.Point(491, 372);
            this.btnIsprazniKosnicka.Name = "btnIsprazniKosnicka";
            this.btnIsprazniKosnicka.Size = new System.Drawing.Size(238, 23);
            this.btnIsprazniKosnicka.TabIndex = 12;
            this.btnIsprazniKosnicka.Text = "Испразни ја кошничката?";
            this.btnIsprazniKosnicka.UseVisualStyleBackColor = true;
            this.btnIsprazniKosnicka.Click += new System.EventHandler(this.btnIsprazniKosnicka_Click);
            // 
            // nudKolicina
            // 
            this.nudKolicina.Location = new System.Drawing.Point(432, 201);
            this.nudKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKolicina.Name = "nudKolicina";
            this.nudKolicina.Size = new System.Drawing.Size(52, 20);
            this.nudKolicina.TabIndex = 13;
            this.nudKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 409);
            this.Controls.Add(this.nudKolicina);
            this.Controls.Add(this.btnIsprazniKosnicka);
            this.Controls.Add(this.btnIsprazniListaProdukti);
            this.Controls.Add(this.tbVkupno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnIzbrisiProdukt);
            this.Controls.Add(this.btnDodadiNovProdukt);
            this.Controls.Add(this.btnIzbrisiOdKosnicka);
            this.Controls.Add(this.btnDodadiVoKosnicka);
            this.Controls.Add(this.lbKosnicka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbListaProdukti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbListaProdukti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbKosnicka;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbKategorija;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodadiVoKosnicka;
        private System.Windows.Forms.Button btnIzbrisiOdKosnicka;
        private System.Windows.Forms.Button btnDodadiNovProdukt;
        private System.Windows.Forms.Button btnIzbrisiProdukt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbVkupno;
        private System.Windows.Forms.Button btnIsprazniListaProdukti;
        private System.Windows.Forms.Button btnIsprazniKosnicka;
        private System.Windows.Forms.NumericUpDown nudKolicina;
    }
}

