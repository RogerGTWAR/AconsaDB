using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Dto.Cliente
{
    public class ClienteUpdateDto
    {
        public string? ClienteID { get; set; }
        public string? NombreEmpresa { get; set; }
        public string? NombreContacto { get; set; }
        public string? CargoContacto { get; set; }
        public string? Direccion { get; set; }
        public string? Ciudad { get; set; }
        public string? Pais { get; set; }
        public string? Telefono { get; set; }
    }

}
