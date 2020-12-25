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
    public partial class Modifier_Client : Form
    {
        GereData gereData = new GereData();
        public Modifier_Client()
        {
            InitializeComponent();
        }

        private void Modifier_Client_Load(object sender, EventArgs e)
        {
            foreach (var reader in gereData.GetData("select num_client as numero from client"))
            {
                Numero.Items.Add(reader["numero"]);
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gereData.Modifier($"update client set nom_client='{Nom.Text}', prenom_client='{Prenom.Text}' where num_client={Numero.SelectedItem};"));
        }

        private void Numero_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var reader in gereData.GetData($"select * from client where num_client={Numero.SelectedItem};"))
            {
                Nom.Text = reader["nom_client"].ToString();
                Prenom.Text = reader["prenom_client"].ToString();
            }
        }
    }
}
