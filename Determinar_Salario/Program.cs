namespace Determinar_Salario
{
    public class Program
    {
        public static double CalcularSalario(double horasTrabajadas, double tarifaPorHora)
        {
            if (horasTrabajadas <= 40)
            {
                return horasTrabajadas * tarifaPorHora;
            }
            else
            {
                double horasExtras = horasTrabajadas - 40;
                return (40 * tarifaPorHora) + (horasExtras * (tarifaPorHora * 1.5));
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese las horas trabajadas:");
            double horasTrabajadas = Convert.ToDouble(Console.ReadLine());
            horasTrabajadas = Math.Abs(horasTrabajadas); // Asegurarse de que las horas trabajadas sean positivas

            Console.WriteLine("Ingrese la tarifa por hora:");
            double tarifaPorHora = Convert.ToDouble(Console.ReadLine());
            tarifaPorHora = Math.Abs(tarifaPorHora); // Asegurarse de que la tarifa por hora sea positiva

            double salarioSemanal = CalcularSalario(horasTrabajadas, tarifaPorHora);

            double salarioMensual = salarioSemanal * 4; // Asumiendo 4 semanas en un mes(Como dice el documento)

            Console.WriteLine($"El salario total  al mes es: {salarioMensual}");

        }
    }
}
