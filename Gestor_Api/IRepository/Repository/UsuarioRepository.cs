using Gestor_Api.Data;
using Gestor_Api.Repository.IRepository;
using Microsoft.Extensions.Configuration;
using SharedModels;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
//Falta

namespace Gestor_Api.IRepository.Repository
{
    public class UsuarioRepository : IUsuario
    {
        private readonly string _connectionString;
        private readonly IPasswordHasher<Usuario> _passwordHasher;

        public UsuarioRepository(IConfiguration configuration, IPasswordHasher<Usuario> passwordHasher)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            _passwordHasher = passwordHasher;
        }

        public async Task<Usuario> GetUserByIdAsync(int id)
        {
            Usuario user = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Users WHERE UsuarioID = @UsuarioID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UsuarioID", id);

                await connection.OpenAsync();
                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        user = new Usuario
                        {
                            UsuarioID = reader.GetInt32(reader.GetOrdinal("UsuarioID")),
                            EmpleadoID = reader.GetInt32(reader.GetOrdinal("EmpleadoID")),
                            UsuarioNombre = reader.IsDBNull(reader.GetOrdinal("UsuarioNombre")) ? null : reader.GetString(reader.GetOrdinal("UsuarioNombre")),
                            Contraseña = reader.IsDBNull(reader.GetOrdinal("Contraseña")) ? null : reader.GetString(reader.GetOrdinal("Contraseña")),
                            FechaCreacion = reader.GetDateTime(reader.GetOrdinal("FechaCreacion")),
                            FechaModificacion = reader.GetDateTime(reader.GetOrdinal("FechaModificacion"))
                        };
                    }
                }
            }

            return user;
        }

        public async Task<Usuario> GetUserByUserNameAsync(string username)
        {
            Usuario user = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Users WHERE UsuarioNombre = @UsuarioNombre";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UsuarioNombre", username);

                await connection.OpenAsync();
                using (SqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        user = new Usuario
                        {
                            UsuarioID = reader.GetInt32(reader.GetOrdinal("UsuarioID")),
                            EmpleadoID = reader.GetInt32(reader.GetOrdinal("EmpleadoID")),
                            UsuarioNombre = reader.IsDBNull(reader.GetOrdinal("UsuarioNombre")) ? null : reader.GetString(reader.GetOrdinal("UsuarioNombre")),
                            Contraseña = reader.IsDBNull(reader.GetOrdinal("Contraseña")) ? null : reader.GetString(reader.GetOrdinal("Contraseña")),
                            FechaCreacion = reader.GetDateTime(reader.GetOrdinal("FechaCreacion")),
                            FechaModificacion = reader.GetDateTime(reader.GetOrdinal("FechaModificacion"))
                        };
                    }
                }
            }

            return user;
        }

        public async Task RegisterUserAsync(Usuario user, string password)
        {
            string hashedPassword = _passwordHasher.HashPassword(user, password);

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Users (EmpleadoID, UsuarioNombre, Contraseña, FechaCreacion, FechaModificacion) " +
                               "VALUES (@EmpleadoID, @UsuarioNombre, @Contraseña, @FechaCreacion, @FechaModificacion)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EmpleadoID", user.EmpleadoID);
                command.Parameters.AddWithValue("@UsuarioNombre", user.UsuarioNombre ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@Contraseña", hashedPassword);
                command.Parameters.AddWithValue("@FechaCreacion", user.FechaCreacion);
                command.Parameters.AddWithValue("@FechaModificacion", user.FechaModificacion);

                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task<bool> ValidateUserAsync(string userName, string password)
        {
            var user = await GetUserByUserNameAsync(userName);
            if (user == null)
            {
                return false;
            }

            var verificationResult = _passwordHasher.VerifyHashedPassword(user, user.Contraseña, password);
            return verificationResult == PasswordVerificationResult.Success;
        }
        async Task<Usuario> IUsuario.GetUserByIdAsync(int id)
        {
            return await GetUserByIdAsync(id);
        }

        async Task<Usuario> IUsuario.GetUserByUserNameAsync(string userName)
        {
            return await GetUserByUserNameAsync(userName);
        }
    }
}
