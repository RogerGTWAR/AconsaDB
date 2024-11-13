using Microsoft.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Gestor_Api.Data
{
    public class Context : IDisposable
    {
        private readonly string _connectionString;
        private SqlConnection _connection;
        private string? connectionString;

        public Context(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public Context(string? connectionString)
        {
            this.connectionString = connectionString;
        }

        public async Task<DataTable> ExecuteQueryAsync(string query)
        {
            using (_connection = new SqlConnection(_connectionString))
            {
                await _connection.OpenAsync();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, _connection);
                DataTable dataTable = new DataTable();
                await Task.Run(() => dataAdapter.Fill(dataTable)); 
                return dataTable;
            }
        }

        public async Task<int> ExecuteNonQueryAsync(string query)
        {
            using (_connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, _connection);
                await _connection.OpenAsync();
                return await command.ExecuteNonQueryAsync();
            }
        }

        public void Dispose()
        {
            _connection?.Dispose();
        }
    
    }
}
