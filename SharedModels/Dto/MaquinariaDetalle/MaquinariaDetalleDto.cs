using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Dto.MaquinariaDetalle
{
    public class MaquinariaDetallesDto
    {
        public int Maquinaria_DetalleID { get; set; }
        public int ProyectoID { get; set; }
        public int MaquinariaID { get; set; }
        public int HorasUtilizadas { get; set; }
        public DateTime FechaInicioAsignacion { get; set; }
        public DateTime FechaFinAsignacion { get; set; }
    }

}
