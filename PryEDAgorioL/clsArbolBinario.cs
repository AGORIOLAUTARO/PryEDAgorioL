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
                    if (Nvo.Codigo < Aux.Codigo) Aux = Aux.Izquierdo;
                    else Aux = Aux.Derecho;

                }
                if (Nvo.Codigo < P.Codigo) P.Izquierdo = Nvo;
                else P.Derecho = Nvo;
            }
        }
        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        private void InOrdenAsc(DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Dgv, R.Izquierdo);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(Dgv, R.Derecho);

        }

        public void Recorrer(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);

        }

        private void InOrdenAsc(ComboBox cmb, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(cmb, R.Izquierdo);
            cmb.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(cmb, R.Derecho);
        }

        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Arbol");
            tree.Nodes.Add(NodoPadre);
            PreOrden(Raiz, NodoPadre);
            tree.ExpandAll();
        }

        private void PreOrden(clsNodo R, TreeNode nodoTreeView)
        { TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());
            nodoTreeView.Nodes.Add(NodoPadre);
            if (R.Izquierdo != null)
            {
                PreOrden(R.Izquierdo, NodoPadre);
            }
            if (R.Derecho != null)
            {
                PreOrden(R.Derecho, NodoPadre);

            }


        }

        private void InOrdenAsc(clsNodo[] vec, ref int ind, clsNodo R)
        {

            if (R.Izquierdo !=null) InOrdenAsc(vec,ref ind, R.Izquierdo);
            vec[ind] = R;
            ind++;
            if (R.Derecho!=null) InOrdenAsc(vec,ref ind,R.Derecho);
        }
        public void Recorrer(clsNodo[] vector)
        {
            int ind = 0;
            if(Raiz != null)
            {
                InOrdenAsc(vector,ref ind,Raiz);
            }
        }
        public void RecorrerPreOrden (DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);


        }
        private void PreOrden(DataGridView grilla, clsNodo R)
        {

            if(R != null)
            {
                grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
                PreOrden(grilla, R.Izquierdo);
                PreOrden(grilla,R.Derecho);

            }
        }
        public void RecorrerPostOrden (DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);
        }
        private void PostOrden (DataGridView grilla, clsNodo R)
        {
            if (R != null)
            {
                PostOrden(grilla, R.Izquierdo);
                PostOrden(grilla, R.Derecho);
                grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            }

        }

    }
}
