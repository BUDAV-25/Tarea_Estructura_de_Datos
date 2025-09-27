namespace Temperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] temps = new double[10];
            double suma = 0;
            double maxTemp, minTemp;
            int diasMayor30 = 0;

            // Registro de temperaturas
            for (int i = 0; i < temps.Length; i++)
            {
                Console.Write($"Ingrese la temperatura del día {i + 1}: ");
                temps[i] = Convert.ToDouble(Console.ReadLine());
            }

            // Inicializamos con el primer valor
            maxTemp = temps[0];
            minTemp = temps[0];

            // Procesamiento
            for (int i = 0; i < temps.Length; i++)
            {
                double t = temps[i];
                suma += t;

                if (t > maxTemp)
                    maxTemp = t;

                if (t < minTemp)
                    minTemp = t;

                if (t > 30)
                    diasMayor30++;
            }

            // Cálculo del promedio
            double promedio = suma / temps.Length;

            // Resultados
            Console.WriteLine("\n--- Resultados ---");
            Console.WriteLine($"Temperatura más alta: {maxTemp}°C");
            Console.WriteLine($"Temperatura más baja: {minTemp}°C");
            Console.WriteLine($"Promedio de temperaturas: {promedio:F2}°C");
            Console.WriteLine($"Días por encima de 30°C: {diasMayor30}");
        }
    }
}
