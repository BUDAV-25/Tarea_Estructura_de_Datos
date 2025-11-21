namespace Atención_de_clientes_en_un_banco
{
    public class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new();
            int opcion = 0;

            void MostrarMenu()
            {
                Console.WriteLine("===== MENÚ DEL BANCO =====");
                Console.WriteLine("1. Llegada de nuevo cliente");
                Console.WriteLine("2. Atender cliente");
                Console.WriteLine("3. Mostrar cliente actual");
                Console.WriteLine("4. Mostrar cola de espera");
                Console.WriteLine("5. Salir");
                Console.WriteLine("===========================");
            }
                MostrarMenu();
                // Intento convertir lo que escribe el usuario

            do
            {

                int.TryParse(Console.ReadLine(), out opcion);
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre del cliente: ");
                        string nombre = Console.ReadLine();
                        banco.LlegadaCliente(nombre);
                        break;

                    case 2:
                        banco.AtenderCliente();
                        break;

                    case 3:
                        banco.ClienteActual();
                        break;

                    case 4:
                        banco.MostrarCola();
                        break;

                    case 5:
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != 5);

            Console.WriteLine("Programa finalizado.");
        }
    }
}
