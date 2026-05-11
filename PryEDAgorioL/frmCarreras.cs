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
    public partial class frmCarreras : Form
    {
        public frmCarreras()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = "Carreras.csv";
            x.Grabar(txtCarreras.Text);
            x.Recorrer(lstCarreras);

            txtCarreras.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = "Carreras.csv";
            x.BorrarTodo();
            x.Recorrer(lstCarreras);


        }

        private void frmCarreras_Load(object sender, EventArgs e)
        {
            btnGrabar.Enabled = false;

        }

        private void txtCarreras_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void ValidarDatos()
        {
            if (txtCarreras.Text != "")
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
