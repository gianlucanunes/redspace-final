using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redspace.DTO
{
    public class UsuarioJogoInputDTO
    {
        public int IdUsuario { get; set; }
        public int IdJogo { get; set; }
        public DateTime DataDownload { get; set; }
    }
}
