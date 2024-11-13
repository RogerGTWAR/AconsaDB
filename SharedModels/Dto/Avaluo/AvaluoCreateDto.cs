using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Dto.Avaluo
{
    public class AvaluoCreateDto
    {
        public int ProyectoID { get; set; }
        public string? Descripcion { get; set; }
        public decimal MontoEjecutado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int TiempoTotalDias { get; set; }

    }

}
