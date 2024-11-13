using Gestor_Api.Data;
using Microsoft.Data.SqlClient;
using SharedModels;
using System.Data;
//Listo para la api
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
        Avaluo? avaluo = null;

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
        try
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                var command = new SqlCommand("INSERT INTO Avaluos (ProyectoID, Descripcion, MontoEjecutado, FechaInicio, FechaFin) " +
                           "VALUES (@ProyectoID, @Descripcion, @MontoEjecutado, @FechaInicio, @FechaFin)", connection);

                command.Parameters.AddWithValue("@ProyectoID", entity.ProyectoID);
                command.Parameters.AddWithValue("@Descripcion", entity.Descripcion ?? (object)DBNull.Value); 
                command.Parameters.AddWithValue("@MontoEjecutado", entity.MontoEjecutado);
                command.Parameters.AddWithValue("@FechaInicio", entity.FechaInicio);
                command.Parameters.AddWithValue("@FechaFin", entity.FechaFin);

                return Convert.ToInt32(await command.ExecuteScalarAsync());
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("Error al insertar el registro", ex);
        }
    }

    public async Task<int> UpdateAsync(Avaluo entity)
    {
        try
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                var command = new SqlCommand("UPDATE Avaluos SET ProyectoID = @ProyectoID, Descripcion = @Descripcion, MontoEjecutado = @MontoEjecutado, " +
                                             "FechaInicio = @FechaInicio, FechaFin = @FechaFin WHERE AvaluoID = @AvaluoID", connection);

                command.Parameters.Add(new SqlParameter("@AvaluoID", SqlDbType.Int) { Value = entity.AvaluoID });
                command.Parameters.Add(new SqlParameter("@ProyectoID", SqlDbType.Int) { Value = entity.ProyectoID });
                command.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.NVarChar, 255) { Value = entity.Descripcion ?? (object)DBNull.Value });
                command.Parameters.Add(new SqlParameter("@MontoEjecutado", SqlDbType.Decimal) { Value = entity.MontoEjecutado });
                command.Parameters.Add(new SqlParameter("@FechaInicio", SqlDbType.DateTime) { Value = entity.FechaInicio });
                command.Parameters.Add(new SqlParameter("@FechaFin", SqlDbType.DateTime) { Value = entity.FechaFin });

                int rowsAffected = await command.ExecuteNonQueryAsync();

                if (rowsAffected == 0)
                {
                    throw new Exception("No se encontró el registro a actualizar.");
                }

                return rowsAffected; 
            }
        }
        catch (SqlException ex)
        {
            throw new Exception($"Error al actualizar el registro Avaluo con ID {entity.AvaluoID}: {ex.Message}", ex);
        }
        catch (Exception ex)
        {
            throw new Exception("Ocurrió un error inesperado al actualizar el registro.", ex);
        }
    }


    public async Task<int> DeleteAsync(int id)
    {
        try
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var command = new SqlCommand("DELETE FROM Avaluos WHERE AvaluoID = @AvaluoID", connection);
                command.Parameters.AddWithValue("@AvaluoID", id);

                return await command.ExecuteNonQueryAsync();
            }
        }
        catch (SqlException ex)
        {
            throw new Exception("Error al eliminar el registro", ex);
        }
    }

}
