using System;
using System.Collections.Generic;
using System.Text;

namespace Pedidos_restaurante
{
    class Plato
    {
        public Plato()
        {

        }
        private int cantidad;

        public string Contenido { get; set; }
        public string Tamano_plato { get; set; }
        public double Precio { get; set; }
        public string Nombre { get; set; }

        public int Cantidad
        {
            get { return Cantidad; }
            set
            {
                cantidad = value;
                if (cantidad <= 2)
                    Tamano_plato = "Pequeño";
                else if (cantidad > 2 & cantidad < 4)
                    Tamano_plato = "Mediano";
                else
                    Tamano_plato = "Grande";
            }
        }

        public void anadirCantidad()
        {
            Cantidad++;
        }

    }
}
