using ControleDeChamados.DAO;
using ControleDeChamados.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeChamados.Controller
{
    public class ChamadoController
    {
        public Chamado InserirChamado(int idChamadoUsuario, string numeroChamado, string categoria, string subCategoria, string item, string vip,
            string aprovacao, string statusChamado, string urgencia, string prioridade, string titulo, string descricao, DateTime dataAbertura, DateTime entregaEstimada)
        {
            return new ChamadoDB().InserirChamado(idChamadoUsuario, numeroChamado, categoria, subCategoria, item, vip, aprovacao, statusChamado, urgencia, prioridade,
                        titulo, descricao, dataAbertura, entregaEstimada);
        }
        public Chamado CalcularNumeroChamado()
        {
            return new ChamadoDB().CalcularNumeroChamado();
        }
        public List<Chamado> ConsultarNumeroChamado(string numeroChamado)
        {
            return new ChamadoDB().ConsultarNumeroChamado(numeroChamado);
        }

    }
}
