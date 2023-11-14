using Microsoft.AspNetCore.Mvc;
using proyecto.Models;
using Microsoft.AspNetCore.Mvc;

namespace proyecto.Controllers
{
    [ApiController]
    [Route("api/talleres")]
    public class TalleresController : ControllerBase
    {
        [HttpGet]
        public ActionResult<TallerDto> GetAllTalleres(int id)
        {
            return Ok(TalleresDataStore.Actual.Talleres);
        }
        [HttpGet("{id}")]
        public ActionResult<TallerDto> GetTalleres(int id)
        {
            var tallerARetornar = TalleresDataStore.Actual.Talleres
                .FirstOrDefault(c => c.Id_taller == id);

            if (tallerARetornar != null)
            {
                return Ok(tallerARetornar);
            }
            else
            {
                return NotFound("Taller no encontrado");
            }
            //return new JsonResult(
            //EstudiantesDataStore.Actual.Estudiantes.FirstOrDefault(c => c.Id == id));
        }
    }
}
