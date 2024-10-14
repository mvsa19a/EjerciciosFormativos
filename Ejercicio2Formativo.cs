using System;

namespace InventarioProductos
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Diccionario para almacenar el inventario
            Dictionary<string, (double precio, int cantidad)> inventario = new Dictionary<string, (double, int)>();

            // Añadir productos al inventario
            AgregarProducto(ref inventario, "Producto1", 10.5, 50);
            AgregarProducto(ref inventario, "Producto2", 25.0, 30);
            AgregarProducto(ref inventario, "Producto3", 5.75, 100);

            // Actualizar el stock de un producto
            Console.WriteLine("\nActualizar el stock de 'Producto2' a 60 unidades:");
            ActualizarStock(ref inventario, "Producto2", 60);

            // Calcular el valor total del inventario
            double valorTotal = CalcularValorTotal(ref inventario);
            Console.WriteLine($"\nEl valor total del inventario es: {valorTotal:C}");

            Console.ReadKey();
        }

        // Funcion para agregar productos al inventario
        public static void AgregarProducto(ref Dictionary<string, (double precio, int cantidad)> inventario, string nombre, double precio, int cantidad)
        {
            if (!inventario.ContainsKey(nombre))
            {
                inventario[nombre] = (precio, cantidad);
                Console.WriteLine($"Producto '{nombre}' agregado al inventario con precio {precio:C} y cantidad {cantidad}.");
            }
            else
            {
                Console.WriteLine($"El producto '{nombre}' ya existe en el inventario.");
            }
        }

        // Funcion para actualizar el stock de un producto
        public static void ActualizarStock(ref Dictionary<string, (double precio, int cantidad)> inventario, string nombre, int nuevaCantidad)
        {
            if (inventario.ContainsKey(nombre))
            {
                var producto = inventario[nombre];
                inventario[nombre] = (producto.precio, nuevaCantidad);
                Console.WriteLine($"Stock actualizado para '{nombre}'. Nueva cantidad: {nuevaCantidad}.");
            }
            else
            {
                Console.WriteLine($"El producto '{nombre}' no existe en el inventario.");
            }
        }

        // Funcion para calcular el valor total del inventario
        public static double CalcularValorTotal(ref Dictionary<string, (double precio, int cantidad)> inventario)
        {
            double valorTotal = 0;

            foreach (var producto in inventario)
            {
                valorTotal += producto.Value.precio * producto.Value.cantidad;
            }

            return valorTotal;
        }
    }
}
