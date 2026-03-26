using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEDAgorioL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void datosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatosdelDesarrollador v = new FrmDatosdelDesarrollador();
            v.ShowDialog();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColores ven = new frmColores();
            ven.ShowDialog();   
        }

        private void mesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeses vent = new frmMeses();
            vent.ShowDialog();

        }
    }
}
