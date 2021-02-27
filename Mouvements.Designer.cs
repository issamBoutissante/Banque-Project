
namespace Gestion_de_Banque
{
    partial class Mouvements
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
            this.MouvementBtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Montant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CompteDataGridView = new System.Windows.Forms.DataGridView();
            this.MouvementDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CompteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MouvementDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Numero_Compte
            // 
            this.Numero_Compte.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero_Compte.FormattingEnabled = true;
            this.Numero_Compte.Location = new System.Drawing.Point(187, 87);
            this.Numero_Compte.Name = "Numero_Compte";
            this.Numero_Compte.Size = new System.Drawing.Size(98, 28);
            this.Numero_Compte.TabIndex = 35;
            // 
            // MouvementBtn
            // 
            this.MouvementBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MouvementBtn.Location = new System.Drawing.Point(609, 105);
            this.MouvementBtn.Name = "MouvementBtn";
            this.MouvementBtn.Size = new System.Drawing.Size(110, 34);
            this.MouvementBtn.TabIndex = 34;
            this.MouvementBtn.Text = "MouvementBtn";
            this.MouvementBtn.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 21);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(324, 24);
            this.title.TabIndex = 33;
            this.title.Text = "titre   ???This Form is Dynamic";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Montant";
            // 
            // Montant
            // 
            this.Montant.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Montant.Location = new System.Drawing.Point(185, 134);
            this.Montant.Name = "Montant";
            this.Montant.Size = new System.Drawing.Size(100, 26);
            this.Montant.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Numero Compte";
            // 
            // CompteDataGridView
            // 
            this.CompteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompteDataGridView.Location = new System.Drawing.Point(65, 218);
            this.CompteDataGridView.Name = "CompteDataGridView";
            this.CompteDataGridView.Size = new System.Drawing.Size(256, 150);
            this.CompteDataGridView.TabIndex = 36;
            // 
            // MouvementDataGridView
            // 
            this.MouvementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MouvementDataGridView.Location = new System.Drawing.Point(365, 218);
            this.MouvementDataGridView.Name = "MouvementDataGridView";
            this.MouvementDataGridView.Size = new System.Drawing.Size(354, 150);
            this.MouvementDataGridView.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.label2.Location = new System.Drawing.Point(137, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 38;
            this.label2.Text = "Comptes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.label5.Location = new System.Drawing.Point(479, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 39;
            this.label5.Text = "Mouvements";
            // 
            // Mouvements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MouvementDataGridView);
            this.Controls.Add(this.CompteDataGridView);
            this.Controls.Add(this.Numero_Compte);
            this.Controls.Add(this.MouvementBtn);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Montant);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mouvements";
            this.Text = "Mouvements";
            this.Load += new System.EventHandler(this.Mouvements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CompteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MouvementDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Numero_Compte;
        private System.Windows.Forms.Button MouvementBtn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Montant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CompteDataGridView;
        private System.Windows.Forms.DataGridView MouvementDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}