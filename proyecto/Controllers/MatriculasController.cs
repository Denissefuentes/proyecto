using Microsoft.AspNetCore.Mvc;
using proyecto.Models;


namespace proyecto.Controllers
{
    [ApiController]
    [Route("api/matriculas")]
    public class MatriculasController : ControllerBase
    {
        [HttpGet]
        public ActionResult<MatriculaDto> GetAllMatriculas(int id)
        {
            return Ok(MatriculasDataStore.Actual.Matriculas);
        }
        [HttpGet("{id}")]
        public ActionResult<MatriculaDto> GetMatricula(int id)
        {
            var matriculaARetornar = MatriculasDataStore.Actual.Matriculas
                .FirstOrDefault(c => c.Id_matricula == id);

            if (matriculaARetornar != null)
            {
                return Ok(matriculaARetornar);
            }
            else
            {
                return NotFound("Matricula no encontrado");
            }
            //return new JsonResult(
            //EstudiantesDataStore.Actual.Estudiantes.FirstOrDefault(c => c.Id == id));
        }
    }
}
