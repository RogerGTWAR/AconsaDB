using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Gestor_Api.IRepository;
using Microsoft.Data.SqlClient;
using SharedModels;

public class AvaluoRepository : IRepository<Avaluo>
{
    private readonly string _connectionString;

    public AvaluoRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<IEnumerable<Avaluo>> GetAllAsync()
    {
        var avaluos = new List<Avaluo>();

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Avaluos";  

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        avaluos.Add(new Avaluo
                        {
                            AvaluoID = reader.GetInt32(0),
                            ProyectoID = reader.GetInt32(1),
                            Descripcion = reader.IsDBNull(2) ? null : reader.GetString(2),
                            MontoEjecutado = reader.GetDecimal(3),
                            FechaInicio = reader.GetDateTime(4),
                            FechaFin = reader.GetDateTime(5),
                            TiempoTotalDias = reader.GetInt32(6)
                        });
                    }
                }
            }
        }

        return avaluos;
    }

    public async Task<Avaluo> GetByIdAsync(int id)
    {
        Avaluo avaluo = null;

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Avaluos WHERE AvaluoID = @AvaluoID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@AvaluoID", id);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        avaluo = new Avaluo
                        {
                            AvaluoID = reader.GetInt32(0),
                            ProyectoID = reader.GetInt32(1),
                            Descripcion = reader.IsDBNull(2) ? null : reader.GetString(2),
                            MontoEjecutado = reader.GetDecimal(3),
                            FechaInicio = reader.GetDateTime(4),
                            FechaFin = reader.GetDateTime(5),
                            TiempoTotalDias = reader.GetInt32(6)
                        };
                    }
                }
            }
        }

        return avaluo;
    }

    public async Task<int> InsertAsync(Avaluo entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "INSERT INTO Avaluos (ProyectoID, Descripcion, MontoEjecutado, FechaInicio, FechaFin, TiempoTotalDias) " +
                           "VALUES (@ProyectoID, @Descripcion, @MontoEjecutado, @FechaInicio, @FechaFin, @TiempoTotalDias)";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProyectoID", entity.ProyectoID);
                command.Parameters.AddWithValue("@Descripcion", entity.Descripcion ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@MontoEjecutado", entity.MontoEjecutado);
                command.Parameters.AddWithValue("@FechaInicio", entity.FechaInicio);
                command.Parameters.AddWithValue("@FechaFin", entity.FechaFin);
                command.Parameters.AddWithValue("@TiempoTotalDias", entity.TiempoTotalDias);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task<int> UpdateAsync(Avaluo entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "UPDATE Avaluos SET ProyectoID = @ProyectoID, Descripcion = @Descripcion, MontoEjecutado = @MontoEjecutado, " +
                           "FechaInicio = @FechaInicio, FechaFin = @FechaFin, TiempoTotalDias = @TiempoTotalDias WHERE AvaluoID = @AvaluoID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@AvaluoID", entity.AvaluoID);
                command.Parameters.AddWithValue("@ProyectoID", entity.ProyectoID);
                command.Parameters.AddWithValue("@Descripcion", entity.Descripcion ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@MontoEjecutado", entity.MontoEjecutado);
                command.Parameters.AddWithValue("@FechaInicio", entity.FechaInicio);
                command.Parameters.AddWithValue("@FechaFin", entity.FechaFin);
                command.Parameters.AddWithValue("@TiempoTotalDias", entity.TiempoTotalDias);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task<int> DeleteAsync(int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "DELETE FROM Avaluos WHERE AvaluoID = @AvaluoID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@AvaluoID", id);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }
}
