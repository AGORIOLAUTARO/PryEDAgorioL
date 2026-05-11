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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }
        clsListaDoble ObjDoble = new clsListaDoble();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            x.Codigo = Convert.ToInt32(txtCodigo.Text);
            x.Nombre = txtNombre.Text;
            x.Tramite = txtTramite.Text;

            ObjDoble.Agregar(x);    
            ObjDoble.Recorrer(lstListaDoble);
            ObjDoble.Recorrer(dgvListaDoble);
            ObjDoble.Recorrer(cmbListaDoble);
            ObjDoble.Recorrer ("ListaDoble.csv");

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ObjDoble.Primero != null)
            {
                Int32 x = Convert.ToInt32(cmbListaDoble.Text);
                ObjDoble.Eliminar(x);
                ObjDoble.Recorrer(lstListaDoble);
                ObjDoble.Recorrer(dgvListaDoble);
                ObjDoble.Recorrer(cmbListaDoble);
                ObjDoble.Recorrer("ListaDoble.csv");
            }
        }

        private void frmListaDoble_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
        }

        private void rbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            ObjDoble.Recorrer(dgvListaDoble);
            ObjDoble.Recorrer(cmbListaDoble);
            ObjDoble.Recorrer(lstListaDoble);
        }

        private void rbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            ObjDoble.RecorrerDesc(dgvListaDoble);
            ObjDoble.RecorrerDesc(cmbListaDoble);
            ObjDoble.RecorrerDesc(lstListaDoble);
        }
        private void ValidarDatos()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }
            
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }
    }
}
