using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SharedModels;

public class EmpleadoDetalleRepository : IRepository<EmpleadoDetalle>
{
    private readonly string _connectionString;

    public EmpleadoDetalleRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<IEnumerable<EmpleadoDetalle>> GetAllAsync()
    {
        var empleadoDetalles = new List<EmpleadoDetalle>();

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM [Empleado Detalles]"; 

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        empleadoDetalles.Add(new EmpleadoDetalle
                        {
                            EmpleadoDetalleID = reader.GetInt32(0),
                            EmpleadoID = reader.GetInt32(1),
                            ProyectoID = reader.GetInt32(2),
                            FechaDeProyecto = reader.GetDateTime(3)
                        });
                    }
                }
            }
        }

        return empleadoDetalles;
    }

    public async Task<EmpleadoDetalle> GetByIdAsync(int id)
    {
        EmpleadoDetalle empleadoDetalle = null;

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM [Empleado Detalles] WHERE EmpleadoDetalleID = @EmpleadoDetalleID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@EmpleadoDetalleID", id);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        empleadoDetalle = new EmpleadoDetalle
                        {
                            EmpleadoDetalleID = reader.GetInt32(0),
                            EmpleadoID = reader.GetInt32(1),
                            ProyectoID = reader.GetInt32(2),
                            FechaDeProyecto = reader.GetDateTime(3)
                        };
                    }
                }
            }
        }

        return empleadoDetalle;
    }

    public async Task<int> InsertAsync(EmpleadoDetalle entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "INSERT INTO [Empleado Detalles] (EmpleadoID, ProyectoID, FechaDeProyecto) " +
                           "VALUES (@EmpleadoID, @ProyectoID, @FechaDeProyecto)";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@EmpleadoID", entity.EmpleadoID);
                command.Parameters.AddWithValue("@ProyectoID", entity.ProyectoID);
                command.Parameters.AddWithValue("@FechaDeProyecto", entity.FechaDeProyecto);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task<int> UpdateAsync(EmpleadoDetalle entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "UPDATE [Empleado Detalles] SET EmpleadoID = @EmpleadoID, ProyectoID = @ProyectoID, " +
                           "FechaDeProyecto = @FechaDeProyecto WHERE EmpleadoDetalleID = @EmpleadoDetalleID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@EmpleadoDetalleID", entity.EmpleadoDetalleID);
                command.Parameters.AddWithValue("@EmpleadoID", entity.EmpleadoID);
                command.Parameters.AddWithValue("@ProyectoID", entity.ProyectoID);
                command.Parameters.AddWithValue("@FechaDeProyecto", entity.FechaDeProyecto);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task<int> DeleteAsync(int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "DELETE FROM [Empleado Detalles] WHERE EmpleadoDetalleID = @EmpleadoDetalleID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@EmpleadoDetalleID", id);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }
}
