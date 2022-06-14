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

                    botClient.SendTextMessageAsync(chatId, "Olá, " + e.Message.From.FirstName + "! \nDigite uma opção:" +
                        "\n\n <b>1 - Cadastrar Usuário</b> \n <b>2 - Abrir Chamado</b> \n <b>3 - Consultar Chamado</b> \n <b>4 - Resetar Senha</b> \n <b>5 - Sair</b>",
                        Telegram.Bot.Types.Enums.ParseMode.Html);
                    break;

                case "1":
                case "Cadastrar Usuário":
                case "1 - Cadastrar Usuário":

                    botClient.SendTextMessageAsync(chatId, "Preencha os campos abaixo: \n\n" +
                        "<b>Nome do Usuário:</b>\n<b>E-mail do Usuário:</b>\n<b>Senha:</b>\n<b>Repita a Senha:</b>\n<b>Função:</b>",
                        Telegram.Bot.Types.Enums.ParseMode.Html);
                    break;

                case "2":
                case "Abrir Chamado":
                case "2 - Abrir Chamado":

                    botClient.SendTextMessageAsync(chatId, "Preencha os campos abaixo: \n\n" +
                        "<b>E-mail do Usuário:</b>\n<b>Categoria:</b>\n<b>Subcategoria:</b>\n<b>Item:</b>\n" +
                        "<b>VIP:</b>\n<b>Urgência:</b>\n<b>Prioridade:</b>\n<b>Título:</b>\n<b>Descrição:</b>\n",
                        Telegram.Bot.Types.Enums.ParseMode.Html);
                    break;

                case "3":
                case "Consultar Chamado":
                case "3 - Consultar Chamado":

                    botClient.SendTextMessageAsync(chatId, "<b>Digite o número do chamado:</b>", Telegram.Bot.Types.Enums.ParseMode.Html);
                    break;

                case "4":
                case "Resetar Senha":
                case "4 - Resetar Senha":

                    botClient.SendTextMessageAsync(chatId, "<b>Digite o usuário:</b>", Telegram.Bot.Types.Enums.ParseMode.Html);
                    break;

                case "5":
                case "Sair":
                case "5 - Sair":
                    botClient.SendTextMessageAsync(chatId, "<b>Obrigado e até a próxima!</b>", Telegram.Bot.Types.Enums.ParseMode.Html);
                    break;
            }

            if (respostas.Contains("Nome do Usuário") && respostas.StartsWith("Nome"))
            {
                UsuarioController novoUsuario = new UsuarioController();
                string nomeUsuario = "", emailUsuario = "", senha = "", repetirSenha = "", funcao = "", tipoUsuario = "Comum", usuarioAtivo = "S";
                string[] teste = respostas.Replace("Nome do Usuário", "").
                    Replace("E-mail do Usuário", "").Replace("Senha", "").Replace("Repita a Senha", "").Replace("Função", "").Split(":");

                nomeUsuario = teste[1].Replace("\n", "").Trim();
                emailUsuario = teste[2].Replace("\n", "").Trim();
                senha = teste[3].Replace("\n Repita a", "").Trim();
                repetirSenha = teste[4].Replace("\n", "").Trim();
                funcao = teste[5].Trim();

                if (!ValidarPreenchimento(chatId, nomeUsuario, emailUsuario, senha, repetirSenha, funcao))
                    return;

                else if (novoUsuario.ConsultarUsuarioPorEmail(emailUsuario).Count > 0)
                {
                    botClient.SendTextMessageAsync(chatId, "E-mail já está cadastrado para outro usuário!", Telegram.Bot.Types.Enums.ParseMode.Html);
                    return;
                }
                else if (novoUsuario.ConsultarUsuarioPorNome(nomeUsuario).Count > 0)
                {
                    botClient.SendTextMessageAsync(chatId, "Usuário já cadastrado!", Telegram.Bot.Types.Enums.ParseMode.Html);
                    return;
                }
                else
                {
                    novoUsuario.InserirUsuario(nomeUsuario, emailUsuario, senha, tipoUsuario, funcao, usuarioAtivo);
                    botClient.SendTextMessageAsync(chatId, "Cadastro incluído com sucesso!", Telegram.Bot.Types.Enums.ParseMode.Html);

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

                                email.Subject = "Novo usuário cadastrado";
                                email.IsBodyHtml = false;
                                email.Body = "Novo usuário cadastrado no sistema: " + nomeUsuario + "! Seja bem-vindo(a)!";

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
                        botClient.SendTextMessageAsync(chatId, "Novo usuário cadastrado! Bem-vindo " + nomeUsuario + "!", Telegram.Bot.Types.Enums.ParseMode.Html);
                    }
                }
            }
            if (respostas.Contains("@"))
            {
                if (!IsEmail(respostas))
                {
                    botClient.SendTextMessageAsync(chatId, "<b>E-mail não estava em um formato correto!</b>", Telegram.Bot.Types.Enums.ParseMode.Html);
                    return;
                }

                UsuarioController resetarSenha = new UsuarioController();
                int resultadoBusca = resetarSenha.ConsultarUsuarioPorEmail(respostas.ToLower()).Count;
                int idUsuario = 0;
                string senhaNova = "";

                if (resultadoBusca == 0)
                {
                    botClient.SendTextMessageAsync(chatId, "<b>Usuário não encontrado!</b>", Telegram.Bot.Types.Enums.ParseMode.Html);
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
                                email.Body = "Reset de senha realizado com sucesso! Sua nova senha é: " + senhaNova + ".\n" +
                                              "Não se esqueça de trocar a senha após o primeiro acesso!\n\n" +
                                              "Atenciosamente,\n\n" +
                                              "Equipe de Suporte Técnico.\n" +
                                              "suporte.centralchamados@hotmail.com\n" +
                                              "É um prazer atendê-los!";

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
                botClient.SendTextMessageAsync(chatId, "Nome do usuário está vazio!", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (IsNome(nomeUsuario) == false)
            {
                botClient.SendTextMessageAsync(chatId, "Nome do usuário não contém somente letras.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (nomeUsuario.Length > 50)
            {
                botClient.SendTextMessageAsync(chatId, "Nome do usuário está muito grande.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (emailUsuario == "")
            {
                botClient.SendTextMessageAsync(chatId, "E-mail está vazio.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (IsEmail(emailUsuario) == false)
            {
                botClient.SendTextMessageAsync(chatId, "E-mail não está num formato correto.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (emailUsuario.Length > 100)
            {
                botClient.SendTextMessageAsync(chatId, "E-mail está muito grande.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (senha == "")
            {
                botClient.SendTextMessageAsync(chatId, "Senha do usuário está vazia.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (senha.Length > 30)
            {
                botClient.SendTextMessageAsync(chatId, "Senha do usuário está muito grande.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (repetirSenha != senha)
            {
                botClient.SendTextMessageAsync(chatId, "As senhas não coincidem.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (funcao == "")
            {
                botClient.SendTextMessageAsync(chatId, "Função do usuário está vazia.", Telegram.Bot.Types.Enums.ParseMode.Html);
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

