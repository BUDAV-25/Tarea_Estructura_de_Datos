namespace Verificar_asistencia_en_lista
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Arreglo que contiene los nombres de los estudiantes inscritos
            string[] nombres = { "Benny", "Ana", "Carlos", "Beatriz", "Juan", "Luis", "María", "Alfonso" };

            // Se pide al usuario que escriba el nombre del estudiante que desea buscar
            Console.Write("Ingrese el nombre del estudiante a buscar: ");
            string nombreBuscado = Console.ReadLine(); // Se guarda el nombre que el usuario escribió

            bool encontrado = false; // Variable para saber si el nombre fue encontrado o no

            // Se recorre todo el arreglo de nombres
            for (int i = 0; i < nombres.Length; i++)
            {
                // Se compara el nombre actual del arreglo con el nombre que se está buscando
                // Equals con StringComparison.OrdinalIgnoreCase se usa para ignorar mayúsculas y minúsculas
                if (nombres[i].Equals(nombreBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    encontrado = true; // Si lo encuentra, cambia el valor a true
                    // Se muestra un mensaje indicando que el estudiante está en la lista y en qué posición
                    Console.WriteLine($"El estudiante {nombreBuscado} está en la lista (posición {i}).");
                    break; // Se detiene el bucle porque ya encontramos el nombre
                }
            }

            // Si al terminar el bucle no se encontró el nombre, se muestra un mensaje
            if (!encontrado)
            {
                Console.WriteLine($"El estudiante {nombreBuscado} no está en la lista.");
            }

            // Espera que el usuario presione una tecla antes de cerrar la consola
            Console.ReadKey();
        }
    }
}
