﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSpaceDesktop.DTO
{
    public class ComentarioInputDTO
    {
        public string IdUsuario { get; set; }
        public string IdJogo { get; set; }
        public string Comentario { get; set; }
        public int Nota { get; set; }
    }
}
