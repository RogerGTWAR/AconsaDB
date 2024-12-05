using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Dto.Cliente
{
    public class ClienteCreateDto
    {
        public required string ClienteID { get; set; }
        public required string NombreEmpresa { get; set; }
        public string? NombreContacto { get; set; }
        public string? CargoContacto { get; set; }
        public string? Dirección { get; set; }
        public string? Ciudad { get; set; }
        public string? País { get; set; }
        public string? Teléfono { get; set; }
    }

}
