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

namespace salon_de_thee.View
{
    public partial class SupprimerServeur : Form
    {
        public SupprimerServeur()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dbconx dd = new Dbconx();
            Dbserveur db = new Dbserveur(dd);
            if (db.ChercherServeur(int.Parse(textBox1.Text)) != null)
            {
                db.SupprimerServeurs(int.Parse(textBox1.Text));
            }
            else
            {
                MessageBox.Show("not found");

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
