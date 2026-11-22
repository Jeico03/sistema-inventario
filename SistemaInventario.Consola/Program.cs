using System;

namespace SistemaInventario.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventario inventario = new Inventario();
            int opcion = -1;

            do
            {
                Console.WriteLine();
                Console.WriteLine("===== SISTEMA DE INVENTARIO =====");
                Console.WriteLine("1. Registrar producto");
                Console.WriteLine("2. Listar productos");
                Console.WriteLine("3. Buscar producto por código");
                Console.WriteLine("4. Actualizar precio");
                Console.WriteLine("5. Agregar existencias");
                Console.WriteLine("6. Consultar valor total");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    switch (opcion)
                    {
                        case 1:
                            Console.Write("Código: ");
                            string codigo = Console.ReadLine();
                            Console.Write("Nombre: ");
                            string nombre = Console.ReadLine();
                            Console.Write("Precio: ");
                            decimal precio = Convert.ToDecimal(Console.ReadLine());
                            Console.Write("Cantidad inicial: ");
                            int cantidad = Convert.ToInt32(Console.ReadLine());

                            Producto nuevo = new Producto(codigo, nombre, precio, cantidad);

                            if (inventario.AgregarProducto(nuevo))
                            {
                                Console.WriteLine("Producto agregado.");
                            }
                            else
                            {
                                Console.WriteLine("Registro rechazado: el código ya existe.");
                            }
                            break;

                        case 2:
                            inventario.ListarProductos();
                            break;

                        case 3:
                            Console.Write("Código a buscar: ");
                            Producto encontrado = inventario.BuscarPorCodigo(Console.ReadLine());

                            if (encontrado == null)
                            {
                                Console.WriteLine("El producto no existe.");
                            }
                            else
                            {
                                encontrado.MostrarInformacion();
                            }
                            break;

                        case 4:
                            Console.Write("Código del producto: ");
                            Producto Actualizarproducto = inventario.BuscarPorCodigo(Console.ReadLine());

                            if (Actualizarproducto == null)
                            {
                                Console.WriteLine("El producto no existe.");
                            }
                            else
                            {
                                Console.Write("Nuevo precio: ");
                                decimal nuevoPrecio = Convert.ToDecimal(Console.ReadLine());
                                Actualizarproducto.ActualizarPrecio(nuevoPrecio);
                                Console.WriteLine("Precio actualizado.");
                            }
                            break;

                        case 5:
                            Console.Write("Código del producto: ");
                            Producto Agregarproducto = inventario.BuscarPorCodigo(Console.ReadLine());

                            if (Agregarproducto == null)
                            {
                                Console.WriteLine("El producto no existe.");
                            }
                            else
                            {
                                Console.Write("Cantidad a agregar: ");
                                int agregar = Convert.ToInt32(Console.ReadLine());
                                Agregarproducto.AgregarExistencia(agregar);
                                Console.WriteLine($"Existencia actualizada. Cantidad actual: {Agregarproducto.Cantidad}");
                            }
                            break;

                        case 6:
                            Console.Write("Código del producto: ");
                            Producto paraValor = inventario.BuscarPorCodigo(Console.ReadLine());

                            if (paraValor == null)
                            {
                                Console.WriteLine("El producto no existe.");
                            }
                            else
                            {
                                Console.WriteLine($"Valor total: RD${paraValor.CalcularValorTotal():N2}");
                            }
                            break;

                        case 0:
                            Console.WriteLine("Saliendo...");
                            break;

                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Operación rechazada: {ex.Message}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada inválida. Debe escribir un número.");
                }

            } while (opcion != 0);
        }
    }
}