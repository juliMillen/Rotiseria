﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_parcial1
{
    class ItemMenu
    {
        private string descripcion;
        public double Precio { get; set; }

        public ItemMenu(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public string Descripcion()
        {
            return descripcion;
        }
    }
}
