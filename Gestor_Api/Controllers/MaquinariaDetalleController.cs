using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using SharedModels.Dto.MaquinariaDetalle;
using SharedModels;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace Gestor_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaquinariaDetalleController : ControllerBase
    {
        private readonly IRepository<MaquinariaDetalle> _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<MaquinariaDetalleController> _logger;

        public MaquinariaDetalleController(ILogger<MaquinariaDetalleController> logger, IMapper mapper, IRepository<MaquinariaDetalle> repository)
        {
            _logger = logger;
            _mapper = mapper;
            _repository = repository;
        }

        // GET: api/MaquinariaDetalle
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllMaquinariaDetalles()
        {
            _logger.LogInformation("Recuperando todos los detalles de Maquinaria de la base de datos.");
            try
            {
                var maquinariaDetalles = await _repository.GetAllAsync();
                var maquinariaDetalleDtos = _mapper.Map<IEnumerable<MaquinariaDetallesDto>>(maquinariaDetalles);
                return Ok(maquinariaDetalleDtos);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error al recuperar los detalles de Maquinaria.");
                return StatusCode(500, "Error interno del servidor.");
            }
        }

        // GET: api/MaquinariaDetalle/{id}
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetMaquinariaDetalleById(int id)
        {
            _logger.LogInformation($"Recuperando detalle de Maquinaria con ID {id} de la base de datos.");
            try
            {
                var maquinariaDetalle = await _repository.GetByIdAsync(id);
                if (maquinariaDetalle == null)
                {
                    return NotFound();
                }
                var maquinariaDetalleDto = _mapper.Map<MaquinariaDetallesDto>(maquinariaDetalle);
                return Ok(maquinariaDetalleDto);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error al recuperar el detalle de Maquinaria por ID.");
                return StatusCode(500, "Error interno del servidor.");
            }
        }

        // POST: api/MaquinariaDetalle
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<MaquinariaDetallesDto>> PostMaquinariaDetalle(MaquinariaDetalleCreateDto createDto)
        {
            if (createDto == null)
            {
                _logger.LogError("Se recibió un detalle de Maquinaria nulo en la solicitud.");
                return BadRequest("El detalle de Maquinaria no puede ser nulo.");
            }

            try
            {
                _logger.LogInformation($"Creando un nuevo detalle de Maquinaria con MaquinariaID: {createDto.MaquinariaID}");

                var newMaquinariaDetalle = _mapper.Map<MaquinariaDetalle>(createDto);

                await _repository.InsertAsync(newMaquinariaDetalle);

                _logger.LogInformation($"Nuevo detalle de Maquinaria con MaquinariaID '{createDto.MaquinariaID}' creado con ID: {newMaquinariaDetalle.MaquinariaID}");
                return CreatedAtAction(nameof(GetMaquinariaDetalleById), new { id = newMaquinariaDetalle.MaquinariaID }, _mapper.Map<MaquinariaDetallesDto>(newMaquinariaDetalle));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al crear un nuevo detalle de Maquinaria: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor al crear el detalle de Maquinaria.");
            }
        }

        // PUT: api/MaquinariaDetalle/{id}
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PutMaquinariaDetalle(int id, MaquinariaDetalleUpdateDto updateDto)
        {
            if (updateDto == null || id != updateDto.Maquinaria_DetalleID)
            {
                return BadRequest("Datos inválidos o el ID de detalle de Maquinaria no coincide.");
            }

            try
            {
                _logger.LogInformation($"Actualizando detalle de Maquinaria con ID: {id}");

                var maquinariaDetalleToUpdate = _mapper.Map<MaquinariaDetalle>(updateDto);

                var rowsAffected = await _repository.UpdateAsync(maquinariaDetalleToUpdate);

                if (rowsAffected == 0)
                {
                    _logger.LogWarning($"Detalle de Maquinaria con ID {id} no encontrado o no actualizado.");
                    return NotFound("El detalle de Maquinaria no existe.");
                }

                _logger.LogInformation($"Detalle de Maquinaria con ID {id} actualizado con éxito.");
                return NoContent();
            }
            catch (SqlException ex)
            {
                _logger.LogError($"Error al actualizar detalle de Maquinaria con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor al actualizar el detalle de Maquinaria.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error inesperado al actualizar detalle de Maquinaria con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor.");
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteMaquinariaDetalle(int id)
        {
            _logger.LogInformation($"Eliminando detalle de Maquinaria con ID {id}.");
            try
            {
                var result = await _repository.DeleteAsync(id);
                if (result == 0)
                {
                    return NotFound();
                }

                return NoContent();
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error al eliminar detalle de Maquinaria.");
                return StatusCode(500, "Error interno del servidor.");
            }
        }
    }
}
