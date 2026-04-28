using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace PryEDAgorioL
{
    internal class clsPila
    {
        private clsNodo pri;


        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public void Agregar (clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                Nuevo.Siguiente = Primero;
                Primero = Nuevo;
            }
        }
        public void Eliminar()
        {
            if (Primero != null)
            {
                Primero = Primero.Siguiente;
            }
        }
        public void Recorrer (DataGridView Grilla)
        {
            clsNodo Aux = Primero;
            Grilla.Rows.Clear();
            while (Aux != null)
            {
                Grilla.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Siguiente;
            }
        }
        public void Recorrer (ListBox Lista)
        {
            clsNodo Aux = Primero;
            Lista.Items.Clear();
            while (Aux != null)
            {
                Lista.Items.Add(Aux.Codigo + " - " + Aux.Nombre + " - " + Aux.Tramite);
                Aux = Aux.Siguiente;
            }
        }
        public void Recorrer (string clsPila)
        {
            clsNodo Aux = Primero;
            System.IO.StreamWriter ArchivoSalida = new System.IO.StreamWriter(clsPila);
            while (Aux != null)
            {
                ArchivoSalida.WriteLine(Aux.Codigo + ";" + Aux.Nombre + ";" + Aux.Tramite);
                Aux = Aux.Siguiente;
            }
            ArchivoSalida.Close();
            ArchivoSalida.Dispose();
        }
    }
}

