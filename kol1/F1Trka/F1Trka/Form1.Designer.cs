namespace F1Trka
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbVozaci = new System.Windows.Forms.ListBox();
            this.btnDodadiVozac = new System.Windows.Forms.Button();
            this.btnIzbrisiVozac = new System.Windows.Forms.Button();
            this.lbKrugovi = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMinuti = new System.Windows.Forms.NumericUpDown();
            this.nudSekundi = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodadiKrug = new System.Windows.Forms.Button();
            this.tbNajdobarKrug = new System.Windows.Forms.TextBox();
            this.nudVreme = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSekundi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVreme)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIzbrisiVozac);
            this.groupBox1.Controls.Add(this.btnDodadiVozac);
            this.groupBox1.Controls.Add(this.lbVozaci);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 390);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Возачи";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudVreme);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbNajdobarKrug);
            this.groupBox2.Controls.Add(this.btnDodadiKrug);
            this.groupBox2.Controls.Add(this.nudSekundi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nudMinuti);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbKrugovi);
            this.groupBox2.Location = new System.Drawing.Point(346, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 390);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кругови";
            // 
            // lbVozaci
            // 
            this.lbVozaci.FormattingEnabled = true;
            this.lbVozaci.Location = new System.Drawing.Point(7, 20);
            this.lbVozaci.Name = "lbVozaci";
            this.lbVozaci.Size = new System.Drawing.Size(301, 290);
            this.lbVozaci.TabIndex = 0;
            this.lbVozaci.SelectedIndexChanged += new System.EventHandler(this.lbVozaci_SelectedIndexChanged);
            // 
            // btnDodadiVozac
            // 
            this.btnDodadiVozac.Location = new System.Drawing.Point(7, 326);
            this.btnDodadiVozac.Name = "btnDodadiVozac";
            this.btnDodadiVozac.Size = new System.Drawing.Size(301, 23);
            this.btnDodadiVozac.TabIndex = 1;
            this.btnDodadiVozac.Text = "Додади возач";
            this.btnDodadiVozac.UseVisualStyleBackColor = true;
            this.btnDodadiVozac.Click += new System.EventHandler(this.btnDodadiVozac_Click);
            // 
            // btnIzbrisiVozac
            // 
            this.btnIzbrisiVozac.Enabled = false;
            this.btnIzbrisiVozac.Location = new System.Drawing.Point(7, 355);
            this.btnIzbrisiVozac.Name = "btnIzbrisiVozac";
            this.btnIzbrisiVozac.Size = new System.Drawing.Size(301, 23);
            this.btnIzbrisiVozac.TabIndex = 2;
            this.btnIzbrisiVozac.Text = "Избриши возач";
            this.btnIzbrisiVozac.UseVisualStyleBackColor = true;
            this.btnIzbrisiVozac.Click += new System.EventHandler(this.btnIzbrisiVozac_Click);
            // 
            // lbKrugovi
            // 
            this.lbKrugovi.FormattingEnabled = true;
            this.lbKrugovi.Location = new System.Drawing.Point(7, 20);
            this.lbKrugovi.Name = "lbKrugovi";
            this.lbKrugovi.Size = new System.Drawing.Size(301, 225);
            this.lbKrugovi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Најдобар круг";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Минути";
            // 
            // nudMinuti
            // 
            this.nudMinuti.Location = new System.Drawing.Point(7, 269);
            this.nudMinuti.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMinuti.Name = "nudMinuti";
            this.nudMinuti.Size = new System.Drawing.Size(69, 20);
            this.nudMinuti.TabIndex = 4;
            // 
            // nudSekundi
            // 
            this.nudSekundi.Location = new System.Drawing.Point(82, 269);
            this.nudSekundi.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudSekundi.Name = "nudSekundi";
            this.nudSekundi.Size = new System.Drawing.Size(69, 20);
            this.nudSekundi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Секунди";
            // 
            // btnDodadiKrug
            // 
            this.btnDodadiKrug.Enabled = false;
            this.btnDodadiKrug.Location = new System.Drawing.Point(157, 265);
            this.btnDodadiKrug.Name = "btnDodadiKrug";
            this.btnDodadiKrug.Size = new System.Drawing.Size(151, 23);
            this.btnDodadiKrug.TabIndex = 7;
            this.btnDodadiKrug.Text = "Додади круг";
            this.btnDodadiKrug.UseVisualStyleBackColor = true;
            this.btnDodadiKrug.Click += new System.EventHandler(this.btnDodadiKrug_Click);
            // 
            // tbNajdobarKrug
            // 
            this.tbNajdobarKrug.Enabled = false;
            this.tbNajdobarKrug.Location = new System.Drawing.Point(7, 317);
            this.tbNajdobarKrug.Name = "tbNajdobarKrug";
            this.tbNajdobarKrug.Size = new System.Drawing.Size(301, 20);
            this.tbNajdobarKrug.TabIndex = 8;
            // 
            // nudVreme
            // 
            this.nudVreme.Location = new System.Drawing.Point(7, 364);
            this.nudVreme.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.nudVreme.Name = "nudVreme";
            this.nudVreme.Size = new System.Drawing.Size(89, 20);
            this.nudVreme.TabIndex = 10;
            this.nudVreme.ValueChanged += new System.EventHandler(this.nudVreme_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Време";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 420);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSekundi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVreme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIzbrisiVozac;
        private System.Windows.Forms.Button btnDodadiVozac;
        private System.Windows.Forms.ListBox lbVozaci;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudVreme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNajdobarKrug;
        private System.Windows.Forms.Button btnDodadiKrug;
        private System.Windows.Forms.NumericUpDown nudSekundi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMinuti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbKrugovi;
    }
}

