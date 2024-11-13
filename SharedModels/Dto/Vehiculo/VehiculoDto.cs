using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Dto.Vehiculo
{
    public class VehiculoDto
    {
        public int VehiculoID { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Placa { get; set; }
        public decimal CostoDiario { get; set; }
        public string? Estado { get; set; }
    }

}
