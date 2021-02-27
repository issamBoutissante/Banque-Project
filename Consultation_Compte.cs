using System;
using System.Linq;
using System.Windows.Forms;

namespace Gestion_de_Banque
{
    public partial class Consultation_Compte : Form
    {
        public Consultation_Compte()
        {
            InitializeComponent();
        }
        private void Consultation_Compte_Load(object sender, EventArgs e)
        {
            banqueEntities bq = new banqueEntities();
            CompteDataGridView.DataSource = bq.Comptes.ToList();
        }
    }
}
