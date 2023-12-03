using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace practica_parcial1
{
    class Rotiseria
    {
        private ArrayList listaPedidos = new ArrayList();
        public double TotalRecaudado { get; set; }
        public int TotalPedidos { get; set; }

        public void AgregarPedido(Pedido p)
        {
            listaPedidos.Add(p);
        }

        public void Ordenar()
        {
            QuickSort(0, listaPedidos.Count - 1);
        }

        private void QuickSort(int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(low, high);

                QuickSort(low, pi - 1);
                QuickSort(pi + 1, high);
            }
        }

        private int Partition(int low, int high)
        {
            Pedido pivot = (Pedido)listaPedidos[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (((Pedido)listaPedidos[j]).CompareTo(pivot) < 0)
                {
                    i++;

                    // Swap listaPedidos[i] y listaPedidos[j]
                    Pedido temp = (Pedido)listaPedidos[i];
                    listaPedidos[i] = listaPedidos[j];
                    listaPedidos[j] = temp;
                }
            }

            // Swap listaPedidos[i + 1] y listaPedidos[high]
            Pedido temp1 = (Pedido)listaPedidos[i + 1];
            listaPedidos[i + 1] = listaPedidos[high];
            listaPedidos[high] = temp1;

            return i + 1;
        }
        public Pedido VerPedido(int numero)
        {
            Pedido nuevoP = new Pedido(numero,"");
            Ordenar();
            int orden = listaPedidos.BinarySearch(nuevoP);

            if (orden >= 0)
            {
                return (Pedido)listaPedidos[orden];
            }
            return null;
        }
    }
}
