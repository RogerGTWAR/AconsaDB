using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SharedModels;
//Listo
public class MaquinariaRepository : IRepository<Maquinaria>
{
    private readonly string _connectionString;

    public MaquinariaRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<IEnumerable<Maquinaria>> GetAllAsync()
    {
        var maquinarias = new List<Maquinaria>();

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Maquinarias";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        maquinarias.Add(new Maquinaria
                        {
                            MaquinariaID = reader.GetInt32(0),
                            ProveedorID = reader.GetInt32(1),
                            NombreMaquinaria = reader.GetString(2),
                            Marca = reader.IsDBNull(3) ? null : reader.GetString(3),
                            Modelo = reader.IsDBNull(4) ? null : reader.GetString(4),
                            FechaInicioRenta = reader.GetDateTime(5),
                            FechaFinalizacionRenta = reader.GetDateTime(6),
                            PrecioPorHora = reader.GetDecimal(7),
                            Estado = reader.GetString(8)
                        });
                    }
                }
            }
        }

        return maquinarias;
    }

    public async Task<Maquinaria> GetByIdAsync(int id)
    {
        Maquinaria? maquinaria = null;

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Maquinarias WHERE MaquinariaID = @MaquinariaID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaquinariaID", id);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        maquinaria = new Maquinaria
                        {
                            MaquinariaID = reader.GetInt32(0),
                            ProveedorID = reader.GetInt32(1),
                            NombreMaquinaria = reader.GetString(2),
                            Marca = reader.GetString(3),
                            Modelo =reader.GetString(4),
                            FechaInicioRenta =  reader.GetDateTime(5),
                            FechaFinalizacionRenta =reader.GetDateTime(6),
                            PrecioPorHora = reader.GetDecimal(7),
                            Estado = reader.GetString(8)
                        };
                    }
                }
            }
        }

        return maquinaria;
    }

    public async Task<int> InsertAsync(Maquinaria entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "INSERT INTO Maquinarias (ProveedorID, NombreMaquinaria, Marca, Modelo, FechaInicioRenta, FechaFinalizacionRenta, PrecioPorHora, Estado) " +
                           "VALUES (@ProveedorID, @NombreMaquinaria, @Marca, @Modelo, @FechaInicioRenta, @FechaFinalizacionRenta, @PrecioPorHora, @Estado)";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProveedorID", entity.ProveedorID);
                command.Parameters.AddWithValue("@NombreMaquinaria", entity.NombreMaquinaria);
                command.Parameters.AddWithValue("@Marca", entity.Marca );
                command.Parameters.AddWithValue("@Modelo", entity.Modelo );
                command.Parameters.AddWithValue("@FechaInicioRenta", entity.FechaInicioRenta );
                command.Parameters.AddWithValue("@FechaFinalizacionRenta", entity.FechaFinalizacionRenta );
                command.Parameters.AddWithValue("@PrecioPorHora", entity.PrecioPorHora);
                command.Parameters.AddWithValue("@Estado", entity.Estado);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task<int> UpdateAsync(Maquinaria entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "UPDATE Maquinarias SET ProveedorID = @ProveedorID, NombreMaquinaria = @NombreMaquinaria, Marca = @Marca, " +
                           "Modelo = @Modelo, FechaInicioRenta = @FechaInicioRenta, FechaFinalizacionRenta = @FechaFinalizacionRenta, " +
                           "PrecioPorHora = @PrecioPorHora, Estado = @Estado WHERE MaquinariaID = @MaquinariaID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaquinariaID", entity.MaquinariaID);
                command.Parameters.AddWithValue("@ProveedorID", entity.ProveedorID);
                command.Parameters.AddWithValue("@NombreMaquinaria", entity.NombreMaquinaria);
                command.Parameters.AddWithValue("@Marca", entity.Marca );
                command.Parameters.AddWithValue("@Modelo", entity.Modelo);
                command.Parameters.AddWithValue("@FechaInicioRenta", entity.FechaInicioRenta);
                command.Parameters.AddWithValue("@FechaFinalizacionRenta", entity.FechaFinalizacionRenta );
                command.Parameters.AddWithValue("@PrecioPorHora", entity.PrecioPorHora);
                command.Parameters.AddWithValue("@Estado", entity.Estado);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task<int> DeleteAsync(int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "DELETE FROM Maquinarias WHERE MaquinariaID = @MaquinariaID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaquinariaID", id);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }
}

