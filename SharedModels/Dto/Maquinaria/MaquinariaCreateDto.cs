﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Dto.Maquinaria
{
    public class MaquinariaCreateDto
    {
        public int ProveedorID { get; set; }
        public string? NombreMaquinaria { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public DateTime FechaInicioRenta { get; set; }
        public DateTime FechaFinalizacionRenta { get; set; }
        public decimal Precio { get; set; }
        public string? Estado { get; set; }
    }

}
