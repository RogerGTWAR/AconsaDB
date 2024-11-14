using AutoMapper;
using Gestor_Api.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using SharedModels;
using SharedModels.Dto.VehiculoDetalle;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gestor_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculoDetalleController : ControllerBase
    {
        private readonly IRepository<VehiculoDetalle> _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<VehiculoDetalleController> _logger;

        public VehiculoDetalleController(IRepository<VehiculoDetalle> repository, IMapper mapper, ILogger<VehiculoDetalleController> logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllVehiculoDetalles()
        {
            _logger.LogInformation("Obteniendo todos los Vehiculo Detalles de la base de datos.");
            try
            {
                var vehiculoDetalles = await _repository.GetAllAsync();
                var vehiculoDetalleDtos = _mapper.Map<IEnumerable<VehiculoDetallesDto>>(vehiculoDetalles);
                return Ok(vehiculoDetalleDtos);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener los Vehiculo Detalles");
                return StatusCode(500, "Error interno del servidor");
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetVehiculoDetalleById(int id)
        {
            _logger.LogInformation($"Obteniendo el Vehiculo Detalle con ID {id} de la base de datos.");
            try
            {
                var vehiculoDetalle = await _repository.GetByIdAsync(id);
                if (vehiculoDetalle == null)
                {
                    return NotFound();
                }
                var vehiculoDetalleDto = _mapper.Map<VehiculoDetallesDto>(vehiculoDetalle);
                return Ok(vehiculoDetalleDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener el Vehiculo Detalle por ID");
                return StatusCode(500, "Error interno del servidor");
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<VehiculoDetallesDto>> PostVehiculoDetalle(VehiculoDetalleCreateDto createDto)
        {
            if (createDto == null)
            {
                _logger.LogError("Se recibió un Vehiculo Detalle nulo en la solicitud.");
                return BadRequest("El Vehiculo Detalle no puede ser nulo.");
            }

            try
            {
                _logger.LogInformation($"Creando un nuevo Vehiculo Detalle con EmpleadoID: {createDto.EmpleadoID}");

                var newVehiculoDetalle = _mapper.Map<VehiculoDetalle>(createDto);

                await _repository.InsertAsync(newVehiculoDetalle);

                _logger.LogInformation($"Nuevo Vehiculo Detalle creado con ID: {newVehiculoDetalle.EmpleadoID}");
                return CreatedAtAction(nameof(GetVehiculoDetalleById), new { id = newVehiculoDetalle.EmpleadoID }, _mapper.Map<VehiculoDetallesDto>(newVehiculoDetalle));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al crear un nuevo Vehiculo Detalle: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor al crear el Vehiculo Detalle.");
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PutVehiculoDetalle(int id, VehiculoDetalleUpdateDto updateDto)
        {
            if (updateDto == null || id != updateDto.Vehiculo_DetalleID)
            {
                return BadRequest("Datos de entrada inválidos o discrepancia en el ID del Vehiculo Detalle.");
            }

            try
            {
                _logger.LogInformation($"Actualizando el Vehiculo Detalle con ID: {id}");

                var vehiculoDetalleToUpdate = _mapper.Map<VehiculoDetalle>(updateDto);

                var rowsAffected = await _repository.UpdateAsync(vehiculoDetalleToUpdate);

                if (rowsAffected == 0)
                {
                    _logger.LogWarning($"Vehiculo Detalle con ID {id} no encontrado o no actualizado.");
                    return NotFound("El Vehiculo Detalle no existe.");
                }

                _logger.LogInformation($"Vehiculo Detalle con ID {id} actualizado exitosamente.");
                return NoContent();
            }
            catch (SqlException ex)
            {
                _logger.LogError($"Error al actualizar el Vehiculo Detalle con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor al actualizar el Vehiculo Detalle.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error inesperado al actualizar el Vehiculo Detalle con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor.");
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteVehiculoDetalle(int id)
        {
            _logger.LogInformation($"Eliminando el Vehiculo Detalle con ID {id}.");
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
                _logger.LogError(ex, "Error al eliminar el Vehiculo Detalle");
                return StatusCode(500, "Error interno del servidor");
            }
        }
    }
}
