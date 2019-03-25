namespace Lab2NarackaNaPica
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
            this.gbGolemina = new System.Windows.Forms.GroupBox();
            this.rbGolema = new System.Windows.Forms.RadioButton();
            this.rbSredna = new System.Windows.Forms.RadioButton();
            this.rbMala = new System.Windows.Forms.RadioButton();
            this.tbGolema = new System.Windows.Forms.TextBox();
            this.tbSredna = new System.Windows.Forms.TextBox();
            this.tbMala = new System.Windows.Forms.TextBox();
            this.gbDodatoci = new System.Windows.Forms.GroupBox();
            this.cbKechap = new System.Windows.Forms.CheckBox();
            this.cbEkstraSirenje = new System.Windows.Forms.CheckBox();
            this.cbFeferonki = new System.Windows.Forms.CheckBox();
            this.tbKechap = new System.Windows.Forms.TextBox();
            this.tbEkstraSirenje = new System.Windows.Forms.TextBox();
            this.tbFeferonki = new System.Windows.Forms.TextBox();
            this.gbPijalok = new System.Windows.Forms.GroupBox();
            this.tbVkupnoPivo = new System.Windows.Forms.TextBox();
            this.tbCenaPivo = new System.Windows.Forms.TextBox();
            this.tbVkupnoSokJabolko = new System.Windows.Forms.TextBox();
            this.tbPivo = new System.Windows.Forms.TextBox();
            this.tbVkupnoKokaKola = new System.Windows.Forms.TextBox();
            this.lblVkupno = new System.Windows.Forms.Label();
            this.tbCenaSokJabolko = new System.Windows.Forms.TextBox();
            this.lblPivo = new System.Windows.Forms.Label();
            this.tbCenaKokaKola = new System.Windows.Forms.TextBox();
            this.lblCena = new System.Windows.Forms.Label();
            this.tbSokJabolko = new System.Windows.Forms.TextBox();
            this.lblSokJabolko = new System.Windows.Forms.Label();
            this.tbKokaKola = new System.Windows.Forms.TextBox();
            this.lblKokaKola = new System.Windows.Forms.Label();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.gbNaplata = new System.Windows.Forms.GroupBox();
            this.lblZaVrakjanje = new System.Windows.Forms.Label();
            this.lblNaplateno = new System.Windows.Forms.Label();
            this.lblVkupnoZaPlakjanje = new System.Windows.Forms.Label();
            this.tbZaVrakjanje = new System.Windows.Forms.TextBox();
            this.tbNaplateno = new System.Windows.Forms.TextBox();
            this.tbVkupnoZaPlakjanje = new System.Windows.Forms.TextBox();
            this.gbDesert = new System.Windows.Forms.GroupBox();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnNaracaj = new System.Windows.Forms.Button();
            this.lbDeserti = new System.Windows.Forms.ListBox();
            this.lblCenaDesert = new System.Windows.Forms.Label();
            this.tbCenaDesert = new System.Windows.Forms.TextBox();
            this.gbGolemina.SuspendLayout();
            this.gbDodatoci.SuspendLayout();
            this.gbPijalok.SuspendLayout();
            this.gbNaplata.SuspendLayout();
            this.gbDesert.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGolemina
            // 
            this.gbGolemina.Controls.Add(this.rbGolema);
            this.gbGolemina.Controls.Add(this.rbSredna);
            this.gbGolemina.Controls.Add(this.rbMala);
            this.gbGolemina.Controls.Add(this.tbGolema);
            this.gbGolemina.Controls.Add(this.tbSredna);
            this.gbGolemina.Controls.Add(this.tbMala);
            this.gbGolemina.Location = new System.Drawing.Point(12, 12);
            this.gbGolemina.Name = "gbGolemina";
            this.gbGolemina.Size = new System.Drawing.Size(259, 100);
            this.gbGolemina.TabIndex = 0;
            this.gbGolemina.TabStop = false;
            this.gbGolemina.Text = "Големина";
            // 
            // rbGolema
            // 
            this.rbGolema.AutoSize = true;
            this.rbGolema.Location = new System.Drawing.Point(7, 74);
            this.rbGolema.Name = "rbGolema";
            this.rbGolema.Size = new System.Drawing.Size(63, 17);
            this.rbGolema.TabIndex = 2;
            this.rbGolema.Text = "Голема";
            this.rbGolema.UseVisualStyleBackColor = true;
            this.rbGolema.CheckedChanged += new System.EventHandler(this.rbGolema_CheckedChanged);
            // 
            // rbSredna
            // 
            this.rbSredna.AutoSize = true;
            this.rbSredna.Location = new System.Drawing.Point(7, 47);
            this.rbSredna.Name = "rbSredna";
            this.rbSredna.Size = new System.Drawing.Size(62, 17);
            this.rbSredna.TabIndex = 1;
            this.rbSredna.Text = "Средна";
            this.rbSredna.UseVisualStyleBackColor = true;
            this.rbSredna.CheckedChanged += new System.EventHandler(this.rbSredna_CheckedChanged);
            // 
            // rbMala
            // 
            this.rbMala.AutoSize = true;
            this.rbMala.Checked = true;
            this.rbMala.Location = new System.Drawing.Point(7, 20);
            this.rbMala.Name = "rbMala";
            this.rbMala.Size = new System.Drawing.Size(52, 17);
            this.rbMala.TabIndex = 0;
            this.rbMala.TabStop = true;
            this.rbMala.Text = "Мала";
            this.rbMala.UseVisualStyleBackColor = true;
            this.rbMala.CheckedChanged += new System.EventHandler(this.rbMala_CheckedChanged);
            // 
            // tbGolema
            // 
            this.tbGolema.Location = new System.Drawing.Point(153, 71);
            this.tbGolema.Name = "tbGolema";
            this.tbGolema.Size = new System.Drawing.Size(100, 20);
            this.tbGolema.TabIndex = 5;
            this.tbGolema.Text = "500";
            // 
            // tbSredna
            // 
            this.tbSredna.Location = new System.Drawing.Point(153, 44);
            this.tbSredna.Name = "tbSredna";
            this.tbSredna.Size = new System.Drawing.Size(100, 20);
            this.tbSredna.TabIndex = 4;
            this.tbSredna.Text = "300";
            // 
            // tbMala
            // 
            this.tbMala.Location = new System.Drawing.Point(153, 16);
            this.tbMala.Name = "tbMala";
            this.tbMala.Size = new System.Drawing.Size(100, 20);
            this.tbMala.TabIndex = 3;
            this.tbMala.Text = "200";
            // 
            // gbDodatoci
            // 
            this.gbDodatoci.Controls.Add(this.cbKechap);
            this.gbDodatoci.Controls.Add(this.cbEkstraSirenje);
            this.gbDodatoci.Controls.Add(this.cbFeferonki);
            this.gbDodatoci.Controls.Add(this.tbKechap);
            this.gbDodatoci.Controls.Add(this.tbEkstraSirenje);
            this.gbDodatoci.Controls.Add(this.tbFeferonki);
            this.gbDodatoci.Location = new System.Drawing.Point(289, 12);
            this.gbDodatoci.Name = "gbDodatoci";
            this.gbDodatoci.Size = new System.Drawing.Size(260, 100);
            this.gbDodatoci.TabIndex = 1;
            this.gbDodatoci.TabStop = false;
            this.gbDodatoci.Text = "Додатоци";
            // 
            // cbKechap
            // 
            this.cbKechap.AutoSize = true;
            this.cbKechap.Location = new System.Drawing.Point(7, 73);
            this.cbKechap.Name = "cbKechap";
            this.cbKechap.Size = new System.Drawing.Size(56, 17);
            this.cbKechap.TabIndex = 2;
            this.cbKechap.Text = "Кечап";
            this.cbKechap.UseVisualStyleBackColor = true;
            this.cbKechap.CheckedChanged += new System.EventHandler(this.cbKechap_CheckedChanged);
            // 
            // cbEkstraSirenje
            // 
            this.cbEkstraSirenje.AutoSize = true;
            this.cbEkstraSirenje.Location = new System.Drawing.Point(7, 46);
            this.cbEkstraSirenje.Name = "cbEkstraSirenje";
            this.cbEkstraSirenje.Size = new System.Drawing.Size(105, 17);
            this.cbEkstraSirenje.TabIndex = 1;
            this.cbEkstraSirenje.Text = "Екстра сирење";
            this.cbEkstraSirenje.UseVisualStyleBackColor = true;
            this.cbEkstraSirenje.CheckedChanged += new System.EventHandler(this.cbEkstraSirenje_CheckedChanged);
            // 
            // cbFeferonki
            // 
            this.cbFeferonki.AutoSize = true;
            this.cbFeferonki.Location = new System.Drawing.Point(7, 19);
            this.cbFeferonki.Name = "cbFeferonki";
            this.cbFeferonki.Size = new System.Drawing.Size(87, 17);
            this.cbFeferonki.TabIndex = 0;
            this.cbFeferonki.Text = "Феферонки";
            this.cbFeferonki.UseVisualStyleBackColor = true;
            this.cbFeferonki.CheckedChanged += new System.EventHandler(this.cbFeferonki_CheckedChanged);
            // 
            // tbKechap
            // 
            this.tbKechap.Location = new System.Drawing.Point(154, 71);
            this.tbKechap.Name = "tbKechap";
            this.tbKechap.Size = new System.Drawing.Size(100, 20);
            this.tbKechap.TabIndex = 5;
            this.tbKechap.Text = "20";
            // 
            // tbEkstraSirenje
            // 
            this.tbEkstraSirenje.Location = new System.Drawing.Point(154, 44);
            this.tbEkstraSirenje.Name = "tbEkstraSirenje";
            this.tbEkstraSirenje.Size = new System.Drawing.Size(100, 20);
            this.tbEkstraSirenje.TabIndex = 4;
            this.tbEkstraSirenje.Text = "30";
            // 
            // tbFeferonki
            // 
            this.tbFeferonki.Location = new System.Drawing.Point(154, 16);
            this.tbFeferonki.Name = "tbFeferonki";
            this.tbFeferonki.Size = new System.Drawing.Size(100, 20);
            this.tbFeferonki.TabIndex = 3;
            this.tbFeferonki.Text = "40";
            // 
            // gbPijalok
            // 
            this.gbPijalok.Controls.Add(this.tbVkupnoPivo);
            this.gbPijalok.Controls.Add(this.tbCenaPivo);
            this.gbPijalok.Controls.Add(this.tbVkupnoSokJabolko);
            this.gbPijalok.Controls.Add(this.tbPivo);
            this.gbPijalok.Controls.Add(this.tbVkupnoKokaKola);
            this.gbPijalok.Controls.Add(this.lblVkupno);
            this.gbPijalok.Controls.Add(this.tbCenaSokJabolko);
            this.gbPijalok.Controls.Add(this.lblPivo);
            this.gbPijalok.Controls.Add(this.tbCenaKokaKola);
            this.gbPijalok.Controls.Add(this.lblCena);
            this.gbPijalok.Controls.Add(this.tbSokJabolko);
            this.gbPijalok.Controls.Add(this.lblSokJabolko);
            this.gbPijalok.Controls.Add(this.tbKokaKola);
            this.gbPijalok.Controls.Add(this.lblKokaKola);
            this.gbPijalok.Controls.Add(this.lblKolicina);
            this.gbPijalok.Location = new System.Drawing.Point(12, 128);
            this.gbPijalok.Name = "gbPijalok";
            this.gbPijalok.Size = new System.Drawing.Size(537, 124);
            this.gbPijalok.TabIndex = 2;
            this.gbPijalok.TabStop = false;
            this.gbPijalok.Text = "Пијалок";
            // 
            // tbVkupnoPivo
            // 
            this.tbVkupnoPivo.Enabled = false;
            this.tbVkupnoPivo.Location = new System.Drawing.Point(431, 93);
            this.tbVkupnoPivo.Name = "tbVkupnoPivo";
            this.tbVkupnoPivo.Size = new System.Drawing.Size(100, 20);
            this.tbVkupnoPivo.TabIndex = 11;
            // 
            // tbCenaPivo
            // 
            this.tbCenaPivo.Location = new System.Drawing.Point(298, 93);
            this.tbCenaPivo.Name = "tbCenaPivo";
            this.tbCenaPivo.Size = new System.Drawing.Size(100, 20);
            this.tbCenaPivo.TabIndex = 8;
            this.tbCenaPivo.Text = "80";
            // 
            // tbVkupnoSokJabolko
            // 
            this.tbVkupnoSokJabolko.Enabled = false;
            this.tbVkupnoSokJabolko.Location = new System.Drawing.Point(431, 66);
            this.tbVkupnoSokJabolko.Name = "tbVkupnoSokJabolko";
            this.tbVkupnoSokJabolko.Size = new System.Drawing.Size(100, 20);
            this.tbVkupnoSokJabolko.TabIndex = 10;
            // 
            // tbPivo
            // 
            this.tbPivo.Location = new System.Drawing.Point(160, 93);
            this.tbPivo.Name = "tbPivo";
            this.tbPivo.Size = new System.Drawing.Size(100, 20);
            this.tbPivo.TabIndex = 5;
            this.tbPivo.Text = "0";
            this.tbPivo.TextChanged += new System.EventHandler(this.tbPivo_TextChanged);
            // 
            // tbVkupnoKokaKola
            // 
            this.tbVkupnoKokaKola.Enabled = false;
            this.tbVkupnoKokaKola.Location = new System.Drawing.Point(431, 39);
            this.tbVkupnoKokaKola.Name = "tbVkupnoKokaKola";
            this.tbVkupnoKokaKola.Size = new System.Drawing.Size(100, 20);
            this.tbVkupnoKokaKola.TabIndex = 9;
            // 
            // lblVkupno
            // 
            this.lblVkupno.AutoSize = true;
            this.lblVkupno.Location = new System.Drawing.Point(458, 16);
            this.lblVkupno.Name = "lblVkupno";
            this.lblVkupno.Size = new System.Drawing.Size(43, 13);
            this.lblVkupno.TabIndex = 14;
            this.lblVkupno.Text = "Вкупно";
            // 
            // tbCenaSokJabolko
            // 
            this.tbCenaSokJabolko.Location = new System.Drawing.Point(298, 66);
            this.tbCenaSokJabolko.Name = "tbCenaSokJabolko";
            this.tbCenaSokJabolko.Size = new System.Drawing.Size(100, 20);
            this.tbCenaSokJabolko.TabIndex = 7;
            this.tbCenaSokJabolko.Text = "70";
            // 
            // lblPivo
            // 
            this.lblPivo.AutoSize = true;
            this.lblPivo.Location = new System.Drawing.Point(6, 93);
            this.lblPivo.Name = "lblPivo";
            this.lblPivo.Size = new System.Drawing.Size(33, 13);
            this.lblPivo.TabIndex = 2;
            this.lblPivo.Text = "Пиво";
            // 
            // tbCenaKokaKola
            // 
            this.tbCenaKokaKola.Location = new System.Drawing.Point(298, 39);
            this.tbCenaKokaKola.Name = "tbCenaKokaKola";
            this.tbCenaKokaKola.Size = new System.Drawing.Size(100, 20);
            this.tbCenaKokaKola.TabIndex = 6;
            this.tbCenaKokaKola.Text = "60";
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(325, 16);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(33, 13);
            this.lblCena.TabIndex = 13;
            this.lblCena.Text = "Цена";
            // 
            // tbSokJabolko
            // 
            this.tbSokJabolko.Location = new System.Drawing.Point(160, 66);
            this.tbSokJabolko.Name = "tbSokJabolko";
            this.tbSokJabolko.Size = new System.Drawing.Size(100, 20);
            this.tbSokJabolko.TabIndex = 4;
            this.tbSokJabolko.Text = "0";
            this.tbSokJabolko.TextChanged += new System.EventHandler(this.tbSokJabolko_TextChanged);
            // 
            // lblSokJabolko
            // 
            this.lblSokJabolko.AutoSize = true;
            this.lblSokJabolko.Location = new System.Drawing.Point(6, 66);
            this.lblSokJabolko.Name = "lblSokJabolko";
            this.lblSokJabolko.Size = new System.Drawing.Size(140, 13);
            this.lblSokJabolko.TabIndex = 1;
            this.lblSokJabolko.Text = "Сок од јаболко / портокал";
            // 
            // tbKokaKola
            // 
            this.tbKokaKola.Location = new System.Drawing.Point(160, 39);
            this.tbKokaKola.Name = "tbKokaKola";
            this.tbKokaKola.Size = new System.Drawing.Size(100, 20);
            this.tbKokaKola.TabIndex = 3;
            this.tbKokaKola.Text = "0";
            this.tbKokaKola.TextChanged += new System.EventHandler(this.tbKokaKola_TextChanged);
            // 
            // lblKokaKola
            // 
            this.lblKokaKola.AutoSize = true;
            this.lblKokaKola.Location = new System.Drawing.Point(6, 39);
            this.lblKokaKola.Name = "lblKokaKola";
            this.lblKokaKola.Size = new System.Drawing.Size(148, 13);
            this.lblKokaKola.TabIndex = 0;
            this.lblKokaKola.Text = "Кока Кола / Фанта / Спрајт";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(157, 16);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(55, 13);
            this.lblKolicina.TabIndex = 12;
            this.lblKolicina.Text = "Количина";
            // 
            // gbNaplata
            // 
            this.gbNaplata.Controls.Add(this.lblZaVrakjanje);
            this.gbNaplata.Controls.Add(this.lblNaplateno);
            this.gbNaplata.Controls.Add(this.lblVkupnoZaPlakjanje);
            this.gbNaplata.Controls.Add(this.tbZaVrakjanje);
            this.gbNaplata.Controls.Add(this.tbNaplateno);
            this.gbNaplata.Controls.Add(this.tbVkupnoZaPlakjanje);
            this.gbNaplata.Location = new System.Drawing.Point(295, 274);
            this.gbNaplata.Name = "gbNaplata";
            this.gbNaplata.Size = new System.Drawing.Size(254, 127);
            this.gbNaplata.TabIndex = 4;
            this.gbNaplata.TabStop = false;
            this.gbNaplata.Text = "Наплата";
            // 
            // lblZaVrakjanje
            // 
            this.lblZaVrakjanje.AutoSize = true;
            this.lblZaVrakjanje.Location = new System.Drawing.Point(9, 91);
            this.lblZaVrakjanje.Name = "lblZaVrakjanje";
            this.lblZaVrakjanje.Size = new System.Drawing.Size(72, 13);
            this.lblZaVrakjanje.TabIndex = 4;
            this.lblZaVrakjanje.Text = "За враќање:";
            // 
            // lblNaplateno
            // 
            this.lblNaplateno.AutoSize = true;
            this.lblNaplateno.Location = new System.Drawing.Point(9, 57);
            this.lblNaplateno.Name = "lblNaplateno";
            this.lblNaplateno.Size = new System.Drawing.Size(65, 13);
            this.lblNaplateno.TabIndex = 2;
            this.lblNaplateno.Text = "Наплатено:";
            // 
            // lblVkupnoZaPlakjanje
            // 
            this.lblVkupnoZaPlakjanje.AutoSize = true;
            this.lblVkupnoZaPlakjanje.Location = new System.Drawing.Point(9, 23);
            this.lblVkupnoZaPlakjanje.Name = "lblVkupnoZaPlakjanje";
            this.lblVkupnoZaPlakjanje.Size = new System.Drawing.Size(110, 13);
            this.lblVkupnoZaPlakjanje.TabIndex = 0;
            this.lblVkupnoZaPlakjanje.Text = "Вкупно за плаќање:";
            // 
            // tbZaVrakjanje
            // 
            this.tbZaVrakjanje.Location = new System.Drawing.Point(148, 88);
            this.tbZaVrakjanje.Name = "tbZaVrakjanje";
            this.tbZaVrakjanje.Size = new System.Drawing.Size(100, 20);
            this.tbZaVrakjanje.TabIndex = 5;
            this.tbZaVrakjanje.Text = "0";
            // 
            // tbNaplateno
            // 
            this.tbNaplateno.Location = new System.Drawing.Point(148, 54);
            this.tbNaplateno.Name = "tbNaplateno";
            this.tbNaplateno.Size = new System.Drawing.Size(100, 20);
            this.tbNaplateno.TabIndex = 3;
            this.tbNaplateno.Text = "0";
            this.tbNaplateno.TextChanged += new System.EventHandler(this.tbNaplateno_TextChanged);
            // 
            // tbVkupnoZaPlakjanje
            // 
            this.tbVkupnoZaPlakjanje.Enabled = false;
            this.tbVkupnoZaPlakjanje.Location = new System.Drawing.Point(148, 20);
            this.tbVkupnoZaPlakjanje.Name = "tbVkupnoZaPlakjanje";
            this.tbVkupnoZaPlakjanje.Size = new System.Drawing.Size(100, 20);
            this.tbVkupnoZaPlakjanje.TabIndex = 1;
            this.tbVkupnoZaPlakjanje.Text = "200";
            // 
            // gbDesert
            // 
            this.gbDesert.Controls.Add(this.btnOtkazi);
            this.gbDesert.Controls.Add(this.btnNaracaj);
            this.gbDesert.Controls.Add(this.lbDeserti);
            this.gbDesert.Controls.Add(this.lblCenaDesert);
            this.gbDesert.Controls.Add(this.tbCenaDesert);
            this.gbDesert.Location = new System.Drawing.Point(12, 274);
            this.gbDesert.Name = "gbDesert";
            this.gbDesert.Size = new System.Drawing.Size(271, 127);
            this.gbDesert.TabIndex = 3;
            this.gbDesert.TabStop = false;
            this.gbDesert.Text = "Десерт";
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(138, 91);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(115, 23);
            this.btnOtkazi.TabIndex = 4;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnNaracaj
            // 
            this.btnNaracaj.Location = new System.Drawing.Point(138, 61);
            this.btnNaracaj.Name = "btnNaracaj";
            this.btnNaracaj.Size = new System.Drawing.Size(115, 23);
            this.btnNaracaj.TabIndex = 3;
            this.btnNaracaj.Text = "Нарачај";
            this.btnNaracaj.UseVisualStyleBackColor = true;
            this.btnNaracaj.Click += new System.EventHandler(this.btnNaracaj_Click);
            // 
            // lbDeserti
            // 
            this.lbDeserti.FormattingEnabled = true;
            this.lbDeserti.Items.AddRange(new object[] {
            "Овошна пита",
            "Сладолед",
            "Торта"});
            this.lbDeserti.Location = new System.Drawing.Point(9, 20);
            this.lbDeserti.Name = "lbDeserti";
            this.lbDeserti.Size = new System.Drawing.Size(120, 95);
            this.lbDeserti.TabIndex = 0;
            this.lbDeserti.SelectedIndexChanged += new System.EventHandler(this.lbDeserti_SelectedIndexChanged);
            // 
            // lblCenaDesert
            // 
            this.lblCenaDesert.AutoSize = true;
            this.lblCenaDesert.Location = new System.Drawing.Point(135, 19);
            this.lblCenaDesert.Name = "lblCenaDesert";
            this.lblCenaDesert.Size = new System.Drawing.Size(89, 13);
            this.lblCenaDesert.TabIndex = 1;
            this.lblCenaDesert.Text = "Цена на десерт:";
            // 
            // tbCenaDesert
            // 
            this.tbCenaDesert.Location = new System.Drawing.Point(138, 35);
            this.tbCenaDesert.Name = "tbCenaDesert";
            this.tbCenaDesert.Size = new System.Drawing.Size(115, 20);
            this.tbCenaDesert.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 416);
            this.Controls.Add(this.gbNaplata);
            this.Controls.Add(this.gbDesert);
            this.Controls.Add(this.gbPijalok);
            this.Controls.Add(this.gbDodatoci);
            this.Controls.Add(this.gbGolemina);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbGolemina.ResumeLayout(false);
            this.gbGolemina.PerformLayout();
            this.gbDodatoci.ResumeLayout(false);
            this.gbDodatoci.PerformLayout();
            this.gbPijalok.ResumeLayout(false);
            this.gbPijalok.PerformLayout();
            this.gbNaplata.ResumeLayout(false);
            this.gbNaplata.PerformLayout();
            this.gbDesert.ResumeLayout(false);
            this.gbDesert.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGolemina;
        private System.Windows.Forms.RadioButton rbGolema;
        private System.Windows.Forms.RadioButton rbSredna;
        private System.Windows.Forms.RadioButton rbMala;
        private System.Windows.Forms.TextBox tbGolema;
        private System.Windows.Forms.TextBox tbSredna;
        private System.Windows.Forms.TextBox tbMala;
        private System.Windows.Forms.GroupBox gbDodatoci;
        private System.Windows.Forms.CheckBox cbKechap;
        private System.Windows.Forms.CheckBox cbEkstraSirenje;
        private System.Windows.Forms.CheckBox cbFeferonki;
        private System.Windows.Forms.TextBox tbKechap;
        private System.Windows.Forms.TextBox tbEkstraSirenje;
        private System.Windows.Forms.TextBox tbFeferonki;
        private System.Windows.Forms.GroupBox gbPijalok;
        private System.Windows.Forms.TextBox tbCenaPivo;
        private System.Windows.Forms.TextBox tbPivo;
        private System.Windows.Forms.TextBox tbCenaSokJabolko;
        private System.Windows.Forms.Label lblPivo;
        private System.Windows.Forms.TextBox tbCenaKokaKola;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.TextBox tbSokJabolko;
        private System.Windows.Forms.Label lblSokJabolko;
        private System.Windows.Forms.TextBox tbKokaKola;
        private System.Windows.Forms.Label lblKokaKola;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.TextBox tbVkupnoPivo;
        private System.Windows.Forms.TextBox tbVkupnoSokJabolko;
        private System.Windows.Forms.TextBox tbVkupnoKokaKola;
        private System.Windows.Forms.Label lblVkupno;
        private System.Windows.Forms.GroupBox gbNaplata;
        private System.Windows.Forms.Label lblZaVrakjanje;
        private System.Windows.Forms.Label lblNaplateno;
        private System.Windows.Forms.Label lblVkupnoZaPlakjanje;
        private System.Windows.Forms.TextBox tbZaVrakjanje;
        private System.Windows.Forms.TextBox tbNaplateno;
        private System.Windows.Forms.TextBox tbVkupnoZaPlakjanje;
        private System.Windows.Forms.GroupBox gbDesert;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnNaracaj;
        private System.Windows.Forms.ListBox lbDeserti;
        private System.Windows.Forms.Label lblCenaDesert;
        private System.Windows.Forms.TextBox tbCenaDesert;
    }
}

