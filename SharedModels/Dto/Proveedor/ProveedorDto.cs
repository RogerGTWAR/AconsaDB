using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Dto.Proveedor
{
    public class ProveedorDto
    {
        public int ProveedorID { get; set; }
        public required string NombreEmpresa { get; set; }
        public required string NombreContacto { get; set; }
        public required string CargoContacto { get; set; }
        public required string Direccion { get; set; }
        public required string Ciudad { get; set; }
        public required string Pais { get; set; }
        public required string Telefono { get; set; }
        public required string Correo { get; set; }
    }

}
