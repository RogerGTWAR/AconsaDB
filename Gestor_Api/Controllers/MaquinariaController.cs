using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using SharedModels.Dto.Maquinaria;
using SharedModels;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace Gestor_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaquinariaController : ControllerBase
    {
        private readonly IRepository<Maquinaria> _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<MaquinariaController> _logger;

        public MaquinariaController(ILogger<MaquinariaController> logger, IMapper mapper, IRepository<Maquinaria> repository)
        {
            _logger = logger;
            _mapper = mapper;
            _repository = repository;
        }

        // GET: api/Maquinaria
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllMaquinarias()
        {
            _logger.LogInformation("Recuperando todas las Maquinarias de la base de datos.");
            try
            {
                var maquinarias = await _repository.GetAllAsync();
                var maquinariaDtos = _mapper.Map<IEnumerable<MaquinariaDto>>(maquinarias);
                return Ok(maquinariaDtos);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error al recuperar las Maquinarias.");
                return StatusCode(500, "Error interno del servidor.");
            }
        }

        // GET: api/Maquinaria/{id}
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetMaquinariaById(int id)
        {
            _logger.LogInformation($"Recuperando Maquinaria con ID {id} de la base de datos.");
            try
            {
                var maquinaria = await _repository.GetByIdAsync(id);
                if (maquinaria == null)
                {
                    return NotFound();
                }
                var maquinariaDto = _mapper.Map<MaquinariaDto>(maquinaria);
                return Ok(maquinariaDto);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error al recuperar la Maquinaria por ID.");
                return StatusCode(500, "Error interno del servidor.");
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<MaquinariaDto>> PostMaquinaria(MaquinariaCreateDto createDto)
        {
            if (createDto == null)
            {
                _logger.LogError("Se recibió una Maquinaria nula en la solicitud.");
                return BadRequest("La Maquinaria no puede ser nula.");
            }

            try
            {
                _logger.LogInformation($"Creando una nueva Maquinaria con ProveedorID: {createDto.ProveedorID}");

                var newMaquinaria = _mapper.Map<Maquinaria>(createDto);

                await _repository.InsertAsync(newMaquinaria);

                _logger.LogInformation($"Nueva Maquinaria con ProveedorID '{createDto.ProveedorID}' creada con ID: {newMaquinaria.ProveedorID}");
                return CreatedAtAction(nameof(GetMaquinariaById), new { id = newMaquinaria.ProveedorID }, _mapper.Map<MaquinariaDto>(newMaquinaria));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al crear una nueva Maquinaria: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor al crear la Maquinaria.");
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PutMaquinaria(int id, MaquinariaUpdateDto updateDto)
        {
            if (updateDto == null || id != updateDto.MaquinariaID)
            {
                return BadRequest("Datos inválidos o el ID de Maquinaria no coincide.");
            }

            try
            {
                _logger.LogInformation($"Actualizando Maquinaria con ID: {id}");

                var maquinariaToUpdate = _mapper.Map<Maquinaria>(updateDto);

                var rowsAffected = await _repository.UpdateAsync(maquinariaToUpdate);

                if (rowsAffected == 0)
                {
                    _logger.LogWarning($"Maquinaria con ID {id} no encontrada o no actualizada.");
                    return NotFound("La Maquinaria no existe.");
                }

                _logger.LogInformation($"Maquinaria con ID {id} actualizada con éxito.");
                return NoContent();
            }
            catch (SqlException ex)
            {
                _logger.LogError($"Error al actualizar Maquinaria con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor al actualizar la Maquinaria.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error inesperado al actualizar Maquinaria con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor.");
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteMaquinaria(int id)
        {
            _logger.LogInformation($"Eliminando Maquinaria con ID {id}.");
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
                _logger.LogError(ex, "Error al eliminar Maquinaria.");
                return StatusCode(500, "Error interno del servidor.");
            }
        }
    }
}
