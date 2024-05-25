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
    public partial class ModifierCommande : Form
    {
        public ModifierCommande()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dbconx dd = new Dbconx();
            Dbcommande db2 = new Dbcommande(dd);
            Commande cc = new Commande();
            cc = db2.ChercherCommande(int.Parse(textBox1.Text));
            if (cc!=null)
            {
                textBox2.Text = cc.Heure.ToString();
                textBox3.Text = cc.Serveur.ToString();
                // = cc.DateCom;
            }
            else
            {
                MessageBox.Show("not found");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dbconx dd = new Dbconx();
            Dbcommande db2 = new Dbcommande(dd);
            db2.ModifierCommande(int.Parse(textBox1.Text),dateTimePicker1.Value, int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            MessageBox.Show("modifier"); 
            
        }
    }
}
