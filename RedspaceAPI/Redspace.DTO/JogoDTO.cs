using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redspace.DTO
{
    public class JogoDTO
    {
        public int IdJogo { get; set; }
        public string IdCategoria { get; set; }
        public string IdDesenvolvedor { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Banner { get; set; }
        public DateTime DtLancamento { get; set; }
        public string InstaladorPath { get; set; }
        public bool Status { get; set; }
    }
}
