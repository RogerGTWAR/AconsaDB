using Gestor_Api.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedModels.Dto.Avaluo;
using SharedModels;
using AutoMapper;

namespace Gestor_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvaluoController : ControllerBase
    {
        private readonly IRepository<Avaluo> _repository;
        private readonly ILogger<AvaluoController> _logger;
        private readonly IMapper _mapper;

        public AvaluoController(IRepository<Avaluo> repository, ILogger<AvaluoController> logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                _logger.LogInformation("Obteniendo todos los avalúos");
                var avaluos = await _repository.GetAllAsync();

                var avaluosDtos = avaluos.Select(avaluo => new AvaluoDto
                {
                    AvaluoID = avaluo.AvaluoID,
                    ProyectoID = avaluo.ProyectoID,
                    Descripcion = avaluo.Descripcion,
                    MontoEjecutado = avaluo.MontoEjecutado,
                    FechaInicio = avaluo.FechaInicio,
                    FechaFin = avaluo.FechaFin,
                    TiempoTotalDias = avaluo.TiempoTotalDias
                });

                return Ok(avaluosDtos);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al obtener avalúos: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al obtener los avalúos");
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                _logger.LogInformation($"Obteniendo avalúo con ID {id}");
                var avaluo = await _repository.GetByIdAsync(id);

                if (avaluo == null)
                {
                    return NotFound("Avalúo no encontrado");
                }

                var avaluoDto = new AvaluoDto
                {
                    AvaluoID = avaluo.AvaluoID,
                    ProyectoID = avaluo.ProyectoID,
                    Descripcion = avaluo.Descripcion,
                    MontoEjecutado = avaluo.MontoEjecutado,
                    FechaInicio = avaluo.FechaInicio,
                    FechaFin = avaluo.FechaFin,
                    TiempoTotalDias = avaluo.TiempoTotalDias
                };

                return Ok(avaluoDto);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al obtener avalúo con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al obtener el avalúo");
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create([FromBody] AvaluoCreateDto avaluoDto)
        {
            if (avaluoDto == null || !ModelState.IsValid)
            {
                return BadRequest("Los datos del avalúo son inválidos");
            }

            try
            {
                var avaluo = new Avaluo
                {
                    ProyectoID = avaluoDto.ProyectoID,
                    Descripcion = avaluoDto.Descripcion,
                    MontoEjecutado = avaluoDto.MontoEjecutado,
                    FechaInicio = avaluoDto.FechaInicio,
                    FechaFin = avaluoDto.FechaFin,
                    TiempoTotalDias = avaluoDto.TiempoTotalDias
                };

                var createdAvaluoId = await _repository.InsertAsync(avaluo);
                if (createdAvaluoId > 0)
                {
                    return CreatedAtAction(nameof(GetById), new { id = createdAvaluoId }, avaluo);
                }

                return BadRequest("No se pudo crear el avalúo");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al crear avalúo: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al crear el avalúo");
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
                _logger.LogInformation($"Creando un nuevo avaluo para el proyecto ID: {createDto.ProyectoID}");

                // Verificar si ya existe un avaluo para el proyecto
                var existingAvaluo = await _repository.GetAsync(a => a.ProyectoID == createDto.ProyectoID && a.FechaFin >= DateTime.Now);

                if (existingAvaluo != null)
                {
                    _logger.LogWarning($"Ya existe un avaluo para el proyecto ID '{createDto.ProyectoID}' que aún está activo.");
                    ModelState.AddModelError("AvaluoExiste", "¡Ya existe un avaluo activo para este proyecto!");
                    return BadRequest(ModelState);
                }

                if (!ModelState.IsValid)
                {
                    _logger.LogError("El modelo de avaluo no es válido.");
                    return BadRequest(ModelState);
                }

                var newAvaluo = _logger.Mapper<Avaluo>(createDto);

                // Guardar el nuevo avaluo en la base de datos
                await _repository.InsertAsync(newAvaluo);

                _logger.LogInformation($"Nuevo avaluo creado para el proyecto ID: {createDto.ProyectoID} con ID: {newAvaluo.AvaluoID}");
                return CreatedAtAction(nameof(GetAvaluo), new { id = newAvaluo.AvaluoID }, newAvaluo);
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
        public async Task<IActionResult> Update(int id, [FromBody] AvaluoUpdateDto avaluoDto)
        {
            if (avaluoDto == null || id != avaluoDto.AvaluoID || !ModelState.IsValid)
            {
                return BadRequest("Los datos del avalúo son inválidos o el ID no coincide");
            }

            try
            {
                _logger.LogInformation($"Actualizando avalúo con ID {id}");

                var existingAvaluo = await _repository.GetByIdAsync(id);
                if (existingAvaluo == null)
                {
                    _logger.LogWarning($"Avalúo con ID {id} no encontrado.");
                    return NotFound("Avalúo no encontrado.");
                }

                existingAvaluo.ProyectoID = avaluoDto.ProyectoID;
                existingAvaluo.Descripcion = avaluoDto.Descripcion;
                existingAvaluo.MontoEjecutado = avaluoDto.MontoEjecutado;
                existingAvaluo.FechaInicio = avaluoDto.FechaInicio;
                existingAvaluo.FechaFin = avaluoDto.FechaFin;
                existingAvaluo.TiempoTotalDias = avaluoDto.TiempoTotalDias;

                var updated = await _repository.UpdateAsync(existingAvaluo);
                if (updated > 0)
                {
                    _logger.LogInformation($"Avalúo con ID {id} actualizado correctamente.");
                    return NoContent();
                }

                return StatusCode(StatusCodes.Status500InternalServerError, "No se pudo actualizar el avalúo.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al actualizar avalúo: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al actualizar el avalúo");
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                _logger.LogInformation($"Eliminando avalúo con ID {id}");
                var deleted = await _repository.DeleteAsync(id);
                if (deleted > 0)
                {
                    return NoContent();
                }

                return NotFound("Avalúo no encontrado");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al eliminar avalúo con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al eliminar el avalúo");
            }
        }
    }
}
