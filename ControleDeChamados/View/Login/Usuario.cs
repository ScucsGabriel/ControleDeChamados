using ControleDeChamados.Controller;
using ControleDeChamados.View.Principal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace ControleDeChamados.View.Login
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void Link_NovoUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCadastroUsuario formCadastrarUsuario = new FormCadastroUsuario();
            formCadastrarUsuario.ShowDialog();
        }

        private void Link_EsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormEsqueciSenha formEsqueciSenha = new FormEsqueciSenha();
            formEsqueciSenha.ShowDialog();
        }

        private async void Link_Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FazerLogin();
            
        }
        private void FormUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Txt_SenhaLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                FazerLogin();
        }

        public async void FazerLogin()
        {
            UsuarioController buscasUsuario = new UsuarioController();
            int resultadoBusca = buscasUsuario.ConsultarUsuarioPorEmail(Txt_UsuarioLogin.Text.ToLower()).Count;
            int idUsuario = 0;
            string senha = buscasUsuario.ConsultarSenhaUsuario(Txt_UsuarioLogin.Text.ToLower());
            string usuarioAtivo = buscasUsuario.ConsultarSenhaUsuario(Txt_UsuarioLogin.Text.ToLower());
            string nomeUsuario = "", tipoUsuario = "";

            if (resultadoBusca == 0)
            {
                MessageBox.Show("Usuário não encontrado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else if (Txt_SenhaLogin.Text != senha)
            {
                MessageBox.Show("A senha está errada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (usuarioAtivo == "N")
            {
                MessageBox.Show("Usuário desativado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                foreach (var item in buscasUsuario.ConsultarUsuarioPorEmail(Txt_UsuarioLogin.Text.ToLower()))
                {
                    nomeUsuario = item.nomeUsuario;
                    idUsuario = item.idUsuario;
                    tipoUsuario = item.tipoUsuario;
                }
            }

            MessageBox.Show("Bem-Vindo(a), " + nomeUsuario + "!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TelegramBotClient telegramBot = new TelegramBotClient("5543170318:AAHoRt1BT45l-OzZmzZf3I12-j_XIC0uZJY");
            await telegramBot.SendTextMessageAsync("-617447420", nomeUsuario + " efetuou login", ParseMode.Html);

            this.Hide();

            FormPrincipal formPrincipal = new FormPrincipal(idUsuario, tipoUsuario);
            formPrincipal.ShowDialog();
        }

        private void Btn_MostrarSenha_Click(object sender, EventArgs e)
        {
            if (Txt_SenhaLogin.UseSystemPasswordChar == true)
                Txt_SenhaLogin.UseSystemPasswordChar = false;
            else
                Txt_SenhaLogin.UseSystemPasswordChar = true;
        }
    }
}
