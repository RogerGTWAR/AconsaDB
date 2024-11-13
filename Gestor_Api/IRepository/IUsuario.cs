using SharedModels;

namespace Gestor_Api.Repository.IRepository
{
    public interface IUsuario
    {
        Task<Usuario> GetUserByUserNameAsync(string userName);
        Task<Usuario> GetUserByIdAsync(int id);
        Task<bool> ValidateUserAsync(string userName, string password);
        Task RegisterUserAsync(Usuario user, string password);
    }
}
