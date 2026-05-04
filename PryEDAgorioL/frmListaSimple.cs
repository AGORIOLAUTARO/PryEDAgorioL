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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }

        clsListaSimple objLista = new clsListaSimple();
        
        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            x.Codigo = Convert.ToInt32(txtCodigo.Text);
            x.Nombre = txtNombre.Text;
            x.Tramite = txtTramite.Text;

            objLista.Agregar(x);
            objLista.Recorrer(dgvListaSimple);
            objLista.Recorrer(cmbListaSimple);
            objLista.Recorrer(lstListaSimple);
            objLista.Recorrer("clsListaSimple.csv");

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void dgvListaSimple_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(objLista.Primero != null)
            {
                Int32 x = Convert.ToInt32(cmbListaSimple.Text);
                objLista.Eliminar(x);
                objLista.Recorrer(dgvListaSimple);
                objLista.Recorrer(cmbListaSimple);
                objLista.Recorrer(lstListaSimple);
                objLista.Recorrer("ListaSimple.csv");
            }
            else
            {
                MessageBox.Show("La lista esta vacia");
            }
            btnEliminar.Enabled = false;
        }
        private void ValidarDatos()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text !="")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false; 
            }
        }

        private void cmbListaSimple_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbListaSimple.Text != "")
            {
                btnEliminar.Enabled= true;
            }
            else
            {      
                btnEliminar.Enabled = false;
            }
        }
    }
}
