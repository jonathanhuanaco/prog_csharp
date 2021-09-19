using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarritoDeCompras
{
    public class Carrito
    {
        private int cantidad;
        private double total;
        private double descuento;
        private double neto;
        //constructor
        public Carrito()
        {
            Cantidad = 0;
        }

        public void CalcularTotal(double Precio)
        {
            Total = Cantidad * Precio;
        }

        public void Descontar()
        {
            if (Cantidad >= 3 && Cantidad <= 5)
            {
                Descuento = 0.1;
            }
            else if (Cantidad > 5)
            {
                Descuento = 0.2;
            }
            else
            {
                Descuento = 0.0;
            }

            TotalFinal = Total - Total * Descuento;
        }

        public int Cantidad
        {
            get => cantidad;
            set => cantidad = value;
        }

        public double Total
        {
            get => total;
            set => total = value;
        }

        public double Descuento
        {
            get => descuento;
            set => descuento = value;
        }

        public double TotalFinal
        {
            get => neto;
            set => neto = value;
        }
    }
}