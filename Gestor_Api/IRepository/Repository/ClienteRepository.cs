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
                            Direccion = reader.IsDBNull(4) ? null : reader.GetString(4),
                            Ciudad = reader.IsDBNull(5) ? null : reader.GetString(5),
                            Pais = reader.IsDBNull(6) ? null : reader.GetString(6),
                            Telefono = reader.IsDBNull(7) ? null : reader.GetString(7)
                        });
                    }
                }

            }

            return clientes;
        }

        public async Task<int> InsertAsync(Cliente entity)
        {

            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Clientes (ClienteID, NombreEmpresa, NombreContacto, CargoContacto, Direccion, Ciudad, Pais, Telefono) " +
                               "VALUES (@ClienteID, @NombreEmpresa, @NombreContacto, @CargoContacto, @Direccion, @Ciudad, @Pais, @Telefono)";


                await connection.OpenAsync();

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClienteID", entity.ClienteID);
                    command.Parameters.AddWithValue("@NombreEmpresa", entity.NombreEmpresa);
                    command.Parameters.AddWithValue("@NombreContacto", entity.NombreContacto ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@CargoContacto", entity.CargoContacto ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Direccion", entity.Direccion ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Ciudad", entity.Ciudad ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Pais", entity.Pais ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Telefono", entity.Telefono ?? (object)DBNull.Value);

                    return await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<int> UpdateAsync(Cliente entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Clientes SET NombreEmpresa = @NombreEmpresa, NombreContacto = @NombreContacto, " +
                               "CargoContacto = @CargoContacto, Direccion = @Direccion, Ciudad = @Ciudad, Pais = @Pais, " +
                               "Telefono = @Telefono WHERE ClienteID = @ClienteID";


                await connection.OpenAsync();

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClienteID", entity.ClienteID);
                    command.Parameters.AddWithValue("@NombreEmpresa", entity.NombreEmpresa);
                    command.Parameters.AddWithValue("@NombreContacto", entity.NombreContacto ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@CargoContacto", entity.CargoContacto ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Direccion", entity.Direccion ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Ciudad", entity.Ciudad ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Pais", entity.Pais ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Telefono", entity.Telefono ?? (object)DBNull.Value);

                    return await command.ExecuteNonQueryAsync();
                }

            }
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
                                Direccion = reader.IsDBNull(4) ? null : reader.GetString(4),
                                Ciudad = reader.IsDBNull(5) ? null : reader.GetString(5),
                                Pais = reader.IsDBNull(6) ? null : reader.GetString(6),
                                Telefono = reader.IsDBNull(7) ? null : reader.GetString(7)
                            };
                        }
                    }
                }

            }

            return cliente;
        }
    public async Task<int> DeleteAsync(string id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "DELETE FROM Clientes WHERE ClienteID = @ClienteID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ClienteID", id);

                return await command.ExecuteNonQueryAsync();
            }

        }
    }
}

