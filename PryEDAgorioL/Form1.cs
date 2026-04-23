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

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes vent = new frmClientes();
            vent.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos vent = new frmAlumnos(); 
            vent.ShowDialog();
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarreras vent = new frmCarreras();
            vent.ShowDialog();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola vent = new frmCola();
            vent.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila vent = new frmPila();
            vent.ShowDialog();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple vent = new frmListaSimple();
            vent.ShowDialog();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble vent = new frmListaDoble();
            vent.ShowDialog();
        }
    }
}
