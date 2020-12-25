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
    public partial class Modifier_Compte : Form
    {
        GereData gereData = new GereData();
        public Modifier_Compte()
        {
            InitializeComponent();
        }

        private void Modifier_Load(object sender, EventArgs e)
        {
            foreach(var reader in gereData.GetData($"select num_Compte from compte ;"))
            {
                Numero_Compte.Items.Add(reader["num_Compte"]);
            }
            foreach (var reader in gereData.GetData($"select num_Client from client ;"))
            {
                Numero_Client.Items.Add(reader["num_client"]);
            }
        }


        private void Numero_Compte_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var reader in gereData.GetData($"select * from compte where num_compte={Numero_Compte.SelectedItem}"))
            {
                Numero_Client.Text= reader["num_client"].ToString();
                Solde.Text = reader["solde"].ToString();
                Type_Compte.Text = reader["typeC"].ToString();
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gereData.Modifier($"update compte set num_client={Numero_Client.SelectedItem},typeC='{Type_Compte.Text}' where num_compte={Numero_Compte.SelectedItem}"));
        }
    }
}
