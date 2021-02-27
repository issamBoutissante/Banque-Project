using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_de_Banque
{
    public partial class Suprimer_Compte : Form
    {
        banqueEntities bq;
        public Suprimer_Compte()
        {
            InitializeComponent();
        }

        private void Suprimer_Click(object sender, EventArgs e)
        {
          
            try
            {
                bq = new banqueEntities();
                int selectedValue = int.Parse(Numero_Compte.SelectedValue.ToString());
                Compte compte = bq.Comptes.Where(cl => cl.Num_Compte == selectedValue).First();
                bq.Comptes.Remove(compte);
                bq.SaveChanges();
                MessageBox.Show("la supprission a ete effectue", "Termine", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Compte compte = bq.Comptes.Where(cl => cl.Num_Compte == selectedValue).First();
                Numero_Client.Text = compte.Num_Client.ToString();
                Solde.Text = compte.Solde.ToString();
                Type_Compte.Text = compte.TypeC;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Suprimer_Compte_Load(object sender, EventArgs e)
        {
            RemplirComboBox();   
        }
        void RemplirComboBox()
        {
            try
            {
                bq = new banqueEntities();
                Numero_Compte.DisplayMember = "Num_compte";
                Numero_Compte.ValueMember = "Num_compte";
                Numero_Compte.DataSource = bq.Comptes.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
