using ControleDeChamados.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace ControleDeChamados.View.Login
{
    public partial class FormEsqueciSenha : Form
    {
        public FormEsqueciSenha()
        {
            InitializeComponent();
        }

        private void Btn_CancelarConfiguracoes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ResetarSenha_Click(object sender, EventArgs e)
        {
            UsuarioController buscasUsuario = new UsuarioController();
            int resultadoBusca = buscasUsuario.ConsultarUsuarioPorEmail(Txt_UsuarioEsqueciSenha.Text.ToLower()).Count;
            int idUsuario = 0;
            string senhaNova = "";

            if (resultadoBusca == 0)
            {
                MessageBox.Show("Usuário não encontrado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else
            {
                foreach (var item in buscasUsuario.ConsultarUsuarioPorEmail(Txt_UsuarioEsqueciSenha.Text.ToLower()))
                {
                    idUsuario = item.idUsuario;
                    senhaNova = item.nomeUsuario.ToLower().Substring(0, item.nomeUsuario.IndexOf(' ')).Trim();
                }

                Random rand = new Random();
                senhaNova = String.Concat(senhaNova, rand.Next(1000, 2000).ToString());
                buscasUsuario.AtualizarSenha(idUsuario, senhaNova);

                //Enviar e-mail com a senha
                try
                {
                    using (SmtpClient smtp = new SmtpClient())
                    {
                        using (MailMessage email = new MailMessage())
                        {
                            //Servidor SMTP
                            smtp.Host = "smtp.office365.com";
                            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                            smtp.UseDefaultCredentials = false;
                            smtp.Credentials = new NetworkCredential("equipe.suporte.chamados@hotmail.com", "Suporte123");
                            smtp.Port = 587;
                            smtp.EnableSsl = true;

                            //Mensagem de e-mail
                            email.From = new MailAddress("equipe.suporte.chamados@hotmail.com");
                            email.To.Add(Txt_UsuarioEsqueciSenha.Text.ToLower());

                            email.Subject = "Nova senha";
                            email.IsBodyHtml = false;
                            email.Body = "Reset de senha realizado com sucesso! Sua nova senha é: " + senhaNova + ".\n" +
                                          "Não se esqueça de trocar a senha após o primeiro acesso!\n\n" +
                                          "Atenciosamente,\n\n" +
                                          "Equipe de Suporte Técnico.\n" +
                                          "equipe.suporte.chamados@hotmail.com\n" +
                                          "É um prazer atendê-los!";

                            //Enviar e-mail
                            smtp.Send(email);
                        }
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao enviar o e-mail!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                finally
                {
                    MessageBox.Show("Sua nova senha foi enviada para o e-mail " + Txt_UsuarioEsqueciSenha.Text.ToLower(), "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void FormEsqueciSenha_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
