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
    public partial class FormdeveloParProjet : Form
    {
        public FormdeveloParProjet()
        {
            InitializeComponent();
            //developpeurBindingSource.DataSource = dbcontext.Developpeur.ToList();
            //tacheBindingSource.DataSource = dbcontext.Tache.ToList();
            comboBox1.DataSource = dbcontext.Projet.ToList();
            comboBox1.ValueMember = "num_projet";
            comboBox1.SelectedValueChanged += comboBox1_SelectedIndexChanged;
        }

        ModelGestiondesProjetsinformatique dbcontext = new ModelGestiondesProjetsinformatique();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idp = (int)comboBox1.SelectedValue;

            var p = from dev in dbcontext.Developpeur
                    join ta in dbcontext.Tache on dev.cin equals ta.cin
                    where ta.num_projet == idp
                    select dev;
            
            //var rqt = dbcontext.Tache.ToList()
            //    .Where(s => s.Projet.num_projet == int.Parse(comboBox1.ValueMember));//hada howa jawab 3atzid join
            //// db khsek tjib projet selectionne
            //var rqt2 = dbcontext.Developpeur.ToList().Where(s => s.Tache == ((comboBox1.ValueMember)) as Tache)


            developpeurBindingSource.DataSource = p.ToList();
            developpeurDataGridView.DataSource = developpeurBindingSource;
                //dbcontext.Tache.ToList().Where(s => s.Projet.num_projet == int.Parse(comboBdox1.ValueMember));
        }
    }
}
