
using proyecto.Models;

namespace proyecto
{
    public class TalleresDataStore
    {
        public List<TallerDto> Talleres { get; set; }
        public static TalleresDataStore Actual { get; } = new TalleresDataStore();
        public TalleresDataStore()
        {
            Talleres = new List<TallerDto>
            {
                new TallerDto()
                {
                    Id_taller = 1,
                    Nombre = "Taller danza principiantes",
                    Descripcion = "El estudiante aprendera los pasos basicos del folklore nicaraguense para sus primeras presentaciones",
                    Cupos= 15,
                    Area = "Danza",
                    Fecha_ini = "05/06/2020",
                    Fecha_final = "09/07/2020",
                    Id_profesor = 1

    },
                new TallerDto()

                {
                    Id_taller = 2,
                    Nombre = "Taller basico dre guitarra",
                    Descripcion = "El estudiante aprendera las notas musicales y como tocar algunas canciones en guitarra",
                    Cupos= 10,
                    Area = "Musica",
                    Fecha_ini = "10/10/2021",
                    Fecha_final = "15/11/2020",
                    Id_profesor = 2
                }
            };
        }
    }
}


