

using proyecto.Models;

namespace proyecto
{
    public class ProfesoresDataStore
    {
        public List<ProfesorDto> Profesores { get; set; }
        public static ProfesoresDataStore Actual { get; } = new ProfesoresDataStore();
        public ProfesoresDataStore()
        {
            Profesores = new List<ProfesorDto>
            {
                new ProfesorDto()
                {
                    Id_profesor = 1,
                    Nombre = "Martha Gonzalez",
                    Area = "Danza",
                    Cedula = "161-200390-0000K"
                },
                new ProfesorDto()
                {
                    Id_profesor = 2,
                    Nombre = "Jimmy Rodriguez",
                    Area = "Musica",
                    Cedula = "324-120589-100KL"
                }
            };
        }
    }
}


