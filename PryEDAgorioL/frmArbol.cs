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
    public partial class frmArbol : Form
    {
        public frmArbol()
        {
            InitializeComponent();
        }
        clsArbolBinario objArbol = new clsArbolBinario();

        private void frmArbol_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void Validar()
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            x.Codigo = Convert.ToInt32(txtCodigo.Text);
                x.Nombre = txtNombre.Text;
                x.Tramite = txtTramite.Text;

            objArbol.Agregar(x);
            objArbol.Recorrer(dgvArbol);
            objArbol.Recorrer(cmbArbol);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }
    }
}
