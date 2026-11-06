namespace SistemaInventario.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Producto Laptop = new Producto();
            Producto Mouse = new Producto();
            Producto Teclado = new Producto();

            Laptop.Codigo = "P001";
            Laptop.Nombre = "Laptop";
            Laptop.Precio = 100m;
            Laptop.Cantidad = 5;

            Mouse.Codigo = "P002";
            Mouse.Nombre = "Mouse";
            Mouse.Precio = 250m;
            Mouse.Cantidad = 0;

            Teclado.Codigo = "P003";
            Teclado.Nombre = "Teclado";
            Teclado.Precio = 50m;
            Teclado.Cantidad = 10;

            Console.WriteLine("=== Laptop ===");
            Laptop.MostrarInformacion();
            Console.WriteLine($"Valor total: RD${Laptop.CalcularValorTotal():N2}");

            Console.WriteLine("\n=== Mouse ===");
            Mouse.MostrarInformacion();
            Console.WriteLine($"Valor total: RD${Mouse.CalcularValorTotal():N2}");

            Console.WriteLine("\n=== Teclado ===");
            Teclado.MostrarInformacion();
            Console.WriteLine($"Valor total: RD${Teclado.CalcularValorTotal():N2}");

            // Modificar el precio de un producto: los demás no cambian
            Console.WriteLine("\n--- Se cambia el precio del Teclado a RD$75.00 ---");
            Teclado.Precio = 75m;

            Console.WriteLine("\n=== Laptop (sin cambios) ===");
            Laptop.MostrarInformacion();
            Console.WriteLine($"Valor total: RD${Laptop.CalcularValorTotal():N2}");

            Console.WriteLine("\n=== Mouse (sin cambios) ===");
            Mouse.MostrarInformacion();
            Console.WriteLine($"Valor total: RD${Mouse.CalcularValorTotal():N2}");

            Console.WriteLine("\n=== Teclado (precio modificado) ===");
            Teclado.MostrarInformacion();
            Console.WriteLine($"Valor total: RD${Teclado.CalcularValorTotal():N2}");
        }
    }
}
