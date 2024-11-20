using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SharedModels;

public class RolRepository : IRepository<Rol>
{
    private readonly string _connectionString;

    public RolRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<IEnumerable<Rol>> GetAllAsync()
    {
        var roles = new List<Rol>();

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Roles";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        roles.Add(new Rol
                        {
                            RolID = reader.GetInt32(0),
                            Cargo = reader.GetString(1),
                            Descripcion = reader.GetString(2)
                        });
                    }
                }
            }
        }

        return roles;
    }

    public async Task<Rol> GetByIdAsync(int id)
    {
        Rol? rol = null;

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Roles WHERE RolID = @RolID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@RolID", id);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        rol = new Rol
                        {
                            RolID = reader.GetInt32(0),
                            Cargo = reader.GetString(1),
                            Descripcion = reader.GetString(2)
                        };
                    }
                }
            }
        }

        return rol;
    }

    public async Task<int> InsertAsync(Rol entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "INSERT INTO Roles (Cargo, Descripcion) " +
                           "VALUES (@Cargo, @Descripcion)";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Cargo", entity.Cargo);
                command.Parameters.AddWithValue("@Descripcion", entity.Descripcion);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task<int> UpdateAsync(Rol entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "UPDATE Roles SET Cargo = @Cargo, Descripcion = @Descripcion WHERE RolID = @RolID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@RolID", entity.RolID);
                command.Parameters.AddWithValue("@Cargo", entity.Cargo);
                command.Parameters.AddWithValue("@Descripcion", entity.Descripcion);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task<int> DeleteAsync(int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "DELETE FROM Roles WHERE RolID = @RolID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@RolID", id);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }
}
