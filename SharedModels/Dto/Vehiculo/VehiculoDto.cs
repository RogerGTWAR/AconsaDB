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
        public int ProveedorID { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int Año { get; set; }
        public string? Placa { get; set; }
        public string? TipoDeVehiculo { get; set; }
        public string? TipoDeCombustible { get; set; }
        public string? Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
    }

}
