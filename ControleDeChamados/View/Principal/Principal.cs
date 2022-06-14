using ControleDeChamados.View.Chamados;
using ControleDeChamados.View.Login;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace ControleDeChamados.View.Principal
{
    public partial class FormPrincipal : Form
    {
        int idUsuarioLogado = 0;
        string tipoUsuarioLogado = "";
        public FormPrincipal(int idUsuario, string tipoUsuario)
        {
            InitializeComponent();
            idUsuarioLogado = idUsuario;
            tipoUsuarioLogado = tipoUsuario;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Btn_TotalChamados_Click(object sender, EventArgs e)
        {
            FormChamados formChamados = new FormChamados();
            formChamados.ShowDialog();
        }

        private void Link_Configurações_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tipoUsuarioLogado == "Comum")
            {
                MessageBox.Show("Você não tem privilégios suficientes para acessar o painel de configurações. Contate um Administrador.",
                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else 
            {
                FormConfiguracoes formConfiguracoes = new FormConfiguracoes(idUsuarioLogado);
                formConfiguracoes.ShowDialog();
            }
        }

        private void Link_Sair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            this.Hide();

            FormUsuario formUsuario = new FormUsuario();
            formUsuario.ShowDialog();
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Link_AbrirChamado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAbrirChamado formAbrirChamado = new FormAbrirChamado(idUsuarioLogado);
            formAbrirChamado.ShowDialog();
        }

        private void Link_TrocarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormTrocarSenha formTrocarSenha = new FormTrocarSenha(idUsuarioLogado);
            formTrocarSenha.ShowDialog();
        }
    }
}
