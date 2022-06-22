using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeChamados.Model
{
    public class Chamado
    {
        public int idChamado { get; set; }
        public int idChamadoUsuario { get; set; }
        public string numeroChamado { get; set; }
        public string categoria { get; set; }
        public string subCategoria { get; set; }
        public string item { get; set; }       
        public string aprovacao { get; set; }
        public string statusChamado { get; set; }
        public string urgencia { get; set; }
        public string prioridade { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public DateTime dataAbertura { get; set; }
        public DateTime entregaEstimada { get; set; }
        public DateTime dataFechamento { get; set; }
        public string informacao { get; set; }
        public string resolucao { get; set; }
        public Usuario usuario { get; set; }
        public List<Usuario> listaUsuarios { get; set; }
        public Chamado()
        {
            this.usuario = new Usuario();
        }
    }
}
