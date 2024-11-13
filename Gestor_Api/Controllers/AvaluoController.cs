using Gestor_Api.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedModels.Dto.Avaluo;
using SharedModels;
using AutoMapper;
using Gestor_Api.Fliters;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Data.SqlClient;

namespace Gestor_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvaluoController : ControllerBase
    {
        private readonly IRepository<Avaluo> _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<AvaluoController> _logger;

        public AvaluoController(ILogger<AvaluoController> logger, IMapper mapper, IRepository<Avaluo> repository)
        {
            _logger = logger;
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllAvaluos()
        {
            _logger.LogInformation("Fetching all Avaluos from database.");
            try
            {
                var avaluos = await _repository.GetAllAsync();
                var avaluoDtos = _mapper.Map<IEnumerable<AvaluoDto>>(avaluos);
                return Ok(avaluoDtos);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error while fetching Avaluos");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAvaluoById(int id)
        {
            _logger.LogInformation($"Fetching Avaluo with ID {id} from database.");
            try
            {
                var avaluo = await _repository.GetByIdAsync(id);
                if (avaluo == null)
                {
                    return NotFound();
                }
                var avaluoDto = _mapper.Map<AvaluoDto>(avaluo);
                return Ok(avaluoDto);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error while fetching Avaluo by ID");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<AvaluoDto>> PostAvaluo(AvaluoCreateDto createDto)
        {
            if (createDto == null)
            {
                _logger.LogError("Se recibió un avaluo nulo en la solicitud.");
                return BadRequest("El avaluo no puede ser nulo.");
            }

            try
            {
                _logger.LogInformation($"Creando un nuevo avaluo con descripción: {createDto.ProyectoID}");

                var newIngreso = _mapper.Map<Avaluo>(createDto);

                await _repository.InsertAsync(newIngreso);

                _logger.LogInformation($"Nuevo avaluo '{createDto.ProyectoID}' creado con ID: {newIngreso.ProyectoID}");
                return CreatedAtAction(nameof(GetAllAvaluos), new { id = newIngreso.ProyectoID }, _mapper.Map<AvaluoDto>(newIngreso));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al crear un nuevo avaluo: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error interno del servidor al crear un nuevo avaluo.");
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PutAvaluo(int id, AvaluoUpdateDto updateDto)
        {
            if (updateDto == null || id != updateDto.AvaluoID)
            {
                return BadRequest("Los datos de entrada no son válidos o el ID del Avaluo no coincide.");
            }

            try
            {
                _logger.LogInformation($"Actualizando Avaluo con ID: {id}");
                var avaluoToUpdate = _mapper.Map<Avaluo>(updateDto);
                var rowsAffected = await _repository.UpdateAsync(avaluoToUpdate);

                if (rowsAffected == 0)
                {
                    _logger.LogWarning($"El Avaluo con ID {id} no fue encontrado o no se pudo actualizar.");
                    return NotFound("El Avaluo no existe.");
                }

                _logger.LogInformation($"Avaluo con ID {id} actualizado correctamente.");
                return NoContent();
            }
            catch (SqlException ex)
            {
                _logger.LogError($"Error al actualizar el Avaluo con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor al actualizar el Avaluo.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error inesperado al actualizar el Avaluo con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor.");
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteAvaluo(int id)
        {
            _logger.LogInformation($"Deleting Avaluo with ID {id}.");
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
                _logger.LogError(ex, "Error while deleting Avaluo");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
