using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_de_Banque
{
    public partial class Mouvements : Form
    {
        banqueEntities bq;
        public Mouvements(string typeMouvement)
        {
            InitializeComponent();
            MouvementBtn.Click += (object obj, EventArgs e) => Effectue(typeMouvement);
            title.Text = $"Mouvement {typeMouvement}";
            MouvementBtn.Text = typeMouvement;
        }
        private void Effectue(string typeM)
        {
            bq = new banqueEntities();
            string message = "Depot a ete effectue";
            try
            {
                if (typeM == "Retrait")
                {
                    bq.spRetrait(int.Parse(Numero_Compte.Text), decimal.Parse(Montant.Text));
                    message = "Retrait a ete effectue";
                }
                else
                    bq.spDepot(int.Parse(Numero_Compte.Text), decimal.Parse(Montant.Text));
                MessageBox.Show(message, "Termine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         private void Mouvements_Load(object sender, EventArgs e)
         {
            bq = new banqueEntities();
            try
            {
                Numero_Compte.DisplayMember = "Num_compte";
                Numero_Compte.ValueMember = "Num_compte";
                Numero_Compte.DataSource =bq.Comptes.ToList();
                Numero_Compte.Text = "-Faites votre choix-";
                CompteDataGridView.DataSource = bq.Comptes.Select(compte => new { compte.Num_Compte, compte.Solde }).ToList();
                MouvementDataGridView.DataSource = bq.Mouvements.Select(mv=>new { mv.Num_Mouvement,mv.Num_Compte,mv.Montant}).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
