namespace Atención_de_clientes_en_un_banco
{
    public class Banco
    {
        // Aquí creo una cola donde se van a ir formando los clientes.
        // La cola funciona FIFO: el primero que llega es el primero que se atiende.
        private Queue<string> clientes = new Queue<string>();

        // Método para agregar un cliente a la cola
        public void LlegadaCliente(string nombre)
        {
            clientes.Enqueue(nombre); // Enqueue lo mete al final de la cola
            Console.WriteLine(nombre + " ha llegado al banco y está esperando.");
        }

        // Método para atender al siguiente cliente
        public void AtenderCliente()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("No hay clientes esperando.");
                return;
            }

            // Dequeue saca al cliente que llegó primero
            string clienteAtendido = clientes.Dequeue();
            Console.WriteLine("Atendiendo al cliente: " + clienteAtendido);
        }

        // Método para mostrar quién está siendo atendido (el primero de la cola)
        public void ClienteActual()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("No hay clientes para ser atendidos.");
                return;
            }

            // Peek solo mira al primero sin sacarlo
            Console.WriteLine("Cliente siendo atendido ahora: " + clientes.Peek());
        }

        // Método para mostrar toda la cola
        public void MostrarCola()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("No hay clientes en la fila.");
                return;
            }

            Console.WriteLine("Clientes en espera:");
            foreach (var c in clientes)
            {
                Console.WriteLine("- " + c);
            }
        }
    }
}
