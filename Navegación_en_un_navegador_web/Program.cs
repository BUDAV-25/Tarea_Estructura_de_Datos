namespace Navegación_en_un_navegador_web
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear el navegador
            NavegadorWeb navegador = new();
            int opcion = 0; // para controlar la opción del usuario

            void MostrarMenu()
            {
                Console.WriteLine("===== MENÚ DE NAVEGADOR =====");
                Console.WriteLine("1. Visitar una nueva página");
                Console.WriteLine("2. Regresar a la página anterior");
                Console.WriteLine("3. Mostrar historial");
                Console.WriteLine("4. Salir");
                Console.WriteLine("=============================");
            }

            // Ciclo del menú interactivo
            do
            {
                MostrarMenu();

                // Intento convertir lo que escribe el usuario
                int.TryParse(Console.ReadLine(), out opcion);

                Console.WriteLine(); // Línea en blanco para separar

                switch (opcion)
                {
                    case 1:
                        // Usuario quiere visitar página
                        Console.Write("Escribe la URL de la página: ");
                        string url = Console.ReadLine();
                        navegador.VisitarPagina(url);
                        break;

                    case 2:
                        // Usuario quiere regresar
                        navegador.Regresar();
                        break;

                    case 3:
                        // Mostrar historial
                        navegador.MostrarHistorial();
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del navegador...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intenta otra vez.");
                        break;
                }

            } while (opcion != 4); // El programa termina cuando el usuario elige 4

            Console.WriteLine("Programa finalizado.");
        }
    }
}
