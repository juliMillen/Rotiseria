using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_parcial1
{
    class Delivery:Pedido
    {

        private double distancia;

        public Delivery(int num, string cliente, double distEnKm) : base(num, cliente)
        {
            distancia = distEnKm;
        }

        public override double Precio()
        {
            return base.Precio() + 150 + (base.Precio() * distancia * 0.08);
        }
    }
}
