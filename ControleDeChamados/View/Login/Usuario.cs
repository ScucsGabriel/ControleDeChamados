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
            this.BackColor = Color.FromArgb(127, 0, 255);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            Label_Login.BackColor = Color.FromArgb(153, 50, 205);
            Btn_Login.BackColor = Color.FromArgb(153, 50, 205);
            Btn_Login.FlatAppearance.BorderColor = Color.FromArgb(153, 50, 205);
            Btn_Login.FlatAppearance.CheckedBackColor = Color.FromArgb(153, 50, 205);
            Btn_Login.FlatAppearance.MouseDownBackColor = Color.FromArgb(153, 50, 205);
            Btn_Login.FlatAppearance.MouseOverBackColor = Color.FromArgb(153, 50, 205);
            Btn_NovoUsuario.BackColor = Color.FromArgb(153, 50, 205);
            Btn_NovoUsuario.FlatAppearance.BorderColor = Color.FromArgb(153, 50, 205);
            Btn_NovoUsuario.FlatAppearance.CheckedBackColor = Color.FromArgb(153, 50, 205);
            Btn_NovoUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(153, 50, 205);
            Btn_NovoUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(153, 50, 205);
            Btn_NovaSenha.BackColor = Color.FromArgb(153, 50, 205);
            Btn_NovaSenha.FlatAppearance.BorderColor = Color.FromArgb(153, 50, 205);
            Btn_NovaSenha.FlatAppearance.CheckedBackColor = Color.FromArgb(153, 50, 205);
            Btn_NovaSenha.FlatAppearance.MouseDownBackColor = Color.FromArgb(153, 50, 205);
            Btn_NovaSenha.FlatAppearance.MouseOverBackColor = Color.FromArgb(153, 50, 205);
            Btn_Sair.BackColor = Color.FromArgb(127, 0, 255);
            Btn_Sair.FlatAppearance.BorderColor = Color.FromArgb(127, 0, 255);
            Btn_Sair.FlatAppearance.CheckedBackColor = Color.FromArgb(127, 0, 255);
            Btn_Sair.FlatAppearance.MouseDownBackColor = Color.FromArgb(127, 0, 255);
            Btn_Sair.FlatAppearance.MouseOverBackColor = Color.FromArgb(127, 0, 255);
            Pic_Usuario.BackColor = Color.FromArgb(127, 0, 255);
            Txt_UsuarioLogin.BackColor = Color.FromArgb(127, 0, 255);
            Txt_UsuarioLogin.PlaceholderText = "Usuário";
            Panel_Usuario.BackColor = Color.White;
            Panel_Usuario.ForeColor = Color.White;
            Pic_Senha.BackColor = Color.FromArgb(127, 0, 255);
            Txt_SenhaLogin.BackColor = Color.FromArgb(127, 0, 255);
            Txt_SenhaLogin.PlaceholderText = "Senha";
            Panel_Senha.BackColor = Color.White;
            Panel_Senha.ForeColor = Color.White;
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

            TelegramBotClient telegramBot = new TelegramBotClient("");
            await telegramBot.SendTextMessageAsync("", nomeUsuario + " efetuou login", ParseMode.Html);

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

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            FazerLogin();
        }

        private void Btn_NovoUsuario_Click(object sender, EventArgs e)
        {
            FormCadastroUsuario formCadastrarUsuario = new FormCadastroUsuario();
            formCadastrarUsuario.ShowDialog();
        }

        private void Btn_NovaSenha_Click(object sender, EventArgs e)
        {
            FormEsqueciSenha formEsqueciSenha = new FormEsqueciSenha();
            formEsqueciSenha.ShowDialog();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
