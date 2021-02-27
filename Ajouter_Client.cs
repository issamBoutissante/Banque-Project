using System;
using System.Windows.Forms;

namespace Gestion_de_Banque
{
    public partial class Ajouter_Client : Form
    {
        public Ajouter_Client()
        {
            InitializeComponent();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client()
                {
                    Num_client = int.Parse(Numero.Text),
                    Nom_client = Nom.Text,
                    Prenom_Client = Prenom.Text
                };
                banqueEntities bq = new banqueEntities();
                bq.Clients.Add(client);
                bq.SaveChanges();
                foreach (dynamic t in this.Controls)
                    if (t is TextBox) t.Clear();
                MessageBox.Show("l'ajout a ete effectue", "Termine", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
