namespace Gestion_de_Banque
{
    partial class Homme
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouteCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMouvementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutMouvementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionMouvementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.virementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.compteToolStripMenuItem,
            this.menuMouvementToolStripMenuItem,
            this.virementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listClientToolStripMenuItem,
            this.ajouterClientToolStripMenuItem,
            this.modificationClientToolStripMenuItem,
            this.suppressionClientToolStripMenuItem,
            this.rechercheToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // listClientToolStripMenuItem
            // 
            this.listClientToolStripMenuItem.Name = "listClientToolStripMenuItem";
            this.listClientToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.listClientToolStripMenuItem.Text = "Consultation";
            this.listClientToolStripMenuItem.Click += new System.EventHandler(this.listClientToolStripMenuItem_Click);
            // 
            // ajouterClientToolStripMenuItem
            // 
            this.ajouterClientToolStripMenuItem.Name = "ajouterClientToolStripMenuItem";
            this.ajouterClientToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ajouterClientToolStripMenuItem.Text = "Ajouter Client";
            this.ajouterClientToolStripMenuItem.Click += new System.EventHandler(this.ajouterClientToolStripMenuItem_Click);
            // 
            // modificationClientToolStripMenuItem
            // 
            this.modificationClientToolStripMenuItem.Name = "modificationClientToolStripMenuItem";
            this.modificationClientToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.modificationClientToolStripMenuItem.Text = "Modifier Client";
            this.modificationClientToolStripMenuItem.Click += new System.EventHandler(this.modificationClientToolStripMenuItem_Click);
            // 
            // suppressionClientToolStripMenuItem
            // 
            this.suppressionClientToolStripMenuItem.Name = "suppressionClientToolStripMenuItem";
            this.suppressionClientToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.suppressionClientToolStripMenuItem.Text = "Suppremer Client";
            this.suppressionClientToolStripMenuItem.Click += new System.EventHandler(this.suppressionClientToolStripMenuItem_Click);
            // 
            // rechercheToolStripMenuItem
            // 
            this.rechercheToolStripMenuItem.Name = "rechercheToolStripMenuItem";
            this.rechercheToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.rechercheToolStripMenuItem.Text = "Recherche";
            this.rechercheToolStripMenuItem.Click += new System.EventHandler(this.rechercheToolStripMenuItem_Click);
            // 
            // compteToolStripMenuItem
            // 
            this.compteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeCompteToolStripMenuItem,
            this.ajouteCompteToolStripMenuItem,
            this.modificationCompteToolStripMenuItem,
            this.suppressionCompteToolStripMenuItem});
            this.compteToolStripMenuItem.Name = "compteToolStripMenuItem";
            this.compteToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.compteToolStripMenuItem.Text = "Compte";
            // 
            // listeCompteToolStripMenuItem
            // 
            this.listeCompteToolStripMenuItem.Name = "listeCompteToolStripMenuItem";
            this.listeCompteToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.listeCompteToolStripMenuItem.Text = "consultation";
            this.listeCompteToolStripMenuItem.Click += new System.EventHandler(this.listeCompteToolStripMenuItem_Click);
            // 
            // ajouteCompteToolStripMenuItem
            // 
            this.ajouteCompteToolStripMenuItem.Name = "ajouteCompteToolStripMenuItem";
            this.ajouteCompteToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ajouteCompteToolStripMenuItem.Text = "Ajouter Compte";
            this.ajouteCompteToolStripMenuItem.Click += new System.EventHandler(this.ajouteCompteToolStripMenuItem_Click);
            // 
            // modificationCompteToolStripMenuItem
            // 
            this.modificationCompteToolStripMenuItem.Name = "modificationCompteToolStripMenuItem";
            this.modificationCompteToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.modificationCompteToolStripMenuItem.Text = "Modifier Compte";
            this.modificationCompteToolStripMenuItem.Click += new System.EventHandler(this.modificationCompteToolStripMenuItem_Click);
            // 
            // suppressionCompteToolStripMenuItem
            // 
            this.suppressionCompteToolStripMenuItem.Name = "suppressionCompteToolStripMenuItem";
            this.suppressionCompteToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.suppressionCompteToolStripMenuItem.Text = "Suppremer Compte";
            this.suppressionCompteToolStripMenuItem.Click += new System.EventHandler(this.suppressionCompteToolStripMenuItem_Click);
            // 
            // menuMouvementToolStripMenuItem
            // 
            this.menuMouvementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutMouvementToolStripMenuItem,
            this.suppressionMouvementToolStripMenuItem});
            this.menuMouvementToolStripMenuItem.Name = "menuMouvementToolStripMenuItem";
            this.menuMouvementToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.menuMouvementToolStripMenuItem.Text = "Mouvement";
            // 
            // ajoutMouvementToolStripMenuItem
            // 
            this.ajoutMouvementToolStripMenuItem.Name = "ajoutMouvementToolStripMenuItem";
            this.ajoutMouvementToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.ajoutMouvementToolStripMenuItem.Text = "Dépôt";
            this.ajoutMouvementToolStripMenuItem.Click += new System.EventHandler(this.ajoutMouvementToolStripMenuItem_Click);
            // 
            // suppressionMouvementToolStripMenuItem
            // 
            this.suppressionMouvementToolStripMenuItem.Name = "suppressionMouvementToolStripMenuItem";
            this.suppressionMouvementToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.suppressionMouvementToolStripMenuItem.Text = "Retrait";
            this.suppressionMouvementToolStripMenuItem.Click += new System.EventHandler(this.suppressionMouvementToolStripMenuItem_Click);
            // 
            // virementToolStripMenuItem
            // 
            this.virementToolStripMenuItem.Name = "virementToolStripMenuItem";
            this.virementToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.virementToolStripMenuItem.Text = "Virement";
            this.virementToolStripMenuItem.Click += new System.EventHandler(this.virementToolStripMenuItem_Click);
            // 
            // Homme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Homme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Banque";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouteCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuMouvementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutMouvementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionMouvementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem virementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheToolStripMenuItem;
    }
}

