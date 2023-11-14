using proyecto.Models;
using Microsoft.AspNetCore.Mvc;

namespace proyecto.Controllers
{
    [ApiController]
    [Route("api/estudiantes")]
    public class EstudiantesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<EstudianteDto> GetAllEstudiantes(int id)
        {
            return Ok(EstudiantesDataStore.Actual.Estudiantes);
        }
        [HttpGet("{id}")]
        public ActionResult<EstudianteDto> GetEstudiante(int id)
        {
            var estudianteARetornar = EstudiantesDataStore.Actual.Estudiantes
                .FirstOrDefault(c => c.Id_estudiante == id);

            if (estudianteARetornar != null)
            {
                return Ok(estudianteARetornar);
            }
            else
            {
                return NotFound("Estudiante no encontrado");
            }
            //return new JsonResult(
            //EstudiantesDataStore.Actual.Estudiantes.FirstOrDefault(c => c.Id == id));
        }
    }
}
