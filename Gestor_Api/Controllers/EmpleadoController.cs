using Gestor_Api.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedModels.Dto.Empleado;
using AutoMapper;
using Microsoft.Extensions.Logging;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;
using SharedModels;

namespace Gestor_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly IRepository<Empleado> _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<EmpleadoController> _logger;

        public EmpleadoController(ILogger<EmpleadoController> logger, IMapper mapper, IRepository<Empleado> repository)
        {
            _logger = logger;
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllEmpleados()
        {
            _logger.LogInformation("Obteniendo todos los empleados de la base de datos.");
            try
            {
                var empleados = await _repository.GetAllAsync();
                var empleadoDtos = _mapper.Map<IEnumerable<EmpleadoDto>>(empleados);
                return Ok(empleadoDtos);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error al obtener los empleados.");
                return StatusCode(500, "Error interno del servidor.");
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetEmpleadoById(int id)
        {
            _logger.LogInformation($"Obteniendo el empleado con ID {id}.");
            try
            {
                var empleado = await _repository.GetByIdAsync(id);
                if (empleado == null)
                {
                    return NotFound();
                }
                var empleadoDto = _mapper.Map<EmpleadoDto>(empleado);
                return Ok(empleadoDto);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error al obtener el empleado.");
                return StatusCode(500, "Error interno del servidor.");
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<EmpleadoDto>> PostEmpleado(EmpleadoCreateDto createDto)
        {
            if (createDto == null)
            {
                _logger.LogError("El objeto Empleado está nulo.");
                return BadRequest("El empleado no puede ser nulo.");
            }

            try
            {
                _logger.LogInformation($"Creando un nuevo empleado con nombre: {createDto.Nombres}");

                var newEmpleado = _mapper.Map<Empleado>(createDto);
                await _repository.InsertAsync(newEmpleado);

                _logger.LogInformation($"Nuevo empleado '{createDto.Nombres}' creado con ID: {newEmpleado.Nombres}");
                return CreatedAtAction(nameof(GetEmpleadoById), new { id = newEmpleado.Nombres }, _mapper.Map<EmpleadoDto>(newEmpleado));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al crear un nuevo empleado: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor al crear un nuevo empleado.");
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PutEmpleado(int id, EmpleadoUpdateDto updateDto)
        {
            if (updateDto == null || id != updateDto.EmpleadoID)
            {
                return BadRequest("Los datos de entrada no son válidos o el ID del Empleado no coincide.");
            }

            try
            {
                _logger.LogInformation($"Actualizando empleado con ID: {id}");
                var empleadoToUpdate = _mapper.Map<Empleado>(updateDto);
                var rowsAffected = await _repository.UpdateAsync(empleadoToUpdate);

                if (rowsAffected == 0)
                {
                    _logger.LogWarning($"El empleado con ID {id} no fue encontrado o no se pudo actualizar.");
                    return NotFound("El empleado no existe.");
                }

                _logger.LogInformation($"Empleado con ID {id} actualizado correctamente.");
                return NoContent();
            }
            catch (SqlException ex)
            {
                _logger.LogError($"Error al actualizar el empleado con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor al actualizar el empleado.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error inesperado al actualizar el empleado con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor.");
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteEmpleado(int id)
        {
            _logger.LogInformation($"Eliminando empleado con ID {id}.");
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
                _logger.LogError(ex, "Error al eliminar el empleado.");
                return StatusCode(500, "Error interno del servidor.");
            }
        }
    }
}
