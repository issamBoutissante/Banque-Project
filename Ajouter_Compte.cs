using System;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_de_Banque
{
    public partial class Ajouter_Compte : Form
    {
        banqueEntities bq;
        public Ajouter_Compte()
        {
            InitializeComponent();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                bq = new banqueEntities();
                Compte compte = new Compte()
                {
                    Num_Compte = int.Parse(Numero_Compte.Text),
                    Num_Client = int.Parse(Numero_Client.Text),
                    Solde = decimal.Parse(Solde.Text),
                    TypeC = Type_Compte.Text,
                };
                bq.Comptes.Add(compte);
                bq.SaveChanges();
                foreach (dynamic t in this.Controls)
                    if (t is TextBox) t.Clear();
                MessageBox.Show("l'ajout a ete effectue", "Termine", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ajouter_Compte_Load(object sender, EventArgs e)
        {
            bq = new banqueEntities();
            Numero_Client.DisplayMember = "Num_client";
            Numero_Client.ValueMember = "Num_client";
            Numero_Client.DataSource = bq.Clients.ToList();
        }
    }
}
