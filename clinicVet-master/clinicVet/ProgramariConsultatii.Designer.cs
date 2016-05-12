namespace clinicVet
{
    partial class grpConsultatii
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnimal = new System.Windows.Forms.TextBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grpProgramari = new System.Windows.Forms.GroupBox();
            this.btnStergereProgr = new System.Windows.Forms.GroupBox();
            this.dgrvProgramari = new System.Windows.Forms.DataGridView();
            this.dgrvConsultatii = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdaugareProgr = new System.Windows.Forms.Button();
            this.btnModificareProgr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnTratament = new System.Windows.Forms.Button();
            this.btnAdaugareCons = new System.Windows.Forms.Button();
            this.btnModificareCons = new System.Windows.Forms.Button();
            this.btnStergereCons = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.grpProgramari.SuspendLayout();
            this.btnStergereProgr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvProgramari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvConsultatii)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Animal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client";
            // 
            // txtAnimal
            // 
            this.txtAnimal.Enabled = false;
            this.txtAnimal.Location = new System.Drawing.Point(58, 5);
            this.txtAnimal.Name = "txtAnimal";
            this.txtAnimal.Size = new System.Drawing.Size(202, 20);
            this.txtAnimal.TabIndex = 2;
            this.txtAnimal.TextChanged += new System.EventHandler(this.txtAnimal_TextChanged);
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(320, 5);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(202, 20);
            this.txtClient.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Operatii";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Programari",
            "Consultatii cu programare",
            "Consultatii fara programare"});
            this.comboBox1.Location = new System.Drawing.Point(67, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // grpProgramari
            // 
            this.grpProgramari.Controls.Add(this.button1);
            this.grpProgramari.Controls.Add(this.btnModificareProgr);
            this.grpProgramari.Controls.Add(this.btnAdaugareProgr);
            this.grpProgramari.Controls.Add(this.label7);
            this.grpProgramari.Controls.Add(this.textBox2);
            this.grpProgramari.Controls.Add(this.textBox1);
            this.grpProgramari.Controls.Add(this.label6);
            this.grpProgramari.Controls.Add(this.comboBox2);
            this.grpProgramari.Controls.Add(this.label5);
            this.grpProgramari.Controls.Add(this.dateTimePicker1);
            this.grpProgramari.Controls.Add(this.label4);
            this.grpProgramari.Controls.Add(this.dgrvProgramari);
            this.grpProgramari.Location = new System.Drawing.Point(20, 84);
            this.grpProgramari.Name = "grpProgramari";
            this.grpProgramari.Size = new System.Drawing.Size(675, 183);
            this.grpProgramari.TabIndex = 6;
            this.grpProgramari.TabStop = false;
            this.grpProgramari.Text = "Programari";
            this.grpProgramari.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnStergereProgr
            // 
            this.btnStergereProgr.Controls.Add(this.btnStergereCons);
            this.btnStergereProgr.Controls.Add(this.btnModificareCons);
            this.btnStergereProgr.Controls.Add(this.btnAdaugareCons);
            this.btnStergereProgr.Controls.Add(this.btnTratament);
            this.btnStergereProgr.Controls.Add(this.textBox5);
            this.btnStergereProgr.Controls.Add(this.label12);
            this.btnStergereProgr.Controls.Add(this.textBox4);
            this.btnStergereProgr.Controls.Add(this.label11);
            this.btnStergereProgr.Controls.Add(this.comboBox3);
            this.btnStergereProgr.Controls.Add(this.label10);
            this.btnStergereProgr.Controls.Add(this.label9);
            this.btnStergereProgr.Controls.Add(this.dateTimePicker2);
            this.btnStergereProgr.Controls.Add(this.textBox3);
            this.btnStergereProgr.Controls.Add(this.label8);
            this.btnStergereProgr.Controls.Add(this.dgrvConsultatii);
            this.btnStergereProgr.Location = new System.Drawing.Point(20, 291);
            this.btnStergereProgr.Name = "btnStergereProgr";
            this.btnStergereProgr.Size = new System.Drawing.Size(675, 202);
            this.btnStergereProgr.TabIndex = 7;
            this.btnStergereProgr.TabStop = false;
            this.btnStergereProgr.Text = "Consultatii";
            // 
            // dgrvProgramari
            // 
            this.dgrvProgramari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvProgramari.Location = new System.Drawing.Point(6, 19);
            this.dgrvProgramari.Name = "dgrvProgramari";
            this.dgrvProgramari.Size = new System.Drawing.Size(240, 150);
            this.dgrvProgramari.TabIndex = 0;
            // 
            // dgrvConsultatii
            // 
            this.dgrvConsultatii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvConsultatii.Location = new System.Drawing.Point(6, 19);
            this.dgrvConsultatii.Name = "dgrvConsultatii";
            this.dgrvConsultatii.Size = new System.Drawing.Size(240, 150);
            this.dgrvConsultatii.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Programare";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(339, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Lucrare";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(339, 45);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(546, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantitate";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(601, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(339, 77);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(308, 62);
            this.textBox2.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Observatii";
            // 
            // btnAdaugareProgr
            // 
            this.btnAdaugareProgr.Location = new System.Drawing.Point(339, 146);
            this.btnAdaugareProgr.Name = "btnAdaugareProgr";
            this.btnAdaugareProgr.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugareProgr.TabIndex = 9;
            this.btnAdaugareProgr.Text = "Adaugare";
            this.btnAdaugareProgr.UseVisualStyleBackColor = true;
            // 
            // btnModificareProgr
            // 
            this.btnModificareProgr.Location = new System.Drawing.Point(464, 145);
            this.btnModificareProgr.Name = "btnModificareProgr";
            this.btnModificareProgr.Size = new System.Drawing.Size(75, 23);
            this.btnModificareProgr.TabIndex = 10;
            this.btnModificareProgr.Text = "Modificare";
            this.btnModificareProgr.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(572, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Stergere";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Consultatie";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(339, 16);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 20);
            this.textBox3.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(464, 17);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(428, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Data";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(274, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Lucrare";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(339, 48);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 21);
            this.comboBox3.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(546, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Cantitate";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(601, 44);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(46, 20);
            this.textBox4.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(271, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Observatii";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(339, 82);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(308, 42);
            this.textBox5.TabIndex = 11;
            // 
            // btnTratament
            // 
            this.btnTratament.Location = new System.Drawing.Point(264, 130);
            this.btnTratament.Name = "btnTratament";
            this.btnTratament.Size = new System.Drawing.Size(75, 23);
            this.btnTratament.TabIndex = 12;
            this.btnTratament.Text = "Tratament";
            this.btnTratament.UseVisualStyleBackColor = true;
            // 
            // btnAdaugareCons
            // 
            this.btnAdaugareCons.Location = new System.Drawing.Point(339, 173);
            this.btnAdaugareCons.Name = "btnAdaugareCons";
            this.btnAdaugareCons.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugareCons.TabIndex = 13;
            this.btnAdaugareCons.Text = "Adaugare";
            this.btnAdaugareCons.UseVisualStyleBackColor = true;
            // 
            // btnModificareCons
            // 
            this.btnModificareCons.Location = new System.Drawing.Point(464, 173);
            this.btnModificareCons.Name = "btnModificareCons";
            this.btnModificareCons.Size = new System.Drawing.Size(75, 23);
            this.btnModificareCons.TabIndex = 14;
            this.btnModificareCons.Text = "Modificare";
            this.btnModificareCons.UseVisualStyleBackColor = true;
            // 
            // btnStergereCons
            // 
            this.btnStergereCons.Location = new System.Drawing.Point(572, 172);
            this.btnStergereCons.Name = "btnStergereCons";
            this.btnStergereCons.Size = new System.Drawing.Size(75, 23);
            this.btnStergereCons.TabIndex = 15;
            this.btnStergereCons.Text = "Stergere";
            this.btnStergereCons.UseVisualStyleBackColor = true;
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(540, 4);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(75, 23);
            this.btnClient.TabIndex = 8;
            this.btnClient.Text = "...";
            this.btnClient.UseVisualStyleBackColor = true;
            // 
            // grpConsultatii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 505);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnStergereProgr);
            this.Controls.Add(this.grpProgramari);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.txtAnimal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "grpConsultatii";
            this.Text = "Programari si Consultatii";
            this.grpProgramari.ResumeLayout(false);
            this.grpProgramari.PerformLayout();
            this.btnStergereProgr.ResumeLayout(false);
            this.btnStergereProgr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvProgramari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvConsultatii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnimal;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox grpProgramari;
        private System.Windows.Forms.GroupBox btnStergereProgr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnModificareProgr;
        private System.Windows.Forms.Button btnAdaugareProgr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgrvProgramari;
        private System.Windows.Forms.DataGridView dgrvConsultatii;
        private System.Windows.Forms.Button btnStergereCons;
        private System.Windows.Forms.Button btnModificareCons;
        private System.Windows.Forms.Button btnAdaugareCons;
        private System.Windows.Forms.Button btnTratament;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClient;
    }
}