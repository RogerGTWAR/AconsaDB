using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Proyecto
    {
        public int ProyectoID { get; set; }
        public required string ClienteID { get; set; }
        public required string NombreProyecto { get; set; }
        public required string Descripcion { get; set; }
        public required string Ubicacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal PresupuestoTotal { get; set; }
        public required string Estado { get; set; }
        public int TiempoTotalDias { get; set; }
    }
}
