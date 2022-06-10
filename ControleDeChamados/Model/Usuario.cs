using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeChamados.Model
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string nomeUsuario { get; set; }
        public string emailUsuario { get; set; }
        public string senhaUsuario { get; set; }
        public string tipoUsuario { get; set; }
        public string funcaoUsuario { get; set; }
        public string usuarioAtivo { get; set; }
    }
}
