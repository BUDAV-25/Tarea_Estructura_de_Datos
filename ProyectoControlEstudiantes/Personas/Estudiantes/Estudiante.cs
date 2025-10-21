using ProyectoControlEstudiantes.Personas.Base;

namespace ProyectoControlEstudiantes.Personas.Estudiantes
{
    public abstract class Estudiante : Personal
    {
        protected double ExamenFinal { get; set; }
        protected double Practicas { get; set; }

        public Estudiante(string nombre, string matricula) : base(nombre, matricula)
        {}

        public void AsignarCalificaciones(double examenFinal, double practicas)
        {
            this.ExamenFinal = examenFinal;
            this.Practicas = practicas;
        }

        public abstract double CalcularNotaFinal();

        public bool EstaAprobado()
        {
            return CalcularNotaFinal() >= 70;
        }

        public override string ObtenerInformacion()
        {
            string infoBase = base.ObtenerInformacion();
            return $"{infoBase} | Examen Final: {this.ExamenFinal} | Prácticas: {this.Practicas} | Nota Final: {CalcularNotaFinal()} | Aprobado: {EstaAprobado()}";
        }
    }
}
