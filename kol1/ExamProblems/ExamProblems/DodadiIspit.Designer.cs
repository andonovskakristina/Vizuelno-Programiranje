namespace ExamProblems
{
    partial class DodadiIspit
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
            this.nudGodina = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMesec = new System.Windows.Forms.ComboBox();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudGodina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Година:";
            // 
            // nudGodina
            // 
            this.nudGodina.Location = new System.Drawing.Point(16, 29);
            this.nudGodina.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudGodina.Name = "nudGodina";
            this.nudGodina.Size = new System.Drawing.Size(208, 20);
            this.nudGodina.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Месец:";
            // 
            // cbMesec
            // 
            this.cbMesec.FormattingEnabled = true;
            this.cbMesec.Items.AddRange(new object[] {
            "Јануари",
            "Февруари",
            "Март",
            "Април",
            "Мај",
            "Јуни",
            "Јули",
            "Август",
            "Септември",
            "Октомври",
            "Ноември",
            "Декември"});
            this.cbMesec.Location = new System.Drawing.Point(16, 74);
            this.cbMesec.Name = "cbMesec";
            this.cbMesec.Size = new System.Drawing.Size(208, 21);
            this.cbMesec.TabIndex = 3;
            this.cbMesec.Validating += new System.ComponentModel.CancelEventHandler(this.cbMesec_Validating);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.CausesValidation = false;
            this.btnOtkazi.Location = new System.Drawing.Point(68, 112);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(75, 23);
            this.btnOtkazi.TabIndex = 4;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // btnDodadi
            // 
            this.btnDodadi.Location = new System.Drawing.Point(149, 112);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(75, 23);
            this.btnDodadi.TabIndex = 5;
            this.btnDodadi.Text = "Додади";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DodadiIspit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 149);
            this.Controls.Add(this.btnDodadi);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.cbMesec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudGodina);
            this.Controls.Add(this.label1);
            this.Name = "DodadiIspit";
            this.Text = "DodadiIspit";
            this.Load += new System.EventHandler(this.DodadiIspit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudGodina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudGodina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMesec;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Button btnDodadi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}