using proyecto.Models;

namespace proyecto
{
    public class AsistenciasDataStore
    {
        public List<AsistenciaDto> Asistencias { get; set; }
        public static AsistenciasDataStore Actual { get; } = new AsistenciasDataStore();
        public AsistenciasDataStore()
        {
            Asistencias = new List<AsistenciaDto>
            {
                new AsistenciaDto()
                {
                    Id_asistencia = 1,
                    Id_estudiante = 2,
                    Fecha = "2023/08/05"
                },
                new AsistenciaDto()
                {
                    Id_asistencia = 2,
                    Id_estudiante = 3,
                    Fecha = "2023/08/05"
                }
            };
        }
    }
}


