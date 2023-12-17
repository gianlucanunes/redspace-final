using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redspace.DTO
{
    public class GaleriaDTO
    {
        public int IdGaleria { get; set; }
        public string IdJogo { get; set; }
        public string FotoPath { get; set; }
        public bool? Status { get; set; }
    }
}
