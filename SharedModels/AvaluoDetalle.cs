﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class AvaluoDetalle
    {
        public int AvaluoDetalleID { get; set; }
        public int AvaluoID { get; set; }
        public int ProductoID { get; set; }
        public string? Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
