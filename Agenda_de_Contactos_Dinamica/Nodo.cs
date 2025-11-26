namespace Agenda_de_Contactos_Dinamica
{
    // Nodo de la lista simplemente enlazada
    // Cada nodo almacena un contacto y un puntero al siguiente nodo
    public class Nodo
    {
        public Contacto Dato { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(Contacto dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
