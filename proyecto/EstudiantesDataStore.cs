using proyecto.Models;

namespace proyecto
{
    public class EstudiantesDataStore
    {
        public List<EstudianteDto> Estudiantes { get; set; }
        public static EstudiantesDataStore Actual { get; } = new EstudiantesDataStore();
        public EstudiantesDataStore()
        {
            Estudiantes = new List<EstudianteDto>
            {
                new EstudianteDto()
                {
                    Id_estudiante = 1,
                    Nombres = "Bielka Vanessa",
                    Apellidos = "Melgara Trochez",
                    Edad= "05/03/06",
                    Sexo= "F",
                    Cedula= "323-050306-1000C",
                    Anio= "II",
                    Carrera= "Psicologia",
                    Carnet= "22504966",
                    Turno= "Matutino",
                    Telefono= "58067780"
                },
                new EstudianteDto()
                {
                    Id_estudiante = 2,
                    Nombres = "Denisse Mariell",
                    Apellidos = "Fuentes Hernandez",
                    Edad= "26/10/05",
                    Sexo= "F",
                    Cedula= "161-261005-1001H",
                    Anio= "III",
                    Carrera= "Derecho",
                    Carnet= "22503426",
                    Turno= "Matutino",
                    Telefono= "84225176"

                },
                new EstudianteDto()
                {
                    Id_estudiante = 3,
                    Nombres = "Jeriel Paul",
                    Apellidos = "Blandon Valdivia",
                    Edad= "02/02/04",
                    Sexo= "M",
                    Cedula= "241-020204-1001E",
                    Anio= "IV",
                    Carrera= "Ingenieria en sistemas de informacion",
                    Carnet= "22500566",
                    Turno= "Matutino",
                    Telefono= "76658399"

                }
            };
        }
    }
}


