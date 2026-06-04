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
    public partial class frmOperacionesBaseDeDatos : Form
    {
        public frmOperacionesBaseDeDatos()
        {
            InitializeComponent();
        }
        clsBaseDatos objBaseDatos = new clsBaseDatos();
        private void btnProSimple_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO " +
                "FROM LIBRO " +
                "ORDER BY 1 DESC";
            objBaseDatos.Listar(dgvOperaciones,varSQL);
        }

        private void btnProMultiAtributo_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT TITULO, AÑO " +
                "FROM LIBRO " +
                "ORDER BY 1 ASC";
            objBaseDatos.Listar(dgvOperaciones, varSQL);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT Libro.Titulo, Autor.Nombre " +
                "FROM Libro INNER JOIN Autor " +
                "ON Libro.IdAutor = Autor.IdAutor";
            objBaseDatos.Listar(varSQL, dgvOperaciones);
        }

        private void btnConvolucion_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * " +
                "FROM (select * from libro whre idIdioma > 1) as X " +
                "WHERE IDPAIS = 2 ";
            objBaseDatos.Listar(dgvOperaciones, varSQL);
        }
    }
}
