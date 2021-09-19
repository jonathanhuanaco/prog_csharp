using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CarritoDeCompras
{
    public class Menu
    {
        private int opcion;
        private int unidades;

        public void MostrarMenu(Camisa camisa, Carrito carrito)
        {
            do
            {
                carrito.CalcularTotal(camisa.GetPrecioUnidad());
                carrito.Descontar();

                Console.WriteLine("MENÚ PRINCIPAL:");
                Console.WriteLine("1- Añadir camisas al carro de compras.");
                Console.WriteLine("2- Eliminar camisas del carro de compras.");
                Console.WriteLine("3- Salir.");
                if (carrito.Cantidad > 0)
                {
                    Console.WriteLine("4- Comprar.");
                }

                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("     -  Cantidad de camisas en el carro de compras: " + carrito.Cantidad);
                Console.WriteLine("     -  Precio unitario: " + camisa.GetPrecioUnidad());
                Console.WriteLine("     -  Precio total sin descuento: $" + carrito.Total);
                Console.WriteLine("     -  Descuento del: " + (carrito.Descuento * 100) + "%");
                Console.WriteLine("     -  Precio final con descuento: $" + carrito.TotalFinal);
                Console.WriteLine("Ingrese segun corresponda: ");

                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("- Introduzca cantidad de camisas a añadir: ");
                            unidades = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("- Se agregaron " + unidades + " camisas.");
                            carrito.Cantidad = carrito.Cantidad + unidades;
                            break;
                        case 2:
                            if (unidades > 0)
                            {
                                Console.WriteLine("- ingrese cantidad de camisas que desea comprar: ");
                                try
                                {
                                    int aux = Convert.ToInt32(Console.ReadLine());
                                    if (aux <= unidades && aux > 0)
                                    {
                                        unidades = unidades - aux;
                                        carrito.Cantidad = unidades;
                                    }
                                    else
                                    {
                                        Console.WriteLine("- fuera de rango");
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("- no puede ingresar un numero negativo");
                                }
                            }
                            else
                            {
                                Console.WriteLine("- no hay camisas en el carrito para eliminar");
                            }
                            break;
                        case 3:
                            char confirm;
                            Console.WriteLine("- seguro desea salir? S/N");
                            try
                            {
                                confirm = Convert.ToChar(Console.ReadLine()[0]);
                                confirm = Char.ToUpper(confirm);

                                if (confirm == 'S')
                                {
                                    Console.WriteLine("- Saliendo...");
                                    Environment.Exit(0);
                                }
                                else if (confirm == 'N')
                                {
                                    opcion = 0;
                                }
                                else
                                {
                                    Console.WriteLine("- opcion no valida");
                                    opcion = 0;
                                }
                            }
                            catch (NullReferenceException)
                            {
                                Console.WriteLine("- para decir 'si' debe ingresar S y para 'no' N");
                            }
                            break;
                        case 4:
                            char complete;
                            if (carrito.Cantidad != 0)
                            {
                                Console.WriteLine("- confirme la compra: S/N");
                                try
                                {
                                    complete = Convert.ToChar(Console.ReadLine()[0]);
                                    complete = Char.ToUpper(complete);

                                    if (complete == 'S')
                                    {
                                        Console.WriteLine("- compra exitosa");
                                        Console.WriteLine("- Saliendo...");
                                        Environment.Exit(0);
                                    }
                                    else if (complete == 'N')
                                    {
                                        opcion = 0;
                                    }
                                    else
                                    {
                                        Console.WriteLine("- opcion no valida");
                                        opcion = 0;
                                    }
                                }
                                catch (NullReferenceException)
                                {
                                    Console.WriteLine("- para decir 'si' debe ingresar S y para 'no' N");
                                }
                            }
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("- el numero ingresado no puede ser negativo");
                }
            } while (opcion != 3);
        }
    }
}