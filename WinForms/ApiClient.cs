using Microsoft.Data.SqlClient;
using SharedModels;
using SharedModels.Dto.Avaluo;
using SharedModels.Dto.AvaluoDetalle;
using SharedModels.Dto.Categoria;
using SharedModels.Dto.Cliente;
using SharedModels.Dto.Empleado;
using SharedModels.Dto.EmpleadoDetalle;
using SharedModels.Dto.Maquinaria;
using SharedModels.Dto.MaquinariaDetalle;
using SharedModels.Dto.Producto;
using SharedModels.Dto.Proveedor;
using SharedModels.Dto.Proyecto;
using SharedModels.Dto.Rol;
using SharedModels.Dto.Vehiculo;
using SharedModels.Dto.VehiculoDetalle;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WinForms;

namespace WinForms
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;
        public IRepository<EmpleadoDto> Empleados { get; set; }
        public IRepository<EmpleadoDetallesDto> EmpleadosDetalles { get; set; }
        public IRepository<ClienteDto> Clientes { get; set; }
        public IRepository<ProveedorDto> Proveedores { get; set; }
        public IRepository<ProyectoDto> Proyectos { get; set; }
        public IRepository<CategoriaDto> Categorias { get; set; }
        public IRepository<AvaluoDto> Avaluos { get; set; }
        public IRepository<AvaluoDetallesDto> AvaluosDetalles { get; set; }

        public IRepository<ProductoDto> Productos { get; set; }
        public IRepository<VehiculoDto> Vehiculos { get; set; }
        public IRepository<VehiculoDetallesDto> VehiculosDetalles { get; set; }
        public IRepository<MaquinariaDto> Maquinarias { get; set; }
        public IRepository<MaquinariaDetallesDto> MaquinariasDetalles { get; set; }
        public IRepository<RolDto> Roles { get; set; }
        public IUserRepository LoginUsers { get; }
        public IUserRepository RegisterUsuarios { get; }

        public ApiClient()
        {
            string apiBaseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
            _httpClient = new HttpClient { BaseAddress = new Uri(apiBaseUrl) };    
            //Nota lo que esta entre "" tiene que llamarse igual que la clase de shared models o la api
            Empleados = new Repository<EmpleadoDto>(_httpClient, "Empleado");
            EmpleadosDetalles = new Repository<EmpleadoDetallesDto>(_httpClient, "EmpleadoDetalle");
            Clientes = new Repository<ClienteDto>(_httpClient, "Cliente");
            Proveedores = new Repository<ProveedorDto>(_httpClient, "Proveedor");
            Proyectos = new Repository<ProyectoDto>(_httpClient, "Proyecto");
            Categorias = new Repository<CategoriaDto>(_httpClient, "Categoria");
            Avaluos = new Repository<AvaluoDto>(_httpClient, "Avaluo");
            AvaluosDetalles = new Repository<AvaluoDetallesDto>(_httpClient, "AvaluoDetalle");
            Productos = new Repository<ProductoDto>(_httpClient, "Producto");
            Vehiculos = new Repository<VehiculoDto>(_httpClient, "Vehiculo");
            VehiculosDetalles = new Repository<VehiculoDetallesDto>(_httpClient, "VehiculoDetalle");
            Maquinarias = new Repository<MaquinariaDto>(_httpClient, "Maquinaria");
            MaquinariasDetalles = new Repository<MaquinariaDetallesDto>(_httpClient, "MaquinariaDetalle");
            Roles = new Repository<RolDto>(_httpClient, "Roles");
            LoginUsers = new UserRepository(_httpClient, "Auth/Login");
            RegisterUsuarios = new UserRepository(_httpClient, "Auth/register");
        }
        internal void SetAuthToken(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);
        }

    }
}
