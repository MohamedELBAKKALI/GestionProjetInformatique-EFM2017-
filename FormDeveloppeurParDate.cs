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
    public partial class FormDeveloppeurParDate : Form
    {
        public FormDeveloppeurParDate()
        {
            InitializeComponent();
           // developpeurBindingSource.DataSource = dbcontext.Developpeur.ToList();
        }
        ModelGestiondesProjetsinformatique dbcontext = new ModelGestiondesProjetsinformatique();

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            var Q = from dev in dbcontext.Developpeur
                    join tac in dbcontext.Tache on dev.cin equals tac.cin
                    where tac.date_Debut >= dateTimePicker1.Value && tac.date_Debut <= dateTimePicker2.Value
                    && tac.date_Fin >= dateTimePicker1.Value && tac.date_Fin <= dateTimePicker2.Value
                    select dev;
            developpeurBindingSource.DataSource = Q.ToList();
            developpeurDataGridView.DataSource = developpeurBindingSource;

        }

        private void developpeurDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==4)
            {
                developpeurBindingSource.RemoveCurrent();
                dbcontext.SaveChanges();
            }
        }
    }
}
