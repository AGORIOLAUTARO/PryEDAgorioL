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
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = "Carreras.csv";
            if (File.Exists(x.NomArchi)) x.Recorrer(cmbCarrera);
            if (File.Exists(x.NomArchi)) x.Recorrer(dgvAlumnos);
            btnGrabar.Enabled = false;

            clsArchivo y = new clsArchivo();
            y.NomArchi = "Alumnos.csv";
            if (File.Exists(y.NomArchi)) y.Recorrer(dgvAlumnos);
            btnGrabar.Enabled = false;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = "Alumnos.csv";
            x.Grabar(txtCodigo.Text, txtNombre.Text, cmbCarrera.Text);
            x.Recorrer(dgvAlumnos);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = ("Clientes.csv");
            x.BorrarTodo();

            txtCodigo.Text = "";
            txtNombre.Text = "";
            cmbCarrera.Text = "";
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && cmbCarrera.Text != "")
            {
                btnGrabar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && cmbCarrera.Text != "")
            {
                btnGrabar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
            }
        }
    }
}
