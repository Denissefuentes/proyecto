
using Microsoft.AspNetCore.Mvc;
using proyecto.Models;
using Microsoft.AspNetCore.Mvc;

namespace proyecto.Controllers
{
    [ApiController]
    [Route("api/profesores")]
    public class ProfesoresController : ControllerBase
    {
        [HttpGet]
        public ActionResult<ProfesorDto> GetAllProfesores(int id)
        {
            return Ok(ProfesoresDataStore.Actual.Profesores);
        }
        [HttpGet("{id}")]
        public ActionResult<ProfesorDto> GetProfesores(int id)
        {
            var profesorARetornar = ProfesoresDataStore.Actual.Profesores
                .FirstOrDefault(c => c.Id_profesor == id);

            if (profesorARetornar != null)
            {
                return Ok(profesorARetornar);
            }
            else
            {
                return NotFound("profesor no encontrado");
            }
            //return new JsonResult(
            //EstudiantesDataStore.Actual.Estudiantes.FirstOrDefault(c => c.Id == id));
        }
    }
}
