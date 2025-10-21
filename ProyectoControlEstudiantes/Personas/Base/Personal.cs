namespace ProyectoControlEstudiantes.Personas.Base
{
    public abstract class Personal
    {
        protected string Nombre { get; set; }
        protected string Matricula { get; set; }

        public Personal(string nombre, string matricula)
        {
            this.Nombre = nombre;
            this.Matricula = matricula;
        }

        public virtual string ObtenerInformacion()
        {
            return $"Nombre: {this.Nombre} | Matrícula: {this.Matricula}";
        }
    }
}
