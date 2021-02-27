using System;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_de_Banque
{
    public partial class Modifier_Compte : Form
    {
        banqueEntities bq;
        public Modifier_Compte()
        {
            InitializeComponent();
        }
        private void Modifier_Load(object sender, EventArgs e)
        {
            try
            {
                bq = new banqueEntities();
                Numero_Compte.DisplayMember = "Num_Compte";
                Numero_Compte.ValueMember = "Num_Compte";
                Numero_Compte.DataSource = bq.Comptes.ToList();

                Numero_Client.DisplayMember = "Num_Client";
                Numero_Client.ValueMember = "Num_Client";
                Numero_Client.DataSource = bq.Clients.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Numero_Compte_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bq = new banqueEntities();
                int selectedValue = int.Parse(Numero_Compte.SelectedValue.ToString());
                Compte compte = bq.Comptes.Where(comp=>comp.Num_Compte==selectedValue).First();
                Numero_Client.Text = compte.Num_Client.ToString();
                Solde.Text = compte.Solde.ToString();
                Type_Compte.Text = compte.TypeC;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                bq = new banqueEntities();
                int selectedValue = int.Parse(Numero_Compte.SelectedValue.ToString());
                Compte compte = bq.Comptes.Where(com=>com.Num_Compte==selectedValue).First();
                compte.Num_Client= int.Parse(Numero_Client.Text);
                compte.Solde= decimal.Parse(Solde.Text);
                compte.TypeC= Type_Compte.Text;
                bq.SaveChanges();
                MessageBox.Show("la modification a ete effectue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
