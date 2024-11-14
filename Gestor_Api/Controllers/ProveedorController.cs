using Gestor_Api.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedModels.Dto.Proveedor;
using SharedModels;
using AutoMapper;
using Microsoft.Data.SqlClient;

namespace Gestor_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        private readonly IRepository<Proveedor> _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<ProveedorController> _logger;

        public ProveedorController(ILogger<ProveedorController> logger, IMapper mapper, IRepository<Proveedor> repository)
        {
            _logger = logger;
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllProveedores()
        {
            _logger.LogInformation("Recuperando todos los Proveedores de la base de datos.");
            try
            {
                var proveedores = await _repository.GetAllAsync();
                var proveedorDtos = _mapper.Map<IEnumerable<ProveedorDto>>(proveedores);
                return Ok(proveedorDtos);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error al recuperar los Proveedores.");
                return StatusCode(500, "Error interno en el servidor.");
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProveedorById(int id)
        {
            _logger.LogInformation($"Recuperando Proveedor con ID {id} de la base de datos.");
            try
            {
                var proveedor = await _repository.GetByIdAsync(id);
                if (proveedor == null)
                {
                    return NotFound();
                }
                var proveedorDto = _mapper.Map<ProveedorDto>(proveedor);
                return Ok(proveedorDto);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error al recuperar Proveedor por ID.");
                return StatusCode(500, "Error interno en el servidor.");
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ProveedorDto>> PostProveedor(ProveedorCreateDto createDto)
        {
            if (createDto == null)
            {
                _logger.LogError("Se recibió un Proveedor nulo en la solicitud.");
                return BadRequest("El Proveedor no puede ser nulo.");
            }

            try
            {
                _logger.LogInformation($"Creando un nuevo Proveedor con Nombre: {createDto.NombreEmpresa}");

                var newProveedor = _mapper.Map<Proveedor>(createDto);

                await _repository.InsertAsync(newProveedor);

                _logger.LogInformation($"Nuevo Proveedor '{createDto.NombreEmpresa}' creado con ID: {newProveedor.NombreEmpresa}");
                return CreatedAtAction(nameof(GetProveedorById), new { id = newProveedor.NombreEmpresa }, _mapper.Map<ProveedorDto>(newProveedor));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al crear un nuevo Proveedor: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor al crear Proveedor.");
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PutProveedor(int id, ProveedorUpdateDto updateDto)
        {
            if (updateDto == null || id != updateDto.ProveedorID)
            {
                return BadRequest("Datos inválidos o no coincide el ID de Proveedor.");
            }

            try
            {
                _logger.LogInformation($"Actualizando Proveedor con ID: {id}");

                // Mapeo del DTO a la entidad Proveedor
                var proveedorToUpdate = _mapper.Map<Proveedor>(updateDto);

                // Usamos el repositorio para actualizar la entidad
                var rowsAffected = await _repository.UpdateAsync(proveedorToUpdate);

                if (rowsAffected == 0)
                {
                    _logger.LogWarning($"Proveedor con ID {id} no encontrado o no actualizado.");
                    return NotFound("Proveedor no existe.");
                }

                _logger.LogInformation($"Proveedor con ID {id} actualizado con éxito.");
                return NoContent();
            }
            catch (SqlException ex)
            {
                _logger.LogError($"Error al actualizar Proveedor con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor al actualizar Proveedor.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error inesperado al actualizar Proveedor con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor.");
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteProveedor(int id)
        {
            _logger.LogInformation($"Eliminando Proveedor con ID {id}.");
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
                _logger.LogError(ex, "Error al eliminar Proveedor");
                return StatusCode(500, "Error interno en el servidor");
            }
        }
    }
}
