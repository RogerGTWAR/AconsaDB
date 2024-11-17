using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Dto.Usuario
{
    public class LoginUsuario
    {
        public required string Usuario { get; set; }
        [Required]
        [MinLength(6)]
        public required string Contraseña { get; set; }
    }

}
