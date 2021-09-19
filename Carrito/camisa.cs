using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CarritoDeCompras
{
    public class Camisa
    {
        //el precio de la unidad de remera sera 1000$ y no van a cambiar
        private const double PrecioUnidad = 1000;
        //tomamos y retornamos el precio
        public double GetPrecioUnidad()
        {
            return PrecioUnidad;
        }
    }
}