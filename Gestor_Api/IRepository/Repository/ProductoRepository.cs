using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SharedModels;
//Listo
public class ProductoRepository : IRepository<Producto>
{
    private readonly string _connectionString;

    public ProductoRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    // Obtener todos los productos
    public async Task<IEnumerable<Producto>> GetAllAsync()
    {
        var productoList = new List<Producto>();

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Productos";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        productoList.Add(new Producto
                        {
                            ProductoID = reader.GetInt32(0),
                            NombreProducto = reader.GetString(1),
                            ProveedorID = reader.GetInt32(2),
                            CategoriaID = reader.GetInt32(3),
                            Descripcion = reader.GetString(4),
                            UnidadDeMedida = reader.GetString(5),
                            CantidadEnStock = reader.GetInt32(6),
                            PrecioUnitario = reader.GetDecimal(7)
                        });
                    }
                }
            }
        }

        return productoList;
    }

    // Obtener producto por ID
    public async Task<Producto> GetByIdAsync(int id)
    {
        Producto producto = null;

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Productos WHERE ProductoID = @ProductoID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProductoID", id);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        producto = new Producto
                        {
                            ProductoID = reader.GetInt32(0),
                            NombreProducto = reader.GetString(1),
                            ProveedorID = reader.GetInt32(2),
                            CategoriaID = reader.GetInt32(3),
                            Descripcion = reader.GetString(4),
                            UnidadDeMedida = reader.GetString(5),
                            CantidadEnStock = reader.GetInt32(6),
                            PrecioUnitario = reader.GetDecimal(7)
                        };
                    }
                }
            }
        }

        return producto;
    }

    // Insertar un nuevo producto
    public async Task<int> InsertAsync(Producto entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "INSERT INTO Productos (NombreProducto, ProveedorID, CategoriaID, Descripcion, UnidadDeMedida, CantidadEnStock, PrecioUnitario) " +
                           "VALUES (@NombreProducto, @ProveedorID, @CategoriaID, @Descripcion, @UnidadDeMedida, @CantidadEnStock, @PrecioUnitario)";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@NombreProducto", entity.NombreProducto);
                command.Parameters.AddWithValue("@ProveedorID", entity.ProveedorID);
                command.Parameters.AddWithValue("@CategoriaID", entity.CategoriaID);
                command.Parameters.AddWithValue("@Descripcion", entity.Descripcion);
                command.Parameters.AddWithValue("@UnidadDeMedida", entity.UnidadDeMedida );
                command.Parameters.AddWithValue("@CantidadEnStock", entity.CantidadEnStock);
                command.Parameters.AddWithValue("@PrecioUnitario", entity.PrecioUnitario);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }

    // Actualizar producto
    public async Task<int> UpdateAsync(Producto entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "UPDATE Productos SET NombreProducto = @NombreProducto, ProveedorID = @ProveedorID, CategoriaID = @CategoriaID, " +
                           "Descripcion = @Descripcion, UnidadDeMedida = @UnidadDeMedida, CantidadEnStock = @CantidadEnStock, PrecioUnitario = @PrecioUnitario " +
                           "WHERE ProductoID = @ProductoID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProductoID", entity.ProductoID);
                command.Parameters.AddWithValue("@NombreProducto", entity.NombreProducto);
                command.Parameters.AddWithValue("@ProveedorID", entity.ProveedorID);
                command.Parameters.AddWithValue("@CategoriaID", entity.CategoriaID);
                command.Parameters.AddWithValue("@Descripcion", entity.Descripcion);
                command.Parameters.AddWithValue("@UnidadDeMedida", entity.UnidadDeMedida);
                command.Parameters.AddWithValue("@CantidadEnStock", entity.CantidadEnStock);
                command.Parameters.AddWithValue("@PrecioUnitario", entity.PrecioUnitario);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }

    // Eliminar producto
    public async Task<int> DeleteAsync(int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "DELETE FROM Productos WHERE ProductoID = @ProductoID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProductoID", id);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }
}
