namespace ProyectoControlEstudiantes.Personas.Estudiantes
{
    public class EstudianteVirtual : Estudiante
    {
        public EstudianteVirtual(string nombre, string matricula) : base(nombre, matricula)
        {
        }
        public override double CalcularNotaFinal()
        {
            return (this.ExamenFinal * 0.7) + (this.Practicas * 0.3);
        }
    }
}
