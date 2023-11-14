namespace proyecto.Models
{
    public class TallerDto
    {
        public int Id_taller { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cupos { get; set; }
        public string Area { get; set; }
        public string Fecha_ini { get; set;}
        public string Fecha_final { get; set; }
        public int Id_profesor { get; set; }

    }
}
