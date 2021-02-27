
namespace Gestion_de_Banque
{
    partial class Virementes
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
            this.label2 = new System.Windows.Forms.Label();
            this.VirementDataGridView = new System.Windows.Forms.DataGridView();
            this.CompteDataGridView = new System.Windows.Forms.DataGridView();
            this.Crediteur = new System.Windows.Forms.ComboBox();
            this.Verer = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Montant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Debiteur = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VirementDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.label5.Location = new System.Drawing.Point(502, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 49;
            this.label5.Text = "Virement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.label2.Location = new System.Drawing.Point(160, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 48;
            this.label2.Text = "Comptes";
            // 
            // VirementDataGridView
            // 
            this.VirementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VirementDataGridView.Location = new System.Drawing.Point(338, 219);
            this.VirementDataGridView.Name = "VirementDataGridView";
            this.VirementDataGridView.Size = new System.Drawing.Size(404, 150);
            this.VirementDataGridView.TabIndex = 47;
            // 
            // CompteDataGridView
            // 
            this.CompteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompteDataGridView.Location = new System.Drawing.Point(88, 219);
            this.CompteDataGridView.Name = "CompteDataGridView";
            this.CompteDataGridView.Size = new System.Drawing.Size(220, 150);
            this.CompteDataGridView.TabIndex = 46;
            // 
            // Crediteur
            // 
            this.Crediteur.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crediteur.FormattingEnabled = true;
            this.Crediteur.Location = new System.Drawing.Point(210, 99);
            this.Crediteur.Name = "Crediteur";
            this.Crediteur.Size = new System.Drawing.Size(98, 28);
            this.Crediteur.TabIndex = 45;
            // 
            // Verer
            // 
            this.Verer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verer.Location = new System.Drawing.Point(632, 106);
            this.Verer.Name = "Verer";
            this.Verer.Size = new System.Drawing.Size(110, 34);
            this.Verer.TabIndex = 44;
            this.Verer.Text = "Verer";
            this.Verer.UseVisualStyleBackColor = true;
            this.Verer.Click += new System.EventHandler(this.Verer_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(35, 22);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(158, 24);
            this.title.TabIndex = 43;
            this.title.Text = "Ajout Virement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Montant";
            // 
            // Montant
            // 
            this.Montant.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Montant.Location = new System.Drawing.Point(208, 146);
            this.Montant.Name = "Montant";
            this.Montant.Size = new System.Drawing.Size(100, 26);
            this.Montant.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Crediteur";
            // 
            // Debiteur
            // 
            this.Debiteur.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Debiteur.FormattingEnabled = true;
            this.Debiteur.Location = new System.Drawing.Point(210, 54);
            this.Debiteur.Name = "Debiteur";
            this.Debiteur.Size = new System.Drawing.Size(98, 28);
            this.Debiteur.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Debiteur";
            // 
            // Virementes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.Debiteur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VirementDataGridView);
            this.Controls.Add(this.CompteDataGridView);
            this.Controls.Add(this.Crediteur);
            this.Controls.Add(this.Verer);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Montant);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Virementes";
            this.Text = "Virementes";
            this.Load += new System.EventHandler(this.Virementes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VirementDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView VirementDataGridView;
        private System.Windows.Forms.DataGridView CompteDataGridView;
        private System.Windows.Forms.ComboBox Crediteur;
        private System.Windows.Forms.Button Verer;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Montant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Debiteur;
        private System.Windows.Forms.Label label4;
    }
}