using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using SharedModels.Dto.Rol;
using SharedModels;

namespace Gestor_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRepository<Rol> _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<RolesController> _logger;

        public RolesController(ILogger<RolesController> logger, IMapper mapper, IRepository<Rol> repository)
        {
            _logger = logger;
            _mapper = mapper;
            _repository = repository;
        }

        // GET: api/Roles
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllRoles()
        {
            _logger.LogInformation("Recuperando todos los Roles de la base de datos.");
            try
            {
                var roles = await _repository.GetAllAsync();
                var rolesDtos = _mapper.Map<IEnumerable<RolDto>>(roles);
                return Ok(rolesDtos);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error al recuperar los Roles.");
                return StatusCode(500, "Error interno del servidor.");
            }
        }

        // GET: api/Roles/{id}
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetRoleById(int id)
        {
            _logger.LogInformation($"Recuperando Rol con ID {id} de la base de datos.");
            try
            {
                var rol = await _repository.GetByIdAsync(id);
                if (rol == null)
                {
                    return NotFound();
                }
                var rolDto = _mapper.Map<RolDto>(rol);
                return Ok(rolDto);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error al recuperar el Rol por ID.");
                return StatusCode(500, "Error interno del servidor.");
            }
        }

        // POST: api/Roles
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<RolDto>> PostRole(RolCreateDto createDto)
        {
            if (createDto == null)
            {
                _logger.LogError("Se recibió un Rol nulo en la solicitud.");
                return BadRequest("El Rol no puede ser nulo.");
            }

            try
            {
                _logger.LogInformation($"Creando un nuevo Rol con Cargo: {createDto.Cargo}");

                var newRole = _mapper.Map<Rol>(createDto);

                await _repository.InsertAsync(newRole);

                _logger.LogInformation($"Nuevo Rol con Cargo '{createDto.Cargo}' creado con ID: {newRole.RolID}");
                return CreatedAtAction(nameof(GetRoleById), new { id = newRole.RolID }, _mapper.Map<RolDto>(newRole));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al crear un nuevo Rol: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor al crear el Rol.");
            }
        }

        // PUT: api/Roles/{id}
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PutRole(int id, RolUpdateDto updateDto)
        {
            if (updateDto == null || id != updateDto.RolID)
            {
                return BadRequest("Datos inválidos o el ID de Rol no coincide.");
            }

            try
            {
                _logger.LogInformation($"Actualizando Rol con ID: {id}");

                var roleToUpdate = _mapper.Map<Rol>(updateDto);

                var rowsAffected = await _repository.UpdateAsync(roleToUpdate);

                if (rowsAffected == 0)
                {
                    _logger.LogWarning($"Rol con ID {id} no encontrado o no actualizado.");
                    return NotFound("El Rol no existe.");
                }

                _logger.LogInformation($"Rol con ID {id} actualizado con éxito.");
                return NoContent();
            }
            catch (SqlException ex)
            {
                _logger.LogError($"Error al actualizar Rol con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor al actualizar el Rol.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error inesperado al actualizar Rol con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor.");
            }
        }

        // DELETE: api/Roles/{id}
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteRole(int id)
        {
            _logger.LogInformation($"Eliminando Rol con ID {id}.");
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
                _logger.LogError(ex, "Error al eliminar Rol.");
                return StatusCode(500, "Error interno del servidor.");
            }
        }
    }
}
