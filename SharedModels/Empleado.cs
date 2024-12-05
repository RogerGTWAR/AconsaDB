using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Empleado
    {
        public int EmpleadoID { get; set; }
       public required string Nombres { get; set; }
        public required string Apellidos { get; set; }
        public required string Cedula { get; set; }
        public int RolID { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaContratacion { get; set; }
        public required string Direccion { get; set; }
        public required string País { get; set; }
        public required string Telefono { get; set; }
        public required string Correo { get; set; }
        public int? Reportes { get; set; }
    }
}
