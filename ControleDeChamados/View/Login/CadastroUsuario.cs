using ControleDeChamados.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using System.Net;
using System.Net.Mail;

namespace ControleDeChamados.View.Login
{
    public partial class FormCadastroUsuario : Form
    {
        public FormCadastroUsuario()
        {
            InitializeComponent();
        }

        private bool ValidarPreenchimento()
        {

            if (Txt_Nome.Text == "")
            {
                MessageBox.Show("Nome do usuário está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNome(Txt_Nome.Text) == false)
            {
                MessageBox.Show("Nome do usuário não contém somente letras.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!Txt_Nome.Text.Contains(" "))
            {
                MessageBox.Show("Nome do usuário não contém um sobrenome.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Nome.Text.Length > 50)
            {
                MessageBox.Show("Nome do usuário está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Email.Text == "")
            {
                MessageBox.Show("E-mail está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsEmail(Txt_Email.Text) == false)
            {
                MessageBox.Show("E-mail não está num formato correto.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Email.Text.Length > 100)
            {
                MessageBox.Show("E-mail está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Senha.Text == "")
            {
                MessageBox.Show("Senha do usuário está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Senha.Text.Length > 30)
            {
                MessageBox.Show("Senha do usuário está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Repetir.Text != Txt_Senha.Text)
            {
                MessageBox.Show("As senhas não coincidem.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Funcao.Text == "")
            {
                MessageBox.Show("Função do usuário está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Funcao.Text.Length > 30)
            {
                MessageBox.Show("Função do usuário está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Combo_TipoUsuario.Text == "Tipo")
            {
                MessageBox.Show("Selecione o tipo de usuário.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }            
            return true;
        }

        public static bool IsNome(string strNome)
        {
            for (int i = 0; i < strNome.Length; i++)
            {
                if (!Char.IsLetter(strNome, i) && !Char.IsWhiteSpace(strNome, i))
                    return false;
            }
            return true;
        }

        public static bool IsEmail(string strEmail)
        {
            string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(strEmail, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Btn_CancelarConfiguracoes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Todas as informações não salvas serão perdidas!", "Deseja continuar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private async void Btn_SalvarCadastro_Click(object sender, EventArgs e)
        {
            UsuarioController inserirUsuario = new UsuarioController();

            if (!ValidarPreenchimento())
                return;

            else if (inserirUsuario.ConsultarUsuarioPorEmail(Txt_Email.Text).Count > 0)
            {
                MessageBox.Show("E-mail já está cadastrado para outro usuário!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (inserirUsuario.ConsultarUsuarioPorNome(Txt_Nome.Text).Count > 0)
            {
                MessageBox.Show("Usuário já cadastrado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string usuarioAtivo = "S";
            string usuarioCadastrado = Txt_Nome.Text;
            string emailUsuario = Txt_Email.Text.ToLower();

            inserirUsuario.InserirUsuario(Txt_Nome.Text.Trim(), Txt_Email.Text.Trim().ToLower(), Txt_Senha.Text.Trim(), Combo_TipoUsuario.Text,
                Txt_Funcao.Text.Trim(), usuarioAtivo);

            MessageBox.Show("Cadastro incluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                //Enviar e-mail
                using (SmtpClient smtp = new SmtpClient())
                {
                    using (MailMessage email = new MailMessage())
                    {
                        //Servidor SMTP
                        smtp.Host = "smtp.office365.com";
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential("", "");
                        smtp.Port = 587;
                        smtp.EnableSsl = true;

                        //Mensagem de e-mail
                        email.From = new MailAddress("");
                        email.To.Add(emailUsuario);

                        email.Subject = "Novo usuário cadastrado";
                        email.IsBodyHtml = false;
                        email.Body = "Novo usuário cadastrado no sistema: " + usuarioCadastrado + "! Seja bem-vindo(a)!";

                        //Enviar e-mail
                        smtp.Send(email);
                    }
                }

                //Enviar mensagem no Telegram
                TelegramBotClient telegramBot = new TelegramBotClient("");
                await telegramBot.SendTextMessageAsync("", "Novo usuário cadastrado. Bem-vindo " + usuarioCadastrado + "!", ParseMode.Html);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao enviar o e-mail!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            finally
            {
                this.Close();
            }
        }
        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(127, 0, 255);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            Label_Cadastro.BackColor = Color.FromArgb(153, 50, 205);
            Btn_SalvarCadastro.BackColor = Color.FromArgb(153, 50, 205);
            Btn_SalvarCadastro.FlatAppearance.BorderColor = Color.FromArgb(153, 50, 205);
            Btn_SalvarCadastro.FlatAppearance.CheckedBackColor = Color.FromArgb(153, 50, 205);
            Btn_SalvarCadastro.FlatAppearance.MouseDownBackColor = Color.FromArgb(153, 50, 205);
            Btn_SalvarCadastro.FlatAppearance.MouseOverBackColor = Color.FromArgb(153, 50, 205);
            Btn_CancelarCadastro.BackColor = Color.FromArgb(127, 0, 255);
            Btn_CancelarCadastro.FlatAppearance.BorderColor = Color.FromArgb(127, 0, 255);
            Btn_CancelarCadastro.FlatAppearance.CheckedBackColor = Color.FromArgb(127, 0, 255);
            Btn_CancelarCadastro.FlatAppearance.MouseDownBackColor = Color.FromArgb(127, 0, 255);
            Btn_CancelarCadastro.FlatAppearance.MouseOverBackColor = Color.FromArgb(127, 0, 255);
            Txt_Nome.BackColor = Color.FromArgb(127, 0, 255);
            Txt_Nome.PlaceholderText = "Nome";
            Panel_Nome.BackColor = Color.White;
            Panel_Nome.ForeColor = Color.White;
            Txt_Email.BackColor = Color.FromArgb(127, 0, 255);
            Txt_Email.PlaceholderText = "E-mail";
            Panel_Email.BackColor = Color.White;
            Panel_Email.ForeColor = Color.White;
            Txt_Senha.BackColor = Color.FromArgb(127, 0, 255);
            Txt_Senha.PlaceholderText = "Senha";
            Panel_Senha.BackColor = Color.White;
            Panel_Senha.ForeColor = Color.White;
            Txt_Repetir.BackColor = Color.FromArgb(127, 0, 255);
            Txt_Repetir.PlaceholderText = "Repetir";
            Panel_RepetirSenha.BackColor = Color.White;
            Panel_RepetirSenha.ForeColor = Color.White;
            Txt_Funcao.BackColor = Color.FromArgb(127, 0, 255);
            Txt_Funcao.PlaceholderText = "Função";
            Panel_Funcao.BackColor = Color.White;
            Panel_Funcao.ForeColor = Color.White;
            Combo_TipoUsuario.BackColor = Color.FromArgb(127, 0, 255);
            Combo_TipoUsuario.FlatStyle = FlatStyle.Flat;
            Combo_TipoUsuario.SelectedIndex = 0;
        }

        private void Btn_MostrarSenha_Click(object sender, EventArgs e)
        {
            if (Txt_Senha.UseSystemPasswordChar == true)
                Txt_Senha.UseSystemPasswordChar = false;
            else
                Txt_Senha.UseSystemPasswordChar = true;
        }

        private void Btn_MostrarRepetirSenha_Click(object sender, EventArgs e)
        {
            if (Txt_Repetir.UseSystemPasswordChar == true)
                Txt_Repetir.UseSystemPasswordChar = false;
            else
                Txt_Repetir.UseSystemPasswordChar = true;
        }
    }
}
