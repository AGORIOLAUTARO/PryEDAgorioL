using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// agregamos una libreria que permita ingresar archivos y 
using System.IO;
using System.Windows.Forms;
using System.Security.Policy;

namespace PryEDAgorioL
{
    internal class clsArchivo
    {
        // creamos un campo (una variable que guarde el archivo)
        public String NomArchi = ""; //guarda el nombre del archivo

        public void BorrarTodo()
        {
            StreamWriter AD = new StreamWriter(NomArchi, false);
            AD.Close();

        }

      
         
        



        public void Grabar (String Dato)
        {
            //abrir archivo para escritura
            StreamWriter AD = new StreamWriter(NomArchi, true);
            AD.WriteLine(Dato);
            AD.Close();
        }


        public void Grabar(String dato1, string dato2, string dato3)
        { 
            StreamWriter AD = new StreamWriter(NomArchi, true);
            AD.Write(dato1);//Escribir el contenido e la variable
            AD.Write(";");//Escribir un separador
            AD.Write(dato2);
            AD.Write(";");
            AD.WriteLine(dato3);//Escribir el contenido e la variable + ENTER 
            AD.Close();


        }

         

        public void Recorrer(ListBox lstDatos)
        { 
            lstDatos.Items.Clear();
            String DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchi);
            while (DatoLeido != null)
            {
                lstDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        } //Instancio una sobrecarga pero con combo box y data grid view
        public void Recorrer(ComboBox cmbDatos)
        {

            cmbDatos.Items.Clear();
            String DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchi);
            while (DatoLeido != null) 
            {
                cmbDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }
        public void Recorrer (DataGridView dgvDatos)
        {

            dgvDatos.Rows.Clear();
            String DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchi);
            while (DatoLeido != null) 
            {
                dgvDatos.Rows.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }

    }
    
}
