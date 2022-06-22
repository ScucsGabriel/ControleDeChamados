using ControleDeChamados.DAO;
using ControleDeChamados.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeChamados.Controller
{
    public class ChamadoController
    {
        public Chamado InserirChamado(int idChamadoUsuario, string numeroChamado, string categoria, string subCategoria, string item,
            string aprovacao, string statusChamado, string urgencia, string prioridade, string titulo, string descricao, DateTime dataAbertura, DateTime entregaEstimada)
        {
            return new ChamadoDB().InserirChamado(idChamadoUsuario, numeroChamado, categoria, subCategoria, item, aprovacao, statusChamado, urgencia, prioridade,
                        titulo, descricao, dataAbertura, entregaEstimada);
        }
        public Chamado InserirDetalhesChamado(int idUsuario, int idChamado, DateTime dataFechamento)
        {
            return new ChamadoDB().InserirDetalhesChamado(idUsuario, idChamado, dataFechamento);
        }
        public Chamado CalcularNumeroChamado()
        {
            return new ChamadoDB().CalcularNumeroChamado();
        }
        public List<Chamado> ConsultarNumeroChamado(string numeroChamado)
        {
            return new ChamadoDB().ConsultarNumeroChamado(numeroChamado);
        }
        public List<Chamado> ConsultarDetalhesChamado(int idChamado)
        {
            return new ChamadoDB().ConsultarDetalhesChamado(idChamado);
        }
        public List<Chamado> ConsultarNumeroChamadoDetalhes(string numeroChamado)
        {
            return new ChamadoDB().ConsultarNumeroChamadoDetalhes(numeroChamado);
        }
        public List<Chamado> ConsultarFilaChamados()
        {
            return new ChamadoDB().ConsultarFilaChamados();
        }        
        public List<Chamado> ConsultarNumeroChamadoUsuario(int idUsuarioLogado, string numeroChamado)
        {
            return new ChamadoDB().ConsultarNumeroChamadoUsuario(idUsuarioLogado, numeroChamado);
        }
        public List<Chamado> ConsultarChamadoEncerrado(int idChamado)
        {
            return new ChamadoDB().ConsultarChamadoEncerrado(idChamado);
        }        
        public Chamado AtualizarStatusChamado(int idChamado)
        {
            return new ChamadoDB().AtualizarStatusChamado(idChamado);
        }
        public Chamado AtualizarInformacoes(int idChamado, string informacao)
        {
            return new ChamadoDB().AtualizarInformacoes(idChamado, informacao);
        }
        public Chamado ResolverChamado(int idChamado, DateTime dataFechamento, string informacao, string resolucao)
        {
            return new ChamadoDB().ResolverChamado(idChamado, dataFechamento, informacao, resolucao);
        }
        
    }
}
