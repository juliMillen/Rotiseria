using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace practica_parcial1
{
    class Pedido:IComparable
    {
        private ArrayList menu = new ArrayList();
        private string cliente;
        public int Numero { get; private set; }

        protected double precio;

        public double PrecioProd
        {
            get { return precio; }
            set { precio = value; }
        }
        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public Pedido(int numero, string cliente)
        {
            this.Numero = numero;
            this.cliente = cliente;
        }


        public void AgregarItem(ItemMenu men, int cantidad)
        {
            if (cantidad > 0)
            {
                menu.Add(men);
            }
            else
            {
                throw new Exception("No se ha cargado ningun producto");
            }
        }

        public virtual double Precio()
        {
            precio += precio;
            if (precio > 5000)
            {
                precio = precio - (precio * 5) / 100;
            }
            return precio;
        }

        public int CompareTo(Object obj)
        {
            return this.PrecioProd.CompareTo(((Pedido)obj).PrecioProd);
        }
    }
}
