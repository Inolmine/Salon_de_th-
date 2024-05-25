using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using salon_de_thee.dal;
using salon_de_thee.Models;

namespace salon_de_thee.View.boisson
{
    public partial class ModifierBoisson : Form
    {
        public ModifierBoisson()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dbconx dd = new Dbconx();
            DbBoissons db1 = new DbBoissons(dd);
            db1.ModifierBoisson(int.Parse(textBox1.Text), textBox2.Text, int.Parse(textBox3.Text),int.Parse(textBox4.Text));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dbconx dd = new Dbconx();
            DbBoissons db1 = new DbBoissons(dd);
            Boissons bb = new Boissons();
            bb = db1.ChercherBoisson(int.Parse(textBox1.Text));
            if (bb != null)
            {
                textBox2.Text = bb.Designation;
                textBox3.Text = bb.Prix.ToString();
                textBox4.Text = bb.QteStock.ToString();
            }
            else
            {
                MessageBox.Show("not found");
            }
            
        }
    }
}
