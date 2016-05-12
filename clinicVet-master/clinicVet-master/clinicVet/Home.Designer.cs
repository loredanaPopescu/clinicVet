namespace clinicVet
{
    partial class Home
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
            this.btnProgramare = new System.Windows.Forms.Button();
            this.btnAnimal = new System.Windows.Forms.Button();
            this.btnProduse = new System.Windows.Forms.Button();
            this.btnFacturi = new System.Windows.Forms.Button();
            this.btnRapoarte = new System.Windows.Forms.Button();
            this.lblClinica = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProgramare
            // 
            this.btnProgramare.Location = new System.Drawing.Point(32, 86);
            this.btnProgramare.Name = "btnProgramare";
            this.btnProgramare.Size = new System.Drawing.Size(151, 35);
            this.btnProgramare.TabIndex = 0;
            this.btnProgramare.Text = "Programari si consultatii";
            this.btnProgramare.UseVisualStyleBackColor = true;
            this.btnProgramare.Click += new System.EventHandler(this.btnProgramare_Click);
            // 
            // btnAnimal
            // 
            this.btnAnimal.Location = new System.Drawing.Point(32, 156);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Size = new System.Drawing.Size(151, 35);
            this.btnAnimal.TabIndex = 1;
            this.btnAnimal.Text = "Cautare animal";
            this.btnAnimal.UseVisualStyleBackColor = true;
            // 
            // btnProduse
            // 
            this.btnProduse.Location = new System.Drawing.Point(32, 221);
            this.btnProduse.Name = "btnProduse";
            this.btnProduse.Size = new System.Drawing.Size(151, 35);
            this.btnProduse.TabIndex = 2;
            this.btnProduse.Text = "Produse";
            this.btnProduse.UseVisualStyleBackColor = true;
            // 
            // btnFacturi
            // 
            this.btnFacturi.Location = new System.Drawing.Point(32, 279);
            this.btnFacturi.Name = "btnFacturi";
            this.btnFacturi.Size = new System.Drawing.Size(151, 35);
            this.btnFacturi.TabIndex = 3;
            this.btnFacturi.Text = "Facturi";
            this.btnFacturi.UseVisualStyleBackColor = true;
            // 
            // btnRapoarte
            // 
            this.btnRapoarte.Location = new System.Drawing.Point(32, 347);
            this.btnRapoarte.Name = "btnRapoarte";
            this.btnRapoarte.Size = new System.Drawing.Size(151, 35);
            this.btnRapoarte.TabIndex = 4;
            this.btnRapoarte.Text = "Rapoarte";
            this.btnRapoarte.UseVisualStyleBackColor = true;
            // 
            // lblClinica
            // 
            this.lblClinica.AutoSize = true;
            this.lblClinica.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClinica.Location = new System.Drawing.Point(173, 20);
            this.lblClinica.Name = "lblClinica";
            this.lblClinica.Size = new System.Drawing.Size(84, 23);
            this.lblClinica.TabIndex = 5;
            this.lblClinica.Text = "Clinic Vet";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 405);
            this.Controls.Add(this.lblClinica);
            this.Controls.Add(this.btnRapoarte);
            this.Controls.Add(this.btnFacturi);
            this.Controls.Add(this.btnProduse);
            this.Controls.Add(this.btnAnimal);
            this.Controls.Add(this.btnProgramare);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProgramare;
        private System.Windows.Forms.Button btnAnimal;
        private System.Windows.Forms.Button btnProduse;
        private System.Windows.Forms.Button btnFacturi;
        private System.Windows.Forms.Button btnRapoarte;
        private System.Windows.Forms.Label lblClinica;
    }
}