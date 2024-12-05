using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Gestor_Api.IRepository;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using SharedModels;
//Listo
public class ClienteRepository : IClienteRepository<Cliente>
{
    private readonly string _connectionString;

    public ClienteRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<IEnumerable<Cliente>> GetAllAsync()
    {
        var clientes = new List<Cliente>();

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Clientes";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            using (var reader = await command.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {
                    clientes.Add(new Cliente
                    {
                        ClienteID = reader.GetString(0),
                        NombreEmpresa = reader.GetString(1),
                        NombreContacto = reader.IsDBNull(2) ? null : reader.GetString(2),
                        CargoContacto = reader.IsDBNull(3) ? null : reader.GetString(3),
                        Dirección = reader.IsDBNull(4) ? null : reader.GetString(4),
                        Ciudad = reader.IsDBNull(5) ? null : reader.GetString(5),
                        País = reader.IsDBNull(6) ? null : reader.GetString(6),
                        Teléfono = reader.IsDBNull(7) ? null : reader.GetString(7)
                    });
                }
            }

        }

        return clientes;
    }

    public async Task<Cliente> GetByIdAsync(string id)
    {
        Cliente? cliente = null;

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Clientes WHERE ClienteID = @ClienteID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ClienteID", id);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        cliente = new Cliente
                        {
                            ClienteID = reader.GetString(0),
                            NombreEmpresa = reader.GetString(1),
                            NombreContacto = reader.IsDBNull(2) ? null : reader.GetString(2),
                            CargoContacto = reader.IsDBNull(3) ? null : reader.GetString(3),
                            Dirección = reader.IsDBNull(4) ? null : reader.GetString(4),
                            Ciudad = reader.IsDBNull(5) ? null : reader.GetString(5),
                            País = reader.IsDBNull(6) ? null : reader.GetString(6),
                            Teléfono = reader.IsDBNull(7) ? null : reader.GetString(7)
                        };
                    }
                }
            }

        }

        return cliente;
    }
    public async Task<string> UpdateAsync(Cliente entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "UPDATE Clientes SET NombreEmpresa = @NombreEmpresa, NombreContacto = @NombreContacto, " +
                           "CargoContacto = @CargoContacto, Dirección = @Dirección, Ciudad = @Ciudad, País = @País, " +
                           "Teléfono = @Teléfono WHERE ClienteID = @ClienteID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ClienteID", entity.ClienteID);
                command.Parameters.AddWithValue("@NombreEmpresa", entity.NombreEmpresa);
                command.Parameters.AddWithValue("@NombreContacto", entity.NombreContacto ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@CargoContacto", entity.CargoContacto ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Dirección", entity.Dirección ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Ciudad", entity.Ciudad ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@País", entity.País ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Teléfono", entity.Teléfono ?? (object)DBNull.Value);

                int result = await command.ExecuteNonQueryAsync();
                return result > 0 ? "Cliente Actualizado Exitosamente" : "Error al actualizar Cliente";
            }
        }
    }
    public async Task<string> InsertAsync(Cliente entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "INSERT INTO Clientes (ClienteID, NombreEmpresa, NombreContacto, CargoContacto, Dirección, Ciudad, País , Teléfono) " +
                           "VALUES (@ClienteID, @NombreEmpresa, @NombreContacto, @CargoContacto, @Dirección, @Ciudad, @País, @Teléfono)";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ClienteID", entity.ClienteID);
                command.Parameters.AddWithValue("@NombreEmpresa", entity.NombreEmpresa);
                command.Parameters.AddWithValue("@NombreContacto", entity.NombreContacto ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@CargoContacto", entity.CargoContacto ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Dirección", entity.Dirección ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Ciudad", entity.Ciudad ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@País", entity.País ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Teléfono", entity.Teléfono ?? (object)DBNull.Value);

                int result = await command.ExecuteNonQueryAsync();
                return result > 0 ? "Cliente Insertado Exitosamente" : "Error al insertar Cliente";
            }
        }
    }
    public async Task<string> DeleteAsync(string id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "DELETE FROM Clientes WHERE ClienteID = @ClienteID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ClienteID", id);

                int result = await command.ExecuteNonQueryAsync();
                return result > 0 ? "Cliente Eliminado Exitosamente" : "Error al eliminar Cliente";
            }
        }
    }

}