namespace Comprobar_Suma
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca tres números");
            
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int numero3 = Convert.ToInt32(Console.ReadLine());

            if ((numero1 + numero2 == numero3) || (numero1 + numero3 == numero2) || (numero2 + numero3 == numero1))
            {
                Console.WriteLine("Iguales");
            }
            else
            {
                Console.WriteLine("Distintas");
            }
        }
    }
}
