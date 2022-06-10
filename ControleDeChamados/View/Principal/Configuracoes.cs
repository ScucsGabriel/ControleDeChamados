using ControleDeChamados.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControleDeChamados.View.Principal
{
    public partial class FormConfiguracoes : Form
    {
        int resposta = 0, idUsuarioLog = 0;
        public FormConfiguracoes(int idUsuarioLogado)
        {
            InitializeComponent();
            idUsuarioLog = idUsuarioLogado;
        }

        private void Btn_PesquisarEmail_Click(object sender, EventArgs e)
        {
            UsuarioController pesquisarEmail = new UsuarioController();

            if (resposta == 1)
            {
                Label_UsuarioConfiguracoes.Visible = true;
                Txt_UsuarioConfiguracoes.Visible = true;
                Label_FuncaoConfiguracoes.Visible = true;
                Combo_FuncaoConfiguracoes.Visible = true;
                Label_TipoUsuarioConfiguracoes.Visible = true;
                Combo_TipoUsuarioConfiguracoes.Visible = true;

                foreach (var item in pesquisarEmail.ConsultarUsuarioPorEmail(Txt_EmailConfiguracoes.Text))
                {
                    idUsuarioLog = item.idUsuario;
                    Txt_UsuarioConfiguracoes.Text = item.nomeUsuario;
                    Combo_FuncaoConfiguracoes.ValueMember = item.funcaoUsuario;
                    Combo_FuncaoConfiguracoes.Text = item.funcaoUsuario;
                    Combo_TipoUsuarioConfiguracoes.ValueMember = item.tipoUsuario;
                    Combo_TipoUsuarioConfiguracoes.Text = item.tipoUsuario;
                }
            }
            else if(resposta == 2)
            {

            }
        }

        private void Link_AlterarUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Txt_EmailConfiguracoes.Text = "";
            Label_EmailConfiguracoes.Visible = true;
            Txt_EmailConfiguracoes.Visible = true;
            Btn_PesquisarEmail.Visible = true;

            Label_UsuarioConfiguracoes.Visible = false;
            Txt_UsuarioConfiguracoes.Visible = false;
            Label_FuncaoConfiguracoes.Visible = false;
            Combo_FuncaoConfiguracoes.Visible = false;
            Label_TipoUsuarioConfiguracoes.Visible = false;
            Combo_TipoUsuarioConfiguracoes.Visible = false;

            resposta = 1;
        }

        private void Btn_CancelarConfiguracoes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Todas as informações não salvas serão perdidas!", "Deseja continuar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void Link_DeletarUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Txt_EmailConfiguracoes.Text = "";
            Label_EmailConfiguracoes.Visible = true;
            Txt_EmailConfiguracoes.Visible = true;
            Btn_PesquisarEmail.Visible = false;

            Label_UsuarioConfiguracoes.Visible = false;
            Txt_UsuarioConfiguracoes.Visible = false;
            Label_FuncaoConfiguracoes.Visible = false;
            Combo_FuncaoConfiguracoes.Visible = false;
            Label_TipoUsuarioConfiguracoes.Visible = false;
            Combo_TipoUsuarioConfiguracoes.Visible = false;

            Txt_UsuarioConfiguracoes.Text = "";
            Combo_FuncaoConfiguracoes.Text = "-- Selecione --";
            Combo_TipoUsuarioConfiguracoes.Text = "-- Selecione --";

            resposta = 2;
        }

        private void FormConfiguracoes_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Btn_SalvarConfiguracoes_Click(object sender, EventArgs e)
        {
            if (resposta == 1)
            {
                if (MessageBox.Show("Deseja realmente salvar?", "Salvar Dados",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    UsuarioController confirmacao = new UsuarioController();
                    confirmacao.AtualizarDadosUsuario(idUsuarioLog, Txt_EmailConfiguracoes.Text, Txt_UsuarioConfiguracoes.Text,
                        Combo_FuncaoConfiguracoes.Text, Combo_TipoUsuarioConfiguracoes.Text);

                    MessageBox.Show("Cadastro atualizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                    return;
            }
            else if (resposta == 2)
            {
                if (MessageBox.Show("Deseja realmente deletar o usuário?", "Confirmar Deleção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    UsuarioController confirmacao = new UsuarioController();
                    confirmacao.DesativarUsuario(idUsuarioLog);

                    MessageBox.Show("Usuário desativado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                    return;
            }
        }
    }
}
