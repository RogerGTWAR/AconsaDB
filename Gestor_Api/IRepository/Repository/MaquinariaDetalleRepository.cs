using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SharedModels;
public class MaquinariaDetalleRepository : IRepository<MaquinariaDetalle>
{
    private readonly string _connectionString;

    public MaquinariaDetalleRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<IEnumerable<MaquinariaDetalle>> GetAllAsync()
    {
        var maquinariaDetalleList = new List<MaquinariaDetalle>();

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM [Maquinaria Detalles]"; 

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        maquinariaDetalleList.Add(new MaquinariaDetalle
                        {
                            MaquinariaDetalleID = reader.GetInt32(0),
                            ProyectoID = reader.GetInt32(1),
                            MaquinariaID = reader.GetInt32(2),
                            HorasUtilizadas = reader.GetInt32(3),
                            FechaInicioAsignacion = reader.GetDateTime(4),
                            FechaFinAsignacion = reader.GetDateTime(5)
                        });
                    }
                }
            }
        }

        return maquinariaDetalleList;
    }
    public async Task<MaquinariaDetalle> GetByIdAsync(int id)
    {
        MaquinariaDetalle maquinariaDetalle = null;

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM [Maquinaria Detalles] WHERE MaquinariaDetalleID = @MaquinariaDetalleID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaquinariaDetalleID", id);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        maquinariaDetalle = new MaquinariaDetalle
                        {
                            MaquinariaDetalleID = reader.GetInt32(0),
                            ProyectoID = reader.GetInt32(1),
                            MaquinariaID = reader.GetInt32(2),
                            HorasUtilizadas = reader.GetInt32(3),
                            FechaInicioAsignacion = reader.GetDateTime(4),
                            FechaFinAsignacion = reader.GetDateTime(5)
                        };
                    }
                }
            }
        }

        return maquinariaDetalle;
    }
    public async Task<int> InsertAsync(MaquinariaDetalle entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "INSERT INTO [Maquinaria Detalles] (ProyectoID, MaquinariaID, HorasUtilizadas, FechaInicioAsignacion, FechaFinAsignacion) " +
                           "VALUES (@ProyectoID, @MaquinariaID, @HorasUtilizadas, @FechaInicioAsignacion, @FechaFinAsignacion)";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProyectoID", entity.ProyectoID);
                command.Parameters.AddWithValue("@MaquinariaID", entity.MaquinariaID);
                command.Parameters.AddWithValue("@HorasUtilizadas", entity.HorasUtilizadas);
                command.Parameters.AddWithValue("@FechaInicioAsignacion", entity.FechaInicioAsignacion);
                command.Parameters.AddWithValue("@FechaFinAsignacion", entity.FechaFinAsignacion );

                return await command.ExecuteNonQueryAsync();
            }
        }
    }
    public async Task<int> UpdateAsync(MaquinariaDetalle entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "UPDATE [Maquinaria Detalles] SET ProyectoID = @ProyectoID, MaquinariaID = @MaquinariaID, HorasUtilizadas = @HorasUtilizadas, " +
                           "FechaInicioAsignacion = @FechaInicioAsignacion, FechaFinAsignacion = @FechaFinAsignacion WHERE MaquinariaDetalleID = @MaquinariaDetalleID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaquinariaDetalleID", entity.MaquinariaDetalleID);
                command.Parameters.AddWithValue("@ProyectoID", entity.ProyectoID);
                command.Parameters.AddWithValue("@MaquinariaID", entity.MaquinariaID);
                command.Parameters.AddWithValue("@HorasUtilizadas", entity.HorasUtilizadas);
                command.Parameters.AddWithValue("@FechaInicioAsignacion", entity.FechaInicioAsignacion);
                command.Parameters.AddWithValue("@FechaFinAsignacion", entity.FechaFinAsignacion);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }
    public async Task<int> DeleteAsync(int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "DELETE FROM [Maquinaria Detalles] WHERE MaquinariaDetalleID = @MaquinariaDetalleID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaquinariaDetalleID", id);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }

    public Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}
