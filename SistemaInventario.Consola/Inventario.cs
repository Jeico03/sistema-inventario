using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaInventario.Consola
{
    internal class Inventario
    {
        private List<Producto> Productos();

        public Inventario()
        {
            Productos = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            Productos().Add(producto);
        }

        public void BuscarPorCodigo(string codigo)
        {
            foreach (Productos Producto in Productos)

                if (Producto.Codigo == codigo)
                {
                    Console.WriteLine($"Producto encontrado: {Producto.Nombre}, Precio: {Producto.Precio}");
                    return;
                }
            Console.WriteLine("Producto no encontrado.");
        }

        public void ListarProductos()
        {
            Console.WriteLine("Lista de productos en el inventario:");
            foreach (Producto producto in Productos)
            {
              producto.MostrarInformacion();
            }
        }



    }
}
