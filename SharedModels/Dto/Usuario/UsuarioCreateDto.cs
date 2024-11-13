using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Dto.Usuario
{
    public class UsuarioCreateDto
    {
        public int EmpleadoID { get; set; }
        public string? Usuario { get; set; }
        public string? Contraseña { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }

}
