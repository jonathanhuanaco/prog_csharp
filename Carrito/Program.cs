using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CarritoDeCompras
{
    internal class Program//acceso a clases dentro del programa
    {
        public static void Main(string[] args)//main
        {
            //instancia Camisa a camisa
            Camisa camisa = new Camisa();
            //instancia Carrito a carrito
            Carrito carrito = new Carrito();
            //instancia Menu a menu
            Menu menu = new Menu();

            Console.WriteLine("SHOPPING ONLINE DE CAMISAS – Ventas minoristas y mayoristas.");
            Console.WriteLine("---------------------------------------------");
            //se muestra menu y se envian los objetos camisa y carrito
            menu.MostrarMenu(camisa, carrito);
        }
    }
}