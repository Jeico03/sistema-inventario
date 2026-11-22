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

        public bool AgregarProducto(Producto producto)
        {
            if (BuscarPorCodigo(producto.Codigo) == null)
            {
                Productos.Add(producto);
                return true;
            }
            return false;
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

        public void CalcularPreciosFinales()
        {
            foreach (Producto producto in Productos)
            {
                Console.WriteLine($"{producto.Nombre}: RD${producto.CalcularPrecioFinal():N2}" );
            }
        }

        public void ConsultarExistencias(string codigo)
        {
            Producto producto = BuscarPorCodigo(codigo);

            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado.");
                return;
            }

            Console.WriteLine($"Producto: {producto.Nombre}");
            Console.WriteLine($"Existencias: {producto.Cantidad}");
        }

        public void AplicarDescuento(string codigo, decimal porcentaje)
        {
            Producto producto = BuscarPorCodigo(codigo);

            if (producto is IDescontable descontable)
            {
                descontable.AplicarDescuento(porcentaje);
                Console.WriteLine("Descuento aplicado correctamente.");
            }
            else if (producto == null)
            {
                Console.WriteLine("Producto no encontrado.");
            }
            else
            {
                Console.WriteLine("Este producto no admite descuentos.");
            }
        }
    }
}
