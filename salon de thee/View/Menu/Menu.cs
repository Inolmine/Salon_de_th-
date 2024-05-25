using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using salon_de_thee.View.boisson;
using salon_de_thee.View.commande;

namespace salon_de_thee.View.Menu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void serveurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterServeur ajouter = new AjouterServeur();
            ajouter.ShowDialog();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierServeur modifier = new ModifierServeur();
            modifier.ShowDialog();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerServeur supprimer= new SupprimerServeur();
            supprimer.ShowDialog();
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AjouterBoisson ajouter = new AjouterBoisson();
            ajouter.ShowDialog();
        }

        private void modifierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModifierBoisson modifier = new ModifierBoisson();   
            modifier.ShowDialog();
        }

        private void supprimerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SupprimerBoisson supprimer = new SupprimerBoisson();
            supprimer.ShowDialog();
        }

        private void ajouterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AjouterCommande ajouter = new AjouterCommande();
            ajouter.ShowDialog();
        }

        private void modiferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierCommande modifier = new ModifierCommande();
            modifier.ShowDialog();
        }

        private void supprimerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SupprimerCommande supprimer= new SupprimerCommande();
            supprimer.ShowDialog();
        }
    }
}
