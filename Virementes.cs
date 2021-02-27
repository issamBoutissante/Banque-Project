using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_de_Banque
{
    public partial class Virementes : Form
    {
        banqueEntities bq;
        public Virementes()
        {
            InitializeComponent();
        }

        private void Virementes_Load(object sender, EventArgs e)
        {
            bq = new banqueEntities();
            try
            {
                Debiteur.DisplayMember = "Num_compte";
                Debiteur.ValueMember = "Num_compte";
                Debiteur.DataSource = bq.Comptes.ToList();
                Crediteur.DisplayMember = "Num_compte";
                Crediteur.ValueMember = "Num_compte";
                Crediteur.DataSource = bq.Comptes.ToList();
                Debiteur.Text = "-Faites votre choix-";
                Crediteur.Text = "-Faites votre choix-";
                CompteDataGridView.DataSource = bq.Comptes.Select(compte => new { compte.Num_Compte, compte.Solde }).ToList();
                VirementDataGridView.DataSource = bq.Virements.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Verer_Click(object sender, EventArgs e)
        {
            bq = new banqueEntities();
            try
            {

                bq.spVerer(int.Parse(Debiteur.Text), int.Parse(Crediteur.Text), decimal.Parse(Montant.Text));
                MessageBox.Show("le virement a ete effectue", "Termine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
