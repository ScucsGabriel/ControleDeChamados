using ControleDeChamados.Controller;
using ControleDeChamados.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace ControleDeChamados.View.Chamados
{
    public partial class FormDetalhesChamado : Form
    {
        int idTecnico = 0, idUsuario = 0, idChamado = 0;
        public FormDetalhesChamado(int idUsuarioLogado, List<Chamado> chamadoSelecionado)
        {
            InitializeComponent();
            idTecnico = idUsuarioLogado;
            foreach (var item in chamadoSelecionado)
            {
                idUsuario = item.idChamadoUsuario;
                idChamado = item.idChamado;
                Label_NumeroChamado.Text = item.numeroChamado;                
            }
        }

        private void FormDetalhesChamado_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(127, 0, 255);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            Label_Detalhes.BackColor = Color.FromArgb(153, 50, 205);
            Label_Chamado.BackColor = Color.FromArgb(153, 50, 205);
            Label_NumeroChamado.BackColor = Color.FromArgb(153, 50, 205);
            Btn_Cancelar.BackColor = Color.FromArgb(127, 0, 255);
            Label_Usuario.BackColor = Color.FromArgb(153, 50, 205);
            Label_NomeUsuario.BackColor = Color.FromArgb(153, 50, 205);
            Label_Email.BackColor = Color.FromArgb(153, 50, 205);
            Label_EmailUsuario.BackColor = Color.FromArgb(153, 50, 205);
            Label_Categoria.BackColor = Color.FromArgb(153, 50, 205);
            Label_CategoriaChamado.BackColor = Color.FromArgb(153, 50, 205);
            Label_Subcategoria.BackColor = Color.FromArgb(153, 50, 205);
            Label_SubcategoriaChamado.BackColor = Color.FromArgb(153, 50, 205);
            Label_Item.BackColor = Color.FromArgb(153, 50, 205);
            Label_ItemChamado.BackColor = Color.FromArgb(153, 50, 205);
            Label_Urgencia.BackColor = Color.FromArgb(153, 50, 205);
            Label_UrgenciaChamado.BackColor = Color.FromArgb(153, 50, 205);
            Label_Prioridade.BackColor = Color.FromArgb(153, 50, 205);
            Label_PrioridadeChamado.BackColor = Color.FromArgb(153, 50, 205);
            Label_Status.BackColor = Color.FromArgb(153, 50, 205);
            Label_StatusChamado.BackColor = Color.FromArgb(153, 50, 205);
            Label_Titulo.BackColor = Color.FromArgb(153, 50, 205);
            Label_TituloChamado.BackColor = Color.FromArgb(153, 50, 205);
            Label_Descricao.BackColor = Color.FromArgb(153, 50, 205);
            Label_DescricaoChamado.BackColor = Color.FromArgb(153, 50, 205);
            Label_DataAbertura.BackColor = Color.FromArgb(153, 50, 205);
            Label_DataAberturaChamado.BackColor = Color.FromArgb(153, 50, 205);
            Label_DataEstimativa.BackColor = Color.FromArgb(153, 50, 205);
            Label_DataEstimativaChamado.BackColor = Color.FromArgb(153, 50, 205);
            Btn_Cancelar.FlatAppearance.BorderColor = Color.FromArgb(127, 0, 255);
            Btn_Cancelar.FlatAppearance.CheckedBackColor = Color.FromArgb(127, 0, 255);
            Btn_Cancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(127, 0, 255);
            Btn_Cancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(127, 0, 255);
            Btn_Atender.BackColor = Color.FromArgb(153, 50, 205);
            Btn_Atender.FlatAppearance.BorderColor = Color.FromArgb(153, 50, 205);
            Btn_Atender.FlatAppearance.CheckedBackColor = Color.FromArgb(153, 50, 205);
            Btn_Atender.FlatAppearance.MouseDownBackColor = Color.FromArgb(153, 50, 205);
            Btn_Atender.FlatAppearance.MouseOverBackColor = Color.FromArgb(153, 50, 205);
            Btn_Atualizar.BackColor = Color.FromArgb(153, 50, 205);
            Btn_Atualizar.FlatAppearance.BorderColor = Color.FromArgb(153, 50, 205);
            Btn_Atualizar.FlatAppearance.CheckedBackColor = Color.FromArgb(153, 50, 205);
            Btn_Atualizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(153, 50, 205);
            Btn_Atualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(153, 50, 205);
            Btn_Resolver.BackColor = Color.FromArgb(153, 50, 205);
            Btn_Resolver.FlatAppearance.BorderColor = Color.FromArgb(153, 50, 205);
            Btn_Resolver.FlatAppearance.CheckedBackColor = Color.FromArgb(153, 50, 205);
            Btn_Resolver.FlatAppearance.MouseDownBackColor = Color.FromArgb(153, 50, 205);
            Btn_Resolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(153, 50, 205);
            if (Label_StatusChamado.Text == "Encerrado")
                Btn_Atender.Visible = false;
            Panel_Separacao.BackColor = Color.White;
            Panel_Separacao.ForeColor = Color.White;
            Txt_Informacao.BackColor = Color.FromArgb(127, 0, 255);
            Txt_Informacao.PlaceholderText = "Log de Atendimento";
            Panel_Informacao.BackColor = Color.White;
            Panel_Informacao.ForeColor = Color.White;
            Txt_Resolucao.BackColor = Color.FromArgb(127, 0, 255);
            Txt_Resolucao.PlaceholderText = "Resolução";
            Panel_Resolucao.BackColor = Color.White;
            Panel_Resolucao.ForeColor = Color.White;

            UsuarioController buscaUsuario = new UsuarioController();
            foreach (var itemUsuario in buscaUsuario.ConsultarUsuarioPorId(idUsuario))
            {
                Label_NomeUsuario.Text = itemUsuario.nomeUsuario;
                Label_EmailUsuario.Text = itemUsuario.emailUsuario;
            }

            ChamadoController buscaChamado = new ChamadoController();
            foreach (var itemChamado in buscaChamado.ConsultarNumeroChamadoDetalhes(Label_NumeroChamado.Text))
            {
                Label_CategoriaChamado.Text = itemChamado.categoria;
                Label_SubcategoriaChamado.Text = itemChamado.subCategoria;
                Label_ItemChamado.Text = itemChamado.item;
                Label_UrgenciaChamado.Text = itemChamado.urgencia;
                Label_PrioridadeChamado.Text = itemChamado.prioridade;
                Label_StatusChamado.Text = itemChamado.statusChamado;
                Label_TituloChamado.Text = itemChamado.titulo;
                Label_DescricaoChamado.Text = itemChamado.descricao;
                Label_DataAberturaChamado.Text = itemChamado.dataAbertura.ToString("dd/MM/yyyy");
                if (itemChamado.entregaEstimada.Date >= DateTime.Now.Date)
                {
                    Label_DataEstimativaChamado.Text = "No Prazo";
                    Label_DataEstimativaChamado.ForeColor = Color.Green;
                }
                else
                {
                    Label_DataEstimativaChamado.Text = "Vencido";
                    Label_DataEstimativaChamado.ForeColor = Color.Red;
                }
                if (Label_StatusChamado.Text == "Aberto" || Label_StatusChamado.Text == "Em Andamento")                                    
                    Btn_Atender.Visible = true;
                else
                    Btn_Atender.Visible = false;
                if (Label_StatusChamado.Text == "Encerrado")
                {
                    Txt_Informacao.Enabled = false;
                    Txt_Resolucao.Enabled = false;
                }                
            }

            if (Label_StatusChamado.Text == "Encerrado")
            {
                Panel_Separacao.Visible = true;
                Txt_Informacao.Visible = true;
                Txt_Informacao.Enabled = false;
                Panel_Informacao.Visible = true;
                Txt_Resolucao.Visible = true;
                Txt_Resolucao.Enabled = false;
                Panel_Resolucao.Visible = true;

                foreach (var item in buscaChamado.ConsultarChamadoEncerrado(idChamado))
                {
                    Txt_Informacao.Text = item.informacao;
                    Txt_Resolucao.Text = item.resolucao;
                }
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Resolver_Click(object sender, EventArgs e)
        {
            if (Txt_Resolucao.Text == "")
            {
                MessageBox.Show("Resolução está vazia!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Txt_Informacao.Text == "")
            {
                MessageBox.Show("Log de atendimento está vazio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string nomeUsuario = "";
                ChamadoController resolverChamado = new ChamadoController();
                resolverChamado.ResolverChamado(idChamado, DateTime.Now.Date, Txt_Informacao.Text, Txt_Resolucao.Text);
                Label_StatusChamado.Text = "Encerrado";
                MessageBox.Show("Chamado resolvido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UsuarioController pesquisarTecnico = new UsuarioController();
                foreach (var item in pesquisarTecnico.ConsultarUsuarioPorId(idTecnico))
                {
                    nomeUsuario = item.nomeUsuario;
                }
                TelegramBotClient avisarGrupo = new TelegramBotClient("");
                avisarGrupo.SendTextMessageAsync("", "<b>" + nomeUsuario + "</b> acabou de atualizar o chamado " + Label_NumeroChamado.Text + "!" +
                                                "\nO chamado agora está <b>encerrado!</b>" +
                                                "\n\nResolução: " + Txt_Resolucao.Text, ParseMode.Html);

                this.Close();
            }
        }

        private void Btn_Atualizar_Click(object sender, EventArgs e)
        {
            if (Txt_Resolucao.Text != "")
            {
                MessageBox.Show("O chamado ainda não foi resolvido. Apague a resolução.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Txt_Informacao.Text == "")
            {
                MessageBox.Show("Log de atendimento está vazio", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string nomeUsuario = "";
                ChamadoController atualizarChamado = new ChamadoController();
                atualizarChamado.AtualizarInformacoes(idChamado, Txt_Informacao.Text);
                MessageBox.Show("Log de atendimento atualizado.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UsuarioController pesquisarTecnico = new UsuarioController();
                foreach (var item in pesquisarTecnico.ConsultarUsuarioPorId(idTecnico))
                {
                    nomeUsuario = item.nomeUsuario;
                }
                TelegramBotClient avisarGrupo = new TelegramBotClient("");
                avisarGrupo.SendTextMessageAsync("", "<b>" + nomeUsuario + "</b> acabou de atualizar o chamado " + Label_NumeroChamado.Text + "!" +
                                                "\nO chamado ainda está <b>em andamento</b>, porém, há um novo log de atendimento: " +
                                                "\n\nLog: " + Txt_Informacao.Text, ParseMode.Html);
            }
        }

        private void Btn_Atender_Click(object sender, EventArgs e)
        {
            ChamadoController atenderChamado = new ChamadoController();
            if (atenderChamado.ConsultarDetalhesChamado(idChamado).Count > 0)
            {
                MessageBox.Show("Chamado já está sendo atendido por um analista.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach (var item in atenderChamado.ConsultarDetalhesChamado(idChamado))
                {
                    Txt_Informacao.Text = item.informacao;
                    Txt_Resolucao.Text = item.resolucao;
                }
            }

            else if (atenderChamado.ConsultarDetalhesChamado(idChamado).Count > 0 && Label_StatusChamado.Text == "Encerrado")
            {
                MessageBox.Show("Chamado já está encerrado.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (var item in atenderChamado.ConsultarDetalhesChamado(idChamado))
                {
                    Txt_Informacao.Text = item.informacao;
                    Txt_Resolucao.Text = item.resolucao;
                }
            }
                
            else
            {
                string nomeUsuario = "";
                atenderChamado.InserirDetalhesChamado(idUsuario, idChamado, DateTime.Now.Date);
                atenderChamado.AtualizarStatusChamado(idChamado);
                Label_StatusChamado.Text = "Em Andamento";
                MessageBox.Show("Chamado atribuído a você!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UsuarioController pesquisarTecnico = new UsuarioController();
                foreach (var item in pesquisarTecnico.ConsultarUsuarioPorId(idTecnico))
                {
                    nomeUsuario = item.nomeUsuario;
                }
                TelegramBotClient avisarGrupo = new TelegramBotClient("");
                avisarGrupo.SendTextMessageAsync("", "<b>" + nomeUsuario + "</b> acabou de se atribuir ao chamado " + Label_NumeroChamado.Text + "!" + 
                                                "\nAgora o novo status do chamado é <b>Em Andamento.</b>" + 
                                                "\nAguarde mais informações ou finalização do atendimento para novas atualizações",
                                                ParseMode.Html);
            }

            if (Label_StatusChamado.Text == "Aberto" || Label_StatusChamado.Text == "Em Andamento")
            {
                Btn_Atualizar.Visible = true;
                Btn_Resolver.Visible = true;
            }

            Panel_Separacao.Visible = true;
            Txt_Informacao.Visible = true;
            Panel_Informacao.Visible = true;
            Txt_Resolucao.Visible = true;
            Panel_Resolucao.Visible = true;
        }
    }
}
