namespace Gestion_de_Banque
{
    partial class Liste_Client
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
            this.ClientDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Afficher_Liste = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientDataGridView
            // 
            this.ClientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.ClientDataGridView.Location = new System.Drawing.Point(180, 123);
            this.ClientDataGridView.Name = "ClientDataGridView";
            this.ClientDataGridView.Size = new System.Drawing.Size(343, 150);
            this.ClientDataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Num_Client";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom Client";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prenom Client";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Afficher_Liste
            // 
            this.Afficher_Liste.Location = new System.Drawing.Point(409, 77);
            this.Afficher_Liste.Name = "Afficher_Liste";
            this.Afficher_Liste.Size = new System.Drawing.Size(114, 23);
            this.Afficher_Liste.TabIndex = 1;
            this.Afficher_Liste.Text = "Afficher";
            this.Afficher_Liste.UseVisualStyleBackColor = true;
            this.Afficher_Liste.Click += new System.EventHandler(this.Afficher_Liste_Click);
            // 
            // Liste_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Afficher_Liste);
            this.Controls.Add(this.ClientDataGridView);
            this.Name = "Liste_Client";
            this.Text = "Liste_Client";
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button Afficher_Liste;
    }
}