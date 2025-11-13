namespace Revisar_si_un_producto_esta_agotado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arreglo con los productos que están agotados en la tienda
            string[] agotados = { "Arroz", "Azúcar", "Leche", "Huevos", "Aceite" };

            // Se pide al usuario que ingrese el nombre del producto que quiere verificar
            Console.Write("Ingrese el producto a verificar: ");
            string productoBuscado = Console.ReadLine();

            bool encontrado = false; // Variable para saber si el producto fue encontrado

            // Se recorre el arreglo completo con un bucle for
            for (int i = 0; i < agotados.Length; i++)
            {
                // Se compara el producto actual con el nombre ingresado, ignorando mayúsculas o minúsculas
                if (agotados[i].Equals(productoBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    encontrado = true; // Si se encuentra, se cambia el valor de encontrado a true
                    // Se muestra un mensaje indicando que el producto está agotado y su posición en el arreglo
                    Console.WriteLine($"El producto '{productoBuscado}' está agotado (posición {i}).");
                    break; // Se detiene el bucle porque ya se encontró el producto
                }
            }

            // Si no se encontró el producto en la lista, se asume que no está agotado
            if (!encontrado)
            {
                Console.WriteLine($"El producto '{productoBuscado}' no está agotado y podría estar disponible.");
            }

            // Espera que el usuario presione una tecla antes de cerrar la consola
            Console.ReadKey();
        }
    }
}
