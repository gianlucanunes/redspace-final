using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSpaceDesktop.DTO
{
    public class DesenvolvedorDTO
    {
        public int IdDesenvolvedor { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Discord { get; set; }
        public bool Status { get; set; }
    }
}
