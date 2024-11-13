using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Dto.Categoria
{
    public class CategoriaUpdateDto
    {
        public int CategoriaID { get; set; } 
        public string? NombreCategoria { get; set; }
        public string? Descripcion { get; set; }
    }

}
