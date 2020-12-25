namespace Gestion_de_Banque
{
    partial class Suprimer_Movement
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
            this.Numero_Movement = new System.Windows.Forms.ComboBox();
            this.Date_Mouvement = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.Type_Movement = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Numero_Compte = new System.Windows.Forms.TextBox();
            this.Ajouter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Montant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Numero_Movement
            // 
            this.Numero_Movement.FormattingEnabled = true;
            this.Numero_Movement.Location = new System.Drawing.Point(218, 105);
            this.Numero_Movement.Name = "Numero_Movement";
            this.Numero_Movement.Size = new System.Drawing.Size(102, 21);
            this.Numero_Movement.TabIndex = 33;
            this.Numero_Movement.SelectedIndexChanged += new System.EventHandler(this.Numero_Movement_SelectedIndexChanged);
            // 
            // Date_Mouvement
            // 
            this.Date_Mouvement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_Mouvement.Location = new System.Drawing.Point(220, 297);
            this.Date_Mouvement.Name = "Date_Mouvement";
            this.Date_Mouvement.Size = new System.Drawing.Size(200, 20);
            this.Date_Mouvement.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Type Movement";
            // 
            // Type_Movement
            // 
            this.Type_Movement.Location = new System.Drawing.Point(216, 250);
            this.Type_Movement.Name = "Type_Movement";
            this.Type_Movement.Size = new System.Drawing.Size(100, 20);
            this.Type_Movement.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Num Movement";
            // 
            // Numero_Compte
            // 
            this.Numero_Compte.Location = new System.Drawing.Point(218, 158);
            this.Numero_Compte.Name = "Numero_Compte";
            this.Numero_Compte.Size = new System.Drawing.Size(100, 20);
            this.Numero_Compte.TabIndex = 28;
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(463, 148);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Ajouter.TabIndex = 27;
            this.Ajouter.Text = "Suprimer";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Suprimer Movement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Date Movement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Montant";
            // 
            // Montant
            // 
            this.Montant.Location = new System.Drawing.Point(218, 201);
            this.Montant.Name = "Montant";
            this.Montant.Size = new System.Drawing.Size(100, 20);
            this.Montant.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Numero Compte";
            // 
            // Suprimer_Movement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Numero_Movement);
            this.Controls.Add(this.Date_Mouvement);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Type_Movement);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Numero_Compte);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Montant);
            this.Controls.Add(this.label1);
            this.Name = "Suprimer_Movement";
            this.Text = "Suprimer_Movement";
            this.Load += new System.EventHandler(this.Suprimer_Movement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Numero_Movement;
        private System.Windows.Forms.DateTimePicker Date_Mouvement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Type_Movement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Numero_Compte;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Montant;
        private System.Windows.Forms.Label label1;
    }
}