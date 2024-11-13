using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SharedModels;

public class CategoriaRepository : IRepository<Categoria>
{
    private readonly string _connectionString;

    public CategoriaRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<IEnumerable<Categoria>> GetAllAsync()
    {
        var categorias = new List<Categoria>();

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Categorias";  

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        categorias.Add(new Categoria
                        {
                            CategoriaID = reader.GetInt32(0),
                            NombreCategoria = reader.IsDBNull(1) ? null : reader.GetString(1),
                            Descripcion = reader.IsDBNull(2) ? null : reader.GetString(2)
                        });
                    }
                }
            }
        }

        return categorias;
    }

    public async Task<Categoria> GetByIdAsync(int id)
    {
        Categoria categoria = null;

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Categorias WHERE CategoriaID = @CategoriaID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CategoriaID", id);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        categoria = new Categoria
                        {
                            CategoriaID = reader.GetInt32(0),
                            NombreCategoria = reader.IsDBNull(1) ? null : reader.GetString(1),
                            Descripcion = reader.IsDBNull(2) ? null : reader.GetString(2)
                        };
                    }
                }
            }
        }

        return categoria;
    }

    public async Task<int> InsertAsync(Categoria entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "INSERT INTO Categorias (NombreCategoria, Descripcion) " +
                           "VALUES (@NombreCategoria, @Descripcion)";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@NombreCategoria", entity.NombreCategoria ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Descripcion", entity.Descripcion ?? (object)DBNull.Value);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task<int> UpdateAsync(Categoria entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "UPDATE Categorias SET NombreCategoria = @NombreCategoria, " +
                           "Descripcion = @Descripcion WHERE CategoriaID = @CategoriaID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CategoriaID", entity.CategoriaID);
                command.Parameters.AddWithValue("@NombreCategoria", entity.NombreCategoria ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Descripcion", entity.Descripcion ?? (object)DBNull.Value);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task<int> DeleteAsync(int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "DELETE FROM Categorias WHERE CategoriaID = @CategoriaID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CategoriaID", id);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }
}
