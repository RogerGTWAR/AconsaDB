using Gestor_Api;
using Gestor_Api.Data;
using Gestor_Api.IRepository;
using Gestor_Api.IRepository.Repository;
using Gestor_Api.Repositories;
using Gestor_Api.Repository.IRepository;
using Gestor_Api.Security;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
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
builder.Services.AddScoped<IRepository<Empleado>>(sp => new EmpleadoRepository(connectionString));
builder.Services.AddScoped<IRepository<EmpleadoDetalle>>(sp => new EmpleadoDetalleRepository(connectionString));
builder.Services.AddScoped<IRepository<Maquinaria>>(sp => new MaquinariaRepository(connectionString));
builder.Services.AddScoped<IRepository<MaquinariaDetalle>>(sp => new MaquinariaDetalleRepository(connectionString));
builder.Services.AddScoped<IRepository<Producto>>(sp => new ProductoRepository(connectionString));
builder.Services.AddScoped<IRepository<Proveedor>>(sp => new ProveedorRepository(connectionString));
builder.Services.AddScoped<IRepository<Proyecto>>(sp => new ProyectoRepository(connectionString));
builder.Services.AddScoped<IRepository<Vehiculo>>(sp => new VehiculoRepository(connectionString));
builder.Services.AddScoped<IRepository<VehiculoDetalle>>(sp => new VehiculoDetalleRepository(connectionString));
builder.Services.AddScoped<IPasswordHasher<Usuarioz>, PasswordHasher<Usuarioz>>();
// Registrar la dependencia IUsuario
builder.Services.AddScoped<IUsuario, UsuarioRepository>();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
            ValidAudience = builder.Configuration["JwtSettings:Audience"],
            IssuerSigningKey =
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtSettings:Key"]))
        };
    })
    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

builder.Services.AddControllers(options =>
{
    //options.Filters.Add(new MyLogging());
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    // Título (Diseño)
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Software Gestor", Version = "v1" });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. Example: " +
        "\"Authorization: Bearer {token}\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityDefinition("Basic", new OpenApiSecurityScheme
    {
        Description = "Basic Authorization header using the Bearer scheme.",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "Basic"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                },
                Scheme = "oauth2",
                Name = "Bearer",
                In = ParameterLocation.Header
            },
            new List<string>()
        },
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Basic"
                },
                Scheme = "Basic",
                Name = "Basic",
                In = ParameterLocation.Header
            },
            new List<string>()
        }
    });
});


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

//// Habilitar CORS para permitir solicitudes desde dominios específicos
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowSpecificOrigin", policy =>
//    {
//        policy.WithOrigins("http://localhost:7067") // Reemplaza con el origen de tu cliente
//              .AllowAnyMethod()
//              .AllowAnyHeader();
//    });
//});

