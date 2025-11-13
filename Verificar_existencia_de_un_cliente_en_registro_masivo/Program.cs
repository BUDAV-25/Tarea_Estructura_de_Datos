namespace Verificar_existencia_de_un_cliente_en_registro_masivo
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Cantidad de registros (simulamos una base de datos grande)
            int cantidadClientes = 1500;

            // Creamos un arreglo con las "cédulas" de los clientes
            int[] cedulas = new int[cantidadClientes];

            // Llenamos el arreglo con números de cédula simulados (por ejemplo, del 1000 al 2499)
            for (int i = 0; i < cantidadClientes; i++)
            {
                cedulas[i] = 1000 + i;
            }

            // Se pide al usuario que ingrese la cédula a buscar
            Console.Write("Ingrese el número de cédula a buscar: ");
            int cedulaBuscada = int.Parse(Console.ReadLine());

            bool encontrado = false; // Para saber si la cédula fue encontrada

            // Simulamos búsqueda externa recorriendo el arreglo "por bloques"
            int tamanoBloque = 100; // Cada bloque simula una lectura desde disco

            for (int i = 0; i < cantidadClientes; i += tamanoBloque)
            {
                // Simulamos que cargamos un bloque desde el "disco"
                int limite = Math.Min(i + tamanoBloque, cantidadClientes);

                // Búsqueda secuencial dentro del bloque cargado
                for (int j = i; j < limite; j++)
                {
                    if (cedulas[j] == cedulaBuscada)
                    {
                        encontrado = true;
                        Console.WriteLine($"Cliente encontrado. La cédula {cedulaBuscada} está en la posición {j}.");
                        break;
                    }
                }

                // Si se encontró, detenemos la búsqueda (ya no seguimos leyendo más bloques)
                if (encontrado)
                    break;
            }

            // Si no se encontró la cédula, mostramos un mensaje
            if (!encontrado)
            {
                Console.WriteLine($"No se encontró la cédula {cedulaBuscada} en el registro.");
            }

            Console.ReadKey();
        }
    }
}
