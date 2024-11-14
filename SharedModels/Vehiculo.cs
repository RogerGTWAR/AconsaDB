using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Vehiculo
    {
        public int VehiculoID { get; set; }
        public int ProveedorID { get; set; }
        public required string Marca { get; set; }
        public required string Modelo { get; set; }
        public int Año { get; set; }
        public required string Placa { get; set; }
        public required string TipoDeVehiculo { get; set; }
        public required string TipoDeCombustible { get; set; }
        public required string Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
