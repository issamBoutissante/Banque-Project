namespace Gestion_de_Banque
{
    partial class Ajouter_Verment
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
            this.Numero_Debiteur = new System.Windows.Forms.ComboBox();
            this.Date_Virement = new System.Windows.Forms.DateTimePicker();
            this.Ajouter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Montant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NumeroCrediteur = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Numero_Debiteur
            // 
            this.Numero_Debiteur.FormattingEnabled = true;
            this.Numero_Debiteur.Location = new System.Drawing.Point(228, 166);
            this.Numero_Debiteur.Name = "Numero_Debiteur";
            this.Numero_Debiteur.Size = new System.Drawing.Size(102, 21);
            this.Numero_Debiteur.TabIndex = 31;
            // 
            // Date_Virement
            // 
            this.Date_Virement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_Virement.Location = new System.Drawing.Point(223, 269);
            this.Date_Virement.Name = "Date_Virement";
            this.Date_Virement.Size = new System.Drawing.Size(200, 20);
            this.Date_Virement.TabIndex = 30;
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(473, 172);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Ajouter.TabIndex = 28;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(322, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ajouter Virement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Date Virement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Montant";
            // 
            // Montant
            // 
            this.Montant.Location = new System.Drawing.Point(228, 212);
            this.Montant.Name = "Montant";
            this.Montant.Size = new System.Drawing.Size(100, 20);
            this.Montant.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Numero Debiteur";
            // 
            // NumeroCrediteur
            // 
            this.NumeroCrediteur.FormattingEnabled = true;
            this.NumeroCrediteur.Location = new System.Drawing.Point(226, 124);
            this.NumeroCrediteur.Name = "NumeroCrediteur";
            this.NumeroCrediteur.Size = new System.Drawing.Size(102, 21);
            this.NumeroCrediteur.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Numero Crediteur";
            // 
            // Ajouter_Verment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumeroCrediteur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Numero_Debiteur);
            this.Controls.Add(this.Date_Virement);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Montant);
            this.Controls.Add(this.label1);
            this.Name = "Ajouter_Verment";
            this.Text = "Ajouter_Verment";
            this.Load += new System.EventHandler(this.Ajouter_Verment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Numero_Debiteur;
        private System.Windows.Forms.DateTimePicker Date_Virement;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Montant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox NumeroCrediteur;
        private System.Windows.Forms.Label label5;
    }
}