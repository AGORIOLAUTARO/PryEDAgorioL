using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEDAgorioL
{
    internal class clsArbolBinario
    {
        private clsNodo Pri;

        public clsNodo Raiz
        {
            get { return Pri; }
            set { Pri = value; }
        }

        public void Agregar(clsNodo Nvo)
        {
            if (Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodo P = Raiz;
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    P = Aux;
                    if(Nvo.Codigo < Aux.Codigo) Aux = Aux.Izquierdo;
                    else Aux = Aux.Derecho;

                }
                if (Nvo.Codigo < P.Codigo) P.Izquierdo = Nvo;
                else P.Derecho = Nvo;
            }
        } 
        public void Recorrer (DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        private void InOrdenAsc (DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Dgv, R.Izquierdo);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(Dgv, R.Derecho);

        }

        public void Recorrer (ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);

        }

        private void InOrdenAsc (ComboBox cmb, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(cmb, R.Izquierdo);
            cmb.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(cmb, R.Derecho);
        }

    }
}
