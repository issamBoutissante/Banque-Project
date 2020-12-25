namespace Gestion_de_Banque
{
    partial class Modifier_Client
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
            this.Numero = new System.Windows.Forms.ComboBox();
            this.Modifier = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Prenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Numero
            // 
            this.Numero.FormattingEnabled = true;
            this.Numero.Location = new System.Drawing.Point(219, 179);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(102, 21);
            this.Numero.TabIndex = 24;
            this.Numero.SelectedIndexChanged += new System.EventHandler(this.Numero_SelectedIndexChanged);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(470, 217);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(75, 23);
            this.Modifier.TabIndex = 23;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(328, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Modifier Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Prenom";
            // 
            // Prenom
            // 
            this.Prenom.Location = new System.Drawing.Point(221, 324);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(100, 20);
            this.Prenom.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nom";
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(219, 251);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(100, 20);
            this.Nom.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Numero";
            // 
            // Modifier_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.label1);
            this.Name = "Modifier_Client";
            this.Text = "Modifier_Client";
            this.Load += new System.EventHandler(this.Modifier_Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Numero;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Prenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.Label label1;
    }
}