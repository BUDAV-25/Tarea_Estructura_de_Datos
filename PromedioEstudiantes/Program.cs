namespace PromedioEstudiantes
{
    public class PromedioEstudiantes
    {
        static void Main(string[] args)
        {
            double[,] notas = new double[4, 3];
            double promedioEstudiante, promedioAsignatura;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Ingrese las 3 notas del estudiante {i + 1}:");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Nota {j + 1}: ");
                    notas[i, j] = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.WriteLine("PROMEDIO DE CADA ESTUDIANTE:");
            for (int i = 0; i < 4; i++)
            {
                promedioEstudiante = 0;
                for (int j = 0; j < 3; j++)
                {
                    promedioEstudiante += notas[i, j];
                }
                promedioEstudiante /= 3;
                Console.WriteLine($"Estudiante {i + 1}: {promedioEstudiante:F2}");
            }

            Console.WriteLine("\nPROMEDIO DE CADA ASIGNATURA:");
            for (int j = 0; j < 3; j++)
            {
                promedioAsignatura = 0;
                for (int i = 0; i < 4; i++)
                {
                    promedioAsignatura += notas[i, j];
                }
                promedioAsignatura /= 4;
                Console.WriteLine($"Asignatura {j + 1}: {promedioAsignatura:F2}");
            }

            Console.ReadKey();
        }
    }
}
