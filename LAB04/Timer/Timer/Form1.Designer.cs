namespace Timer
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIgrac = new System.Windows.Forms.TextBox();
            this.tbOperand1 = new System.Windows.Forms.TextBox();
            this.tbOperator = new System.Windows.Forms.TextBox();
            this.tbOperand2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRezultat = new System.Windows.Forms.TextBox();
            this.btnPogodi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPoeni = new System.Windows.Forms.Label();
            this.pbPoeni = new System.Windows.Forms.ProgressBar();
            this.lblVreme = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbVreme = new System.Windows.Forms.ProgressBar();
            this.btnNovaIgra = new System.Windows.Forms.Button();
            this.btnNajdobriIgraci = new System.Windows.Forms.Button();
            this.btnIskluci = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Играч:";
            // 
            // tbIgrac
            // 
            this.tbIgrac.Location = new System.Drawing.Point(60, 13);
            this.tbIgrac.Name = "tbIgrac";
            this.tbIgrac.Size = new System.Drawing.Size(100, 20);
            this.tbIgrac.TabIndex = 1;
            this.tbIgrac.Leave += new System.EventHandler(this.tbIgrac_Leave);
            // 
            // tbOperand1
            // 
            this.tbOperand1.Enabled = false;
            this.tbOperand1.Location = new System.Drawing.Point(16, 55);
            this.tbOperand1.Name = "tbOperand1";
            this.tbOperand1.Size = new System.Drawing.Size(73, 20);
            this.tbOperand1.TabIndex = 2;
            // 
            // tbOperator
            // 
            this.tbOperator.Enabled = false;
            this.tbOperator.Location = new System.Drawing.Point(104, 55);
            this.tbOperator.Name = "tbOperator";
            this.tbOperator.Size = new System.Drawing.Size(37, 20);
            this.tbOperator.TabIndex = 3;
            // 
            // tbOperand2
            // 
            this.tbOperand2.Enabled = false;
            this.tbOperand2.Location = new System.Drawing.Point(156, 55);
            this.tbOperand2.Name = "tbOperand2";
            this.tbOperand2.Size = new System.Drawing.Size(75, 20);
            this.tbOperand2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            // 
            // tbRezultat
            // 
            this.tbRezultat.Location = new System.Drawing.Point(276, 55);
            this.tbRezultat.Name = "tbRezultat";
            this.tbRezultat.Size = new System.Drawing.Size(75, 20);
            this.tbRezultat.TabIndex = 6;
            // 
            // btnPogodi
            // 
            this.btnPogodi.Location = new System.Drawing.Point(385, 53);
            this.btnPogodi.Name = "btnPogodi";
            this.btnPogodi.Size = new System.Drawing.Size(75, 23);
            this.btnPogodi.TabIndex = 7;
            this.btnPogodi.Text = "Погоди";
            this.btnPogodi.UseVisualStyleBackColor = true;
            this.btnPogodi.Click += new System.EventHandler(this.btnPogodi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Поени:";
            // 
            // lblPoeni
            // 
            this.lblPoeni.AutoSize = true;
            this.lblPoeni.Location = new System.Drawing.Point(64, 99);
            this.lblPoeni.Name = "lblPoeni";
            this.lblPoeni.Size = new System.Drawing.Size(13, 13);
            this.lblPoeni.TabIndex = 9;
            this.lblPoeni.Text = "0";
            // 
            // pbPoeni
            // 
            this.pbPoeni.Location = new System.Drawing.Point(16, 133);
            this.pbPoeni.Name = "pbPoeni";
            this.pbPoeni.Size = new System.Drawing.Size(444, 23);
            this.pbPoeni.TabIndex = 10;
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.Location = new System.Drawing.Point(133, 180);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(0, 13);
            this.lblVreme.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Преостанато време:";
            // 
            // pbVreme
            // 
            this.pbVreme.Location = new System.Drawing.Point(16, 210);
            this.pbVreme.Name = "pbVreme";
            this.pbVreme.Size = new System.Drawing.Size(444, 23);
            this.pbVreme.TabIndex = 13;
            // 
            // btnNovaIgra
            // 
            this.btnNovaIgra.Location = new System.Drawing.Point(16, 252);
            this.btnNovaIgra.Name = "btnNovaIgra";
            this.btnNovaIgra.Size = new System.Drawing.Size(111, 23);
            this.btnNovaIgra.TabIndex = 14;
            this.btnNovaIgra.Text = "Нова игра";
            this.btnNovaIgra.UseVisualStyleBackColor = true;
            this.btnNovaIgra.Click += new System.EventHandler(this.btnNovaIgra_Click);
            // 
            // btnNajdobriIgraci
            // 
            this.btnNajdobriIgraci.Location = new System.Drawing.Point(179, 252);
            this.btnNajdobriIgraci.Name = "btnNajdobriIgraci";
            this.btnNajdobriIgraci.Size = new System.Drawing.Size(120, 23);
            this.btnNajdobriIgraci.TabIndex = 15;
            this.btnNajdobriIgraci.Text = "Најдобри играчи";
            this.btnNajdobriIgraci.UseVisualStyleBackColor = true;
            this.btnNajdobriIgraci.Click += new System.EventHandler(this.btnNajdobriIgraci_Click);
            // 
            // btnIskluci
            // 
            this.btnIskluci.Location = new System.Drawing.Point(365, 252);
            this.btnIskluci.Name = "btnIskluci";
            this.btnIskluci.Size = new System.Drawing.Size(95, 23);
            this.btnIskluci.TabIndex = 16;
            this.btnIskluci.Text = "Исклучи";
            this.btnIskluci.UseVisualStyleBackColor = true;
            this.btnIskluci.Click += new System.EventHandler(this.btnIskluci_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 294);
            this.Controls.Add(this.btnIskluci);
            this.Controls.Add(this.btnNajdobriIgraci);
            this.Controls.Add(this.btnNovaIgra);
            this.Controls.Add(this.pbVreme);
            this.Controls.Add(this.lblVreme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbPoeni);
            this.Controls.Add(this.lblPoeni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPogodi);
            this.Controls.Add(this.tbRezultat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbOperand2);
            this.Controls.Add(this.tbOperator);
            this.Controls.Add(this.tbOperand1);
            this.Controls.Add(this.tbIgrac);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIgrac;
        private System.Windows.Forms.TextBox tbOperand1;
        private System.Windows.Forms.TextBox tbOperator;
        private System.Windows.Forms.TextBox tbOperand2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRezultat;
        private System.Windows.Forms.Button btnPogodi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPoeni;
        private System.Windows.Forms.ProgressBar pbPoeni;
        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pbVreme;
        private System.Windows.Forms.Button btnNovaIgra;
        private System.Windows.Forms.Button btnNajdobriIgraci;
        private System.Windows.Forms.Button btnIskluci;
        private System.Windows.Forms.Timer timer1;
    }
}

