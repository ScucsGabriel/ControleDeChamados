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

                    await botClient.SendTextMessageAsync(chatId, "Ol�, " + e.Message.From.FirstName + "! \nDigite uma op��o:" +
                        "\n\n <b>1 - Cadastrar Usu�rio</b> \n <b>2 - Abrir Chamado</b> \n <b>3 - Consultar Chamado</b> \n <b>4 - Resetar Senha</b> \n <b>5 - Sair</b>",
                        Telegram.Bot.Types.Enums.ParseMode.Html);
                    break;

                case "1":
                case "Cadastrar Usu�rio":
                case "1 - Cadastrar Usu�rio":

                    await botClient.SendTextMessageAsync(chatId, "Preencha os campos abaixo: \n\n" +
                        "<b>Nome do Usu�rio: </b>\n<b>E-mail do Usu�rio: </b>\n<b>Senha: </b>\n<b>Repita a Senha: </b>\n<b>Fun��o: </b>",
                        Telegram.Bot.Types.Enums.ParseMode.Html);
                    menu = "S";
                    break;

                case "2":
                case "Abrir Chamado":
                case "2 - Abrir Chamado":

                    await botClient.SendTextMessageAsync(chatId, "Preencha os campos abaixo: \n\n" +
                        "<b>E-mail do Usu�rio: </b>\n<b>Categoria: </b>\n<b>Subcategoria: </b>\n<b>Item: </b>\n" +
                        "<b>VIP: </b>\n<b>Urg�ncia: </b>\n<b>Prioridade: </b>\n<b>T�tulo: </b>\n<b>Descri��o: </b>\n",
                        Telegram.Bot.Types.Enums.ParseMode.Html);
                    menu = "S";
                    break;

                case "3":
                case "Consultar Chamado":
                case "3 - Consultar Chamado":

                    await botClient.SendTextMessageAsync(chatId, "<b>Digite o n�mero do chamado: </b>", Telegram.Bot.Types.Enums.ParseMode.Html);
                    menu = "S";
                    break;

                case "4":
                case "Resetar Senha":
                case "4 - Resetar Senha":

                    await botClient.SendTextMessageAsync(chatId, "<b>Digite o usu�rio: </b>", Telegram.Bot.Types.Enums.ParseMode.Html);
                    menu = "S";
                    break;

                case "5":
                case "Sair":
                case "5 - Sair":
                    await botClient.SendTextMessageAsync(chatId, "<b>Obrigado e at� a pr�xima!</b>", Telegram.Bot.Types.Enums.ParseMode.Html);
                    menu = "S";
                    break;
            }

            if (respostas == null)
                return;
            else
            {
                
                if (respostas.Contains("Nome do Usu�rio") && respostas.StartsWith("Nome"))
                {
                    UsuarioController novoUsuario = new UsuarioController();
                    string nomeUsuario = "", emailUsuario = "", senha = "", repetirSenha = "", funcao = "", tipoUsuario = "Comum", usuarioAtivo = "S";
                    string[] separador = respostas.Replace("Nome do Usu�rio", "").
                        Replace("E-mail do Usu�rio", "").Replace("Senha", "").Replace("Repita a Senha", "").Replace("Fun��o", "").Split(":");

                    nomeUsuario = separador[1].Replace("\n", "").Trim();
                    emailUsuario = separador[2].Replace("\n", "").Trim();
                    senha = separador[3].Replace("\nRepita a", "").Trim();
                    repetirSenha = separador[4].Replace("\n", "").Trim();
                    funcao = separador[5].Trim();

                    if (!ValidarPreenchimento(chatId, nomeUsuario, emailUsuario, senha, repetirSenha, funcao))
                         return;

                        else if (novoUsuario.ConsultarUsuarioPorEmail(emailUsuario).Count > 0)
                        {
                            await botClient.SendTextMessageAsync(chatId, "E-mail j� est� cadastrado para outro usu�rio!", Telegram.Bot.Types.Enums.ParseMode.Html);
                            return;
                        }
                        else if (novoUsuario.ConsultarUsuarioPorNome(nomeUsuario).Count > 0)
                        {
                            await botClient.SendTextMessageAsync(chatId, "Usu�rio j� cadastrado!", Telegram.Bot.Types.Enums.ParseMode.Html);
                            return;
                        }
                        else
                        {
                            novoUsuario.InserirUsuario(nomeUsuario, emailUsuario, senha, tipoUsuario, funcao, usuarioAtivo);
                            await botClient.SendTextMessageAsync(chatId, "Cadastro inclu�do com sucesso!", Telegram.Bot.Types.Enums.ParseMode.Html);

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
                                await botClient.SendTextMessageAsync(chatId, "Erro ao enviar e-mail!", Telegram.Bot.Types.Enums.ParseMode.Html);
                                return;
                            }
                            finally
                            {
                                await botClient.SendTextMessageAsync(chatId, "Novo usu�rio cadastrado! Bem-vindo " + nomeUsuario + "!", Telegram.Bot.Types.Enums.ParseMode.Html);
                            }
                        }
                }
                if (respostas.Contains("@") && (respostas.EndsWith("com") || respostas.EndsWith("br")))
                {
                    if (!IsEmail(respostas))
                    {
                        await botClient.SendTextMessageAsync(chatId, "<b>E-mail n�o estava em um formato correto!</b>", Telegram.Bot.Types.Enums.ParseMode.Html);
                        return;
                    }

                    UsuarioController resetarSenha = new UsuarioController();
                    int resultadoBusca = resetarSenha.ConsultarUsuarioPorEmail(respostas.ToLower()).Count;
                    int idUsuario = 0;
                    string senhaNova = "";

                    if (resultadoBusca == 0)
                    {
                        await botClient.SendTextMessageAsync(chatId, "<b>Usu�rio n�o encontrado!</b>", Telegram.Bot.Types.Enums.ParseMode.Html);
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
                                    email.Body = "Reset de senha realizado com sucesso! Sua nova senha �: " + senhaNova + ".\n" +
                                                  "N�o se esque�a de trocar a senha ap�s o primeiro acesso!\n\n" +
                                                  "Atenciosamente,\n\n" +
                                                  "Equipe de Suporte T�cnico.\n" +
                                                  "equipe.suporte.chamados@hotmail.com\n" +
                                                  "� um prazer atend�-los!";

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
                if (respostas.Contains("E-mail do Usu�rio") && respostas.StartsWith("E-mail"))
                {
                    int idChamadoUsuario = 0;
                    string nomeUsuario = "", numeroChamado = "", aprovacao = "", statusChamado = "";
                    DateTime dataAbertura, entregaEstimada;
                    string emailUsuario = "", categoria = "", subCategoria = "", item = "", vip = "", urgencia = "", prioridade = "", titulo = "", descricao = "";
                    string[] separador = respostas.Replace("E-mail do Usu�rio", "").
                        Replace("Categoria", "").Replace("Subcategoria", "").Replace("Item", "").Replace("VIP", "").Replace("Urg�ncia", "")
                        .Replace("Prioridade", "").Replace("T�tulo", "").Replace("Descri��o", "").Split(":");

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
                        await botClient.SendTextMessageAsync(chatId, "<b>E-mail n�o estava num formato correto!</b>", Telegram.Bot.Types.Enums.ParseMode.Html);
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
                            await botClient.SendTextMessageAsync(chatId, "Usu�rio n�o cadastrado!", Telegram.Bot.Types.Enums.ParseMode.Html);
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
                            aprovacao = "Aguardando aprova��o";
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
                                                               "\n<b>N�mero do chamado:</b> " + numeroChamado +
                                                               "\n<b>Status do chamado:</b> " + statusChamado +
                                                               "\n<b>Data de abertura:</b> " + dataAbertura.Date.ToString("dd/MM/yyyy") +
                                                               "\n<b>Estimativa de atendimento at�:</b> " + entregaEstimada.Date.ToString("dd/MM/yyyy") +
                                                               "\n\nQuaisquer atualiza��es sobre o chamado, voc� receber� atrav�s do e-mail " +
                                                               "ou pode consultar aqui no ChatBot, op��o 3, ok?" +
                                                               "\n\nAtenciosamente," +
                                                               "\nEquipe de suporte t�cnico.", Telegram.Bot.Types.Enums.ParseMode.Html);

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
                                              "\nN�mero do chamado: " + numeroChamado +
                                              "\nStatus do chamado: " + statusChamado +
                                              "\nData de abertura: " + dataAbertura.Date.ToString("dd/MM/yyyy") +
                                              "\nEstimativa de atendimento at�: " + entregaEstimada.Date.ToString("dd/MM/yyyy") +
                                              "\nQuaisquer atualiza��es sobre o chamado, voc� receber� atrav�s do e-mail ou pode consultar via ChatBot do Telegram." +
                                              "\n\nAtenciosamente," +
                                              "\nequipe.suporte.chamados@hotmail.com" +
                                              "\n� um prazer atend�-los!";

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
                        await botClient.SendTextMessageAsync(chatId, "<b>Chamado n�o encontrado!</b>", Telegram.Bot.Types.Enums.ParseMode.Html);
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

                        await botClient.SendTextMessageAsync(chatId, "<b>Chamado n�mero: </b>" + numeroChamado +
                                                                     "\n<b>Problema: </b>" + titulo +
                                                                     "\nEst� com o status de <b>" + statusChamado + "</b>" +
                                                                     "\nChamado foi aberto no dia <b>" + dataAbertura.ToString("dd/MM/yyyy") + "</b>" + 
                                                                     "\nChamado tem prazo de atendimento at� <b>" + entregaEstimada.ToString("dd/MM/yyyy") + "</b>" + 
                                                                     "\nCaso o prazo j� tenha vencido, favor contatar a equipe de suporte.", Telegram.Bot.Types.Enums.ParseMode.Html);
                        return;
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
            else if (!nomeUsuario.Contains(" "))
            {
                botClient.SendTextMessageAsync(chatId, "Nome do usu�rio n�o cont�m um sobrenome.", Telegram.Bot.Types.Enums.ParseMode.Html);
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

        private static bool ValidarPreenchimento(long chatId, string emailUsuario, string categoria, string subCategoria, string item, string vip,
            string urgencia, string prioridade, string titulo, string descricao)
        {

            if (emailUsuario == "")
            {
                botClient.SendTextMessageAsync(chatId, "E-mail do Usu�rio est� vazio!", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (IsEmail(emailUsuario) == false)
            {
                botClient.SendTextMessageAsync(chatId, "E-mail n�o est� num formato correto.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (emailUsuario.Length > 100)
            {
                botClient.SendTextMessageAsync(chatId, "E-mail est� muito grande..", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (categoria == "")
            {
                botClient.SendTextMessageAsync(chatId, "Categoria est� vazia.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (categoria.Length > 70)
            {
                botClient.SendTextMessageAsync(chatId, "Categoria est� muito grande.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (subCategoria == "")
            {
                botClient.SendTextMessageAsync(chatId, "Subcategoria est� vazia.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (subCategoria.Length > 70)
            {
                botClient.SendTextMessageAsync(chatId, "Subcategoria est� muito grande.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (item == "")
            {
                botClient.SendTextMessageAsync(chatId, "Item est� vazio.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (item.Length > 30)
            {
                botClient.SendTextMessageAsync(chatId, "Item est� muito grande.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (vip == "")
            {
                botClient.SendTextMessageAsync(chatId, "VIP est� vazio.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (vip.Length > 3)
            {
                botClient.SendTextMessageAsync(chatId, "VIP est� muito grande.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (urgencia == "")
            {
                botClient.SendTextMessageAsync(chatId, "Urg�ncia est� vazia.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (urgencia.Length > 15)
            {
                botClient.SendTextMessageAsync(chatId, "Urg�ncia est� muito grande.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (prioridade == "")
            {
                botClient.SendTextMessageAsync(chatId, "Prioridade est� vazia.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (prioridade.Length > 15)
            {
                botClient.SendTextMessageAsync(chatId, "Prioridade est� muito grande.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (titulo == "")
            {
                botClient.SendTextMessageAsync(chatId, "T�tulo est� vazio.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (titulo.Length > 40)
            {
                botClient.SendTextMessageAsync(chatId, "T�tulo est� muito grande.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (descricao == "")
            {
                botClient.SendTextMessageAsync(chatId, "Descri��o est� vazia.", Telegram.Bot.Types.Enums.ParseMode.Html);
                return false;
            }
            else if (descricao.Length > 200)
            {
                botClient.SendTextMessageAsync(chatId, "Descri��o est� muito grande.", Telegram.Bot.Types.Enums.ParseMode.Html);
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

