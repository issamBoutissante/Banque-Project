using System;
using System.Windows.Forms;

namespace Gestion_de_Banque
{
    public partial class Suprimer_Verment : Form
    {
        GereData gereData = new GereData();
        public Suprimer_Verment()
        {
            InitializeComponent();
        }

        private void Suprimer_Click(object sender, EventArgs e)
        {
            decimal soldDebiteur = gereData.GetValue($"select solde from compte where num_compte={NumeroDebiteur.Text};");
            decimal soldCrediteur = gereData.GetValue($"select solde from compte where num_compte={Numero_Crediteur.Text};");

            if (soldCrediteur > Convert.ToDecimal(Montant.Text))
            {
                gereData.Modifier($"update compte set solde={soldCrediteur - Convert.ToDecimal(Montant.Text)} where num_compte={Numero_Crediteur.Text}");
                gereData.Modifier($"update compte set solde={soldDebiteur + Convert.ToDecimal(Montant.Text)} where num_compte={NumeroDebiteur.Text}");
            }
            else
            {
                MessageBox.Show("le crediteur n'a pas assez de sold pour superimer virement");
                return;
            }
            MessageBox.Show(gereData.Supprimer($"delete from virement where num_virement ={Numer_Virement.Text};"));
        }
        private void Suprimer_Verment_Load(object sender, EventArgs e)
        {
            foreach(var reader in gereData.GetData("select num_virement from virement;"))
            {
                Numer_Virement.Items.Add(reader["num_virement"]);
            }
        }

        private void Numer_Virement_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var reader in gereData.GetData($"select * from virement where num_virement={Numer_Virement.SelectedItem};"))
            {
                Numero_Crediteur.Text = reader["num_crediteur"].ToString();
                NumeroDebiteur.Text = reader["num_debiteur"].ToString();
                Montant.Text = reader["montant_vr"].ToString();
                Date_Virement.Value = Convert.ToDateTime(reader["date_Vr"]);
            }
        }
    }
}