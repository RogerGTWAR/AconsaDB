using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Dto.Rol
{
    public class RolDto
    {
        public int RolID { get; set; }
        public required string Cargo { get; set; }
        public required string Descripcion { get; set; }
    }
}
