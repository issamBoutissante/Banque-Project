using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_de_Banque
{
    public partial class Modifier_Client : Form
    {
        banqueEntities bq;
        public Modifier_Client()
        {
            InitializeComponent();
        }

        private void Modifier_Client_Load(object sender, EventArgs e)
        {
            bq = new banqueEntities();
            Numero.DisplayMember = "Num_client";
            Numero.ValueMember = "Num_client";
            Numero.DataSource= bq.Clients.ToList();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                bq = new banqueEntities();
                int selectedValue = int.Parse(Numero.SelectedValue.ToString());
                Client client = bq.Clients.Where(cl => cl.Num_client == selectedValue).First();
                client.Nom_client = Nom.Text;
                client.Prenom_Client = Prenom.Text;
                bq.SaveChanges();
                MessageBox.Show("la modification a ete effectue", "Termine", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Numero_SelectedIndexChanged(object sender, EventArgs e)
        {
            bq = new banqueEntities();
            int selectedValue = int.Parse(Numero.SelectedValue.ToString());
            Client client = bq.Clients.Where(cl=>cl.Num_client==selectedValue).First();
            Nom.Text = client.Nom_client;
            Prenom.Text = client.Prenom_Client;
        }
    }
}
