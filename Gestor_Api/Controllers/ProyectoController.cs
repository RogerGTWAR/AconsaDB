using Gestor_Api.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedModels.Dto.Proyecto;
using SharedModels;
using AutoMapper;
using Microsoft.Data.SqlClient;

namespace Gestor_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProyectoController : ControllerBase
    {
        private readonly IRepository<Proyecto> _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<ProyectoController> _logger;

        public ProyectoController(ILogger<ProyectoController> logger, IMapper mapper, IRepository<Proyecto> repository)
        {
            _logger = logger;
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllProyectos()
        {
            _logger.LogInformation("Recuperando todos los Proyectos de la base de datos.");
            try
            {
                var proyectos = await _repository.GetAllAsync();
                var proyectoDtos = _mapper.Map<IEnumerable<ProyectoDto>>(proyectos);
                return Ok(proyectoDtos);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error al recuperar los Proyectos.");
                return StatusCode(500, "Error interno en el servidor.");
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProyectoById(int id)
        {
            _logger.LogInformation($"Recuperando Proyecto con ID {id} de la base de datos.");
            try
            {
                var proyecto = await _repository.GetByIdAsync(id);
                if (proyecto == null)
                {
                    return NotFound();
                }
                var proyectoDto = _mapper.Map<ProyectoDto>(proyecto);
                return Ok(proyectoDto);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error al recuperar Proyecto por ID.");
                return StatusCode(500, "Error interno en el servidor.");
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ProyectoDto>> PostProyecto(ProyectoCreateDto createDto)
        {
            if (createDto == null)
            {
                _logger.LogError("Se recibió un Proyecto nulo en la solicitud.");
                return BadRequest("El Proyecto no puede ser nulo.");
            }

            try
            {
                _logger.LogInformation($"Creando un nuevo Proyecto con Nombre: {createDto.NombreProyecto}");

                var newProyecto = _mapper.Map<Proyecto>(createDto);

                await _repository.InsertAsync(newProyecto);

                _logger.LogInformation($"Nuevo Proyecto '{createDto.NombreProyecto}' creado con ID: {newProyecto.NombreProyecto}");
                return CreatedAtAction(nameof(GetProyectoById), new { id = newProyecto.NombreProyecto }, _mapper.Map<ProyectoDto>(newProyecto));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al crear un nuevo Proyecto: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor al crear Proyecto.");
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PutProyecto(int id, ProyectoUpdateDto updateDto)
        {
            if (updateDto == null || id != updateDto.ProyectoID)
            {
                return BadRequest("Datos inválidos o no coincide el ID del Proyecto.");
            }

            try
            {
                _logger.LogInformation($"Actualizando Proyecto con ID: {id}");

                // Mapeo del DTO a la entidad Proyecto
                var proyectoToUpdate = _mapper.Map<Proyecto>(updateDto);

                // Usamos el repositorio para actualizar la entidad
                var rowsAffected = await _repository.UpdateAsync(proyectoToUpdate);

                if (rowsAffected == 0)
                {
                    _logger.LogWarning($"Proyecto con ID {id} no encontrado o no actualizado.");
                    return NotFound("Proyecto no existe.");
                }

                _logger.LogInformation($"Proyecto con ID {id} actualizado con éxito.");
                return NoContent();
            }
            catch (SqlException ex)
            {
                _logger.LogError($"Error al actualizar Proyecto con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor al actualizar Proyecto.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error inesperado al actualizar Proyecto con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor.");
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteProyecto(int id)
        {
            _logger.LogInformation($"Eliminando Proyecto con ID {id}.");
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
                _logger.LogError(ex, "Error al eliminar Proyecto");
                return StatusCode(500, "Error interno en el servidor");
            }
        }
    }
}
