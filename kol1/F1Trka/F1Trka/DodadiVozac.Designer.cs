namespace F1Trka
{
    partial class DodadiVozac
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
            this.tbIme = new System.Windows.Forms.TextBox();
            this.cbPrvVozac = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudVozrast = new System.Windows.Forms.NumericUpDown();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudVozrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(16, 29);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(195, 20);
            this.tbIme.TabIndex = 0;
            this.tbIme.Validating += new System.ComponentModel.CancelEventHandler(this.tbIme_Validating);
            // 
            // cbPrvVozac
            // 
            this.cbPrvVozac.AutoSize = true;
            this.cbPrvVozac.Location = new System.Drawing.Point(133, 74);
            this.cbPrvVozac.Name = "cbPrvVozac";
            this.cbPrvVozac.Size = new System.Drawing.Size(78, 17);
            this.cbPrvVozac.TabIndex = 1;
            this.cbPrvVozac.Text = "Прв возач";
            this.cbPrvVozac.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Име";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Возраст";
            // 
            // nudVozrast
            // 
            this.nudVozrast.Location = new System.Drawing.Point(16, 73);
            this.nudVozrast.Name = "nudVozrast";
            this.nudVozrast.Size = new System.Drawing.Size(100, 20);
            this.nudVozrast.TabIndex = 4;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.CausesValidation = false;
            this.btnOtkazi.Location = new System.Drawing.Point(16, 110);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(90, 23);
            this.btnOtkazi.TabIndex = 5;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnDodadi
            // 
            this.btnDodadi.Location = new System.Drawing.Point(122, 110);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(89, 23);
            this.btnDodadi.TabIndex = 6;
            this.btnDodadi.Text = "Додади";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DodadiVozac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 150);
            this.Controls.Add(this.btnDodadi);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.nudVozrast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPrvVozac);
            this.Controls.Add(this.tbIme);
            this.Name = "DodadiVozac";
            this.Text = "DodadiVozac";
            ((System.ComponentModel.ISupportInitialize)(this.nudVozrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.CheckBox cbPrvVozac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudVozrast;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnDodadi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}