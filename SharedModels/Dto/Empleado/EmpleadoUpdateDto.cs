using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Dto.Avaluo
{
    public class EmpleadoUpdateDto
    {
        public int EmpleadoID { get; set; }
        public required string Nombres { get; set; }
        public required string Apellidos { get; set; }
        public required string Cedula { get; set; }
        public required string Cargo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaContratacion { get; set; }
        public required string Direccion { get; set; }
        public required string Pais { get; set; }
        public required string Telefono { get; set; }
        public required string Correo { get; set; }
        public int? Reportes { get; set; }
    }

}
