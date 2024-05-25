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

namespace salon_de_thee.View.boisson
{
    public partial class SupprimerBoisson : Form
    {
        public SupprimerBoisson()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dbconx dd = new Dbconx();
            DbBoissons db1 = new DbBoissons(dd);
            if (db1.ChercherBoisson(int.Parse(textBox1.Text)) == null)
            {
                MessageBox.Show("not found");
            }
            else
            {
                db1.SupprimerBoisson(int.Parse(textBox1.Text));
                
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
