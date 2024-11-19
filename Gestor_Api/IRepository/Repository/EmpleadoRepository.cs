using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SharedModels;
//Listo
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
                            Nombres = reader.GetString(1),
                            Apellidos = reader.GetString(2),
                            Cedula = reader.GetString(3),
                            RolID = reader.GetInt32(4),
                            FechaNacimiento = reader.GetDateTime(5),
                            FechaContratacion = reader.GetDateTime(6),
                            Direccion = reader.GetString(7),
                            Pais = reader.GetString(8),
                            Telefono = reader.GetString(9),
                            Correo = reader.GetString(10),
                            Reportes = reader.IsDBNull(11) ? null : reader.GetInt32(11)
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
                            Nombres = reader.GetString(1),
                            Apellidos = reader.GetString(2),
                            Cedula = reader.GetString(3),
                            RolID = reader.GetInt32(4),
                            FechaNacimiento = reader.GetDateTime(5),
                            FechaContratacion = reader.GetDateTime(6),
                            Direccion = reader.GetString(7),
                            Pais = reader.GetString(8),
                            Telefono = reader.GetString(9),
                            Correo = reader.GetString(10),
                            Reportes = reader.IsDBNull(11) ? null : reader.GetInt32(11)
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
            string query = "INSERT INTO Empleados (Nombres, Apellidos, Cedula, RolID, FechaNacimiento, FechaContratacion, Direccion, Pais, Telefono, Correo, Reportes) " +
                           "VALUES (@Nombres, @Apellidos, @Cedula, @RolID, @FechaNacimiento, @FechaContratacion, @Direccion, @Pais, @Telefono, @Correo, @Reportes)";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nombres", entity.Nombres );
                command.Parameters.AddWithValue("@Apellidos", entity.Apellidos);
                command.Parameters.AddWithValue("@Cedula", entity.Cedula);
                command.Parameters.AddWithValue("@RolID", entity.RolID);
                command.Parameters.AddWithValue("@FechaNacimiento", entity.FechaNacimiento);
                command.Parameters.AddWithValue("@FechaContratacion", entity.FechaContratacion);
                command.Parameters.AddWithValue("@Direccion", entity.Direccion);
                command.Parameters.AddWithValue("@Pais", entity.Pais);
                command.Parameters.AddWithValue("@Telefono", entity.Telefono    );
                command.Parameters.AddWithValue("@Correo", entity.Correo);
                command.Parameters.AddWithValue("@Reportes", entity.Reportes ?? (object)DBNull.Value);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task<int> UpdateAsync(Empleado entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "UPDATE Empleados SET Nombres = @Nombres, Apellidos = @Apellidos, Cedula = @Cedula, RolID = @RolID, " +
                           "FechaNacimiento = @FechaNacimiento, FechaContratacion = @FechaContratacion, Direccion = @Direccion, Pais = @Pais, " +
                           "Telefono = @Telefono, Correo = @Correo, Reportes = @Reportes WHERE EmpleadoID = @EmpleadoID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@EmpleadoID", entity.EmpleadoID);
                command.Parameters.AddWithValue("@Nombres", entity.Nombres );
                command.Parameters.AddWithValue("@Apellidos", entity.Apellidos);
                command.Parameters.AddWithValue("@Cedula", entity.Cedula);
                command.Parameters.AddWithValue("@RolID", entity.RolID);
                command.Parameters.AddWithValue("@FechaNacimiento", entity.FechaNacimiento);
                command.Parameters.AddWithValue("@FechaContratacion", entity.FechaContratacion);
                command.Parameters.AddWithValue("@Direccion", entity.Direccion);
                command.Parameters.AddWithValue("@Pais", entity.Pais);
                command.Parameters.AddWithValue("@Telefono", entity.Telefono);
                command.Parameters.AddWithValue("@Correo", entity.Correo);
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
