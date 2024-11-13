using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using SharedModels.Dto.Categoria;
using SharedModels;

namespace Gestor_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly IRepository<Categoria> _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<CategoriaController> _logger;

        public CategoriaController(ILogger<CategoriaController> logger, IMapper mapper, IRepository<Categoria> repository)
        {
            _logger = logger;
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllCategorias()
        {
            _logger.LogInformation("Recuperando todas las Categorias de la base de datos.");
            try
            {
                var categorias = await _repository.GetAllAsync();
                var categoriaDtos = _mapper.Map<IEnumerable<CategoriaDto>>(categorias);
                return Ok(categoriaDtos);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error al recuperar las Categorias.");
                return StatusCode(500, "Error interno del servidor.");
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCategoriaById(int id)
        {
            _logger.LogInformation($"Recuperando Categoria con ID {id} de la base de datos.");
            try
            {
                var categoria = await _repository.GetByIdAsync(id);
                if (categoria == null)
                {
                    return NotFound();
                }
                var categoriaDto = _mapper.Map<CategoriaDto>(categoria);
                return Ok(categoriaDto);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error al recuperar la Categoria por ID.");
                return StatusCode(500, "Error interno del servidor.");
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<CategoriaDto>> PostCategoria(CategoriaCreateDto createDto)
        {
            if (createDto == null)
            {
                _logger.LogError("Se recibió una Categoria nula en la solicitud.");
                return BadRequest("La Categoria no puede ser nula.");
            }

            try
            {
                _logger.LogInformation($"Creando una nueva Categoria con Nombre: {createDto.NombreCategoria}");

                var newCategoria = _mapper.Map<Categoria>(createDto);

                await _repository.InsertAsync(newCategoria);

                _logger.LogInformation($"Nueva Categoria con Nombre '{createDto.NombreCategoria}' creada con ID: {newCategoria.CategoriaID}");
                return CreatedAtAction(nameof(GetCategoriaById), new { id = newCategoria.CategoriaID }, _mapper.Map<CategoriaDto>(newCategoria));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al crear una nueva Categoria: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor al crear la Categoria.");
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PutCategoria(int id, CategoriaUpdateDto updateDto)
        {
            if (updateDto == null || id != updateDto.CategoriaID)
            {
                return BadRequest("Datos inválidos o el ID de Categoria no coincide.");
            }

            try
            {
                _logger.LogInformation($"Actualizando Categoria con ID: {id}");

                var categoriaToUpdate = _mapper.Map<Categoria>(updateDto);

                var rowsAffected = await _repository.UpdateAsync(categoriaToUpdate);

                if (rowsAffected == 0)
                {
                    _logger.LogWarning($"Categoria con ID {id} no encontrada o no actualizada.");
                    return NotFound("La Categoria no existe.");
                }

                _logger.LogInformation($"Categoria con ID {id} actualizada con éxito.");
                return NoContent();
            }
            catch (SqlException ex)
            {
                _logger.LogError($"Error al actualizar Categoria con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor al actualizar la Categoria.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error inesperado al actualizar Categoria con ID {id}: {ex.Message}");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error interno del servidor.");
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteCategoria(int id)
        {
            _logger.LogInformation($"Eliminando Categoria con ID {id}.");
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
                _logger.LogError(ex, "Error al eliminar Categoria.");
                return StatusCode(500, "Error interno del servidor.");
            }
        }
    }
}
