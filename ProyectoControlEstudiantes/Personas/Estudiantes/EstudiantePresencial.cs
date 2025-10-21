namespace ProyectoControlEstudiantes.Personas.Estudiantes
{
    public class EstudiantePresencial : Estudiante
    {
        public EstudiantePresencial(string nombre, string matricula) : base(nombre, matricula)
        {
        }
        public override double CalcularNotaFinal()
        {
            return (this.ExamenFinal * 0.6) + (this.Practicas * 0.4);
        }
    }
}
