using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Dto.Proyecto
{
    public class ProyectoUpdateDto
    {
        public int ProyectoID { get; set; }
        public string? ClienteID { get; set; }
        public string? NombreProyecto { get; set; }
        public string? Descripcion { get; set; }
        public string? Ubicacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal PresupuestoTotal { get; set; }
        public string? Estado { get; set; }
        public int TiempoTotalDias { get; set; }
    }

}
