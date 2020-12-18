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
    public partial class Ajouter_Client : Form
    {
        GereData gereData = new GereData();
        public Ajouter_Client()
        {
            InitializeComponent();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gereData.Ajouter($"insert into Client values({Numero.Text},'{Nom.Text}','{Prenom.Text}');"));
        }


    }
}
