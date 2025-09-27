namespace VentasDiarias
{
    public class VentasDiarias
    {
        static void Main(string[] args)
        {
            double[] ventas = new double[7];
            int diaMayorVenta = 0;


            for (int i = 0; i < ventas.Length; i++)
            {
                Console.Write($"Ingrese las ventas del día {i + 1}: ");
                ventas[i] = Convert.ToDouble(Console.ReadLine());

                if (ventas[i] > ventas[diaMayorVenta])
                {
                    diaMayorVenta = i;
                }
            }
            double totalVentas = 0;
            for (int i = 0; i < ventas.Length; i++)
            {
                totalVentas += ventas[i];
            }

            double promedioVentas = totalVentas / ventas.Length;

            Console.WriteLine($"\nDía con mayor venta: Día {diaMayorVenta + 1} con {ventas[diaMayorVenta]:C}");
            Console.WriteLine($"\nTotal de ventas de la semana: {totalVentas:C}");
            Console.WriteLine($"Promedio diario de ventas: {promedioVentas:C}");
        }
    }
}
