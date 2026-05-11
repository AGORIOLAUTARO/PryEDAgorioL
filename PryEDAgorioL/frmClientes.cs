using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryEDAgorioL
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = "Clientes.csv";
            x.Grabar(txtCodigo.Text, txtNombre.Text, txtDeuda.Text);
            x.Recorrer(dgvClientes);
                
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = "Clientes.CSV";
            if (File.Exists(x.NomArchi)) x.Recorrer (dgvClientes);
            btnGrabar.Enabled = false;
        }
        private void ValidarDatos()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtDeuda.Text != "")
            {
                btnGrabar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
            }
        }   
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = "Clientes.CSV";
            x.BorrarTodo();

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDeuda.Text = "";
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }
        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }
        private void txtDeuda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Solo se permite un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCodigo_TextChanged_1(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtNombre_TextChanged_1(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtDeuda_TextChanged_1(object sender, EventArgs e)
        {
            ValidarDatos();
        }
    }
}
