using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        public required string NombreCategoria { get; set; }
        public required string Descripcion { get; set; }
    }
}

