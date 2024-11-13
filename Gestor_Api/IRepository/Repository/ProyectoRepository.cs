using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SharedModels;
public class ProyectoRepository : IRepository<Proyecto>
{
    private readonly string _connectionString;

    public ProyectoRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<IEnumerable<Proyecto>> GetAllAsync()
    {
        var proyectos = new List<Proyecto>();

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Proyectos";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        proyectos.Add(new Proyecto
                        {
                            ProyectoID = reader.GetInt32(0),
                            ClienteID = reader.IsDBNull(1) ? null : reader.GetString(1),
                            NombreProyecto = reader.IsDBNull(2) ? null : reader.GetString(2),
                            Descripcion = reader.IsDBNull(3) ? null : reader.GetString(3),
                            Ubicacion = reader.IsDBNull(4) ? null : reader.GetString(4),
                            FechaInicio = reader.GetDateTime(5),
                            FechaFin = reader.GetDateTime(6),
                            PresupuestoTotal = reader.GetDecimal(7),
                            Estado = reader.IsDBNull(8) ? null : reader.GetString(8),
                            TiempoTotalDias = reader.GetInt32(9)
                        });
                    }
                }
            }
        }

        return proyectos;
    }

    public async Task<Proyecto> GetByIdAsync(int id)
    {
        Proyecto proyecto = null;

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Proyectos WHERE ProyectoID = @ProyectoID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProyectoID", id);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        proyecto = new Proyecto
                        {
                            ProyectoID = reader.GetInt32(0),
                            ClienteID = reader.IsDBNull(1) ? null : reader.GetString(1),
                            NombreProyecto = reader.IsDBNull(2) ? null : reader.GetString(2),
                            Descripcion = reader.IsDBNull(3) ? null : reader.GetString(3),
                            Ubicacion = reader.IsDBNull(4) ? null : reader.GetString(4),
                            FechaInicio = reader.GetDateTime(5),
                            FechaFin = reader.GetDateTime(6),
                            PresupuestoTotal = reader.GetDecimal(7),
                            Estado = reader.IsDBNull(8) ? null : reader.GetString(8),
                            TiempoTotalDias = reader.GetInt32(9)
                        };
                    }
                }
            }
        }

        return proyecto;
    }

    public async Task<int> InsertAsync(Proyecto entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "INSERT INTO Proyectos (ClienteID, NombreProyecto, Descripcion, Ubicacion, FechaInicio, FechaFin, PresupuestoTotal, Estado, TiempoTotalDias) " +
                           "VALUES (@ClienteID, @NombreProyecto, @Descripcion, @Ubicacion, @FechaInicio, @FechaFin, @PresupuestoTotal, @Estado, @TiempoTotalDias)";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ClienteID", entity.ClienteID ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@NombreProyecto", entity.NombreProyecto ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Descripcion", entity.Descripcion ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Ubicacion", entity.Ubicacion ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@FechaInicio", entity.FechaInicio);
                command.Parameters.AddWithValue("@FechaFin", entity.FechaFin);
                command.Parameters.AddWithValue("@PresupuestoTotal", entity.PresupuestoTotal);
                command.Parameters.AddWithValue("@Estado", entity.Estado ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@TiempoTotalDias", entity.TiempoTotalDias);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task<int> UpdateAsync(Proyecto entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "UPDATE Proyectos SET ClienteID = @ClienteID, NombreProyecto = @NombreProyecto, Descripcion = @Descripcion, " +
                           "Ubicacion = @Ubicacion, FechaInicio = @FechaInicio, FechaFin = @FechaFin, PresupuestoTotal = @PresupuestoTotal, " +
                           "Estado = @Estado, TiempoTotalDias = @TiempoTotalDias WHERE ProyectoID = @ProyectoID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProyectoID", entity.ProyectoID);
                command.Parameters.AddWithValue("@ClienteID", entity.ClienteID ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@NombreProyecto", entity.NombreProyecto ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Descripcion", entity.Descripcion ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Ubicacion", entity.Ubicacion ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@FechaInicio", entity.FechaInicio);
                command.Parameters.AddWithValue("@FechaFin", entity.FechaFin);
                command.Parameters.AddWithValue("@PresupuestoTotal", entity.PresupuestoTotal);
                command.Parameters.AddWithValue("@Estado", entity.Estado ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@TiempoTotalDias", entity.TiempoTotalDias);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task<int> DeleteAsync(int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "DELETE FROM Proyectos WHERE ProyectoID = @ProyectoID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProyectoID", id);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }
}
