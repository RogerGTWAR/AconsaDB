using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Dto.Empleado
{
    public class EmpleadoDto
    {
        public int EmpleadoID { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Cedula { get; set; }
        public string? Cargo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaContratacion { get; set; }
        public string? Direccion { get; set; }
        public string? Pais { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public int Reportes { get; set; }
    }

}
