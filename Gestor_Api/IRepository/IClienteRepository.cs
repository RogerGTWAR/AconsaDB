using SharedModels;

namespace Gestor_Api.IRepository
{
    public interface IClienteRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(string id);
        Task<string> InsertAsync(T entity);
        Task<string> UpdateAsync(T entity);
        Task<string> DeleteAsync(string id);
    }
}
