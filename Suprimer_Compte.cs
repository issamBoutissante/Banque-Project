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
    public partial class Suprimer_Compte : Form
    {
        GereData gereData = new GereData();
        public Suprimer_Compte()
        {
            InitializeComponent();
        }

        private void Numero_Compte_Click(object sender, EventArgs e)
        {
            Numero_Compte.Items.Clear();
            foreach (var reader in gereData.GetData($"select num_Compte from compte ;"))
            {
                Numero_Compte.Items.Add(reader["num_Compte"]);
            }
            
        }

        private void Suprimer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gereData.Supprimer($"delete from compte where num_compte={Numero_Compte.SelectedItem}"));
        }

        private void Numero_Compte_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var reader in gereData.GetData($"select * from compte where num_compte={Numero_Compte.SelectedItem}"))
            {
                Numero_Client.Text = reader["num_client"].ToString();
                Solde.Text = reader["solde"].ToString();
                Type_Compte.Text = reader["typeC"].ToString();
            }
        }


    }
}
