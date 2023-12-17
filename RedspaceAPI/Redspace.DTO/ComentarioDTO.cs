using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redspace.DTO
{
    public class ComentarioDTO
    {
        public int IdComentario { get; set; }
        public string IdUsuario { get; set; }
        public string IdJogo { get; set; }
        public string Comentario { get; set; }
        public int Nota { get; set; }
        public bool Status { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
    }
}
