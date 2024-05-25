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

namespace salon_de_thee.View.commande
{
    public partial class AjouterCommande : Form
    {
        public AjouterCommande()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dbconx dd = new Dbconx();
            Dbcommande db2 = new Dbcommande(dd);
            if (db2.ChercherCommande(int.Parse(textBox1.Text)) == null)
            {
                Commande cc = new Commande(int.Parse(textBox1.Text),dateTimePicker1.Value, int.Parse(textBox2.Text), int.Parse(textBox3.Text));
                db2.AjouterCommande(cc);

            }
            else
            {
                MessageBox.Show("il existe");
            }
           
           
        }

        private void AjouterCommande_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
