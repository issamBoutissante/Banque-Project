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
    public partial class Suprimer_Movement : Form
    {
        GereData gereData = new GereData();
        public Suprimer_Movement()
        {
            InitializeComponent();
        }

        private void Suprimer_Movement_Load(object sender, EventArgs e)
        {
            foreach(var reader in gereData.GetData("select num_mouvement from mouvement;"))
            {
                Numero_Movement.Items.Add(reader["num_mouvement"]);
            }
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            decimal solde = gereData.GetValue($"select solde from compte where num_compte={Numero_Compte.Text};");
            if (Type_Movement.Text == "retrait")
            {
                gereData.Modifier($"update compte set solde={solde+Convert.ToDecimal(Montant.Text)} where num_compte={Numero_Compte.Text};");

            }
            else
            {
                if (solde > Convert.ToInt32(Montant.Text))
                {
                    gereData.Modifier($"update compte set solde={solde - Convert.ToDecimal(Montant.Text)} where num_compte={Numero_Compte.Text}");

                }
                else
                {
                    MessageBox.Show("il n'ya pas assez de solde");
                    return;
                }

            }
            MessageBox.Show(gereData.Supprimer($"delete from mouvement where num_mouvement={Numero_Movement.SelectedItem}"));
        }

        private void Numero_Movement_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(var reader in gereData.GetData($"select * from mouvement where num_mouvement={Numero_Movement.SelectedItem}"))
            {
                Numero_Compte.Text = reader["num_compte"].ToString();
                Montant.Text = reader["montant"].ToString();
                Type_Movement.Text = reader["typeM"].ToString();
                Date_Mouvement.Value =Convert.ToDateTime( reader["dateM"]);
            }
        }
    }
}
