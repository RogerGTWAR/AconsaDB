using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SharedModels;

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
                            AvaluoDetalleID = reader.GetInt32(0),
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
            string query = "SELECT * FROM [Avaluo Detalles] WHERE AvaluoDetalleID = @AvaluoDetalleID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@AvaluoDetalleID", id);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        detalle = new AvaluoDetalle
                        {
                            AvaluoDetalleID = reader.GetInt32(0),
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
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "INSERT INTO [Avaluo Detalles] (AvaluoID, ProductoID, Descripcion, Cantidad, PrecioUnitario) " +
                           "VALUES (@AvaluoID, @ProductoID, @Descripcion, @Cantidad, @PrecioUnitario)";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@AvaluoID", entity.AvaluoID);
                command.Parameters.AddWithValue("@ProductoID", entity.ProductoID);
                command.Parameters.AddWithValue("@Descripcion", entity.Descripcion ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Cantidad", entity.Cantidad);
                command.Parameters.AddWithValue("@PrecioUnitario", entity.PrecioUnitario);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task<int> UpdateAsync(AvaluoDetalle entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "UPDATE [Avaluo Detalles] SET AvaluoID = @AvaluoID, ProductoID = @ProductoID, " +
                           "Descripcion = @Descripcion, Cantidad = @Cantidad, PrecioUnitario = @PrecioUnitario " +
                           "WHERE AvaluoDetalleID = @AvaluoDetalleID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@AvaluoDetalleID", entity.AvaluoDetalleID);
                command.Parameters.AddWithValue("@AvaluoID", entity.AvaluoID);
                command.Parameters.AddWithValue("@ProductoID", entity.ProductoID);
                command.Parameters.AddWithValue("@Descripcion", entity.Descripcion ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Cantidad", entity.Cantidad);
                command.Parameters.AddWithValue("@PrecioUnitario", entity.PrecioUnitario);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task<int> DeleteAsync(int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "DELETE FROM [Avaluo Detalles] WHERE AvaluoDetalleID = @AvaluoDetalleID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@AvaluoDetalleID", id);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }
}
