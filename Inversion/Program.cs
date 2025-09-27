namespace Inversion
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[6];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nArreglo en orden inverso:");
            for (int i = numeros.Length - 1; i >= 0; i--)
            {
                Console.Write(numeros[i] + " ");
            }
        }
    }
}
