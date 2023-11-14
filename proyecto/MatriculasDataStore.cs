using proyecto.Models;

namespace proyecto
{
    public class MatriculasDataStore
    {

        public List<MatriculaDto> Matriculas { get; set; }
        public static MatriculasDataStore Actual { get; } = new MatriculasDataStore();
        public MatriculasDataStore()
        {
            Matriculas = new List<MatriculaDto>
            {
                new MatriculaDto()
                {
                    Id_matricula = 1,
                    Id_estudiante = 2,
                    Id_taller = 1,
                    Dias_taller = "Martes y Jueves",
                    Turno= "Matutino"
                },
                new MatriculaDto()
                {
                    Id_matricula = 2,
                    Id_estudiante = 1,
                    Id_taller = 2,
                    Dias_taller = "Sabados",
                    Turno= "Matutino"
                }
            };
        }
    }
}


