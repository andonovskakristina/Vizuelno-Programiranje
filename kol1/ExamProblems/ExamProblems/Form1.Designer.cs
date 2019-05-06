namespace ExamProblems
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
            this.lbIspiti = new System.Windows.Forms.ListBox();
            this.btnDodadiIspit = new System.Windows.Forms.Button();
            this.btnIzbrisiIspit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOpis1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPoeni1 = new System.Windows.Forms.NumericUpDown();
            this.btnZacuvaj1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnZacuvaj2 = new System.Windows.Forms.Button();
            this.nudPoeni2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOpis2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoeni1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoeni2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIzbrisiIspit);
            this.groupBox1.Controls.Add(this.btnDodadiIspit);
            this.groupBox1.Controls.Add(this.lbIspiti);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 408);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Испити";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnZacuvaj1);
            this.groupBox2.Controls.Add(this.nudPoeni1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbOpis1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(337, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 201);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Задача 1";
            // 
            // lbIspiti
            // 
            this.lbIspiti.FormattingEnabled = true;
            this.lbIspiti.Location = new System.Drawing.Point(7, 20);
            this.lbIspiti.Name = "lbIspiti";
            this.lbIspiti.Size = new System.Drawing.Size(292, 316);
            this.lbIspiti.TabIndex = 0;
            this.lbIspiti.SelectedIndexChanged += new System.EventHandler(this.lbIspiti_SelectedIndexChanged);
            // 
            // btnDodadiIspit
            // 
            this.btnDodadiIspit.Location = new System.Drawing.Point(6, 342);
            this.btnDodadiIspit.Name = "btnDodadiIspit";
            this.btnDodadiIspit.Size = new System.Drawing.Size(293, 23);
            this.btnDodadiIspit.TabIndex = 1;
            this.btnDodadiIspit.Text = "Додади испит";
            this.btnDodadiIspit.UseVisualStyleBackColor = true;
            this.btnDodadiIspit.Click += new System.EventHandler(this.btnDodadiIspit_Click);
            // 
            // btnIzbrisiIspit
            // 
            this.btnIzbrisiIspit.Enabled = false;
            this.btnIzbrisiIspit.Location = new System.Drawing.Point(6, 371);
            this.btnIzbrisiIspit.Name = "btnIzbrisiIspit";
            this.btnIzbrisiIspit.Size = new System.Drawing.Size(293, 23);
            this.btnIzbrisiIspit.TabIndex = 2;
            this.btnIzbrisiIspit.Text = "Избриши испит";
            this.btnIzbrisiIspit.UseVisualStyleBackColor = true;
            this.btnIzbrisiIspit.Click += new System.EventHandler(this.btnIzbrisiIspit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Опис:";
            // 
            // tbOpis1
            // 
            this.tbOpis1.Location = new System.Drawing.Point(10, 37);
            this.tbOpis1.Multiline = true;
            this.tbOpis1.Name = "tbOpis1";
            this.tbOpis1.Size = new System.Drawing.Size(289, 87);
            this.tbOpis1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Поени:";
            // 
            // nudPoeni1
            // 
            this.nudPoeni1.Location = new System.Drawing.Point(10, 149);
            this.nudPoeni1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudPoeni1.Name = "nudPoeni1";
            this.nudPoeni1.Size = new System.Drawing.Size(120, 20);
            this.nudPoeni1.TabIndex = 3;
            // 
            // btnZacuvaj1
            // 
            this.btnZacuvaj1.Location = new System.Drawing.Point(204, 172);
            this.btnZacuvaj1.Name = "btnZacuvaj1";
            this.btnZacuvaj1.Size = new System.Drawing.Size(95, 23);
            this.btnZacuvaj1.TabIndex = 4;
            this.btnZacuvaj1.Text = "Зачувај";
            this.btnZacuvaj1.UseVisualStyleBackColor = true;
            this.btnZacuvaj1.Click += new System.EventHandler(this.btnZacuvaj1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnZacuvaj2);
            this.groupBox3.Controls.Add(this.nudPoeni2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbOpis2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(337, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 201);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Задача 2";
            // 
            // btnZacuvaj2
            // 
            this.btnZacuvaj2.Location = new System.Drawing.Point(204, 172);
            this.btnZacuvaj2.Name = "btnZacuvaj2";
            this.btnZacuvaj2.Size = new System.Drawing.Size(95, 23);
            this.btnZacuvaj2.TabIndex = 4;
            this.btnZacuvaj2.Text = "Зачувај";
            this.btnZacuvaj2.UseVisualStyleBackColor = true;
            this.btnZacuvaj2.Click += new System.EventHandler(this.btnZacuvaj2_Click);
            // 
            // nudPoeni2
            // 
            this.nudPoeni2.Location = new System.Drawing.Point(10, 149);
            this.nudPoeni2.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudPoeni2.Name = "nudPoeni2";
            this.nudPoeni2.Size = new System.Drawing.Size(120, 20);
            this.nudPoeni2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Поени:";
            // 
            // tbOpis2
            // 
            this.tbOpis2.Location = new System.Drawing.Point(10, 37);
            this.tbOpis2.Multiline = true;
            this.tbOpis2.Name = "tbOpis2";
            this.tbOpis2.Size = new System.Drawing.Size(289, 87);
            this.tbOpis2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Опис:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 435);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoeni1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoeni2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIzbrisiIspit;
        private System.Windows.Forms.Button btnDodadiIspit;
        private System.Windows.Forms.ListBox lbIspiti;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnZacuvaj1;
        private System.Windows.Forms.NumericUpDown nudPoeni1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOpis1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnZacuvaj2;
        private System.Windows.Forms.NumericUpDown nudPoeni2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOpis2;
        private System.Windows.Forms.Label label4;
    }
}

