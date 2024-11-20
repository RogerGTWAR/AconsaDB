using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using SharedModels.Dto.Vehiculo;
using SharedModels;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace Gestor_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoController : ControllerBase
    {
        private readonly IRepository<Vehiculo> _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<VehiculoController> _logger;

        public VehiculoController(ILogger<VehiculoController> logger, IMapper mapper, IRepository<Vehiculo> repository)
        {
            _logger = logger;
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllVehiculos()
        {
            _logger.LogInformation("Recuperando todos los Vehículos de la base de datos.");
            try
            {
                var vehiculos = await _repository.GetAllAsync();
                var vehiculoDtos = _mapper.Map<IEnumerable<VehiculoDto>>(vehiculos);
                return Ok(vehiculoDtos);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error al recuperar los Vehículos.");
                return StatusCode(500, "Error interno del servidor.");
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetVehiculoById(int id)
        {
            _logger.LogInformation($"Recuperando Vehículo con ID {id} de la base de datos.");
            try
            {
                var vehiculo = await _repository.GetByIdAsync(id);
                if (vehiculo == null)
                {
                    return NotFound();
                }
                var vehiculoDto = _mapper.Map<VehiculoDto>(vehiculo);
                return Ok(vehiculoDto);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error al recuperar el Vehículo por ID.");
                return StatusCode(500, "Error interno del servidor.");
            }
        }

        // POST: api/Vehiculo
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<VehiculoDto>> PostVehiculo(VehiculoCreateDto createDto)
        {
            if (createDto == null)
            {
                _logger.LogError("Se recibió un Vehículo nulo en la solicitud.");
                return BadRequest("El Vehículo no puede ser nulo.");
            }

            try
            {
                _logger.LogInformation($"Creando un nuevo Vehículo con ProveedorID: {createDto.ProveedorID}");

                var newVehiculo = _mapper.Map<Vehiculo>(createDto);

                await _repository.InsertAsync(newVehiculo);

                _logger.LogInformation($"Nuevo Vehículo con Placa '{createDto.ProveedorID}' creado con ID: {newVehiculo.ProveedorID}");
                return CreatedAtAction(nameof(GetVehiculoById), new { id = newVehiculo.ProveedorID }, _mapper.Map<VehiculoDto>(newVehiculo));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al crear un nuevo Vehículo: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor al crear el Vehículo.");
            }
        }

        // PUT: api/Vehiculo/{id}
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PutVehiculo(int id, VehiculoUpdateDto updateDto)
        {
            if (updateDto == null || id != updateDto.VehiculoID)
            {
                return BadRequest("Datos inválidos o el ID de Vehículo no coincide.");
            }

            try
            {
                _logger.LogInformation($"Actualizando Vehículo con ID: {id}");

                var vehiculoToUpdate = _mapper.Map<Vehiculo>(updateDto);

                var rowsAffected = await _repository.UpdateAsync(vehiculoToUpdate);

                if (rowsAffected == 0)
                {
                    _logger.LogWarning($"Vehículo con ID {id} no encontrado o no actualizado.");
                    return NotFound("El Vehículo no existe.");
                }

                _logger.LogInformation($"Vehículo con ID {id} actualizado con éxito.");
                return NoContent();
            }
            catch (SqlException ex)
            {
                _logger.LogError($"Error al actualizar Vehículo con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor al actualizar el Vehículo.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error inesperado al actualizar Vehículo con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor.");
            }
        }

        // DELETE: api/Vehiculo/{id}
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteVehiculo(int id)
        {
            _logger.LogInformation($"Eliminando Vehículo con ID {id}.");
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
                _logger.LogError(ex, "Error al eliminar Vehículo.");
                return StatusCode(500, "Error interno del servidor.");
            }
        }
    }
}
