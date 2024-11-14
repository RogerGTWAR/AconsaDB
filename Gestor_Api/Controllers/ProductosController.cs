using AutoMapper;
using Gestor_Api.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using SharedModels;
using SharedModels.Dto.Producto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gestor_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IRepository<Producto> _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<ProductoController> _logger;

        public ProductoController(IRepository<Producto> repository, IMapper mapper, ILogger<ProductoController> logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllProductos()
        {
            _logger.LogInformation("Obteniendo todos los Productos de la base de datos.");
            try
            {
                var productos = await _repository.GetAllAsync();
                var productoDtos = _mapper.Map<IEnumerable<ProductoDto>>(productos);
                return Ok(productoDtos);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener los Productos");
                return StatusCode(500, "Error interno del servidor");
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProductoById(int id)
        {
            _logger.LogInformation($"Obteniendo el Producto con ID {id} de la base de datos.");
            try
            {
                var producto = await _repository.GetByIdAsync(id);
                if (producto == null)
                {
                    return NotFound();
                }
                var productoDto = _mapper.Map<ProductoDto>(producto);
                return Ok(productoDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener el Producto por ID");
                return StatusCode(500, "Error interno del servidor");
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ProductoDto>> PostProducto(ProductoCreateDto createDto)
        {
            if (createDto == null)
            {
                _logger.LogError("Se recibió un Producto nulo en la solicitud.");
                return BadRequest("El Producto no puede ser nulo.");
            }

            try
            {
                _logger.LogInformation($"Creando un nuevo Producto con Nombre: {createDto.ProveedorID}");

                var newProducto = _mapper.Map<Producto>(createDto);

                await _repository.InsertAsync(newProducto);

                _logger.LogInformation($"Nuevo Producto creado con Nombre '{createDto.ProveedorID}' y ID: {newProducto.ProveedorID}");
                return CreatedAtAction(nameof(GetProductoById), new { id = newProducto.ProveedorID }, _mapper.Map<ProductoDto>(newProducto));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al crear un nuevo Producto: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor al crear el Producto.");
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PutProducto(int id, ProductoUpdateDto updateDto)
        {
            if (updateDto == null || id != updateDto.ProductoID)
            {
                return BadRequest("Datos de entrada inválidos o discrepancia en el ID del Producto.");
            }

            try
            {
                _logger.LogInformation($"Actualizando el Producto con ID: {id}");

                var productoToUpdate = _mapper.Map<Producto>(updateDto);

                var rowsAffected = await _repository.UpdateAsync(productoToUpdate);

                if (rowsAffected == 0)
                {
                    _logger.LogWarning($"Producto con ID {id} no encontrado o no actualizado.");
                    return NotFound("El Producto no existe.");
                }

                _logger.LogInformation($"Producto con ID {id} actualizado exitosamente.");
                return NoContent();
            }
            catch (SqlException ex)
            {
                _logger.LogError($"Error al actualizar el Producto con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor al actualizar el Producto.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error inesperado al actualizar el Producto con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor.");
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteProducto(int id)
        {
            _logger.LogInformation($"Eliminando el Producto con ID {id}.");
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
                _logger.LogError(ex, "Error al eliminar el Producto");
                return StatusCode(500, "Error interno del servidor");
            }
        }
    }
}
