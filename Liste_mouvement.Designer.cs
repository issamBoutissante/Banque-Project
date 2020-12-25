namespace Gestion_de_Banque
{
    partial class Liste_mouvement
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
            this.Afficher_Liste = new System.Windows.Forms.Button();
            this.MouvementDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MouvementDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Afficher_Liste
            // 
            this.Afficher_Liste.Location = new System.Drawing.Point(359, 68);
            this.Afficher_Liste.Name = "Afficher_Liste";
            this.Afficher_Liste.Size = new System.Drawing.Size(114, 23);
            this.Afficher_Liste.TabIndex = 5;
            this.Afficher_Liste.Text = "Afficher";
            this.Afficher_Liste.UseVisualStyleBackColor = true;
            this.Afficher_Liste.Click += new System.EventHandler(this.Afficher_Liste_Click);
            // 
            // MouvementDataGridView
            // 
            this.MouvementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MouvementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.MouvementDataGridView.Location = new System.Drawing.Point(130, 114);
            this.MouvementDataGridView.Name = "MouvementDataGridView";
            this.MouvementDataGridView.Size = new System.Drawing.Size(544, 150);
            this.MouvementDataGridView.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Num mouvemet";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "num Compte";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "montant";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "type mouvement";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "date mouvement";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Liste_mouvement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Afficher_Liste);
            this.Controls.Add(this.MouvementDataGridView);
            this.Name = "Liste_mouvement";
            this.Text = "Liste_mouvement";
            ((System.ComponentModel.ISupportInitialize)(this.MouvementDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Afficher_Liste;
        private System.Windows.Forms.DataGridView MouvementDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}