namespace Avtomobili
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIzbrisiAvtomobil = new System.Windows.Forms.Button();
            this.btnDodadiAvtomobil = new System.Windows.Forms.Button();
            this.nudCena = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudPotrosuvacka = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMarka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDodadiMarka = new System.Windows.Forms.Button();
            this.lbMarki = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbNajskap = new System.Windows.Forms.TextBox();
            this.tbNajekonomicen = new System.Windows.Forms.TextBox();
            this.tbProsecnaPotrosuvacka = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbAvtomobili = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPotrosuvacka)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIzbrisiAvtomobil);
            this.groupBox1.Controls.Add(this.btnDodadiAvtomobil);
            this.groupBox1.Controls.Add(this.nudCena);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudPotrosuvacka);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbModel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbMarka);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Нов автомобил:";
            // 
            // btnIzbrisiAvtomobil
            // 
            this.btnIzbrisiAvtomobil.Location = new System.Drawing.Point(170, 204);
            this.btnIzbrisiAvtomobil.Name = "btnIzbrisiAvtomobil";
            this.btnIzbrisiAvtomobil.Size = new System.Drawing.Size(127, 23);
            this.btnIzbrisiAvtomobil.TabIndex = 9;
            this.btnIzbrisiAvtomobil.Text = "Избриши автомобил";
            this.btnIzbrisiAvtomobil.UseVisualStyleBackColor = true;
            this.btnIzbrisiAvtomobil.Click += new System.EventHandler(this.btnIzbrisiAvtomobil_Click);
            // 
            // btnDodadiAvtomobil
            // 
            this.btnDodadiAvtomobil.Location = new System.Drawing.Point(10, 204);
            this.btnDodadiAvtomobil.Name = "btnDodadiAvtomobil";
            this.btnDodadiAvtomobil.Size = new System.Drawing.Size(154, 23);
            this.btnDodadiAvtomobil.TabIndex = 8;
            this.btnDodadiAvtomobil.Text = "Додади автомобил";
            this.btnDodadiAvtomobil.UseVisualStyleBackColor = true;
            this.btnDodadiAvtomobil.Click += new System.EventHandler(this.btnDodadiAvtomobil_Click);
            // 
            // nudCena
            // 
            this.nudCena.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCena.Location = new System.Drawing.Point(10, 165);
            this.nudCena.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.nudCena.Name = "nudCena";
            this.nudCena.Size = new System.Drawing.Size(120, 20);
            this.nudCena.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цена:";
            // 
            // nudPotrosuvacka
            // 
            this.nudPotrosuvacka.DecimalPlaces = 1;
            this.nudPotrosuvacka.Location = new System.Drawing.Point(10, 125);
            this.nudPotrosuvacka.Name = "nudPotrosuvacka";
            this.nudPotrosuvacka.Size = new System.Drawing.Size(120, 20);
            this.nudPotrosuvacka.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Потрошувачка:";
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(10, 81);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(287, 20);
            this.tbModel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Модел:";
            // 
            // cbMarka
            // 
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.Location = new System.Drawing.Point(10, 36);
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(287, 21);
            this.cbMarka.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Марка:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDodadiMarka);
            this.groupBox2.Controls.Add(this.lbMarki);
            this.groupBox2.Location = new System.Drawing.Point(12, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 167);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Марки на автомобили:";
            // 
            // btnDodadiMarka
            // 
            this.btnDodadiMarka.Location = new System.Drawing.Point(140, 134);
            this.btnDodadiMarka.Name = "btnDodadiMarka";
            this.btnDodadiMarka.Size = new System.Drawing.Size(157, 23);
            this.btnDodadiMarka.TabIndex = 1;
            this.btnDodadiMarka.Text = "Додади нова марка";
            this.btnDodadiMarka.UseVisualStyleBackColor = true;
            this.btnDodadiMarka.Click += new System.EventHandler(this.btnDodadiMarka_Click);
            // 
            // lbMarki
            // 
            this.lbMarki.FormattingEnabled = true;
            this.lbMarki.Location = new System.Drawing.Point(7, 20);
            this.lbMarki.Name = "lbMarki";
            this.lbMarki.Size = new System.Drawing.Size(290, 108);
            this.lbMarki.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbNajskap);
            this.groupBox3.Controls.Add(this.tbNajekonomicen);
            this.groupBox3.Controls.Add(this.tbProsecnaPotrosuvacka);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lbAvtomobili);
            this.groupBox3.Location = new System.Drawing.Point(330, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 411);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Листа на автомобили:";
            // 
            // tbNajskap
            // 
            this.tbNajskap.Enabled = false;
            this.tbNajskap.Location = new System.Drawing.Point(7, 378);
            this.tbNajskap.Name = "tbNajskap";
            this.tbNajskap.Size = new System.Drawing.Size(284, 20);
            this.tbNajskap.TabIndex = 6;
            // 
            // tbNajekonomicen
            // 
            this.tbNajekonomicen.Enabled = false;
            this.tbNajekonomicen.Location = new System.Drawing.Point(7, 327);
            this.tbNajekonomicen.Name = "tbNajekonomicen";
            this.tbNajekonomicen.Size = new System.Drawing.Size(284, 20);
            this.tbNajekonomicen.TabIndex = 5;
            // 
            // tbProsecnaPotrosuvacka
            // 
            this.tbProsecnaPotrosuvacka.Enabled = false;
            this.tbProsecnaPotrosuvacka.Location = new System.Drawing.Point(157, 274);
            this.tbProsecnaPotrosuvacka.Name = "tbProsecnaPotrosuvacka";
            this.tbProsecnaPotrosuvacka.Size = new System.Drawing.Size(134, 20);
            this.tbProsecnaPotrosuvacka.TabIndex = 4;
            this.tbProsecnaPotrosuvacka.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Најскап:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Најекономичен:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Просечна потрошувачка:";
            // 
            // lbAvtomobili
            // 
            this.lbAvtomobili.FormattingEnabled = true;
            this.lbAvtomobili.Location = new System.Drawing.Point(7, 20);
            this.lbAvtomobili.Name = "lbAvtomobili";
            this.lbAvtomobili.Size = new System.Drawing.Size(284, 238);
            this.lbAvtomobili.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 434);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPotrosuvacka)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIzbrisiAvtomobil;
        private System.Windows.Forms.Button btnDodadiAvtomobil;
        private System.Windows.Forms.NumericUpDown nudCena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudPotrosuvacka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMarka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDodadiMarka;
        private System.Windows.Forms.ListBox lbMarki;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbNajskap;
        private System.Windows.Forms.TextBox tbNajekonomicen;
        private System.Windows.Forms.TextBox tbProsecnaPotrosuvacka;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbAvtomobili;
    }
}

