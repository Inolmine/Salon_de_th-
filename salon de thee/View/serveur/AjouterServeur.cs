using salon_de_thee.dal;
using salon_de_thee.Models;

namespace salon_de_thee
{
    public partial class AjouterServeur : Form
    {
        public AjouterServeur()
        {
            InitializeComponent();
        }

        private void AjouterServeur_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dbconx dd = new Dbconx();
            Dbserveur db = new Dbserveur(dd);
            if (db.ChercherServeur(int.Parse(textBox1.Text))!= null)
            {
                 MessageBox.Show("existe");
            }
            else 
            {
                Serveur s = new Serveur(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text);
                db.AjouterServeurs(s);
                MessageBox.Show("ajouter");

            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}