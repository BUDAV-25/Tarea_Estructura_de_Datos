using ProyectoControlEstudiantes.Personas.Docentes;
using ProyectoControlEstudiantes.Personas.Estudiantes;
using ProyectoControlEstudiantes.Sistem;

namespace ProyectoControlEstudiantes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Control de Estudiantes ===\n");

            var docente = new Docente("Dr. Juan Pérez", "D12345");
            var asignatura = new Asignatura("Matemáticas Avanzadas");
            var grupo = new Grupo("Grupo A");

            Console.WriteLine("Ingrese cantidad de estudiantes: ");
            int n = int.Parse(Console.ReadLine()!);

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Estudiante #{i + 1} ---");
                Console.Write("Nombre: ");
                string nombreEstudiante = Console.ReadLine()!;

                Console.Write("Matrícula: ");
                string matriculaEstudiante = Console.ReadLine()!;

                Console.Write("Tipo (1= Presencial, 2= Virtual): ");
                int tipoEstudiante = int.Parse(Console.ReadLine()!);

                Console.Write("Calificación examen: ");
                double calificacionExamen = double.Parse(Console.ReadLine()!);

                Console.Write("Calificación práctica: ");
                double calificacionPractica = double.Parse(Console.ReadLine()!);

                Estudiante estudiante = tipoEstudiante == 1
                    ? new EstudiantePresencial(nombreEstudiante, matriculaEstudiante)
                    : new EstudianteVirtual(nombreEstudiante, matriculaEstudiante);

                estudiante.AsignarCalificaciones(calificacionExamen, calificacionPractica);
                grupo.AgregarEstudiante(estudiante);
            }

            asignatura.AgregarGrupo(grupo);
            docente.AgregarAsignatura(asignatura);

            grupo.MostrarCalificaciones();

            var resultadoPorcentaje = grupo.CalcularPorcentajeAprobados();

            if (resultadoPorcentaje.Success)
            {
                Console.WriteLine($"\nPorcentaje de estudiantes aprobados: {resultadoPorcentaje.Data}%");
            }
            else
            {
                Console.WriteLine($"\nError: {resultadoPorcentaje.Message}");
            }
        }
    }
}
