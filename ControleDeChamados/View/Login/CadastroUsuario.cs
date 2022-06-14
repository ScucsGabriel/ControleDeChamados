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

            if (Txt_NomeUsuario.Text == "")
            {
                MessageBox.Show("Nome do usuário está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNome(Txt_NomeUsuario.Text) == false)
            {
                MessageBox.Show("Nome do usuário não contém somente letras.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_NomeUsuario.Text.Length > 50)
            {
                MessageBox.Show("Nome do usuário está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EmailUsuario.Text == "")
            {
                MessageBox.Show("E-mail está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsEmail(Txt_EmailUsuario.Text) == false)
            {
                MessageBox.Show("E-mail não está num formato correto.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EmailUsuario.Text.Length > 100)
            {
                MessageBox.Show("E-mail está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_SenhaUsuario.Text == "")
            {
                MessageBox.Show("Senha do usuário está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_SenhaUsuario.Text.Length > 30)
            {
                MessageBox.Show("Senha do usuário está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_RepetirSenhaUsuario.Text != Txt_SenhaUsuario.Text)
            {
                MessageBox.Show("As senhas não coincidem.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Combo_Funcao.Text == "-- Selecione --")
            {
                MessageBox.Show("Selecione a função do usuário.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Combo_TipoUsuario.Text == "-- Selecione --")
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

        private void Btn_MostrarSenhaCadastro_Click(object sender, EventArgs e)
        {
            if (Txt_SenhaUsuario.UseSystemPasswordChar == true)
                Txt_SenhaUsuario.UseSystemPasswordChar = false;
            else
                Txt_SenhaUsuario.UseSystemPasswordChar = true;
        }

        private void Btn_MostrarRepetirSenhaCadastro_Click(object sender, EventArgs e)
        {
            if (Txt_RepetirSenhaUsuario.UseSystemPasswordChar == true)
                Txt_RepetirSenhaUsuario.UseSystemPasswordChar = false;
            else
                Txt_RepetirSenhaUsuario.UseSystemPasswordChar = true;
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

            else if (inserirUsuario.ConsultarUsuarioPorEmail(Txt_EmailUsuario.Text).Count > 0)
            {
                MessageBox.Show("E-mail já está cadastrado para outro usuário!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (inserirUsuario.ConsultarUsuarioPorNome(Txt_NomeUsuario.Text).Count > 0)
            {
                MessageBox.Show("Usuário já cadastrado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string usuarioAtivo = "S";
            string usuarioCadastrado = Txt_NomeUsuario.Text;
            string emailUsuario = Txt_EmailUsuario.Text.ToLower();

            inserirUsuario.InserirUsuario(Txt_NomeUsuario.Text.Trim(), Txt_EmailUsuario.Text.Trim().ToLower(), Txt_SenhaUsuario.Text.Trim(), Combo_TipoUsuario.Text,
                Combo_Funcao.Text, usuarioAtivo);

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
                await telegramBot.SendTextMessageAsync("-617447420", "Novo usuário cadastrado. Bem-vindo " + usuarioCadastrado + "!", ParseMode.Html);
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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
