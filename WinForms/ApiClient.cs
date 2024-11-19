using Microsoft.Data.SqlClient;
using SharedModels;
using SharedModels.Dto.Cliente;
using SharedModels.Dto.Empleado;
using SharedModels.Dto.Proveedor;
using SharedModels.Dto.Proyecto;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WinForms.IRepository;

namespace WinForms
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;
        public IRepository<EmpleadoDto> Empleados { get; set; }
        public IRepository<ClienteDto> Clientes { get; set; }
        public IRepository<ProveedorDto> Proveedores { get; set; }
        public IRepository<ProyectoDto> Proyectos { get; set; }
        public IUserRepository LoginUsers { get; }
        public IUserRepository RegisterUsuarios { get; }

        public ApiClient()
        {
            string apiBaseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
            _httpClient = new HttpClient { BaseAddress = new Uri(apiBaseUrl) };    
            //Nota lo que esta entre "" tiene que llamarse igual que la clase de shared models o la api
            Empleados = new Repository<EmpleadoDto>(_httpClient, "Empleado");
            Clientes = new Repository<ClienteDto>(_httpClient, "Cliente");
            Proveedores = new Repository<ProveedorDto>(_httpClient, "Proveedor");
            Proyectos = new Repository<ProyectoDto>(_httpClient, "Proyecto");
            LoginUsers = new UserRepository(_httpClient, "Auth/Login");
            RegisterUsuarios = new UserRepository(_httpClient, "Auth/Register");

        }
        internal void SetAuthToken(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);
        }


    }
}
