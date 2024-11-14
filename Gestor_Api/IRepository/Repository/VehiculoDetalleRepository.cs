using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SharedModels;
//Listo
public class VehiculoDetalleRepository : IRepository<VehiculoDetalle>
{
    private readonly string _connectionString;

    public VehiculoDetalleRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<IEnumerable<VehiculoDetalle>> GetAllAsync()
    {
        var vehiculoDetalles = new List<VehiculoDetalle>();

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT Vehiculo_DetalleID, EmpleadoID, VehiculoID, FechaAsignacion, FechaFinAsignacion, Descripcion FROM [Vehiculo Detalles]";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        vehiculoDetalles.Add(new VehiculoDetalle
                        {
                            Vehiculo_DetalleID = reader.GetInt32(0),
                            EmpleadoID = reader.GetInt32(1),
                            VehiculoID = reader.GetInt32(2),
                            FechaAsignacion = reader.GetDateTime(3),
                            FechaFinAsignacion = reader.GetDateTime(4),
                            Descripcion =  reader.GetString(5)
                        });
                    }
                }
            }
        }

        return vehiculoDetalles;
    }

    public async Task<VehiculoDetalle> GetByIdAsync(int id)
    {
        VehiculoDetalle vehiculoDetalle = null;

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT Vehiculo_DetalleID, EmpleadoID, VehiculoID, FechaAsignacion, FechaFinAsignacion, Descripcion FROM [Vehiculo Detalles] WHERE Vehiculo_DetalleID = @Vehiculo_DetalleID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Vehiculo_DetalleID", id);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        vehiculoDetalle = new VehiculoDetalle
                        {
                            Vehiculo_DetalleID = reader.GetInt32(0),
                            EmpleadoID = reader.GetInt32(1),
                            VehiculoID = reader.GetInt32(2),
                            FechaAsignacion = reader.GetDateTime(3),
                            FechaFinAsignacion = reader.GetDateTime(4),
                            Descripcion =  reader.GetString(5)
                        };
                    }
                }
            }
        }

        return vehiculoDetalle;
    }

    public async Task<int> InsertAsync(VehiculoDetalle entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "INSERT INTO [Vehiculo Detalles] (EmpleadoID, VehiculoID, FechaAsignacion, FechaFinAsignacion, Descripcion) " +
                           "VALUES (@EmpleadoID, @VehiculoID, @FechaAsignacion, @FechaFinAsignacion, @Descripcion)";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@EmpleadoID", entity.EmpleadoID);
                command.Parameters.AddWithValue("@VehiculoID", entity.VehiculoID);
                command.Parameters.AddWithValue("@FechaAsignacion", entity.FechaAsignacion);
                command.Parameters.AddWithValue("@FechaFinAsignacion", entity.FechaFinAsignacion );
                command.Parameters.AddWithValue("@Descripcion", entity.Descripcion);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task<int> UpdateAsync(VehiculoDetalle entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "UPDATE [Vehiculo Detalles] SET EmpleadoID = @EmpleadoID, VehiculoID = @VehiculoID, FechaAsignacion = @FechaAsignacion, " +
                           "FechaFinAsignacion = @FechaFinAsignacion, Descripcion = @Descripcion WHERE Vehiculo_DetalleID = @Vehiculo_DetalleID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Vehiculo_DetalleID", entity.Vehiculo_DetalleID);
                command.Parameters.AddWithValue("@EmpleadoID", entity.EmpleadoID);
                command.Parameters.AddWithValue("@VehiculoID", entity.VehiculoID);
                command.Parameters.AddWithValue("@FechaAsignacion", entity.FechaAsignacion);
                command.Parameters.AddWithValue("@FechaFinAsignacion", entity.FechaFinAsignacion);
                command.Parameters.AddWithValue("@Descripcion", entity.Descripcion );

                return await command.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task<int> DeleteAsync(int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "DELETE FROM [Vehiculo Detalles] WHERE Vehiculo_DetalleID = @Vehiculo_DetalleID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Vehiculo_DetalleID", id);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }
}
