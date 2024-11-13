using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Dto.Maquinaria
{
    public class MaquinariaUpdateDto
    {
        public int MaquinariaID { get; set; }
        public int? ProveedorID { get; set; }
        public string? NombreMaquinaria { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Tipo { get; set; }
        public decimal? PrecioPorHora { get; set; }
        public string? Estado { get; set; }
    }

}
