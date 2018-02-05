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
    public partial class FormCrystalparcombo : Form
    {
        public FormCrystalparcombo()
        {
            InitializeComponent();
            //comboBox1.DataSource = dbcontext.Tache.ToList();
        }
       // ModelGestiondesProjetsinformatique dbcontext = new ModelGestiondesProjetsinformatique();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //int idp = (int)comboBox1.SelectedValue;
            //this.CrystalReport31.SetParameterValue("num_projet", idp);
        }
    }
}
