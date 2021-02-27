using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_de_Banque
{
    public partial class Consultation_Client : Form
    {
        public Consultation_Client()
        {
            InitializeComponent();
        }

        private void Consultation_Client_Load(object sender, EventArgs e)
        {
            banqueEntities bq = new banqueEntities();
            ClientDataGridView.DataSource = bq.Clients.Select(cl => new { cl.Num_client,Nom=cl.Nom_client+" "+cl.Prenom_Client }).ToList();
        }
    }
}
