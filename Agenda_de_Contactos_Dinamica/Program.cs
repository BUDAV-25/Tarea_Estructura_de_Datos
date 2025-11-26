namespace Agenda_de_Contactos_Dinamica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazadaAgenda agenda = new ListaEnlazadaAgenda();
            int opcion;

            do
            {
                Console.WriteLine("\n===== AGENDA DE CONTACTOS =====");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Eliminar contacto por nombre");
                Console.WriteLine("3. Mostrar todos los contactos");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                // Validar entrada
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Entrada inválida. Intente nuevamente.");
                    continue;
                }

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();

                        Console.Write("Teléfono: ");
                        string telefono = Console.ReadLine();

                        Console.Write("Email: ");
                        string email = Console.ReadLine();

                        agenda.Agregar(new Contacto(nombre, telefono, email));
                        break;

                    case 2:
                        Console.Write("Ingrese el nombre del contacto a eliminar: ");
                        string nombreEliminar = Console.ReadLine();
                        agenda.EliminarPorNombre(nombreEliminar);
                        break;

                    case 3:
                        agenda.Mostrar();
                        break;

                    case 4:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != 4);
        }
    }
}
