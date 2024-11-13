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
    public class AvaluoDetalleRepository : IRepository<AvaluoDetalle>
    {
        private readonly string _connectionString;

        public AvaluoDetalleRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<IEnumerable<AvaluoDetalle>> GetAllAsync()
        {
            var detalles = new List<AvaluoDetalle>();

            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM [Avaluo Detalles]";

                await connection.OpenAsync();

                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            detalles.Add(new AvaluoDetalle
                            {
                                Avaluo_DetalleID = reader.GetInt32(0),
                                AvaluoID = reader.GetInt32(1),
                                ProductoID = reader.GetInt32(2),
                                Descripcion = reader.IsDBNull(3) ? null : reader.GetString(3),
                                Cantidad = reader.GetInt32(4),
                                PrecioUnitario = reader.GetDecimal(5)
                            });
                        }
                    }
                }
            }

            return detalles;
        }

        public async Task<AvaluoDetalle> GetByIdAsync(int id)
        {
            AvaluoDetalle detalle = null;

            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM [Avaluo Detalles] WHERE Avaluo_DetalleID = @Avaluo_DetalleID";

                await connection.OpenAsync();

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@Avaluo_DetalleID", SqlDbType.Int) { Value = id });

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            detalle = new AvaluoDetalle
                            {
                                Avaluo_DetalleID = reader.GetInt32(0),
                                AvaluoID = reader.GetInt32(1),
                                ProductoID = reader.GetInt32(2),
                                Descripcion = reader.IsDBNull(3) ? null : reader.GetString(3),
                                Cantidad = reader.GetInt32(4),
                                PrecioUnitario = reader.GetDecimal(5)
                            };
                        }
                    }
                }
            }

            return detalle;
        }

        public async Task<int> InsertAsync(AvaluoDetalle entity)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    string query = "INSERT INTO [Avaluo Detalles] (AvaluoID, ProductoID, Descripcion, Cantidad, PrecioUnitario) " +
                                   "VALUES (@AvaluoID, @ProductoID, @Descripcion, @Cantidad, @PrecioUnitario)";

                    await connection.OpenAsync();

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@AvaluoID", SqlDbType.Int) { Value = entity.AvaluoID });
                        command.Parameters.Add(new SqlParameter("@ProductoID", SqlDbType.Int) { Value = entity.ProductoID });
                        command.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.NVarChar, 255) { Value = entity.Descripcion ?? (object)DBNull.Value });
                        command.Parameters.Add(new SqlParameter("@Cantidad", SqlDbType.Int) { Value = entity.Cantidad });
                        command.Parameters.Add(new SqlParameter("@PrecioUnitario", SqlDbType.Decimal) { Value = entity.PrecioUnitario });

                        return await command.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al insertar el detalle de avalúo.", ex);
            }
        }

        public async Task<int> UpdateAsync(AvaluoDetalle entity)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    string query = "UPDATE [Avaluo Detalles] SET AvaluoID = @AvaluoID, ProductoID = @ProductoID, " +
                                   "Descripcion = @Descripcion, Cantidad = @Cantidad, PrecioUnitario = @PrecioUnitario " +
                                   "WHERE Avaluo_DetalleID = @Avaluo_DetalleID";

                    await connection.OpenAsync();

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Avaluo_DetalleID", SqlDbType.Int) { Value = entity.Avaluo_DetalleID });
                        command.Parameters.Add(new SqlParameter("@AvaluoID", SqlDbType.Int) { Value = entity.AvaluoID });
                        command.Parameters.Add(new SqlParameter("@ProductoID", SqlDbType.Int) { Value = entity.ProductoID });
                        command.Parameters.Add(new SqlParameter("@Descripcion", SqlDbType.NVarChar, 255) { Value = entity.Descripcion ?? (object)DBNull.Value });
                        command.Parameters.Add(new SqlParameter("@Cantidad", SqlDbType.Int) { Value = entity.Cantidad });
                        command.Parameters.Add(new SqlParameter("@PrecioUnitario", SqlDbType.Decimal) { Value = entity.PrecioUnitario });

                        return await command.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception($"Error al actualizar el detalle de avalúo con ID {entity.Avaluo_DetalleID}: {ex.Message}", ex);
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    string query = "DELETE FROM [Avaluo Detalles] WHERE Avaluo_DetalleID = @Avaluo_DetalleID";

                    await connection.OpenAsync();

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Avaluo_DetalleID", SqlDbType.Int) { Value = id });

                        return await command.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error al eliminar el detalle de avalúo.", ex);
            }
        }
    }
}
