using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Dto.Maquinaria
{
    public class MaquinariaDto
    {
        public int MaquinariaID { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? Tipo { get; set; }
        public decimal Precio { get; set; }
        public string? Estado { get; set; }
    }

}
