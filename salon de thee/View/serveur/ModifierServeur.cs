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

namespace salon_de_thee.View
{
    public partial class ModifierServeur : Form
    {
        public ModifierServeur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dbconx dd = new Dbconx();
            Dbserveur db = new Dbserveur(dd);
            Serveur ss = new Serveur();
            ss= db.ChercherServeur(int.Parse(textBox1.Text));
            if (ss != null)
            {
                textBox2.Text = ss.Name;
                textBox3.Text = ss.Prenom;
            }
            else
            {
                MessageBox.Show("not found");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dbconx dd = new Dbconx();
            Dbserveur db = new Dbserveur(dd);
            db.ModifierServeurs(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
