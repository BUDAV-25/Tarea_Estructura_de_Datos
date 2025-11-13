namespace Buscar_calificación_específica
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Arreglo de notas finales ordenadas de menor a mayor
            int[] notas = { 60, 65, 70, 75, 80, 85, 90, 95, 100 };

            // Se pide al usuario que ingrese la nota que desea buscar
            Console.Write("Ingrese la calificación que desea buscar: ");
            int notaBuscada = int.Parse(Console.ReadLine());

            // Variables para los límites de la búsqueda
            int inicio = 0;
            int fin = notas.Length - 1;
            bool encontrado = false; // Para saber si se encontró la nota

            // Ciclo de búsqueda binaria
            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2; // Se calcula la posición del medio

                // Si la nota del medio es igual a la buscada
                if (notas[medio] == notaBuscada)
                {
                    encontrado = true;
                    Console.WriteLine($"La nota {notaBuscada} fue encontrada en la posición {medio}.");
                    break; // Se detiene el ciclo porque ya se encontró
                }
                // Si la nota buscada es menor, se busca en la mitad izquierda
                else if (notaBuscada < notas[medio])
                {
                    fin = medio - 1;
                }
                // Si la nota buscada es mayor, se busca en la mitad derecha
                else
                {
                    inicio = medio + 1;
                }
            }

            // Si al final no se encontró la nota, se muestra un mensaje
            if (!encontrado)
            {
                Console.WriteLine($"La nota {notaBuscada} no se encontró en la lista.");
            }

            Console.ReadKey();
        }
    }
}
