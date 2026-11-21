using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaInventario.Consola
{
    internal class Producto
    {
        public string Codigo { get; set; } = "";
        public string Nombre { get; set; } = "";
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        public Producto (string codigo, string nombre, decimal precio, int cantidad)
        {
            if (string.IsNullOrWhiteSpace(Codigo) || string.IsNullOrWhiteSpace(Nombre))
            {
                throw new ArgumentException("El código y el nombre del producto no pueden estar vacíos.");
            }

            if (Precio <= 0 || Cantidad <= 0)
            {
                throw new ArgumentException("El precio y la cantidad del producto deben ser mayores que cero.");
            }

            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Precio: RD${Precio:N2}");
            Console.WriteLine($"Cantidad: {Cantidad}");
        }

        public decimal CalcularValorTotal()
        {
            return Precio * Cantidad;
        }

        public void ActualizarPrecio(decimal nuevoPrecio)
        {
            if(nuevoPrecio <= 0)
            {
                throw new ArgumentException("El nuevo precio debe ser mayor que cero.");
            }
            Precio = nuevoPrecio;
        }

        public void AgregarExistencia(int cantidad)
        {
            if(cantidad <= 0)
            {
                throw new ArgumentException("La cantidad a agregar debe ser mayor que cero.");
            }
            Cantidad += cantidad;
        }
    }
}
