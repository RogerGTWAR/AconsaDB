using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.IRepository
{
    public interface IUserRepository
    {
        Task<string> AuthenticateUserAsync(string username, string password);
        Task<string> Register(string username, int empleadoID,
           string contraseña, DateTime fechacreacion, DateTime fechamodificacion);
    }
}
