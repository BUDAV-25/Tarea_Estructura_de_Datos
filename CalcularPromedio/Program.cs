namespace CalcularPromedio
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca los número uno a uno");
            Console.Write("Número (0 para terminar): ");

            double suma = 0;
            int contador = 0;
            double promedio = 0;
            double numero;

            do
            {
                numero = Convert.ToDouble(Console.ReadLine());
                if (numero != 0)
                {
                    suma += numero;
                    contador++;
                }
            } while (numero != 0);

            if (contador > 0)
            {
                promedio = suma / contador;
                Console.WriteLine($"El promedio es: {promedio}");
            }
            else
            {
                Console.WriteLine("No se introdujeron números.");
            }
        }
    }
}
