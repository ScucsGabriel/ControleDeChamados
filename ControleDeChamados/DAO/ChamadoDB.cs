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

        internal Chamado InserirChamado(int idChamadoUsuario, string numeroChamado, string categoria, string subCategoria, string item, string vip,
            string aprovacao, string statusChamado, string urgencia, string prioridade, string titulo, string descricao, DateTime dataAbertura, DateTime entregaEstimada)
        {
            SqlConnection conn = new SqlConnection(conecta);
            SqlCommand cmd = new SqlCommand("CadastrarChamado", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idChamadoUsuario", idChamadoUsuario);
            cmd.Parameters.AddWithValue("@numeroChamado", numeroChamado);
            cmd.Parameters.AddWithValue("@categoria", categoria);
            cmd.Parameters.AddWithValue("@subCategoria", subCategoria);
            cmd.Parameters.AddWithValue("@item", item);
            cmd.Parameters.AddWithValue("@vip", vip);
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
    }
}
