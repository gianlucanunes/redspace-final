using Redspace.DTO;
using RedSpace.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSpace.BLL
{
    public class UsuarioBLL
    {
        UsuarioDAL usuarioDAL = new UsuarioDAL();
        public List<UsuarioDTO> ListarUsuariosBLL()
        {
            return usuarioDAL.ListarUsuarios();
        }
    }
}
