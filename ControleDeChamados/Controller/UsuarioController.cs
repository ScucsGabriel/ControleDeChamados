using ControleDeChamados.DAO;
using ControleDeChamados.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeChamados.Controller
{
    public class UsuarioController
    {
        public Usuario InserirUsuario(string nomeUsuario, string emailUsuario, string senhaUsuario, string tipoUsuario, string funcaoUsuario, string usuarioAtivo)
        {
            return new UsuarioDB().InserirUsuario(nomeUsuario, emailUsuario, senhaUsuario, tipoUsuario, funcaoUsuario, usuarioAtivo);
        }
        public List<Usuario> ConsultarUsuarioPorEmail(string emailusuario)
        {
            return new UsuarioDB().ConsultarUsuarioPorEmail(emailusuario);
        }
        public List<Usuario> ConsultarUsuarioPorNome(string nomeUsuario)
        {
            return new UsuarioDB().ConsultarUsuarioPorNome(nomeUsuario);
        }
        public List<Usuario> ConsultarUsuarioPorId(int idUsuario)
        {
            return new UsuarioDB().ConsultarUsuarioPorId(idUsuario);
        }

        public string ConsultarSenhaUsuario(string emailusuario)
        {
            return new UsuarioDB().ConsultarSenhaUsuario(emailusuario);
        }

        public string ConsultarUsuarioAtivo(string emailusuario)
        {
            return new UsuarioDB().ConsultarUsuarioAtivo(emailusuario);
        }

        public Usuario AtualizarSenha(int idUsuario, string senhaUsuario)
        {
            return new UsuarioDB().AtualizarSenha(idUsuario, senhaUsuario);
        }

        public Usuario AtualizarDadosUsuario(int idUsuario, string emailUsuario, string nomeUsuario, string funcaoUsuario, string tipoUsuario)
        {
            return new UsuarioDB().AtualizarDadosUsuario(idUsuario, emailUsuario, nomeUsuario, funcaoUsuario, tipoUsuario);
        }

        public Usuario DesativarUsuario(int idUsuario)
        {
            return new UsuarioDB().DesativarUsuario(idUsuario);
        }
    }
}
