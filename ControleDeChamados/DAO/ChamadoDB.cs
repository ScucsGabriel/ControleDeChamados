using ControleDeChamados.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace ControleDeChamados.DAO
{
    class ChamadoDB
    {
        string conecta = ConfigurationManager.ConnectionStrings["ConectaBanco"].ConnectionString;

        internal Chamado InserirChamado(int idChamadoUsuario, string numeroChamado, string categoria, string subCategoria, string item,
            string aprovacao, string statusChamado, string urgencia, string prioridade, string titulo, string descricao, DateTime dataAbertura, DateTime entregaEstimada)
        {
            SqlConnection conn = new SqlConnection(conecta);
            SqlCommand cmd = new SqlCommand("InserirChamado", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idChamadoUsuario", idChamadoUsuario);
            cmd.Parameters.AddWithValue("@numeroChamado", numeroChamado);
            cmd.Parameters.AddWithValue("@categoria", categoria);
            cmd.Parameters.AddWithValue("@subCategoria", subCategoria);
            cmd.Parameters.AddWithValue("@item", item);
            cmd.Parameters.AddWithValue("@aprovacao", aprovacao);
            cmd.Parameters.AddWithValue("@statusChamado", statusChamado);
            cmd.Parameters.AddWithValue("@urgencia", urgencia);
            cmd.Parameters.AddWithValue("@prioridade", prioridade);
            cmd.Parameters.AddWithValue("@titulo", titulo);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@dataAbertura", dataAbertura);
            cmd.Parameters.AddWithValue("@entregaEstimada", entregaEstimada);

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

        internal Chamado InserirDetalhesChamado(int idUsuario, int idChamado, DateTime dataFechamento)
        {
            SqlConnection conn = new SqlConnection(conecta);
            SqlCommand cmd = new SqlCommand("InserirDetalhesChamado", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
            cmd.Parameters.AddWithValue("@idChamado", idChamado);
            cmd.Parameters.AddWithValue("@dataFechamento", dataFechamento);

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
        internal Chamado CalcularNumeroChamado()
        {
            Chamado chamado = new Chamado();
            SqlConnection conn = new SqlConnection(conecta);
            SqlCommand cmd = new SqlCommand("CalcularNumeroChamado", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                var retornoBD = dr["idChamado"].ToString() ?? "0";
                if (retornoBD == "")
                    chamado.idChamado = 0;
                else
                    chamado.idChamado = Convert.ToInt32(retornoBD);
            }
            conn.Close();

            return chamado;
        }

        internal List<Chamado> ConsultarDetalhesChamado(int idChamado)
        {
            List<Chamado> lstChamado = new List<Chamado>();
            SqlConnection conn = new SqlConnection(conecta);
            SqlCommand cmd = new SqlCommand("ConsultarDetalhesChamado", conn);            
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idChamado", idChamado);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Chamado chamado = new Chamado();
                chamado.idChamado = Convert.ToInt32(dr["idChamado"].ToString());
                chamado.dataFechamento = Convert.ToDateTime(dr["dataFechamento"].ToString());
                if (dr["informacao"].ToString() == null)
                    chamado.informacao = "";
                else
                    chamado.informacao = dr["informacao"].ToString();
                if (dr["resolucao"].ToString() == null)
                    chamado.resolucao = "";
                else
                    chamado.resolucao = dr["resolucao"].ToString();

                lstChamado.Add(chamado);
            }
            conn.Close();

            return lstChamado;
        }
        internal List<Chamado> ConsultarFilaChamados()
        {
            List<Chamado> lstChamado = new List<Chamado>();
            SqlConnection conn = new SqlConnection(conecta);
            SqlCommand cmd = new SqlCommand("ConsultarFilaChamados", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Chamado chamado = new Chamado();
                chamado.numeroChamado = dr["numeroChamado"].ToString();
                chamado.titulo = dr["titulo"].ToString();
                chamado.statusChamado = dr["statusChamado"].ToString();
                chamado.dataAbertura = Convert.ToDateTime(dr["dataAbertura"].ToString());
                chamado.entregaEstimada = Convert.ToDateTime(dr["entregaEstimada"].ToString());

                lstChamado.Add(chamado);
            }

            conn.Close();

            return lstChamado;
        }        
        internal List<Chamado> ConsultarNumeroChamado(string numeroChamado)
        {
            List<Chamado> lstChamado = new List<Chamado>();
            SqlConnection conn = new SqlConnection(conecta);
            SqlCommand cmd = new SqlCommand("ConsultarNumeroChamado", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@numeroChamado", numeroChamado);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Chamado chamado = new Chamado();
                chamado.numeroChamado = dr["numeroChamado"].ToString();
                chamado.titulo = dr["titulo"].ToString();
                chamado.statusChamado = dr["statusChamado"].ToString();
                chamado.dataAbertura = Convert.ToDateTime(dr["dataAbertura"].ToString());
                chamado.entregaEstimada = Convert.ToDateTime(dr["entregaEstimada"].ToString());

                lstChamado.Add(chamado);
            }

            conn.Close();

            return lstChamado;
        }

        internal List<Chamado> ConsultarNumeroChamadoDetalhes(string numeroChamado)
        {
            List<Chamado> lstChamado = new List<Chamado>();
            SqlConnection conn = new SqlConnection(conecta);
            SqlCommand cmd = new SqlCommand("ConsultarNumeroChamadoDetalhes", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@numeroChamado", numeroChamado);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Chamado chamado = new Chamado();
                chamado.idChamado = Convert.ToInt32(dr["idChamado"].ToString());
                chamado.idChamadoUsuario = Convert.ToInt32(dr["idChamadoUsuario"].ToString());
                chamado.numeroChamado = dr["numeroChamado"].ToString();
                chamado.categoria = dr["categoria"].ToString();
                chamado.subCategoria = dr["subCategoria"].ToString();
                chamado.item = dr["item"].ToString();
                chamado.aprovacao = dr["aprovacao"].ToString();
                chamado.statusChamado = dr["statusChamado"].ToString();
                chamado.urgencia = dr["urgencia"].ToString();
                chamado.prioridade = dr["prioridade"].ToString();
                chamado.titulo = dr["titulo"].ToString();
                chamado.descricao = dr["descricao"].ToString();
                chamado.dataAbertura = Convert.ToDateTime(dr["dataAbertura"].ToString());
                chamado.entregaEstimada = Convert.ToDateTime(dr["entregaEstimada"].ToString());

                lstChamado.Add(chamado);
            }

            conn.Close();

            return lstChamado;
        }
        internal List<Chamado> ConsultarNumeroChamadoUsuario(int idUsuarioLogado, string numeroChamado)
        {
            List<Chamado> lstChamado = new List<Chamado>();
            SqlConnection conn = new SqlConnection(conecta);
            SqlCommand cmd = new SqlCommand("ConsultarNumeroChamadoUsuario", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idChamadoUsuario", idUsuarioLogado);
            cmd.Parameters.AddWithValue("@numeroChamado", numeroChamado);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Chamado chamado = new Chamado();
                chamado.numeroChamado = dr["numeroChamado"].ToString();
                chamado.titulo = dr["titulo"].ToString();
                chamado.statusChamado = dr["statusChamado"].ToString();
                chamado.dataAbertura = Convert.ToDateTime(dr["dataAbertura"].ToString());
                chamado.entregaEstimada = Convert.ToDateTime(dr["entregaEstimada"].ToString());

                lstChamado.Add(chamado);
            }

            conn.Close();

            return lstChamado;
        }

        internal Chamado AtualizarStatusChamado(int idChamado)
        {
            SqlConnection conn = new SqlConnection(conecta);
            SqlCommand cmd = new SqlCommand("AtualizarStatusChamado", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idChamado", idChamado);

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
        internal List<Chamado> ConsultarChamadoEncerrado(int idChamado)
        {
            List<Chamado> lstChamado = new List<Chamado>();
            SqlConnection conn = new SqlConnection(conecta);
            SqlCommand cmd = new SqlCommand("ConsultarChamadoEncerrado", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idChamado", idChamado);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Chamado chamado = new Chamado();
                chamado.informacao = dr["informacao"].ToString();
                chamado.resolucao = dr["resolucao"].ToString();                

                lstChamado.Add(chamado);
            }

            conn.Close();

            return lstChamado;
        }            
        internal Chamado AtualizarInformacoes(int idChamado, string informacao)
        {
            SqlConnection conn = new SqlConnection(conecta);
            SqlCommand cmd = new SqlCommand("AtualizarInformacoes", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idChamado", idChamado);
            cmd.Parameters.AddWithValue("@informacao", informacao);

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
        internal Chamado ResolverChamado(int idChamado, DateTime dataFechamento, string informacao, string resolucao)
        {
            SqlConnection conn = new SqlConnection(conecta);
            SqlCommand cmd = new SqlCommand("ResolverChamado", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idChamado", idChamado);
            cmd.Parameters.AddWithValue("@dataFechamento", dataFechamento);
            cmd.Parameters.AddWithValue("@informacao", informacao);
            cmd.Parameters.AddWithValue("@resolucao", resolucao);

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
    }
}
