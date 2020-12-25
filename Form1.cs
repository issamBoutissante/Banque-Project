using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Banque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new Liste_Client());
        }
        void openForm(Form form)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
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
            openForm(new Liste_Compte());
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
    }
}
