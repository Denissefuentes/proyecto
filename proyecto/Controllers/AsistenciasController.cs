using Microsoft.AspNetCore.Mvc;
using proyecto.Models;
using Microsoft.AspNetCore.Mvc;

namespace proyecto.Controllers
{
    [ApiController]
    [Route("api/asistencias")]
    public class AsistenciasController :ControllerBase
    {
        [HttpGet]
        public ActionResult<AsistenciaDto> GetAllAsistencias(int id)
        {
            return Ok(AsistenciasDataStore.Actual.Asistencias);
        }
        [HttpGet("{id}")]
        public ActionResult<AsistenciaDto> GetAsistencias(int id)
        {
            var asistenciaARetornar = AsistenciasDataStore.Actual.Asistencias
                .FirstOrDefault(c => c.Id_asistencia == id);

            if (asistenciaARetornar != null)
            {
                return Ok(asistenciaARetornar);
            }
            else
            {
                return NotFound("Asistencia no registrada");
            }
        }
    }
}
