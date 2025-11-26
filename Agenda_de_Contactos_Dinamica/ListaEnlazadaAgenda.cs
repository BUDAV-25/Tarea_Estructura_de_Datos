namespace Agenda_de_Contactos_Dinamica
{
    // Lista Enlazada que gestiona la agenda
    public class ListaEnlazadaAgenda
    {
        private Nodo cabeza;

        public ListaEnlazadaAgenda()
        {
            cabeza = null;
        }

        // Agregar contacto al final de la lista
        public void Agregar(Contacto nuevo)
        {
            Nodo nuevoNodo = new Nodo(nuevo);

            // Si la lista está vacía, el nuevo nodo será la cabeza
            if (cabeza == null)
            {
                cabeza = nuevoNodo;
                Console.WriteLine("\nContacto agregado exitosamente.");
                return;
            }

            // Si no está vacía, recorrer hasta el último nodo
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }

            // Agregar al final
            actual.Siguiente = nuevoNodo;
            Console.WriteLine("\nContacto agregado exitosamente.");
        }

        // Eliminar un contacto por nombre
        public void EliminarPorNombre(string nombre)
        {
            if (cabeza == null)
            {
                Console.WriteLine("\nLa agenda está vacía.");
                return;
            }

            // Caso especial: el contacto a eliminar es la cabeza
            if (cabeza.Dato.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
            {
                cabeza = cabeza.Siguiente;
                Console.WriteLine("\nContacto eliminado.");
                return;
            }

            // Buscar el nodo anterior del que se quiere eliminar
            Nodo actual = cabeza;
            while (actual.Siguiente != null &&
                   !actual.Siguiente.Dato.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
            {
                actual = actual.Siguiente;
            }

            if (actual.Siguiente == null)
            {
                Console.WriteLine("\nNo se encontró un contacto con ese nombre.");
            }
            else
            {
                actual.Siguiente = actual.Siguiente.Siguiente;
                Console.WriteLine("\nContacto eliminado.");
            }
        }

        // Mostrar todos los contactos
        public void Mostrar()
        {
            if (cabeza == null)
            {
                Console.WriteLine("\nLa agenda está vacía.");
                return;
            }

            Console.WriteLine("\n--- Lista de Contactos ---");
            Nodo actual = cabeza;

            while (actual != null)
            {
                Console.WriteLine(actual.Dato.ToString());
                actual = actual.Siguiente;
            }
        }
    }
}
