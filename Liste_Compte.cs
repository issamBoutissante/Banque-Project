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
    public partial class Liste_Compte : Form
    {
        GereData gereData = new GereData();
        public Liste_Compte()
        {
            InitializeComponent();
        }

        private void Afficher_Liste_Click(object sender, EventArgs e)
        {
            foreach(var reader in gereData.GetData("select * from compte;"))
            {
                CompteDataGridView.Rows.Add(reader["num_Compte"], reader["num_Client"], reader["solde"], reader["TypeC"]);
            }
        }
    }
}
