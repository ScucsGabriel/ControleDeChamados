using ControleDeChamados.Controller;
using ControleDeChamados.View.Login;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.util;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace ControleDeChamados
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        public static TelegramBotClient botClient = new TelegramBotClient("");
        [STAThread]
        static void Main()
        {
            botClient.OnMessage += BotClient_OnMessage;
            botClient.StartReceiving();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormUsuario());
        }

        private static void BotClient_OnMessage(object sender, MessageEventArgs e)
        {
            long chatId = e.Message.Chat.Id;
            var respostas = e.Message.Text;
            
            switch (respostas)
            {
                case "oi":
                case "bom dia":
                case "boa tarde":
                case "boa noite":

                    botClient.SendTextMessageAsync(chatId, "Ol�, " + e.Message.From.FirstName + "! \nDigite uma op��o:" +
                        "\n\n <b>1 - Cadastrar Usu�rio</b> \n <b>2 - Abrir Chamado</b> \n <b>3 - Consultar Chamado</b> \n <b>4 - Resetar Senha</b> \n <b>5 - Sair</b>",
                        Telegram.Bot.Types.Enums.ParseMode.Html);
                    break;

                case "1":
                case "Cadastrar Usu�rio":
                case "1 - Cadastrar Usu�rio":

                    botClient.SendTextMessageAsync(chatId, "Preencha os campos abaixo: \n\n" +
                        "<b>Nome do Usu�rio:</b>\n<b>E-mail do Usu�rio:</b>\n<b>Senha:</b>\n<b>Repita a Senha:</b>\n<b>Fun��o:</b>",
                        Telegram.Bot.Types.Enums.ParseMode.Html);
                    break;

                case "2":
                case "Abrir Chamado":
                case "2 - Abrir Chamado":

                    botClient.SendTextMessageAsync(chatId, "Preencha os campos abaixo: \n\n" +
                        "<b>E-mail do Usu�rio:</b>\n<b>Categoria:</b>\n<b>Subcategoria:</b>\n<b>Item:</b>\n" +
                        "<b>VIP:</b>\n<b>Urg�ncia:</b>\n<b>Prioridade:</b>\n<b>T�tulo:</b>\n<b>Descri��o:</b>\n",
                        Telegram.Bot.Types.Enums.ParseMode.Html);
                    break;

                case "3":
                case "Consultar Chamado":
                case "3 - Consultar Chamado":

                    botClient.SendTextMessageAsync(chatId, "<b>Digite o n�mero do chamado:</b>", Telegram.Bot.Types.Enums.ParseMode.Html);
                    break;

                case "4":
                case "Resetar Senha":
                case "4 - Resetar Senha":

                    botClient.SendTextMessageAsync(chatId, "<b>Digite o usu�rio:</b>", Telegram.Bot.Types.Enums.ParseMode.Html);
                    break;

                case "5":
                case "Sair":
                case "5 - Sair":
                    botClient.SendTextMessageAsync(chatId, "<b>Obrigado e at� a pr�xima!</b>", Telegram.Bot.Types.Enums.ParseMode.Html);
                    break;
            }

            if (respostas.Contains("Nome do Usu�rio") && respostas.StartsWith("Nome"))
            {
                UsuarioController novoUsuario = new UsuarioController();
                string nomeUsuario = "", emailUsuario = "", senha = "", repetirSenha = "", funcao = "", tipoUsuario = "Comum", usuarioAtivo = "S";
                string[] teste = respostas.Replace("Nome do Usu�rio", "").
                    Replace("E-mail do Usu�rio", "").Replace("Senha", "").Replace("Repita a Senha", "").Replace("Fun��o", "").Split(":");

                nomeUsuario = teste[1].Replace("\n", "").Trim();
                emailUsuario = teste[2].Replace("\n", "").Trim();
                senha = teste[3].Replace("\n Repita a", "").Trim();
                repetirSenha = teste[4].Replace("\n", "").Trim();
                funcao = teste[5].Trim();

                if (!ValidarPreenchimento(chatId, nomeUsuario, emailUsuario, senha, repetirSenha, funcao))
                    return;

                else if (novoUsuario.ConsultarUsuarioPorEmail(emailUsuario).Count > 0)
                {
                    botClient.SendTextMessageAsync(chatId, "E-mail j� est� cadastrado para outro usu�rio!", Telegram.Bot.Types.Enums.ParseMode.Html);
                    return;
                }
                else if (novoUsuario.ConsultarUsuarioPorNome(nomeUsuario).Count > 0)
                {
                    botClient.SendTextMessageAsync(chatId, "Usu�rio j� cadastrado!", Telegram.Bot.Types.Enums.ParseMode.Html);
                    return;
                }
                else
                {
                    novoUsuario.InserirUsuario(nomeUsuario, emailUsuario, senha, tipoUsuario, funcao, usuarioAtivo);
                    botClient.SendTextMessageAsync(chatId, "Cadastro inclu�do com sucesso!", Telegram.Bot.Types.Enums.ParseMode.Html);

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
                                smtp.Credentials = new NetworkCredential("suporte.centralchamados@hotmail.com", "Suporte123");
                                smtp.Port = 587;
                                smtp.EnableSsl = true;

                                //Mensagem de e-mail
                                email.From = new MailAddress("suporte.centralchamados@hotmail.com");
                                email.To.Add(emailUsuario);

                                email.Subject = "Novo usu�rio cadastrado";
                                email.IsBodyHtml = false;
                                email.Body = "Novo usu�rio cadastrado no sistema: " + nomeUsuario + "! Seja bem-vindo(a)!";

                                //Enviar e-mail
                                smtp.Send(email);
                            }
                        }
                    }
                    catch (Exception erro)
                    {
                        botClient.SendTextMessageAsync(chatId, "Erro ao enviar e-mail!", Telegram.Bot.Types.Enums.ParseMode.Html);
                        return;
                    }
                    finally
                    {
                        botClient.SendTextMessageAsync(chatId, "Novo usu�rio cadastrado! Bem-vindo " + nomeUsuario + "!", Telegram.Bot.Types.Enums.ParseMode.Html);
                    }
                }
            }
            if (respostas.Contains("@"))
            {
                if (!IsEmail(respostas))
                {
                    botClient.SendTextMessageAsync(chatId, "<b>E-mail n�o estava em um formato correto!</b>", Telegram.Bot.Types.Enums.ParseMode.Html);
                    return;
                }

                UsuarioController resetarSenha = new UsuarioController();
                int resultadoBusca = resetarSenha.ConsultarUsuarioPorEmail(respostas.ToLower()).Count;
                int idUsuario = 0;
                string senhaNova = "";

                if (resultadoBusca == 0)
                {
                    botClient.SendTextMessageAsync(chatId, "<b>Usu�rio n�o encontrado!</b>", Telegram.Bot.Types.Enums.ParseMode.Html);
                    return;
                }

                else
                {
                    foreach (var item in resetarSenha.ConsultarUsuarioPorEmail(respostas.ToLower()))
                    {
                        idUsuario = item.idUsuario;
                        senhaNova = item.nomeUsuario.ToLower().Substring(0, item.nomeUsuario.IndexOf(' ')).Trim();
                    }

                    Random rand = new Random();
                    senhaNova = String.Concat(senhaNova, rand.Next(1000, 2000).ToString());
                    resetarSenha.AtualizarSenha(idUsuario, senhaNova);

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
                                smtp.Credentials = new NetworkCredential("suporte.centralchamados@hotmail.com", "Suporte123");
                                smtp.Port = 587;
                                smtp.EnableSsl = true;

                                //Mensagem de e-mail
                                email.From = new MailAddress("suporte.centralchamados@hotmail.com");
                                email.To.Add(respostas.ToLower());

                                email.Subject = "Nova senha";
                                email.IsBodyHtml = false;
                                email.Body = "Reset de senha realizado com sucesso! Sua nova senha �: " + senhaNova + ".\n" +
                                              "N�o se esque�a de trocar a senha ap�s o primeiro acesso!\n\n" +
                                              "Atenciosamente,\n\n" +
                                              "Equipe de Suporte T�cnico.\n" +
                                              "suporte.centralchamados@hotmail.com\n" +
                                              "� um prazer atend�-los!";

                                //Enviar e-mail
                                smtp.Send(email);
                            }
                        }
                    }
                    catch (Exception erro)
                    {
                        botClient.SendTextMessageAsync(chatId, "<b>Erro ao enviar e-mail!</b>", Telegram.Bot.Types.Enums.ParseMode.Html);
                        return;
                    }
                    finally
                    {
                        botClient.SendTextMessageAsync(chatId, "A nova senha foi enviada para o e-mail registrado, " + e.Message.From.FirstName, Telegram.Bot.Types.Enums.ParseMode.Html);
                    }
                }
            }
        }

        private static bool ValidarPreenchimento(long chatId, string nomeUsuario, string emailUsuario, string senha, string repetirSenha, string funcao)
        {

            if (nomeUsuario == "")
            {
                botClient.SendTextMessageAsync(chatId, "Nome do usu�rio est� vazio!", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (IsNome(nomeUsuario) == false)
            {
                botClient.SendTextMessageAsync(chatId, "Nome do usu�rio n�o cont�m somente letras.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (nomeUsuario.Length > 50)
            {
                botClient.SendTextMessageAsync(chatId, "Nome do usu�rio est� muito grande.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (emailUsuario == "")
            {
                botClient.SendTextMessageAsync(chatId, "E-mail est� vazio.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (IsEmail(emailUsuario) == false)
            {
                botClient.SendTextMessageAsync(chatId, "E-mail n�o est� num formato correto.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (emailUsuario.Length > 100)
            {
                botClient.SendTextMessageAsync(chatId, "E-mail est� muito grande.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (senha == "")
            {
                botClient.SendTextMessageAsync(chatId, "Senha do usu�rio est� vazia.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (senha.Length > 30)
            {
                botClient.SendTextMessageAsync(chatId, "Senha do usu�rio est� muito grande.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (repetirSenha != senha)
            {
                botClient.SendTextMessageAsync(chatId, "As senhas n�o coincidem.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (funcao == "")
            {
                botClient.SendTextMessageAsync(chatId, "Fun��o do usu�rio est� vazia.", Telegram.Bot.Types.Enums.ParseMode.Html);
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
                return true;
            else
                return false;
        }
    }
}

