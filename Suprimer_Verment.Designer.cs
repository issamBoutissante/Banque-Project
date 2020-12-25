namespace Gestion_de_Banque
{
    partial class Suprimer_Verment
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
            this.label5 = new System.Windows.Forms.Label();
            this.Date_Virement = new System.Windows.Forms.DateTimePicker();
            this.Suprimer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Montant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Numer_Virement = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NumeroDebiteur = new System.Windows.Forms.TextBox();
            this.Numero_Crediteur = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Numero Crediteur";
            // 
            // Date_Virement
            // 
            this.Date_Virement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_Virement.Location = new System.Drawing.Point(266, 274);
            this.Date_Virement.Name = "Date_Virement";
            this.Date_Virement.Size = new System.Drawing.Size(200, 20);
            this.Date_Virement.TabIndex = 41;
            // 
            // Suprimer
            // 
            this.Suprimer.Location = new System.Drawing.Point(522, 167);
            this.Suprimer.Name = "Suprimer";
            this.Suprimer.Size = new System.Drawing.Size(75, 23);
            this.Suprimer.TabIndex = 40;
            this.Suprimer.Text = "Suprimer";
            this.Suprimer.UseVisualStyleBackColor = true;
            this.Suprimer.Click += new System.EventHandler(this.Suprimer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(371, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 39;
            this.label4.Text = "Suprimer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Date Virement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Montant";
            // 
            // Montant
            // 
            this.Montant.Location = new System.Drawing.Point(272, 230);
            this.Montant.Name = "Montant";
            this.Montant.Size = new System.Drawing.Size(100, 20);
            this.Montant.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Numero Debiteur";
            // 
            // Numer_Virement
            // 
            this.Numer_Virement.FormattingEnabled = true;
            this.Numer_Virement.Location = new System.Drawing.Point(272, 89);
            this.Numer_Virement.Name = "Numer_Virement";
            this.Numer_Virement.Size = new System.Drawing.Size(102, 21);
            this.Numer_Virement.TabIndex = 46;
            this.Numer_Virement.SelectedIndexChanged += new System.EventHandler(this.Numer_Virement_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Numero Virement";
            // 
            // NumeroDebiteur
            // 
            this.NumeroDebiteur.Location = new System.Drawing.Point(272, 184);
            this.NumeroDebiteur.Name = "NumeroDebiteur";
            this.NumeroDebiteur.Size = new System.Drawing.Size(100, 20);
            this.NumeroDebiteur.TabIndex = 47;
            // 
            // Numero_Crediteur
            // 
            this.Numero_Crediteur.Location = new System.Drawing.Point(272, 145);
            this.Numero_Crediteur.Name = "Numero_Crediteur";
            this.Numero_Crediteur.Size = new System.Drawing.Size(100, 20);
            this.Numero_Crediteur.TabIndex = 48;
            // 
            // Suprimer_Verment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Numero_Crediteur);
            this.Controls.Add(this.NumeroDebiteur);
            this.Controls.Add(this.Numer_Virement);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Date_Virement);
            this.Controls.Add(this.Suprimer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Montant);
            this.Controls.Add(this.label1);
            this.Name = "Suprimer_Verment";
            this.Text = "Suprimer_Verment";
            this.Load += new System.EventHandler(this.Suprimer_Verment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Date_Virement;
        private System.Windows.Forms.Button Suprimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Montant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Numer_Virement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NumeroDebiteur;
        private System.Windows.Forms.TextBox Numero_Crediteur;
    }
}