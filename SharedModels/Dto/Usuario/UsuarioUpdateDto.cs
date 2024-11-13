using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Dto.Usuario
{
    public class UsuarioUpdateDto
    {
        public int UsuarioID { get; set; }
        public int EmpleadoID { get; set; }
        public string? UsuarioNombre { get; set; }
        public string? Contraseña { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }

}
