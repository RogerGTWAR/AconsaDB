using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Producto
    {
        public int ProductoID { get; set; }
        public required string NombreProducto { get; set; }
        public int ProveedorID { get; set; }
        public int CategoriaID { get; set; }
        public required string Descripcion { get; set; }
        public required string UnidadDeMedida { get; set; }
        public int CantidadEnStock { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
