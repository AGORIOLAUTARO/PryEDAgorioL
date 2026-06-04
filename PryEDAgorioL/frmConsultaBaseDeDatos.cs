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
    public partial class frmConsultaBaseDeDatos : Form
    {
        public frmConsultaBaseDeDatos()
        {
            InitializeComponent();
        }

        private void btnListarSQL_Click(object sender, EventArgs e)
        {
            clsBaseDatos objBaseDatos = new clsBaseDatos();
            objBaseDatos.Listar(dgvCtaSql, txtSQL.Text);
        }
    }
}
