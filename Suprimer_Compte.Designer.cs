﻿namespace Gestion_de_Banque
{
    partial class Suprimer_Compte
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
            this.Numero_Compte = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Type_Compte = new System.Windows.Forms.TextBox();
            this.Suprimer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Solde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Numero_Client = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Numero_Compte
            // 
            this.Numero_Compte.FormattingEnabled = true;
            this.Numero_Compte.Location = new System.Drawing.Point(196, 111);
            this.Numero_Compte.Name = "Numero_Compte";
            this.Numero_Compte.Size = new System.Drawing.Size(102, 21);
            this.Numero_Compte.TabIndex = 39;
            this.Numero_Compte.SelectedIndexChanged += new System.EventHandler(this.Numero_Compte_SelectedIndexChanged);
            this.Numero_Compte.Click += new System.EventHandler(this.Numero_Compte_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Type Compte";
            // 
            // Type_Compte
            // 
            this.Type_Compte.Location = new System.Drawing.Point(196, 329);
            this.Type_Compte.Name = "Type_Compte";
            this.Type_Compte.Size = new System.Drawing.Size(100, 20);
            this.Type_Compte.TabIndex = 37;
            // 
            // Suprimer
            // 
            this.Suprimer.Location = new System.Drawing.Point(443, 169);
            this.Suprimer.Name = "Suprimer";
            this.Suprimer.Size = new System.Drawing.Size(75, 23);
            this.Suprimer.TabIndex = 36;
            this.Suprimer.Text = "Suprimer";
            this.Suprimer.UseVisualStyleBackColor = true;
            this.Suprimer.Click += new System.EventHandler(this.Suprimer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(301, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "Suprimer Compte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Solde";
            // 
            // Solde
            // 
            this.Solde.Enabled = false;
            this.Solde.Location = new System.Drawing.Point(196, 253);
            this.Solde.Name = "Solde";
            this.Solde.Size = new System.Drawing.Size(100, 20);
            this.Solde.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Numero Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Numero Compte";
            // 
            // Numero_Client
            // 
            this.Numero_Client.Location = new System.Drawing.Point(196, 177);
            this.Numero_Client.Name = "Numero_Client";
            this.Numero_Client.Size = new System.Drawing.Size(100, 20);
            this.Numero_Client.TabIndex = 40;
            // 
            // Suprimer_Compte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Numero_Client);
            this.Controls.Add(this.Numero_Compte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Type_Compte);
            this.Controls.Add(this.Suprimer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Solde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Suprimer_Compte";
            this.Text = "Suprimer_Compte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Numero_Compte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Type_Compte;
        private System.Windows.Forms.Button Suprimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Solde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Numero_Client;
    }
}