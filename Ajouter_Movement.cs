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
    public partial class Ajouter_Movement : Form
    {
        GereData gereData = new GereData();
        public Ajouter_Movement()
        {
            InitializeComponent();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            decimal solde= gereData.GetValue($"select solde from compte where num_compte={Numero_Compte.SelectedItem};");
            if (Type_Mouvement.SelectedItem.ToString() == "retrait")
            {
                if (solde > Convert.ToInt32(Montant.Text))
                {
                    gereData.Modifier($"update compte set solde={solde - Convert.ToInt32(Montant.Text)} where num_compte={Numero_Compte.SelectedItem}");
                }
                else
                {
                    MessageBox.Show("tu n'as pas assez d'argent");
                    return;
                }
            }
            else
            {
                gereData.Modifier($"update compte set solde={solde + Convert.ToInt32(Montant.Text)} where num_compte={Numero_Compte.SelectedItem}");

            }
            MessageBox.Show(gereData.Ajouter($"insert into mouvement values(${Numero_Compte.SelectedItem},${Montant.Text},'{Type_Mouvement.SelectedItem}','{Date_Mouvement.Value}')"));
        }

        private void Ajouter_Movement_Load(object sender, EventArgs e)
        {
            foreach (var reader in gereData.GetData("select num_compte from compte;"))
            {
                Numero_Compte.Items.Add(reader["num_compte"]);
            }
            Type_Mouvement.SelectedItem = "dépôt";
        }
    }
}
