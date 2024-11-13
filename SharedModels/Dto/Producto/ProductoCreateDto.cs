using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Dto.Producto
{
    public class ProductoCreateDto
    {
        public string? NombreProducto { get; set; }
        public int ProveedorID { get; set; }
        public int CategoriaID { get; set; }
        public string? Descripcion { get; set; }
        public string? UnidadDeMedida { get; set; }
        public int CantidadEnStock { get; set; }
        public decimal PrecioUnitario { get; set; }
    }

}
