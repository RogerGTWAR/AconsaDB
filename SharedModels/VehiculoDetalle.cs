using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class VehiculoDetalle
    {
        public int Vehiculo_DetalleID { get; set; }
        public int EmpleadoID { get; set; }
        public int VehiculoID { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public DateTime FechaFinAsignacion { get; set; }
        public required string Descripcion { get; set; }
    }
}
