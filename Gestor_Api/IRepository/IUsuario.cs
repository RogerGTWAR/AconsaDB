using SharedModels;

namespace Gestor_Api.Repository.IRepository
{
    public interface IUsuario
    {
        Task<Usuarioz> GetUserByUserNameAsync(string userName);
        Task<Usuarioz> GetUserByIdAsync(int id);
        Task<bool> ValidateUserAsync(string userName, string password);
        Task RegisterUserAsync(Usuarioz user, string password);
    }
}
