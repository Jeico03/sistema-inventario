namespace SistemaInventario.Consola
{
    internal class ProductoFisico : Producto
    {
        public decimal CostoEnvio { get; private set; }

        public ProductoFisico(
            string codigo,
            string nombre,
            decimal precio,
            int cantidad,
            decimal costoEnvio
        ) : base(codigo, nombre, precio, cantidad)
        {
            if (costoEnvio < 0)
            {
                throw new ArgumentException("El costo de envío no puede ser negativo.");
            }

            CostoEnvio = costoEnvio;
        }

        public override decimal CalcularPrecioFinal()
        {
            return Precio + CostoEnvio;
        }

        public void AplicarDescuento(decimal porcentaje)
        {
            if (porcentaje <= 0 || porcentaje > 100)
            {
                throw new ArgumentException(
                    "El descuento debe ser mayor que 0 y no superar el 100%."
                );
            }

            decimal descuento = Precio * (porcentaje / 100);
            ActualizarPrecio(Precio - descuento);
        }
    }
}
