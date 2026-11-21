using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaInventario.Consola
{
    internal class Inventario
    {
        private List<Producto> Productos;

        public Inventario()
        {
            Productos = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }

        public Producto BuscarPorCodigo(string codigo)
        {
            foreach (Producto Producto in Productos)

                if (Producto.Codigo == codigo)
                {
                    return Producto;
                }
                 return null;
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
