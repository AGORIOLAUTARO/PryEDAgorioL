using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// agregamos una libreria que permita ingresar archivos y 
using System.IO;

namespace PryEDAgorioL
{
    internal class clsArchivo
    {
        // creamos un campo (una variable que guarde el archivo)
        public String NomArchi = "Colores.txt"; //guarda el nombre del archivo

        public void Grabar (String Dato)
        {
            //abrir archivo para escritura
            StreamWriter AD = new StreamWriter(NomArchi, true);
            AD.WriteLine(Dato);
            AD.Close();
        }

    }
    
}
