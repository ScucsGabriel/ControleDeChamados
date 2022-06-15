using ControleDeChamados.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace ControleDeChamados.DAO
{
    class UsuarioDB
    {
        string conecta = ConfigurationManager.ConnectionStrings["ConectaBanco"].ConnectionString;

        internal Usuario InserirUsuario(string nomeUsuario, string emailUsuario, string senhaUsuario, string tipoUsuario, string funcaoUsuario, string usuarioAtivo)
        {
            SqlConnection conn = new SqlConnection(conecta);
            SqlCommand cmd = new SqlCommand("CadastrarUsuario", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nomeUsuario", nomeUsuario);
            cmd.Parameters.AddWithValue("@emailUsuario", emailUsuario);
            cmd.Parameters.AddWithValue("@senhaUsuario", senhaUsuario);
            cmd.Parameters.AddWithValue("@tipoUsuario", tipoUsuario);
            cmd.Parameters.AddWithValue("@funcaoUsuario", funcaoUsuario);
            cmd.Parameters.AddWithValue("@usuarioAtivo", usuarioAtivo);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Houve um problema na gravação de dados: " + ex);
            }
            finally
            {
                conn.Close();
            }

            return null;
        }
        internal List<Usuario> ConsultarUsuarioPorEmail(string emailUsuario)
        {
            List<Usuario> lstUsuario = new List<Usuario>();
            SqlConnection conn = new SqlConnection(conecta);
            SqlCommand cmd = new SqlCommand("ConsultarUsuarioPorEmail", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emailUsuario", emailUsuario);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Usuario usuario = new Usuario();
                usuario.idUsuario = Convert.ToInt32(dr["idUsuario"].ToString());
                usuario.emailUsuario = dr["emailUsuario"].ToString();
                usuario.nomeUsuario = dr["nomeUsuario"].ToString();
                usuario.funcaoUsuario = dr["funcaoUsuario"].ToString();
                usuario.tipoUsuario = dr["tipoUsuario"].ToString();

                lstUsuario.Add(usuario);
            }
            conn.Close();

            return lstUsuario;
        }

        internal List<Usuario> ConsultarUsuarioPorNome(string nomeUsuario)
        {
            List<Usuario> lstUsuario = new List<Usuario>();
            SqlConnection conn = new SqlConnection(conecta);
            SqlCommand cmd = new SqlCommand("ConsultarUsuarioPorNome", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nomeUsuario", nomeUsuario);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Usuario usuario = new Usuario();
                usuario.nomeUsuario = dr["nomeUsuario"].ToString();

                lstUsuario.Add(usuario);
            }
            conn.Close();

            return lstUsuario;
        }

        internal string ConsultarSenhaUsuario(string emailUsuario)
        {
            SqlConnection conn = new SqlConnection(conecta);
            SqlCommand cmd = new SqlCommand("ConsultarSenhaUsuario", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emailUsuario", emailUsuario);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            string senha = "";

            while (dr.Read())
            {
                Usuario usuario = new Usuario();
                senha = usuario.senhaUsuario = dr["senhaUsuario"].ToString();
            }
            conn.Close();

            return senha;
        }

        internal string ConsultarUsuarioAtivo(string emailUsuario)
        {
            SqlConnection conn = new SqlConnection(conecta);
            SqlCommand cmd = new SqlCommand("ConsultarUsuarioAtivo", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emailUsuario", emailUsuario);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            string usuarioAtivo = "";

            while (dr.Read())
            {
                Usuario usuario = new Usuario();
                usuarioAtivo = usuario.usuarioAtivo = dr["usuarioAtivo"].ToString();
            }
            conn.Close();

            return usuarioAtivo;
        }

        internal List<Usuario> ConsultarUsuarioPorId(int idUsuario)
        {
            List<Usuario> lstUsuario = new List<Usuario>();
            SqlConnection conn = new SqlConnection(conecta);
            SqlCommand cmd = new SqlCommand("ConsultarUsuarioPorId", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Usuario usuario = new Usuario();
                usuario.idUsuario = Convert.ToInt32(dr["idUsuario"].ToString());
                usuario.nomeUsuario = dr["nomeUsuario"].ToString();
                usuario.emailUsuario = dr["emailUsuario"].ToString();
                usuario.senhaUsuario = dr["senhaUsuario"].ToString();
                usuario.funcaoUsuario = dr["funcaoUsuario"].ToString();
                usuario.tipoUsuario = dr["tipoUsuario"].ToString();

                lstUsuario.Add(usuario);

            }
            conn.Close();

            return lstUsuario;
        }

        internal Usuario AtualizarSenha(int idUsuario, string senhaUsuario)
        {
            SqlConnection conn = new SqlConnection(conecta);
            SqlCommand cmd = new SqlCommand("AtualizarSenha", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
            cmd.Parameters.AddWithValue("@senhaUsuario", senhaUsuario);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Houve um problema na edição de dados: " + ex);
            }
            finally
            {
                conn.Close();
            }

            return null;
        }

        internal Usuario AtualizarDadosUsuario(int idUsuario, string emailUsuario, string nomeUsuario, string funcaoUsuario, string tipoUsuario)
        {
            SqlConnection conn = new SqlConnection(conecta);
            SqlCommand cmd = new SqlCommand("AtualizarDadosUsuario", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
            cmd.Parameters.AddWithValue("@emailUsuario", emailUsuario);
            cmd.Parameters.AddWithValue("@nomeUsuario", nomeUsuario);
            cmd.Parameters.AddWithValue("@funcaoUsuario", funcaoUsuario);
            cmd.Parameters.AddWithValue("@tipoUsuario", tipoUsuario);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Houve um problema na edição de dados: " + ex);
            }
            finally
            {
                conn.Close();
            }

            return null;
        }

        internal Usuario DesativarUsuario(int idUsuario)
        {
            SqlConnection conn = new SqlConnection(conecta);
            SqlCommand cmd = new SqlCommand("DesativarUsuario", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Houve um problema na edição de dados: " + ex);
            }
            finally
            {
                conn.Close();
            }

            return null;
        }
    }
}
