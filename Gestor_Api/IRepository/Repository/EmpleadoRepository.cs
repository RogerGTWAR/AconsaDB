using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SharedModels;

public class EmpleadoRepository : IRepository<Empleado>
{
    private readonly string _connectionString;

    public EmpleadoRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<IEnumerable<Empleado>> GetAllAsync()
    {
        var empleados = new List<Empleado>();

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Empleados"; 

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        empleados.Add(new Empleado
                        {
                            EmpleadoID = reader.GetInt32(0),
                            Nombres = reader.IsDBNull(1) ? null : reader.GetString(1),
                            Apellidos = reader.IsDBNull(2) ? null : reader.GetString(2),
                            Cedula = reader.IsDBNull(3) ? null : reader.GetString(3),
                            Cargo = reader.IsDBNull(4) ? null : reader.GetString(4),
                            FechaNacimiento = reader.GetDateTime(5),
                            FechaContratacion = reader.GetDateTime(6),
                            Direccion = reader.IsDBNull(7) ? null : reader.GetString(7),
                            Pais = reader.IsDBNull(8) ? null : reader.GetString(8),
                            Telefono = reader.IsDBNull(9) ? null : reader.GetString(9),
                            Correo = reader.IsDBNull(10) ? null : reader.GetString(10),
                            Reportes = reader.IsDBNull(11) ? (int?)null : reader.GetInt32(11)
                        });
                    }
                }
            }
        }

        return empleados;
    }

    public async Task<Empleado> GetByIdAsync(int id)
    {
        Empleado empleado = null;

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Empleados WHERE EmpleadoID = @EmpleadoID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@EmpleadoID", id);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        empleado = new Empleado
                        {
                            EmpleadoID = reader.GetInt32(0),
                            Nombres = reader.IsDBNull(1) ? null : reader.GetString(1),
                            Apellidos = reader.IsDBNull(2) ? null : reader.GetString(2),
                            Cedula = reader.IsDBNull(3) ? null : reader.GetString(3),
                            Cargo = reader.IsDBNull(4) ? null : reader.GetString(4),
                            FechaNacimiento = reader.GetDateTime(5),
                            FechaContratacion = reader.GetDateTime(6),
                            Direccion = reader.IsDBNull(7) ? null : reader.GetString(7),
                            Pais = reader.IsDBNull(8) ? null : reader.GetString(8),
                            Telefono = reader.IsDBNull(9) ? null : reader.GetString(9),
                            Correo = reader.IsDBNull(10) ? null : reader.GetString(10),
                            Reportes = reader.IsDBNull(11) ? (int?)null : reader.GetInt32(11)
                        };
                    }
                }
            }
        }

        return empleado;
    }

    public async Task<int> InsertAsync(Empleado entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "INSERT INTO Empleados (Nombres, Apellidos, Cedula, Cargo, FechaNacimiento, FechaContratacion, Direccion, Pais, Telefono, Correo, Reportes) " +
                           "VALUES (@Nombres, @Apellidos, @Cedula, @Cargo, @FechaNacimiento, @FechaContratacion, @Direccion, @Pais, @Telefono, @Correo, @Reportes)";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nombres", entity.Nombres ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Apellidos", entity.Apellidos ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Cedula", entity.Cedula ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Cargo", entity.Cargo ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@FechaNacimiento", entity.FechaNacimiento);
                command.Parameters.AddWithValue("@FechaContratacion", entity.FechaContratacion);
                command.Parameters.AddWithValue("@Direccion", entity.Direccion ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Pais", entity.Pais ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Telefono", entity.Telefono ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Correo", entity.Correo ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Reportes", entity.Reportes ?? (object)DBNull.Value);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task<int> UpdateAsync(Empleado entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "UPDATE Empleados SET Nombres = @Nombres, Apellidos = @Apellidos, Cedula = @Cedula, Cargo = @Cargo, " +
                           "FechaNacimiento = @FechaNacimiento, FechaContratacion = @FechaContratacion, Direccion = @Direccion, Pais = @Pais, " +
                           "Telefono = @Telefono, Correo = @Correo, Reportes = @Reportes WHERE EmpleadoID = @EmpleadoID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@EmpleadoID", entity.EmpleadoID);
                command.Parameters.AddWithValue("@Nombres", entity.Nombres ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Apellidos", entity.Apellidos ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Cedula", entity.Cedula ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Cargo", entity.Cargo ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@FechaNacimiento", entity.FechaNacimiento);
                command.Parameters.AddWithValue("@FechaContratacion", entity.FechaContratacion);
                command.Parameters.AddWithValue("@Direccion", entity.Direccion ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Pais", entity.Pais ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Telefono", entity.Telefono ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Correo", entity.Correo ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Reportes", entity.Reportes ?? (object)DBNull.Value);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task<int> DeleteAsync(int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "DELETE FROM Empleados WHERE EmpleadoID = @EmpleadoID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@EmpleadoID", id);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }
}
