using proyecto.Models;

namespace proyecto
{
    public class HistorialesDataStore
    {
        public List<HistorialDto> Historiales { get; set; }
        public static HistorialesDataStore Actual { get; } = new HistorialesDataStore();
        public HistorialesDataStore()
        {
            Historiales = new List<HistorialDto>
            {
                new HistorialDto()
                {
                    Id_historial= 1,
                    Fecha = "2023/11/09",
                    Descripcion = "Estudiante Eliminado",
                    Usuario = "Toshiba_user"
                },
                new HistorialDto()
                {
                    Id_historial= 2,
                    Fecha = "2023/11/23",
                    Descripcion = "Taller Actualizado",
                    Usuario = "Toshiba_user"
                }
            };
        }
    }
}


