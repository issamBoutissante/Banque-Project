using System;
using System.Windows.Forms;
using System.Data;
using System.Linq;

namespace Gestion_de_Banque
{
    public partial class Suppremer_Client : Form
    {
        banqueEntities bq ;
        public Suppremer_Client()
        {
            InitializeComponent();
        }
        private void Suppremer_Client_Load(object sender, EventArgs e)
        {
            RemplirComboBox();

        }
        void RemplirComboBox()
        {
            bq = new banqueEntities();
            Numero.DisplayMember = "Num_client";
            Numero.ValueMember = "Num_client";
            Numero.DataSource = bq.Clients.Select(cl => new { Num_Client = cl.Num_client }).ToList();
        }
        private void Suppremer_Click(object sender, EventArgs e)
        {
            try
            {
                bq = new banqueEntities();
                int selectedValue = int.Parse(Numero.SelectedValue.ToString());
                Client client = bq.Clients.Where(cl => cl.Num_client == selectedValue).First();
                bq.Clients.Remove(client);
                bq.SaveChanges();
                MessageBox.Show("la supprission a ete effectue", "Termine", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RemplirComboBox();
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
