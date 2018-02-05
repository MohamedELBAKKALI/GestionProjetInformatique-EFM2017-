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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void projetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestonProjets gp = new FormGestonProjets();
            gp.ShowDialog();
        }

        private void afficherDeveParProjetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormdeveloParProjet dp = new FormdeveloParProjet();
            dp.ShowDialog();
        }

        private void afficherDeveloppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDeveloppeurParDate dpD = new FormDeveloppeurParDate();
            dpD.ShowDialog();
        }

        private void rapportcreQ7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void crystalRparComboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCrystalparcombo cc = new FormCrystalparcombo();
            cc.ShowDialog();
        }
    }
}
