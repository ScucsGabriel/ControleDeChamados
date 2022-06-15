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

        public static TelegramBotClient botClient = new TelegramBotClient("5543170318:AAHoRt1BT45l-OzZmzZf3I12-j_XIC0uZJY");
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

        private static async void BotClient_OnMessage(object sender, MessageEventArgs e)
        {
            long chatId = e.Message.Chat.Id;
            string respostas = e.Message.Text;
            string menu = "";

            switch (respostas)
            {
                case "oi":
                case "bom dia":
                case "boa tarde":
                case "boa noite":

                    await botClient.SendTextMessageAsync(chatId, "Olá, " + e.Message.From.FirstName + "! \nDigite uma opção:" +
                        "\n\n <b>1 - Cadastrar Usuário</b> \n <b>2 - Abrir Chamado</b> \n <b>3 - Consultar Chamado</b> \n <b>4 - Resetar Senha</b> \n <b>5 - Sair</b>",
                        Telegram.Bot.Types.Enums.ParseMode.Html);
                    break;

                case "1":
                case "Cadastrar Usuário":
                case "1 - Cadastrar Usuário":

                    await botClient.SendTextMessageAsync(chatId, "Preencha os campos abaixo: \n\n" +
                        "<b>Nome do Usuário: </b>\n<b>E-mail do Usuário: </b>\n<b>Senha: </b>\n<b>Repita a Senha: </b>\n<b>Função: </b>",
                        Telegram.Bot.Types.Enums.ParseMode.Html);
                    menu = "S";
                    break;

                case "2":
                case "Abrir Chamado":
                case "2 - Abrir Chamado":

                    await botClient.SendTextMessageAsync(chatId, "Preencha os campos abaixo: \n\n" +
                        "<b>E-mail do Usuário: </b>\n<b>Categoria: </b>\n<b>Subcategoria: </b>\n<b>Item: </b>\n" +
                        "<b>VIP: </b>\n<b>Urgência: </b>\n<b>Prioridade: </b>\n<b>Título: </b>\n<b>Descrição: </b>\n",
                        Telegram.Bot.Types.Enums.ParseMode.Html);
                    menu = "S";
                    break;

                case "3":
                case "Consultar Chamado":
                case "3 - Consultar Chamado":

                    await botClient.SendTextMessageAsync(chatId, "<b>Digite o número do chamado: </b>", Telegram.Bot.Types.Enums.ParseMode.Html);
                    menu = "S";
                    break;

                case "4":
                case "Resetar Senha":
                case "4 - Resetar Senha":

                    await botClient.SendTextMessageAsync(chatId, "<b>Digite o usuário: </b>", Telegram.Bot.Types.Enums.ParseMode.Html);
                    menu = "S";
                    break;

                case "5":
                case "Sair":
                case "5 - Sair":
                    await botClient.SendTextMessageAsync(chatId, "<b>Obrigado e até a próxima!</b>", Telegram.Bot.Types.Enums.ParseMode.Html);
                    menu = "S";
                    break;
            }

            if (respostas == null)
                return;
            else
            {
                
                if (respostas.Contains("Nome do Usuário") && respostas.StartsWith("Nome"))
                {
                    UsuarioController novoUsuario = new UsuarioController();
                    string nomeUsuario = "", emailUsuario = "", senha = "", repetirSenha = "", funcao = "", tipoUsuario = "Comum", usuarioAtivo = "S";
                    string[] separador = respostas.Replace("Nome do Usuário", "").
                        Replace("E-mail do Usuário", "").Replace("Senha", "").Replace("Repita a Senha", "").Replace("Função", "").Split(":");

                    nomeUsuario = separador[1].Replace("\n", "").Trim();
                    emailUsuario = separador[2].Replace("\n", "").Trim();
                    senha = separador[3].Replace("\nRepita a", "").Trim();
                    repetirSenha = separador[4].Replace("\n", "").Trim();
                    funcao = separador[5].Trim();

                    if (!ValidarPreenchimento(chatId, nomeUsuario, emailUsuario, senha, repetirSenha, funcao))
                         return;

                        else if (novoUsuario.ConsultarUsuarioPorEmail(emailUsuario).Count > 0)
                        {
                            await botClient.SendTextMessageAsync(chatId, "E-mail já está cadastrado para outro usuário!", Telegram.Bot.Types.Enums.ParseMode.Html);
                            return;
                        }
                        else if (novoUsuario.ConsultarUsuarioPorNome(nomeUsuario).Count > 0)
                        {
                            await botClient.SendTextMessageAsync(chatId, "Usuário já cadastrado!", Telegram.Bot.Types.Enums.ParseMode.Html);
                            return;
                        }
                        else
                        {
                            novoUsuario.InserirUsuario(nomeUsuario, emailUsuario, senha, tipoUsuario, funcao, usuarioAtivo);
                            await botClient.SendTextMessageAsync(chatId, "Cadastro incluído com sucesso!", Telegram.Bot.Types.Enums.ParseMode.Html);

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
                                        smtp.Credentials = new NetworkCredential("equipe.suporte.chamados@hotmail.com", "Suporte123");
                                        smtp.Port = 587;
                                        smtp.EnableSsl = true;

                                        //Mensagem de e-mail
                                        email.From = new MailAddress("equipe.suporte.chamados@hotmail.com");
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
                                await botClient.SendTextMessageAsync(chatId, "Erro ao enviar e-mail!", Telegram.Bot.Types.Enums.ParseMode.Html);
                                return;
                            }
                            finally
                            {
                                await botClient.SendTextMessageAsync(chatId, "Novo usuário cadastrado! Bem-vindo " + nomeUsuario + "!", Telegram.Bot.Types.Enums.ParseMode.Html);
                            }
                        }
                }
                if (respostas.Contains("@") && (respostas.EndsWith("com") || respostas.EndsWith("br")))
                {
                    if (!IsEmail(respostas))
                    {
                        await botClient.SendTextMessageAsync(chatId, "<b>E-mail não estava em um formato correto!</b>", Telegram.Bot.Types.Enums.ParseMode.Html);
                        return;
                    }

                    UsuarioController resetarSenha = new UsuarioController();
                    int resultadoBusca = resetarSenha.ConsultarUsuarioPorEmail(respostas.ToLower()).Count;
                    int idUsuario = 0;
                    string senhaNova = "";

                    if (resultadoBusca == 0)
                    {
                        await botClient.SendTextMessageAsync(chatId, "<b>Usuário não encontrado!</b>", Telegram.Bot.Types.Enums.ParseMode.Html);
                        return;
                    }

                    else
                    {
                        foreach (var item in resetarSenha.ConsultarUsuarioPorEmail(respostas.ToLower()))
                        {
                            idUsuario = item.idUsuario;
                            senhaNova = item.nomeUsuario.ToLower().Substring(0, item.nomeUsuario.IndexOf(' ') - 1);
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
                                    smtp.Credentials = new NetworkCredential("equipe.suporte.chamados@hotmail.com", "Suporte123");
                                    smtp.Port = 587;
                                    smtp.EnableSsl = true;

                                    //Mensagem de e-mail
                                    email.From = new MailAddress("equipe.suporte.chamados@hotmail.com");
                                    email.To.Add(respostas.ToLower());

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
                            await botClient.SendTextMessageAsync(chatId, "A nova senha foi enviada para o e-mail registrado, " + e.Message.From.FirstName, Telegram.Bot.Types.Enums.ParseMode.Html);
                        }
                        catch (Exception erro)
                        {
                            await botClient.SendTextMessageAsync(chatId, "<b>Erro ao enviar e-mail!</b>", Telegram.Bot.Types.Enums.ParseMode.Html);
                            return;
                        }
                        finally
                        {
                        }
                    }
                }
                if (respostas.Contains("E-mail do Usuário") && respostas.StartsWith("E-mail"))
                {
                    int idChamadoUsuario = 0;
                    string nomeUsuario = "", numeroChamado = "", aprovacao = "", statusChamado = "";
                    DateTime dataAbertura, entregaEstimada;
                    string emailUsuario = "", categoria = "", subCategoria = "", item = "", vip = "", urgencia = "", prioridade = "", titulo = "", descricao = "";
                    string[] separador = respostas.Replace("E-mail do Usuário", "").
                        Replace("Categoria", "").Replace("Subcategoria", "").Replace("Item", "").Replace("VIP", "").Replace("Urgência", "")
                        .Replace("Prioridade", "").Replace("Título", "").Replace("Descrição", "").Split(":");

                    emailUsuario = separador[1].Replace("\n", "").Trim();
                    categoria = separador[2].Replace("\n", "").Trim();
                    subCategoria = separador[3].Replace("\n", "").Trim();
                    item = separador[4].Replace("\n", "").Trim();
                    vip = separador[5].Replace("\n", "").Trim();
                    urgencia = separador[6].Replace("\n", "").Trim();
                    prioridade = separador[7].Replace("\n", "").Trim();
                    titulo = separador[8].Replace("\n", "").Trim();
                    descricao = separador[9].Replace("\n", "").Trim();

                    if (!IsEmail(emailUsuario))
                    {
                        await botClient.SendTextMessageAsync(chatId, "<b>E-mail não estava num formato correto!</b>", Telegram.Bot.Types.Enums.ParseMode.Html);
                        return;
                    }
                    else if (!ValidarPreenchimento(chatId, emailUsuario, categoria, subCategoria, item, vip, urgencia, prioridade, titulo, descricao))
                    {
                        return;
                    }
                    else
                    {
                        UsuarioController buscarUsuario = new UsuarioController();
                        if (buscarUsuario.ConsultarUsuarioPorEmail(emailUsuario).Count < 1)
                        {
                            await botClient.SendTextMessageAsync(chatId, "Usuário não cadastrado!", Telegram.Bot.Types.Enums.ParseMode.Html);
                            return;
                        }

                        foreach (var itemUsuario in buscarUsuario.ConsultarUsuarioPorEmail(emailUsuario))
                        {
                            idChamadoUsuario = itemUsuario.idUsuario;
                            nomeUsuario = itemUsuario.nomeUsuario;
                        }

                        ChamadoController novoChamado = new ChamadoController();
                        var itemChamado = novoChamado.CalcularNumeroChamado();
                        if (itemChamado.idChamado == 0)
                            numeroChamado = "Ticket#" + Convert.ToString(1000);
                        else
                        {
                            string calculadoraChamado = "";
                            foreach (var pesquisaChamado in novoChamado.ConsultarNumeroChamado(numeroChamado))
                            {
                                calculadoraChamado = pesquisaChamado.numeroChamado;
                            }

                            calculadoraChamado = calculadoraChamado.Replace("Ticket#", "");
                            numeroChamado = "Ticket#" + Convert.ToString(Convert.ToInt32(calculadoraChamado) + 1);
                        }
                            

                        if (item == "Acessos")
                            aprovacao = "Aguardando aprovação";
                        else
                            aprovacao = "N/A";

                        if (vip.ToLower() == "sim")
                            vip = "S";
                        else
                            vip = "N";

                        statusChamado = "Aberto";
                        dataAbertura = DateTime.Now.Date;
                        entregaEstimada = dataAbertura.AddDays(2);

                        novoChamado.InserirChamado(idChamadoUsuario, numeroChamado, categoria, subCategoria, item, vip, aprovacao, statusChamado, urgencia, prioridade,
                            titulo, descricao, dataAbertura, entregaEstimada);
                        await botClient.SendTextMessageAsync(chatId, "<b>Novo chamado aberto por " + nomeUsuario + "!</b>" +
                                                               "\n<b>Número do chamado:</b> " + numeroChamado +
                                                               "\n<b>Status do chamado:</b> " + statusChamado +
                                                               "\n<b>Data de abertura:</b> " + dataAbertura.Date.ToString("dd/MM/yyyy") +
                                                               "\n<b>Estimativa de atendimento até:</b> " + entregaEstimada.Date.ToString("dd/MM/yyyy") +
                                                               "\n\nQuaisquer atualizações sobre o chamado, você receberá através do e-mail " +
                                                               "ou pode consultar aqui no ChatBot, opção 3, ok?" +
                                                               "\n\nAtenciosamente," +
                                                               "\nEquipe de suporte técnico.", Telegram.Bot.Types.Enums.ParseMode.Html);

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
                                    smtp.Credentials = new NetworkCredential("equipe.suporte.chamados@hotmail.com", "Suporte123");
                                    smtp.Port = 587;
                                    smtp.EnableSsl = true;

                                    //Mensagem de e-mail
                                    email.From = new MailAddress("equipe.suporte.chamados@hotmail.com");
                                    email.To.Add(emailUsuario);

                                    email.Subject = "Novo chamado - " + numeroChamado;
                                    email.IsBodyHtml = false;
                                    email.Body = "Novo chamado aberto por " + nomeUsuario + "." +
                                              "\nNúmero do chamado: " + numeroChamado +
                                              "\nStatus do chamado: " + statusChamado +
                                              "\nData de abertura: " + dataAbertura.Date.ToString("dd/MM/yyyy") +
                                              "\nEstimativa de atendimento até: " + entregaEstimada.Date.ToString("dd/MM/yyyy") +
                                              "\nQuaisquer atualizações sobre o chamado, você receberá através do e-mail ou pode consultar via ChatBot do Telegram." +
                                              "\n\nAtenciosamente," +
                                              "\nequipe.suporte.chamados@hotmail.com" +
                                              "\nÉ um prazer atendê-los!";

                                    //Enviar e-mail
                                    smtp.Send(email);

                                    await botClient.SendTextMessageAsync(chatId, "<b>Equipe de suporte avisada via e-mail!</b>", Telegram.Bot.Types.Enums.ParseMode.Html);
                                }
                            }
                        }
                        catch (Exception erro)
                        {
                            await botClient.SendTextMessageAsync(chatId, "Erro ao enviar e-mail!", Telegram.Bot.Types.Enums.ParseMode.Html);
                            return;
                        }
                        finally
                        {
                        }
                    }
                }
                if (IsNumber(respostas) && menu == "")
                {
                    menu = "N";
                    string numeroChamado = "", titulo = "", statusChamado = "";
                    DateTime dataAbertura = DateTime.Now, entregaEstimada = DateTime.Now;

                    ChamadoController novoChamado = new ChamadoController();
                    if (novoChamado.ConsultarNumeroChamado(respostas).Count < 1)
                    {
                        await botClient.SendTextMessageAsync(chatId, "<b>Chamado não encontrado!</b>", Telegram.Bot.Types.Enums.ParseMode.Html);
                        return;
                    }
                    else
                    {
                        foreach (var itemChamado in novoChamado.ConsultarNumeroChamado(respostas))
                        {
                            numeroChamado = itemChamado.numeroChamado;
                            titulo = itemChamado.titulo;
                            statusChamado = itemChamado.statusChamado;
                            dataAbertura = itemChamado.dataAbertura;
                            entregaEstimada = itemChamado.entregaEstimada;
                        }

                        await botClient.SendTextMessageAsync(chatId, "<b>Chamado número: </b>" + numeroChamado +
                                                                     "\n<b>Problema: </b>" + titulo +
                                                                     "\nEstá com o status de <b>" + statusChamado + "</b>" +
                                                                     "\nChamado foi aberto no dia <b>" + dataAbertura.ToString("dd/MM/yyyy") + "</b>" + 
                                                                     "\nChamado tem prazo de atendimento até <b>" + entregaEstimada.ToString("dd/MM/yyyy") + "</b>" + 
                                                                     "\nCaso o prazo já tenha vencido, favor contatar a equipe de suporte.", Telegram.Bot.Types.Enums.ParseMode.Html);
                        return;
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
            else if (!nomeUsuario.Contains(" "))
            {
                botClient.SendTextMessageAsync(chatId, "Nome do usuário não contém um sobrenome.", Telegram.Bot.Types.Enums.ParseMode.Html);
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

        private static bool ValidarPreenchimento(long chatId, string emailUsuario, string categoria, string subCategoria, string item, string vip,
            string urgencia, string prioridade, string titulo, string descricao)
        {

            if (emailUsuario == "")
            {
                botClient.SendTextMessageAsync(chatId, "E-mail do Usuário está vazio!", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (IsEmail(emailUsuario) == false)
            {
                botClient.SendTextMessageAsync(chatId, "E-mail não está num formato correto.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (emailUsuario.Length > 100)
            {
                botClient.SendTextMessageAsync(chatId, "E-mail está muito grande..", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (categoria == "")
            {
                botClient.SendTextMessageAsync(chatId, "Categoria está vazia.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (categoria.Length > 70)
            {
                botClient.SendTextMessageAsync(chatId, "Categoria está muito grande.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (subCategoria == "")
            {
                botClient.SendTextMessageAsync(chatId, "Subcategoria está vazia.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (subCategoria.Length > 70)
            {
                botClient.SendTextMessageAsync(chatId, "Subcategoria está muito grande.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (item == "")
            {
                botClient.SendTextMessageAsync(chatId, "Item está vazio.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (item.Length > 30)
            {
                botClient.SendTextMessageAsync(chatId, "Item está muito grande.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (vip == "")
            {
                botClient.SendTextMessageAsync(chatId, "VIP está vazio.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (vip.Length > 3)
            {
                botClient.SendTextMessageAsync(chatId, "VIP está muito grande.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (urgencia == "")
            {
                botClient.SendTextMessageAsync(chatId, "Urgência está vazia.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (urgencia.Length > 15)
            {
                botClient.SendTextMessageAsync(chatId, "Urgência está muito grande.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (prioridade == "")
            {
                botClient.SendTextMessageAsync(chatId, "Prioridade está vazia.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (prioridade.Length > 15)
            {
                botClient.SendTextMessageAsync(chatId, "Prioridade está muito grande.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (titulo == "")
            {
                botClient.SendTextMessageAsync(chatId, "Título está vazio.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (titulo.Length > 40)
            {
                botClient.SendTextMessageAsync(chatId, "Título está muito grande.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (descricao == "")
            {
                botClient.SendTextMessageAsync(chatId, "Descrição está vazia.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (descricao.Length > 200)
            {
                botClient.SendTextMessageAsync(chatId, "Descrição está muito grande.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }

            return true;
        }

        public static bool IsNumber(string respostas)
        {
            if (int.TryParse(respostas, out int numero))
                return true;
            else
                return false;
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

