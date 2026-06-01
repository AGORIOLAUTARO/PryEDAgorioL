using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PryEDAgorioL
{
    internal class clsBaseDatos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\BD_EDAgorio.mdb";
        private string CadenaConexion2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\BD_EDAgorio.accdb";

        public void Listar(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion1;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Libro";

                adaptador.SelectCommand = comando;
                DataTable Ds = new DataTable();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(Ds, "Libro");

                Grilla.DataSource = null;
                Grilla.DataSource = Ds.Tables["Libro"];
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

    }
}
