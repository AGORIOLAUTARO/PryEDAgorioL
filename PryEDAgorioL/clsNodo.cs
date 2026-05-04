using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryEDAgorioL
{
    internal class clsNodo
    {
        //creamos los campos
        private Int32 Cod;
        private String Nom;
        private String Tra;
        private clsNodo Sig;
        private clsNodo Ant;


        //propiedades del nodo
        public Int32 Codigo
        {
            get { return Cod; }
            set { Cod = value; }
        }

        public String Nombre
        {
            get { return Nom; }
            set { Nom = value; }
        }
        
        public String Tramite
        {
            get { return Tra; }
            set { Tra = value; }
        }

        public clsNodo Siguiente
        {
            get { return Sig; }
            set { Sig = value; }
        }

        public clsNodo Anterior
        {
            get { return Ant; }
            set { Ant = value; }
        }
    }

}

