using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SharedModels;
//Listo
namespace Gestor_Api.Repositories
{
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
                string query = "SELECT ProyectoID, ClienteID, NombreProyecto, Descripcion, Ubicacion, FechaInicio, FechaFin, PresupuestoTotal, Estado, TiempoTotalDias FROM Proyectos";

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
                                ClienteID = reader.GetString(1),
                                NombreProyecto = reader.GetString(2),
                                Descripcion = reader.GetString(3),
                                Ubicacion = reader.GetString(4),
                                FechaInicio = reader.GetDateTime(5),
                                FechaFin = reader.GetDateTime(6),
                                PresupuestoTotal = reader.GetDecimal(7),
                                Estado = reader.GetString(8),
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
                string query = "SELECT ProyectoID, ClienteID, NombreProyecto, Descripcion, Ubicacion, FechaInicio, FechaFin, PresupuestoTotal, Estado, TiempoTotalDias FROM Proyectos WHERE ProyectoID = @ProyectoID";

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
                                ClienteID = reader.GetString(1),
                                NombreProyecto = reader.GetString(2),
                                Descripcion = reader.GetString(3),
                                Ubicacion = reader.GetString(4),
                                FechaInicio = reader.GetDateTime(5),
                                FechaFin =   reader.GetDateTime(6),
                                PresupuestoTotal = reader.GetDecimal(7),
                                Estado = reader.GetString(8),
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
                string query = "INSERT INTO Proyectos (ClienteID, NombreProyecto, Descripcion, Ubicacion, FechaInicio, FechaFin, PresupuestoTotal, Estado) " +
                               "VALUES (@ClienteID, @NombreProyecto, @Descripcion, @Ubicacion, @FechaInicio, @FechaFin, @PresupuestoTotal, @Estado)";

                await connection.OpenAsync();

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClienteID", entity.ClienteID);
                    command.Parameters.AddWithValue("@NombreProyecto", entity.NombreProyecto);
                    command.Parameters.AddWithValue("@Descripcion", entity.Descripcion);
                    command.Parameters.AddWithValue("@Ubicacion", entity.Ubicacion  );
                    command.Parameters.AddWithValue("@FechaInicio", entity.FechaInicio);
                    command.Parameters.AddWithValue("@FechaFin", entity.FechaFin);
                    command.Parameters.AddWithValue("@PresupuestoTotal", entity.PresupuestoTotal);
                    command.Parameters.AddWithValue("@Estado", entity.Estado);

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
                               "Estado = @Estado WHERE ProyectoID = @ProyectoID";

                await connection.OpenAsync();

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProyectoID", entity.ProyectoID);
                    command.Parameters.AddWithValue("@ClienteID", entity.ClienteID);
                    command.Parameters.AddWithValue("@NombreProyecto", entity.NombreProyecto);
                    command.Parameters.AddWithValue("@Descripcion", entity.Descripcion);
                    command.Parameters.AddWithValue("@Ubicacion", entity.Ubicacion);
                    command.Parameters.AddWithValue("@FechaInicio", entity.FechaInicio);
                    command.Parameters.AddWithValue("@FechaFin", entity.FechaFin );
                    command.Parameters.AddWithValue("@PresupuestoTotal", entity.PresupuestoTotal);
                    command.Parameters.AddWithValue("@Estado", entity.Estado);

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
}
