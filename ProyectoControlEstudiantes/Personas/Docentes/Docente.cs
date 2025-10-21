using ProyectoControlEstudiantes.Personas.Base;
using ProyectoControlEstudiantes.Sistem;

namespace ProyectoControlEstudiantes.Personas.Docentes
{
    public class Docente : Personal
    {
        public List<Asignatura> Asignaturas { get; set; }

        public Docente(string nombre, string matricula) : base(nombre, matricula)
        {
            Asignaturas = new List<Asignatura>();
        }

        public void AgregarAsignatura(Asignatura asignatura)
        {
            Asignaturas.Add(asignatura);
        }
        public override string ObtenerInformacion()
        {
            string infoBase = base.ObtenerInformacion();
            string infoAsignaturas = string.Join(", ", Asignaturas.Select(a => a.Nombre));
            return $"{infoBase} | Asignaturas: {infoAsignaturas}";
        }
    }
}
