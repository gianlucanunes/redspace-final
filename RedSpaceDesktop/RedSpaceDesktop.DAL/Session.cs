﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSpaceDesktop.DAL
{
    public static class Session
    {
        //usuario
        private static string _nomeUsuario;

        public static string nomeUsuario
        {
            get { return _nomeUsuario; }
            set { _nomeUsuario = value; }
        }
    }
}
