using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_de_Banque
{
    public partial class Homme : Form
    {
        public Homme()
        {
            InitializeComponent();           
        }

        private void listClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Consultation_Client());
        }
        void openForm(Form form)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            if(form is Mouvements || form is Virementes)
                this.Size = new Size(800, 550);
            else
                this.Size = new Size(450, 350);
            this.CenterToScreen();
            form.BackColor = Color.White;
            form.Show();
        }

        private void ajouterClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Ajouter_Client());
        }

        private void suppressionClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Suppremer_Client());
        }

        private void modificationClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Modifier_Client());
        }

        private void listeCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Consultation_Compte());
        }

        private void ajouteCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Ajouter_Compte());
        }

        private void modificationCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Modifier_Compte());
        }

        private void suppressionCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Suprimer_Compte());
        }

        private void rechercheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Recherche_Client_Compte());
        }

        private void ajoutMouvementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Mouvements("Dépôt"));
        }

        private void suppressionMouvementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Mouvements("Retrait"));
        }

        private void virementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Virementes());
        }
    }
}
