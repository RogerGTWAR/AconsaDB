using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Usuarioz
    {
        public int UsuarioID { get; set; }
        public int EmpleadoID { get; set; }
        public required string Usuario { get; set; }
        public required string Contraseña { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
