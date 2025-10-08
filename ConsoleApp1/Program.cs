namespace AlmacenarProcesar
{
    public class AlmacenarProcesar
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de filas: ");
            int filas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el número de columnas: ");
            int columnas = Convert.ToInt32(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            Console.WriteLine("\n--- Ingrese los valores de la matriz ---");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\n--+----- MATRIZ INGRESADA --------");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int max = matriz[0, 0];
            int min = matriz[0, 0];
            int filaMax = 0, colMax = 0;
            int filaMin = 0, colMin = 0;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (matriz[i, j] > max)
                    {
                        max = matriz[i, j];
                        filaMax = i;
                        colMax = j;
                    }
                    if (matriz[i, j] < min)
                    {
                        min = matriz[i, j];
                        filaMin = i;
                        colMin = j;
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine("RESULTADOS");
            Console.WriteLine($"Valor máximo: {max} (posición [{filaMax}, {colMax}])");
            Console.WriteLine($"Valor mínimo: {min} (posición [{filaMin}, {colMin}])");

            Console.ReadKey();
        }
    }
}
