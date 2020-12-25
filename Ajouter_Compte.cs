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
    public partial class Ajouter_Compte : Form
    {
        GereData gereData = new GereData();
        public Ajouter_Compte()
        {
            InitializeComponent();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gereData.Ajouter($"insert into compte values({Numero_Compte.Text},{Numero_Client.SelectedItem},{Solde.Text},'{Type_Compte.Text}')"));
        }

        private void Ajouter_Compte_Load(object sender, EventArgs e)
        {
            foreach (var reader in gereData.GetData("select num_client as numero from client"))
            {
                Numero_Client.Items.Add(reader["numero"]);
            }
        }
    }
}
