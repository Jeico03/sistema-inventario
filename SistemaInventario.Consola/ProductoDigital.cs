using System;
using System.Collections.Generic;
using System.Text;


namespace SistemaInventario.Consola
{
    internal class ProductoDigital : Producto, IDescontable
    {
        public ProductoDigital(
            string codigo,
            string nombre,
            decimal precio,
            int cantidad
        ) : base(codigo, nombre, precio, cantidad)
        {
        }

        public override decimal CalcularPrecioFinal()
        {
            return Precio;
        }
    }
}

