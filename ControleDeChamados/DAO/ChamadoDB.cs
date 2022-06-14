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
    }
}
