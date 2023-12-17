using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redspace.DTO
{
    public class JWTTokenResponse
    {
        public string? Token { get; set; }
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public DateTime DtExpiracao { get; set; }
    }
}
