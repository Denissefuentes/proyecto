using Microsoft.AspNetCore.Mvc;
using proyecto.Models;
using Microsoft.AspNetCore.Mvc;


namespace proyecto.Controllers
{
    [ApiController]
    [Route("api/historiales")]
    public class HIstorialesController: ControllerBase
    {
        [HttpGet]
        public ActionResult<HistorialDto> GetAllHistoriales(int id)
        {
            return Ok(HistorialesDataStore.Actual.Historiales);
        }
        [HttpGet("{id}")]
        public ActionResult<HistorialDto> GetHistoriales(int id)
        {
            var historialARetornar = HistorialesDataStore.Actual.Historiales
                .FirstOrDefault(c => c.Id_historial == id);

            if (historialARetornar != null)
            {
                return Ok(historialARetornar);
            }
            else
            {
                return NotFound("Historial no registrado");
            }
            //return new JsonResult(
            //EstudiantesDataStore.Actual.Estudiantes.FirstOrDefault(c => c.Id == id));
        }
    }
}
