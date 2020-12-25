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
    public partial class Liste_mouvement : Form
    {
        GereData gereData = new GereData();
        public Liste_mouvement()
        {
            InitializeComponent();
        }

        private void Afficher_Liste_Click(object sender, EventArgs e)
        {
            foreach(var reader in gereData.GetData("select * from mouvement;"))
            {
                MouvementDataGridView.Rows.Add(reader["num_mouvement"], reader["num_compte"], reader["montant"], reader["typeM"], reader["dateM"]);
            }
        }
    }
}
