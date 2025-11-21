namespace Navegación_en_un_navegador_web
{
    public class NavegadorWeb
    {
        // Pila donde guardo las páginas que visito
        private Stack<string> historial = new Stack<string>();

        // Método para visitar una página nueva
        public void VisitarPagina(string url)
        {
            historial.Push(url); // Agrego la página a la pila
            Console.WriteLine("Visitando: " + url);
        }

        // Método para regresar a la página anterior
        public void Regresar()
        {
            if (historial.Count == 0)
            {
                // Si no hay nada en la pila, no puedo regresar
                Console.WriteLine("No hay páginas anteriores.");
                return;
            }

            // Quito la página de arriba (la actual)
            string paginaQuitada = historial.Pop();
            Console.WriteLine("Regresando desde: " + paginaQuitada);

            // Muestro cuál queda como actual, si queda alguna
            if (historial.Count == 0)
            {
                Console.WriteLine("Ya no hay páginas en el historial.");
            }
            else
            {
                Console.WriteLine("Página actual: " + historial.Peek());
            }
        }

        // Método para ver todo el historial
        public void MostrarHistorial()
        {
            if (historial.Count == 0)
            {
                Console.WriteLine("El historial está vacío.");
                return;
            }

            Console.WriteLine("Historial de navegación:");
            foreach (var pagina in historial)
            {
                Console.WriteLine("- " + pagina);
            }
        }
    }
}
