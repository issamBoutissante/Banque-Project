using System;
using System.Windows.Forms;

namespace Gestion_de_Banque
{
    public partial class Ajouter_Verment : Form
    {
        GereData gereData = new GereData();
        public Ajouter_Verment()
        {
            InitializeComponent();
        }

        private void Ajouter_Verment_Load(object sender, EventArgs e)
        {
            foreach(var reader in gereData.GetData("select num_compte from compte;"))
            {
                NumeroCrediteur.Items.Add(reader["num_compte"]);
                Numero_Debiteur.Items.Add(reader["num_compte"]);
            }
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            decimal soldDebiteur = gereData.GetValue($"select solde from compte where num_compte={Numero_Debiteur.SelectedItem};");
            decimal soldCrediteur = gereData.GetValue($"select solde from compte where num_compte={NumeroCrediteur.SelectedItem};");
            if (soldDebiteur > Convert.ToDecimal(Montant.Text))
            {
                gereData.Modifier($"update compte set solde={soldDebiteur - Convert.ToDecimal(Montant.Text)} where num_compte={Numero_Debiteur.SelectedItem}");
                gereData.Modifier($"update compte set solde={soldCrediteur + Convert.ToDecimal(Montant.Text)} where num_compte={NumeroCrediteur.SelectedItem}");
            }
            else
            {
                MessageBox.Show("le debiteur n'a pas assez d'argent");
                return;
            }
            MessageBox.Show(gereData.Ajouter($"insert into virement values({Numero_Debiteur.SelectedItem},{NumeroCrediteur.SelectedItem},{Montant.Text},'{Date_Virement.Value}')"));
        }
    }
}
