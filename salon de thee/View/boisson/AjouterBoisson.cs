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

namespace salon_de_thee.View.boisson
{
    public partial class AjouterBoisson : Form
    {
        public AjouterBoisson()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Dbconx dd = new Dbconx();
            DbBoissons db1 = new DbBoissons(dd);
            if(db1.ChercherBoisson(int.Parse(textBox1.Text)) ==null)
            {
                Boissons b = new Boissons(int.Parse(textBox1.Text), textBox2.Text, int.Parse(textBox3.Text), int.Parse(textBox4.Text));
                db1.AjouterBoisson(b);
            }
            else
            {
                MessageBox.Show("il existe");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
