using Business.Implements.CQRS.Command;
using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Entity.Dtos.School.Grade;
using Entity.Model.School;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Implements.Abstract;

namespace Web.Controllers.Implements.School
{


    [ApiController]
    [Route("api/[controller]")]
    public class DistributionController : ControllerBase
    {
        private readonly RepartoCommandBusiness _reparto;
        private readonly ILogger<DistributionController> _logger;

        // Si tienes interfaz, cambia a IRepartoCommandBusiness
        public DistributionController(
            RepartoCommandBusiness reparto,
            ILogger<DistributionController> logger)
        {
            _reparto = reparto;
            _logger = logger;
        }

        /// <summary>
        /// Distribuye equitativamente los estudiantes del grado en sus cursos.
        /// </summary>
        /// <param name="gradeId">Id del grado</param>
        /// <returns>200 si todo ok, 422 si falta data para distribuir, 500 si falla</returns>
        [HttpPost("distribute/degree/{gradeId:int}")]
        // [Authorize] // opcional
        [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(object), StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DistributeStudents([FromRoute] int gradeId, CancellationToken ct)
        {
            if (gradeId <= 0)
                return BadRequest(new { message = "gradeId inválido." });

            try
            {
                var ok = await _reparto.DistributionStudent(gradeId);

                if (!ok)
                {
                    // Tu método devuelve false cuando no hay cursos o no hay estudiantes (regla de negocio)
                    return UnprocessableEntity(new
                    {
                        type = "https://httpstatuses.com/422",
                        title = "Regla de negocio violada",
                        status = 422,
                        detail = "No fue posible realizar la distribución: sin cursos disponibles o sin estudiantes en el grado.",
                    });
                }

                return Ok(new
                {
                    message = "Distribución realizada correctamente."
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error distribuyendo estudiantes para grado {GradeId}", gradeId);
                return Problem(
                    title: "Error interno en la distribución",
                    detail: ex.Message,
                    statusCode: StatusCodes.Status500InternalServerError);
            }
        }
    }
}
