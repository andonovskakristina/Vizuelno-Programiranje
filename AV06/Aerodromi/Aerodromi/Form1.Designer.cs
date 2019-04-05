namespace Aerodromi
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
            this.lbAerodromi = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDestinacii = new System.Windows.Forms.ListBox();
            this.btnDodadiAerodrom = new System.Windows.Forms.Button();
            this.btnDodadiDestinacija = new System.Windows.Forms.Button();
            this.btnIzbrisiAerodrom = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNajskapaDestinacija = new System.Windows.Forms.TextBox();
            this.tbProsecnaDolzina = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAerodromi
            // 
            this.lbAerodromi.FormattingEnabled = true;
            this.lbAerodromi.Location = new System.Drawing.Point(13, 34);
            this.lbAerodromi.Name = "lbAerodromi";
            this.lbAerodromi.Size = new System.Drawing.Size(295, 277);
            this.lbAerodromi.TabIndex = 0;
            this.lbAerodromi.SelectedIndexChanged += new System.EventHandler(this.lbAerodromi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Аеродроми";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дестинации";
            // 
            // lbDestinacii
            // 
            this.lbDestinacii.FormattingEnabled = true;
            this.lbDestinacii.Location = new System.Drawing.Point(328, 34);
            this.lbDestinacii.Name = "lbDestinacii";
            this.lbDestinacii.Size = new System.Drawing.Size(295, 277);
            this.lbDestinacii.TabIndex = 2;
            // 
            // btnDodadiAerodrom
            // 
            this.btnDodadiAerodrom.Location = new System.Drawing.Point(13, 329);
            this.btnDodadiAerodrom.Name = "btnDodadiAerodrom";
            this.btnDodadiAerodrom.Size = new System.Drawing.Size(295, 23);
            this.btnDodadiAerodrom.TabIndex = 4;
            this.btnDodadiAerodrom.Text = "Додади аеродром";
            this.btnDodadiAerodrom.UseVisualStyleBackColor = true;
            this.btnDodadiAerodrom.Click += new System.EventHandler(this.btnDodadiAerodrom_Click);
            // 
            // btnDodadiDestinacija
            // 
            this.btnDodadiDestinacija.Location = new System.Drawing.Point(13, 415);
            this.btnDodadiDestinacija.Name = "btnDodadiDestinacija";
            this.btnDodadiDestinacija.Size = new System.Drawing.Size(295, 23);
            this.btnDodadiDestinacija.TabIndex = 5;
            this.btnDodadiDestinacija.Text = "Додади дестинација";
            this.btnDodadiDestinacija.UseVisualStyleBackColor = true;
            this.btnDodadiDestinacija.Click += new System.EventHandler(this.btnDodadiDestinacija_Click);
            // 
            // btnIzbrisiAerodrom
            // 
            this.btnIzbrisiAerodrom.Location = new System.Drawing.Point(12, 372);
            this.btnIzbrisiAerodrom.Name = "btnIzbrisiAerodrom";
            this.btnIzbrisiAerodrom.Size = new System.Drawing.Size(295, 23);
            this.btnIzbrisiAerodrom.TabIndex = 6;
            this.btnIzbrisiAerodrom.Text = "Избриши аеродром";
            this.btnIzbrisiAerodrom.UseVisualStyleBackColor = true;
            this.btnIzbrisiAerodrom.Click += new System.EventHandler(this.btnIzbrisiAerodrom_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbProsecnaDolzina);
            this.groupBox1.Controls.Add(this.tbNajskapaDestinacija);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(328, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 121);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дестинации";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Најскапа дестинација";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Просечна должина на дестинациите";
            // 
            // tbNajskapaDestinacija
            // 
            this.tbNajskapaDestinacija.Enabled = false;
            this.tbNajskapaDestinacija.Location = new System.Drawing.Point(9, 41);
            this.tbNajskapaDestinacija.Name = "tbNajskapaDestinacija";
            this.tbNajskapaDestinacija.Size = new System.Drawing.Size(280, 20);
            this.tbNajskapaDestinacija.TabIndex = 2;
            // 
            // tbProsecnaDolzina
            // 
            this.tbProsecnaDolzina.Enabled = false;
            this.tbProsecnaDolzina.Location = new System.Drawing.Point(9, 81);
            this.tbProsecnaDolzina.Name = "tbProsecnaDolzina";
            this.tbProsecnaDolzina.Size = new System.Drawing.Size(280, 20);
            this.tbProsecnaDolzina.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIzbrisiAerodrom);
            this.Controls.Add(this.btnDodadiDestinacija);
            this.Controls.Add(this.btnDodadiAerodrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbDestinacii);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAerodromi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAerodromi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbDestinacii;
        private System.Windows.Forms.Button btnDodadiAerodrom;
        private System.Windows.Forms.Button btnDodadiDestinacija;
        private System.Windows.Forms.Button btnIzbrisiAerodrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbProsecnaDolzina;
        private System.Windows.Forms.TextBox tbNajskapaDestinacija;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

