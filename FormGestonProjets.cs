using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionProjetInformatique
{
    public partial class FormGestonProjets : Form
    {
        public FormGestonProjets()
        {
            InitializeComponent();
            projetBindingSource.DataSource = dbcontext.Projet.ToList();
        }

        public void Actualise()
        {
            projetBindingSource.DataSource = dbcontext.Projet.ToList();
        }

        public ModelGestiondesProjetsinformatique dbcontext = new ModelGestiondesProjetsinformatique();

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            projetBindingSource.AddNew();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            projetBindingSource.EndEdit();
            dbcontext.SaveChanges();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            projetBindingSource.RemoveCurrent();
            dbcontext.SaveChanges();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            projetBindingSource.EndEdit();
            dbcontext.SaveChanges();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            dbcontext.SaveChanges();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            projetBindingSource.MoveLast();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            projetBindingSource.MoveNext();
        }

        private void btnPrivie_Click(object sender, EventArgs e)
        {
            projetBindingSource.MovePrevious();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            projetBindingSource.MoveFirst();
        }
    }
}
