using Gestor_Api;
using Gestor_Api.Data;
using Gestor_Api.IRepository;
using Gestor_Api.IRepository.Repository;
using Gestor_Api.Repository.IRepository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using SharedModels;
using System.Configuration;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

//Conexion
// Registrar Contexto y repositorios
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddScoped<IRepository<Avaluo>>(sp => new AvaluoRepository(connectionString));
builder.Services.AddScoped<IRepository<AvaluoDetalle>>(sp => new AvaluoDetalleRepository(connectionString));
builder.Services.AddScoped<IRepository<Categoria>>(sp => new CategoriaRepository(connectionString));
builder.Services.AddScoped<IClienteRepository<Cliente>>(sp => new ClienteRepository(connectionString));

// Registrar los repositorios e inyectar la cadena de conexión


//Faltan
builder.Services.AddScoped<IRepository<Empleado>>(sp => new EmpleadoRepository(connectionString));
builder.Services.AddScoped<IRepository<EmpleadoDetalle>>(sp => new EmpleadoDetalleRepository(connectionString));
builder.Services.AddScoped<IRepository<Maquinaria>>(sp => new MaquinariaRepository(connectionString));
builder.Services.AddScoped<IRepository<MaquinariaDetalle>>(sp => new MaquinariaDetalleRepository(connectionString));
builder.Services.AddScoped<IRepository<Producto>>(sp => new ProductoRepository(connectionString));
builder.Services.AddScoped<IRepository<Proveedor>>(sp => new ProveedorRepository(connectionString));
builder.Services.AddScoped<IRepository<Proyecto>>(sp => new ProyectoRepository(connectionString));
builder.Services.AddScoped<IRepository<Vehiculo>>(sp => new VehiculoRepository(connectionString));
builder.Services.AddScoped<IRepository<VehiculoDetalle>>(sp => new VehiculoDetalleRepository(connectionString));
builder.Services.AddScoped<IUsuario, UsuarioRepository>();
builder.Services.AddScoped<IPasswordHasher<Usuario>, PasswordHasher<Usuario>>();




// Configuración de AutoMapper
builder.Services.AddAutoMapper(typeof(MappingConfig));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
