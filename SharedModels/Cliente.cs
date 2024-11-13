using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Cliente
    {
        public required string ClienteID { get; set; }
        public required string NombreEmpresa { get; set; }
        public string? NombreContacto { get; set; }
        public string? CargoContacto { get; set; }
        public string? Direccion { get; set; }
        public string? Ciudad { get; set; }
        public string? Pais { get; set; }
        public string? Telefono { get; set; }
    }
}
