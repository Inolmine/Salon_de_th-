using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using salon_de_thee.dal;
using salon_de_thee.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace salon_de_thee.View.commande
{
    public partial class SupprimerCommande : Form
    {
        public SupprimerCommande()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dbconx dd = new Dbconx();
            Dbcommande db2 = new Dbcommande(dd);
            if (db2.ChercherCommande(int.Parse(textBox1.Text)) == null)
            {
                MessageBox.Show("not found");

            }
            else
            {
                db2.SupprimerCommande(int.Parse(textBox1.Text));
            }

        }
    }
}
