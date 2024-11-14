using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SharedModels;
//Listo
namespace Gestor_Api.Data
{
    public class EmpleadoDetalleRepository : IRepository<EmpleadoDetalle>
    {
        private readonly string _connectionString;

        public EmpleadoDetalleRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<IEnumerable<EmpleadoDetalle>> GetAllAsync()
        {
            var detalles = new List<EmpleadoDetalle>();

            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM [Empleados Detalles]";

                await connection.OpenAsync();

                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            detalles.Add(new EmpleadoDetalle
                            {
                                Empleado_DetalleID = reader.GetInt32(0),
                                EmpleadoID = reader.GetInt32(1),
                                ProyectoID = reader.GetInt32(2),
                                FechaDeProyecto = reader.GetDateTime(3)
                            });
                        }
                    }
                }
            }

            return detalles;
        }

        public async Task<EmpleadoDetalle> GetByIdAsync(int id)
        {
            EmpleadoDetalle detalle = null;

            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM [Empleados Detalles] WHERE Empleado_DetalleID = @Empleado_DetalleID";

                await connection.OpenAsync();

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@Empleado_DetalleID", SqlDbType.Int) { Value = id });

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            detalle = new EmpleadoDetalle
                            {
                                Empleado_DetalleID = reader.GetInt32(0),
                                EmpleadoID = reader.GetInt32(1),
                                ProyectoID = reader.GetInt32(2),
                                FechaDeProyecto = reader.GetDateTime(3)
                            };
                        }
                    }
                }
            }

            return detalle;
        }

        public async Task<int> InsertAsync(EmpleadoDetalle entity)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    string query = "INSERT INTO [Empleados Detalles] (EmpleadoID, ProyectoID, FechaDeProyecto) " +
                                   "VALUES (@EmpleadoID, @ProyectoID, @FechaDeProyecto)";

                    await connection.OpenAsync();

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@EmpleadoID", SqlDbType.Int) { Value = entity.EmpleadoID });
                        command.Parameters.Add(new SqlParameter("@ProyectoID", SqlDbType.Int) { Value = entity.ProyectoID });
                        command.Parameters.Add(new SqlParameter("@FechaDeProyecto", SqlDbType.DateTime) { Value = entity.FechaDeProyecto });

                        return await command.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al insertar el detalle de empleado.", ex);
            }
        }

        public async Task<int> UpdateAsync(EmpleadoDetalle entity)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    string query = "UPDATE [Empleados Detalles] SET EmpleadoID = @EmpleadoID, ProyectoID = @ProyectoID, " +
                                   "FechaDeProyecto = @FechaDeProyecto " +
                                   "WHERE Empleado_DetalleID = @Empleado_DetalleID";

                    await connection.OpenAsync();

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Empleado_DetalleID", SqlDbType.Int) { Value = entity.Empleado_DetalleID });
                        command.Parameters.Add(new SqlParameter("@EmpleadoID", SqlDbType.Int) { Value = entity.EmpleadoID });
                        command.Parameters.Add(new SqlParameter("@ProyectoID", SqlDbType.Int) { Value = entity.ProyectoID });
                        command.Parameters.Add(new SqlParameter("@FechaDeProyecto", SqlDbType.DateTime) { Value = entity.FechaDeProyecto });

                        return await command.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al actualizar el detalle de empleado con ID {entity.Empleado_DetalleID}: {ex.Message}", ex);
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    string query = "DELETE FROM [Empleados Detalles] WHERE Empleado_DetalleID = @Empleado_DetalleID";

                    await connection.OpenAsync();

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Empleado_DetalleID", SqlDbType.Int) { Value = id });

                        return await command.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al eliminar el detalle de empleado.", ex);
            }
        }
    }
}
