﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Dto.EmpleadoDetalle
{
    public class EmpleadoDetalleCreateDto
    {
        public int EmpleadoID { get; set; }
        public int ProyectoID { get; set; }
        public DateTime FechaDeProyecto { get; set; }
    }

}
