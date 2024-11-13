using Gestor_Api.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedModels.Dto.AvaluoDetalle;
using SharedModels;
using AutoMapper;
using Gestor_Api.Fliters;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Data.SqlClient;

namespace Gestor_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvaluoDetalleController : ControllerBase
    {
        private readonly IRepository<AvaluoDetalle> _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<AvaluoDetalleController> _logger;

        public AvaluoDetalleController(ILogger<AvaluoDetalleController> logger, IMapper mapper, IRepository<AvaluoDetalle> repository)
        {
            _logger = logger;
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllAvaluoDetalles()
        {
            _logger.LogInformation("Recuperando todos los AvaluoDetalles de la base de datos.");
            try
            {
                var avaluoDetalles = await _repository.GetAllAsync();
                var avaluoDetalleDtos = _mapper.Map<IEnumerable<AvaluoDetallesDto>>(avaluoDetalles);
                return Ok(avaluoDetalleDtos);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error al recuperar los AvaluoDetalles.");
                return StatusCode(500, "Error interno en el servidor.");
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAvaluoDetalleById(int id)
        {
            _logger.LogInformation($"Recuperando AvaluoDetalle con ID {id} de la base de datos.");
            try
            {
                var avaluoDetalle = await _repository.GetByIdAsync(id);
                if (avaluoDetalle == null)
                {
                    return NotFound();
                }
                var avaluoDetalleDto = _mapper.Map<AvaluoDetallesDto>(avaluoDetalle);
                return Ok(avaluoDetalleDto);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error al recuperar AvaluoDetalle por ID.");
                return StatusCode(500, "Error interno en el servidor.");
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<AvaluoDetallesDto>> PostAvaluoDetalle(AvaluoDetalleCreateDto createDto)
        {
            if (createDto == null)
            {
                _logger.LogError("Se recibió un AvaluoDetalle nulo en la solicitud.");
                return BadRequest("El AvaluoDetalle no puede ser nulo.");
            }

            try
            {
                _logger.LogInformation($"Creando un nuevo AvaluoDetalle con ProductoID: {createDto.AvaluoID}");

                var newAvaluoDetalle = _mapper.Map<AvaluoDetalle>(createDto);

                await _repository.InsertAsync(newAvaluoDetalle);

                _logger.LogInformation($"Nuevo AvaluoDetalle con ProductoID '{createDto.AvaluoID}' creado con ID: {newAvaluoDetalle.AvaluoID}");
                return CreatedAtAction(nameof(GetAvaluoDetalleById), new { id = newAvaluoDetalle.AvaluoID }, _mapper.Map<AvaluoDetallesDto>(newAvaluoDetalle));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al crear un nuevo AvaluoDetalle: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor al crear AvaluoDetalle.");
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PutAvaluoDetalle(int id, AvaluoDetalleUpdateDto updateDto)
        {
            if (updateDto == null || id != updateDto.Avaluo_DetalleID)
            {
                return BadRequest("Datos inválidos o no coincide el ID de AvaluoDetalle.");
            }

            try
            {
                _logger.LogInformation($"Actualizando AvaluoDetalle con ID: {id}");

                // Mapeo del DTO a la entidad AvaluoDetalle
                var avaluoDetalleToUpdate = _mapper.Map<AvaluoDetalle>(updateDto);

                // Usamos el repositorio para actualizar la entidad
                var rowsAffected = await _repository.UpdateAsync(avaluoDetalleToUpdate);

                if (rowsAffected == 0)
                {
                    _logger.LogWarning($"AvaluoDetalle con ID {id} no encontrado o no actualizado.");
                    return NotFound("AvaluoDetalle no existe.");
                }

                _logger.LogInformation($"AvaluoDetalle con ID {id} actualizado con éxito.");
                return NoContent();
            }
            catch (SqlException ex)
            {
                _logger.LogError($"Error al actualizar AvaluoDetalle con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor al actualizar AvaluoDetalle.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error inesperado al actualizar AvaluoDetalle con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor.");
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteAvaluoDetalle(int id)
        {
            _logger.LogInformation($"Eliminando AvaluoDetalle con ID {id}.");
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
                _logger.LogError(ex, "Error al eliminar AvaluoDetalle");
                return StatusCode(500, "Error interno en el servidor");
            }
        }
    }
}
