using AutoMapper;
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
using SharedModels.Dto.Usuario;
using SharedModels.Dto.Vehiculo;
using SharedModels.Dto.VehiculoDetalle;

namespace Gestor_Api
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            // Mapeos de Empleado
            CreateMap<Empleado, EmpleadoDto>().ReverseMap();
            CreateMap<Empleado, EmpleadoCreateDto>().ReverseMap();
            CreateMap<Empleado, EmpleadoUpdateDto>().ReverseMap();

            // Mapeos de Avaluo Detalle
            CreateMap<AvaluoDetalle, AvaluoDetallesDto>().ReverseMap();
            CreateMap<AvaluoDetalle, AvaluoDetalleCreateDto>().ReverseMap();
            CreateMap<AvaluoDetalle, AvaluoDetalleUpdateDto>().ReverseMap();

            // Mapeos de Avaluo
            CreateMap<Avaluo, AvaluoDto>().ReverseMap();
            CreateMap<Avaluo, AvaluoCreateDto>().ReverseMap();
            CreateMap<Avaluo, AvaluoUpdateDto>().ReverseMap();

            // Mapeos de Categoria
            CreateMap<Categoria, CategoriaDto>().ReverseMap();
            CreateMap<Categoria, CategoriaCreateDto>().ReverseMap();
            CreateMap<Categoria, CategoriaUpdateDto>().ReverseMap();

            // Mapeos de Cliente
            CreateMap<Cliente, ClienteDto>().ReverseMap();
            CreateMap<Cliente, ClienteCreateDto>().ReverseMap();
            CreateMap<Cliente, ClienteUpdateDto>().ReverseMap();

            // Mapeos de Maquinaria
            CreateMap<Maquinaria, MaquinariaDto>().ReverseMap();
            CreateMap<Maquinaria, MaquinariaCreateDto>().ReverseMap();
            CreateMap<Maquinaria, MaquinariaUpdateDto>().ReverseMap();

            // Mapeos de Producto
            CreateMap<Producto, ProductoDto>().ReverseMap();
            CreateMap<Producto, ProductoCreateDto>().ReverseMap();
            CreateMap<Producto, ProductoUpdateDto>().ReverseMap();

            // Mapeos de Proveedor
            CreateMap<Proveedor, ProveedorDto>().ReverseMap();
            CreateMap<Proveedor, ProveedorCreateDto>().ReverseMap();
            CreateMap<Proveedor, ProveedorUpdateDto>().ReverseMap();

            // Mapeos de Proyecto
            CreateMap<Proyecto, ProyectoDto>().ReverseMap();
            CreateMap<Proyecto, ProyectoCreateDto>().ReverseMap();
            CreateMap<Proyecto, ProyectoUpdateDto>().ReverseMap();

            // Mapeos de Usuario
            CreateMap<Usuario, UsuarioDto>().ReverseMap();
            CreateMap<Usuario, UsuarioCreateDto>().ReverseMap();
            CreateMap<Usuario, UsuarioUpdateDto>().ReverseMap();

            // Mapeos de Vehiculo
            CreateMap<Vehiculo, VehiculoDto>().ReverseMap();
            CreateMap<Vehiculo, VehiculoCreateDto>().ReverseMap();
            CreateMap<Vehiculo, VehiculoUpdateDto>().ReverseMap();

            // Mapeos de Vehiculo Detalle
            CreateMap<VehiculoDetalle, VehiculoDetallesDto>().ReverseMap();
            CreateMap<VehiculoDetalle, VehiculoDetalleCreateDto>().ReverseMap();
            CreateMap<VehiculoDetalle, VehiculoDetalleUpdateDto>().ReverseMap();

            CreateMap<MaquinariaDetalle, MaquinariaDetallesDto>().ReverseMap();
            CreateMap<MaquinariaDetalle, MaquinariaDetalleCreateDto>().ReverseMap();
            CreateMap<MaquinariaDetalle, MaquinariaDetalleUpdateDto>().ReverseMap();

            CreateMap<EmpleadoDetalle, EmpleadoDetallesDto>().ReverseMap();
            CreateMap<EmpleadoDetalle, EmpleadoDetalleCreateDto>().ReverseMap();
            CreateMap<EmpleadoDetalle, EmpleadoDetalleUpdateDto>().ReverseMap();

        }
    }
}
