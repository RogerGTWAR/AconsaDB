using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SharedModels;
//Listo
public class ProveedorRepository : IRepository<Proveedor>
{
    private readonly string _connectionString;

    public ProveedorRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<IEnumerable<Proveedor>> GetAllAsync()
    {
        var proveedores = new List<Proveedor>();

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Proveedores";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        proveedores.Add(new Proveedor
                        {
                            ProveedorID = reader.GetInt32(0),
                            NombreEmpresa = reader.GetString(1),
                            NombreContacto = reader.GetString(2),
                            CargoContacto = reader.GetString(3),
                            Direccion = reader.GetString(4),
                            Ciudad =  reader.GetString(5),
                            Pais = reader.GetString(6),
                            Telefono =   reader.GetString(7),
                            Correo = reader.GetString(8)
                        });
                    }
                }
            }
        }

        return proveedores;
    }

    public async Task<Proveedor> GetByIdAsync(int id)
    {
        Proveedor? proveedor = null;

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Proveedores WHERE ProveedorID = @ProveedorID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProveedorID", id);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        proveedor = new Proveedor
                        {
                            ProveedorID = reader.GetInt32(0),
                            NombreEmpresa =     reader.GetString(1),
                            NombreContacto = reader.GetString(2),
                            CargoContacto = reader.GetString(3),
                            Direccion = reader.GetString(4),
                            Ciudad = reader.GetString(5),
                            Pais =      reader.GetString(6),
                            Telefono = reader.GetString(7),
                            Correo = reader.GetString(8)
                        };
                    }
                }
            }
        }

        return proveedor;
    }

    public async Task<int> InsertAsync(Proveedor entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "INSERT INTO Proveedores (NombreEmpresa, NombreContacto, CargoContacto, Direccion, Ciudad, Pais, Telefono, Correo) " +
                           "VALUES (@NombreEmpresa, @NombreContacto, @CargoContacto, @Direccion, @Ciudad, @Pais, @Telefono, @Correo)";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@NombreEmpresa", entity.NombreEmpresa);
                command.Parameters.AddWithValue("@NombreContacto", entity.NombreContacto    );
                command.Parameters.AddWithValue("@CargoContacto", entity.CargoContacto);
                command.Parameters.AddWithValue("@Direccion", entity.Direccion);
                command.Parameters.AddWithValue("@Ciudad", entity.Ciudad);
                command.Parameters.AddWithValue("@Pais", entity.Pais);
                command.Parameters.AddWithValue("@Telefono", entity.Telefono);
                command.Parameters.AddWithValue("@Correo", entity.Correo);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task<int> UpdateAsync(Proveedor entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "UPDATE Proveedores SET NombreEmpresa = @NombreEmpresa, NombreContacto = @NombreContacto, CargoContacto = @CargoContacto, " +
                           "Direccion = @Direccion, Ciudad = @Ciudad, Pais = @Pais, Telefono = @Telefono, Correo = @Correo " +
                           "WHERE ProveedorID = @ProveedorID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProveedorID", entity.ProveedorID);
                command.Parameters.AddWithValue("@NombreEmpresa", entity.NombreEmpresa  );
                command.Parameters.AddWithValue("@NombreContacto", entity.NombreContacto );
                command.Parameters.AddWithValue("@CargoContacto", entity.CargoContacto);
                command.Parameters.AddWithValue("@Direccion", entity.Direccion  );
                command.Parameters.AddWithValue("@Ciudad", entity.Ciudad);
                command.Parameters.AddWithValue("@Pais", entity.Pais);
                command.Parameters.AddWithValue("@Telefono", entity.Telefono);
                command.Parameters.AddWithValue("@Correo", entity.Correo);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task<int> DeleteAsync(int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "DELETE FROM Proveedores WHERE ProveedorID = @ProveedorID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProveedorID", id);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }
}
