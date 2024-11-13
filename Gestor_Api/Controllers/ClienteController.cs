using AutoMapper;
using Gestor_Api.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using SharedModels;
using SharedModels.Dto.Cliente;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gestor_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository<Cliente> _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<ClienteController> _logger;

        public ClienteController(IClienteRepository<Cliente> repository, IMapper mapper, ILogger<ClienteController> logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllClientes()
        {
            _logger.LogInformation("Obteniendo todos los Clientes de la base de datos.");
            try
            {
                var clientes = await _repository.GetAllAsync();
                var clienteDtos = _mapper.Map<IEnumerable<ClienteDto>>(clientes);
                return Ok(clienteDtos);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error al obtener los Clientes");
                return StatusCode(500, "Error interno del servidor");
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetClienteById(string id)
        {
            _logger.LogInformation($"Obteniendo el Cliente con ID {id} de la base de datos.");
            try
            {
                var cliente = await _repository.GetByIdAsync(id);
                if (cliente == null)
                {
                    return NotFound();
                }
                var clienteDto = _mapper.Map<ClienteDto>(cliente);
                return Ok(clienteDto);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error al obtener el Cliente por ID");
                return StatusCode(500, "Error interno del servidor");
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ClienteDto>> PostCliente(ClienteCreateDto createDto)
        {
            if (createDto == null)
            {
                _logger.LogError("Se recibió un Cliente nulo en la solicitud.");
                return BadRequest("El Cliente no puede ser nulo.");
            }

            try
            {
                _logger.LogInformation($"Creando un nuevo Cliente con NombreEmpresa: {createDto.NombreEmpresa}");

                var newCliente = _mapper.Map<Cliente>(createDto);

                await _repository.InsertAsync(newCliente);

                _logger.LogInformation($"Nuevo Cliente creado con NombreEmpresa '{createDto.NombreEmpresa}' y ID: {newCliente.ClienteID}");
                return CreatedAtAction(nameof(GetClienteById), new { id = newCliente.ClienteID }, _mapper.Map<ClienteDto>(newCliente));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al crear un nuevo Cliente: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor al crear el Cliente.");
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PutCliente(string id, ClienteUpdateDto updateDto)
        {
            if (updateDto == null || id != updateDto.ClienteID)
            {
                return BadRequest("Datos de entrada inválidos o discrepancia en el ID del Cliente.");
            }

            try
            {
                _logger.LogInformation($"Actualizando el Cliente con ID: {id}");

                var clienteToUpdate = _mapper.Map<Cliente>(updateDto);

                var rowsAffected = await _repository.UpdateAsync(clienteToUpdate);

                if (rowsAffected == 0)
                {
                    _logger.LogWarning($"Cliente con ID {id} no encontrado o no actualizado.");
                    return NotFound("El Cliente no existe.");
                }

                _logger.LogInformation($"Cliente con ID {id} actualizado exitosamente.");
                return NoContent();
            }
            catch (SqlException ex)
            {
                _logger.LogError($"Error al actualizar el Cliente con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor al actualizar el Cliente.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error inesperado al actualizar el Cliente con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor.");
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteCliente(string id)
        {
            _logger.LogInformation($"Eliminando el Cliente con ID {id}.");
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
                _logger.LogError(ex, "Error al eliminar el Cliente");
                return StatusCode(500, "Error interno del servidor");
            }
        }
    }
}

