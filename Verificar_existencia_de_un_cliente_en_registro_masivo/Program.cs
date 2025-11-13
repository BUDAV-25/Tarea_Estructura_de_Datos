namespace Verificar_existencia_de_un_cliente_en_registro_masivo
{
    public class Program
    {
        static void Main(string[] args)
        {
            // En este ejercicio simulamos una búsqueda externa, es decir,
            // cuando los datos están almacenados fuera de la memoria principal (por ejemplo, en disco).
            // Para simular esto, generamos un arreglo con muchas cédulas (1000+).

            string[] cedulas = new string[1500]; // Creamos un arreglo con 1500 cédulas (más de mil)

            Random random = new Random();

            // Generamos las cédulas aleatorias de 11 dígitos (sin guiones)
            for (int i = 0; i < cedulas.Length; i++)
            {
                string cedula = "";
                for (int j = 0; j < 11; j++)
                {
                    cedula += random.Next(0, 10).ToString(); // Agrega dígitos aleatorios del 0 al 9
                }
                cedulas[i] = cedula;
            }

            // Pedimos al usuario que ingrese una cédula para buscar
            Console.Write("Ingrese la cédula del cliente (11 dígitos, sin guiones): ");
            string cedulaBuscada = Console.ReadLine();

            bool encontrada = false; // Variable para saber si se encontró la cédula

            // Simulamos la búsqueda externa recorriendo todo el arreglo
            // (ya que en la búsqueda externa normalmente se lee bloque por bloque desde disco)
            for (int i = 0; i < cedulas.Length; i++)
            {
                if (cedulas[i] == cedulaBuscada)
                {
                    encontrada = true;
                    Console.WriteLine($"Cliente encontrado. La cédula {cedulaBuscada} se encuentra en la posición {i}.");
                    break;
                }

                // Esta línea simula una pequeña pausa para representar que la lectura es más lenta en disco
                System.Threading.Thread.Sleep(1);
            }

            // Si no se encontró, mostramos un mensaje indicando que no está registrado
            if (!encontrada)
            {
                Console.WriteLine($"La cédula {cedulaBuscada} no se encuentra registrada en el sistema.");
            }

            // Esperamos que el usuario presione una tecla antes de cerrar
            //Console.ReadKey();
        }
    }
}
