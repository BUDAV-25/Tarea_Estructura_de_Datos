using ProyectoControlEstudiantes.Personas.Estudiantes;
using ProyectoControlEstudiantes.Result;

namespace ProyectoControlEstudiantes.Sistem
{
    public class Grupo
    {
        public string NombreGrupo { get; set; }
        public List<Estudiante> Estudiantes { get; set; }
        public Grupo(string nombreGrupo)
        {
            this.NombreGrupo = nombreGrupo;
            this.Estudiantes = new List<Estudiante>();
        }

        public OperationResult AgregarEstudiante(Estudiante estudiante)
        {
            var result = new OperationResult();
            Estudiantes.Add(estudiante);
            result.Message = "Estudiante agregado exitosamente.";
            return result;
        }

        public OperationResult MostrarCalificaciones()
        {
            var result = new OperationResult();
            var calificaciones = new List<string>();
            Console.WriteLine($"\n--- Calificaciones del grupo {NombreGrupo} ---");
            foreach (var estudiante in Estudiantes)
            {
                calificaciones.Add(estudiante.ObtenerInformacion());
            }
            result.Data = calificaciones;
            result.Message = "Calificaciones obtenidas exitosamente.";
            return result;
        }

        public OperationResult CalcularPorcentajeAprobados()
        {
            var result = new OperationResult();
            if (Estudiantes.Count == 0)
            {
                result.Success = false;
                result.Message = "No hay estudiantes en el grupo.";
                return result;
            }

            int aprobados = Estudiantes.Count(e => e.EstaAprobado());
            double porcentajeAprobados = (double)aprobados / Estudiantes.Count * 100;

            result.Data = porcentajeAprobados;
            result.Message = "Porcentaje de aprobados calculado exitosamente.";
            return result;
        }
    }
}
