using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using SharedModels;
using SharedModels.Dto.EmpleadoDetalle;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gestor_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoDetalleController : ControllerBase
    {
        private readonly IRepository<EmpleadoDetalle> _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<EmpleadoDetalleController> _logger;

        public EmpleadoDetalleController(ILogger<EmpleadoDetalleController> logger, IMapper mapper, IRepository<EmpleadoDetalle> repository)
        {
            _logger = logger;
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllEmpleadoDetalles()
        {
            _logger.LogInformation("Recuperando todos los detalles de empleados de la base de datos.");
            try
            {
                var detalles = await _repository.GetAllAsync();
                var detalleDtos = _mapper.Map<IEnumerable<EmpleadoDetallesDto>>(detalles);
                return Ok(detalleDtos);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al recuperar los detalles de empleados.");
                return StatusCode(500, "Error interno del servidor.");
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetEmpleadoDetalleById(int id)
        {
            _logger.LogInformation($"Recuperando detalle de empleado con ID {id} de la base de datos.");
            try
            {
                var detalle = await _repository.GetByIdAsync(id);
                if (detalle == null)
                {
                    return NotFound();
                }
                var detalleDto = _mapper.Map<EmpleadoDetallesDto>(detalle);
                return Ok(detalleDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al recuperar el detalle de empleado por ID.");
                return StatusCode(500, "Error interno del servidor.");
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<EmpleadoDetallesDto>> PostEmpleadoDetalle(EmpleadoDetalleCreateDto createDto)
        {
            if (createDto == null)
            {
                _logger.LogError("Se recibió un detalle de empleado nulo en la solicitud.");
                return BadRequest("El detalle de empleado no puede ser nulo.");
            }

            try
            {
                _logger.LogInformation($"Creando un nuevo detalle de empleado para EmpleadoID: {createDto.EmpleadoID}");

                var nuevoDetalle = _mapper.Map<EmpleadoDetalle>(createDto);

                await _repository.InsertAsync(nuevoDetalle);

                _logger.LogInformation($"Nuevo detalle de empleado con  EmpleadoID '{createDto.EmpleadoID }'creado con ID: {nuevoDetalle.EmpleadoID}");
                return CreatedAtAction(nameof(GetEmpleadoDetalleById), new { id = nuevoDetalle.EmpleadoID }, _mapper.Map<EmpleadoDetallesDto>(nuevoDetalle));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al crear un nuevo detalle de empleado: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor al crear el detalle de empleado.");
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PutEmpleadoDetalle(int id, EmpleadoDetalleUpdateDto updateDto)
        {
            if (updateDto == null || id != updateDto.Empleado_DetalleID)
            {
                return BadRequest("Datos inválidos o el ID de detalle de empleado no coincide.");
            }

            try
            {
                _logger.LogInformation($"Actualizando detalle de empleado con ID: {id}");

                var detalleToUpdate = _mapper.Map<EmpleadoDetalle>(updateDto);

                var rowsAffected = await _repository.UpdateAsync(detalleToUpdate);

                if (rowsAffected == 0)
                {
                    _logger.LogWarning($"Detalle de empleado con ID {id} no encontrado o no actualizado.");
                    return NotFound("El detalle de empleado no existe.");
                }

                _logger.LogInformation($"Detalle de empleado con ID {id} actualizado con éxito.");
                return NoContent();
            }
            catch (SqlException ex)
            {
                _logger.LogError($"Error al actualizar detalle de empleado con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor al actualizar el detalle de empleado.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error inesperado al actualizar detalle de empleado con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor.");
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteEmpleadoDetalle(int id)
        {
            _logger.LogInformation($"Eliminando detalle de empleado con ID {id}.");
            try
            {
                var result = await _repository.DeleteAsync(id);
                if (result == 0)
                {
                    return NotFound();
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al eliminar detalle de empleado.");
                return StatusCode(500, "Error interno del servidor.");
            }
        }
    }
}
