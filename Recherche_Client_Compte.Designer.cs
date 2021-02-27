
namespace Gestion_de_Banque
{
    partial class Recherche_Client_Compte
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
            this.ComptesDeClientDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ComptesDeClientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ComptesDeClientDataGridView
            // 
            this.ComptesDeClientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComptesDeClientDataGridView.Location = new System.Drawing.Point(63, 116);
            this.ComptesDeClientDataGridView.Name = "ComptesDeClientDataGridView";
            this.ComptesDeClientDataGridView.Size = new System.Drawing.Size(312, 133);
            this.ComptesDeClientDataGridView.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(21, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Recherche Client Comptes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Num Client";
            // 
            // Numero
            // 
            this.Numero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero.FormattingEnabled = true;
            this.Numero.Location = new System.Drawing.Point(221, 70);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(102, 27);
            this.Numero.TabIndex = 25;
            this.Numero.SelectedIndexChanged += new System.EventHandler(this.Numero_SelectedIndexChanged);
            // 
            // Recherche_Client_Compte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComptesDeClientDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recherche_Client_Compte";
            this.Text = "Recherche_Client_Compte";
            this.Load += new System.EventHandler(this.Recherche_Client_Compte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComptesDeClientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ComptesDeClientDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Numero;
    }
}