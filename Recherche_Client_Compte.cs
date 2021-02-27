using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_de_Banque
{
    public partial class Recherche_Client_Compte : Form
    {
        banqueEntities bq;
        public Recherche_Client_Compte()
        {
            InitializeComponent();
        }

        private void Recherche_Client_Compte_Load(object sender, EventArgs e)
        {
            bq = new banqueEntities();
            Numero.DisplayMember = "Num_client";
            Numero.ValueMember = "Num_client";
            Numero.DataSource = bq.Clients.ToList();
        }

        private void Numero_SelectedIndexChanged(object sender, EventArgs e)
        {
            bq = new banqueEntities();
            int selectedValue = int.Parse(Numero.SelectedValue.ToString());
            ComptesDeClientDataGridView.DataSource = bq.Comptes.Where(cl=>cl.Num_Client==selectedValue).ToList();
        }
    }
}
