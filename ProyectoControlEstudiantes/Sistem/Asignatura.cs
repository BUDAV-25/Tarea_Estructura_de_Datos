namespace ProyectoControlEstudiantes.Sistem
{
    public class Asignatura
    {
        public string Nombre { get; set; }
        public List<Grupo> Grupos { get; set; }

        public Asignatura(string nombre)
        {
            this.Nombre = nombre;
            this.Grupos = new List<Grupo>();
        }

        public void AgregarGrupo(Grupo grupo)
        {
            this.Grupos.Add(grupo);
        }
    }
}
