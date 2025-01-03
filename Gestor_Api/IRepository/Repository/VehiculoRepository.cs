﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SharedModels;
//Listo
public class VehiculoRepository : IRepository<Vehiculo>
{
    private readonly string _connectionString;

    public VehiculoRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<IEnumerable<Vehiculo>> GetAllAsync()
    {
        var vehiculos = new List<Vehiculo>();

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Vehiculos";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        vehiculos.Add(new Vehiculo
                        {
                            VehiculoID = reader.GetInt32(0),
                            ProveedorID = reader.GetInt32(1),
                            Marca = reader.GetString(2),
                            Modelo = reader.GetString(3),
                            Año = reader.GetInt32(4),
                            Placa = reader.GetString(5),
                            TipoDeVehiculo = reader.GetString(6),
                            TipoDeCombustible = reader.GetString(7),
                            Estado = reader.GetString(8),
                            FechaRegistro = reader.GetDateTime(9)
                        });
                    }
                }
            }
        }

        return vehiculos;
    }

    public async Task<Vehiculo> GetByIdAsync(int id)
    {
        Vehiculo? vehiculo = null;

        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Vehiculos WHERE VehiculoID = @VehiculoID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@VehiculoID", id);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        vehiculo = new Vehiculo
                        {
                            VehiculoID = reader.GetInt32(0),
                            ProveedorID = reader.GetInt32(1),
                            Marca = reader.GetString(2),
                            Modelo = reader.GetString(3),
                            Año = reader.GetInt32(4),
                            Placa = reader.GetString(5),
                            TipoDeVehiculo = reader.GetString(6),
                            TipoDeCombustible = reader.GetString(7),
                            Estado = reader.GetString(8),
                            FechaRegistro = reader.GetDateTime(9)
                        };
                    }
                }
            }
        }

        return vehiculo;
    }

    public async Task<int> InsertAsync(Vehiculo entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "INSERT INTO Vehiculos (ProveedorID, Marca, Modelo, Año, Placa, TipoDeVehiculo, TipoDeCombustible, Estado, FechaRegistro) " +
                           "VALUES (@ProveedorID, @Marca, @Modelo, @Año, @Placa, @TipoDeVehiculo, @TipoDeCombustible, @Estado, @FechaRegistro)";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProveedorID", entity.ProveedorID);
                command.Parameters.AddWithValue("@Marca", entity.Marca);
                command.Parameters.AddWithValue("@Modelo", entity.Modelo);
                command.Parameters.AddWithValue("@Año", entity.Año);
                command.Parameters.AddWithValue("@Placa", entity.Placa);
                command.Parameters.AddWithValue("@TipoDeVehiculo", entity.TipoDeVehiculo  );
                command.Parameters.AddWithValue("@TipoDeCombustible", entity.TipoDeCombustible  );
                command.Parameters.AddWithValue("@Estado", entity.Estado);
                command.Parameters.AddWithValue("@FechaRegistro", entity.FechaRegistro);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task<int> UpdateAsync(Vehiculo entity)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "UPDATE Vehiculos SET ProveedorID = @ProveedorID, Marca = @Marca, Modelo = @Modelo, Año = @Año, " +
                           "Placa = @Placa, TipoDeVehiculo = @TipoDeVehiculo, TipoDeCombustible = @TipoDeCombustible, " +
                           "Estado = @Estado, FechaRegistro = @FechaRegistro WHERE VehiculoID = @VehiculoID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@VehiculoID", entity.VehiculoID);
                command.Parameters.AddWithValue("@ProveedorID", entity.ProveedorID);
                command.Parameters.AddWithValue("@Marca", entity.Marca);
                command.Parameters.AddWithValue("@Modelo", entity.Modelo);
                command.Parameters.AddWithValue("@Año", entity.Año);
                command.Parameters.AddWithValue("@Placa", entity.Placa);
                command.Parameters.AddWithValue("@TipoDeVehiculo", entity.TipoDeVehiculo);
                command.Parameters.AddWithValue("@TipoDeCombustible", entity.TipoDeCombustible);
                command.Parameters.AddWithValue("@Estado", entity.Estado);
                command.Parameters.AddWithValue("@FechaRegistro", entity.FechaRegistro);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }

    public async Task<int> DeleteAsync(int id)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string query = "DELETE FROM Vehiculos WHERE VehiculoID = @VehiculoID";

            await connection.OpenAsync();

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@VehiculoID", id);

                return await command.ExecuteNonQueryAsync();
            }
        }
    }
}
