using ControleDeChamados.Controller;
using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace ControleDeChamados.View.Chamados
{
    public partial class FormAbrirChamado : Form
    {
        int idUsuario = 0;
        public FormAbrirChamado(int idUsuarioLogado)
        {
            InitializeComponent();
            idUsuario = idUsuarioLogado;
        }

        private void FormAbrirChamado_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(127, 0, 255);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            Label_NovoChamado.BackColor = Color.FromArgb(153, 50, 205);
            Label_Chamado.BackColor = Color.FromArgb(153, 50, 205);
            Label_NumeroChamado.BackColor = Color.FromArgb(153, 50, 205);
            Label_Usuario.BackColor = Color.FromArgb(153, 50, 205);
            Label_Descricao.BackColor = Color.FromArgb(153, 50, 205);
            Txt_Usuario.BackColor = Color.FromArgb(127, 0, 255);
            Txt_Usuario.PlaceholderText = "Nome";
            Panel_Usuario.BackColor = Color.White;
            Panel_Usuario.ForeColor = Color.White;
            Txt_Email.BackColor = Color.FromArgb(127, 0, 255);
            Txt_Email.PlaceholderText = "E-mail";
            Panel_Email.BackColor = Color.White;
            Panel_Email.ForeColor = Color.White;
            Txt_Funcao.BackColor = Color.FromArgb(127, 0, 255);
            Txt_Funcao.PlaceholderText = "Função";
            Panel_Funcao.BackColor = Color.White;
            Panel_Funcao.ForeColor = Color.White;
            Txt_Categoria.BackColor = Color.FromArgb(127, 0, 255);
            Txt_Categoria.PlaceholderText = "Categoria";
            Panel_Categoria.BackColor = Color.White;
            Panel_Categoria.ForeColor = Color.White;
            Txt_Subcategoria.BackColor = Color.FromArgb(127, 0, 255);
            Txt_Subcategoria.PlaceholderText = "Subcategoria";
            Panel_Subcategoria.BackColor = Color.White;
            Panel_Subcategoria.ForeColor = Color.White;
            Txt_Item.BackColor = Color.FromArgb(127, 0, 255);
            Txt_Item.PlaceholderText = "Item";
            Panel_Item.BackColor = Color.White;
            Panel_Item.ForeColor = Color.White;
            Combo_Urgencia.BackColor = Color.FromArgb(127, 0, 255);
            Combo_Urgencia.FlatStyle = FlatStyle.Flat;
            Combo_Urgencia.SelectedIndex = 0;
            Combo_Prioridade.BackColor = Color.FromArgb(127, 0, 255);
            Combo_Prioridade.FlatStyle = FlatStyle.Flat;
            Combo_Prioridade.SelectedIndex = 0;
            Txt_Titulo.BackColor = Color.FromArgb(127, 0, 255);
            Txt_Titulo.PlaceholderText = "Título";
            Panel_Titulo.BackColor = Color.White;
            Panel_Titulo.ForeColor = Color.White;
            Txt_Descricao.BackColor = Color.FromArgb(127, 0, 255);
            Txt_Descricao.PlaceholderText = "Título";
            Panel_Descricao.BackColor = Color.White;
            Panel_Descricao.ForeColor = Color.White;
            Btn_Salvar.BackColor = Color.FromArgb(153, 50, 205);
            Btn_Salvar.FlatAppearance.BorderColor = Color.FromArgb(153, 50, 205);
            Btn_Salvar.FlatAppearance.CheckedBackColor = Color.FromArgb(153, 50, 205);
            Btn_Salvar.FlatAppearance.MouseDownBackColor = Color.FromArgb(153, 50, 205);
            Btn_Salvar.FlatAppearance.MouseOverBackColor = Color.FromArgb(153, 50, 205);
            Btn_Cancelar.BackColor = Color.FromArgb(127, 0, 255);
            Btn_Cancelar.FlatAppearance.BorderColor = Color.FromArgb(127, 0, 255);
            Btn_Cancelar.FlatAppearance.CheckedBackColor = Color.FromArgb(127, 0, 255);
            Btn_Cancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(127, 0, 255);
            Btn_Cancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(127, 0, 255);

            ChamadoController listarChamado = new ChamadoController();
            var itemChamado = listarChamado.CalcularNumeroChamado();

            if (itemChamado.idChamado == 0)
                Label_NumeroChamado.Text = "Ticket#" + Convert.ToString(1000);
            else
            {
                string calculadoraChamado = "";
                foreach (var pesquisaChamado in listarChamado.ConsultarNumeroChamado(Label_NumeroChamado.Text))
                {
                    calculadoraChamado = pesquisaChamado.numeroChamado;
                }

                calculadoraChamado = calculadoraChamado.Replace("Ticket#", "");
                Label_NumeroChamado.Text = "Ticket#" + Convert.ToString(Convert.ToInt32(calculadoraChamado) + 1);
            }

            UsuarioController buscaUsuario = new UsuarioController();
            foreach (var itemUsuario in buscaUsuario.ConsultarUsuarioPorId(idUsuario))
            {
                Txt_Usuario.Text = itemUsuario.nomeUsuario;
                Txt_Email.Text = itemUsuario.emailUsuario;
                Txt_Funcao.Text = itemUsuario.funcaoUsuario;
            }
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            if (!ValidarPreenchimento())
                return;

            UsuarioController buscarUsuario = new UsuarioController();
            ChamadoController novoChamado = new ChamadoController();
            string aprovacao = "N/A";
            string statusChamado = "Aberto";
            DateTime dataAbertura = DateTime.Now.Date;
            DateTime entregaEstimada = dataAbertura.AddDays(2);

             novoChamado.InserirChamado(idUsuario, Label_NumeroChamado.Text, Txt_Categoria.Text, Txt_Subcategoria.Text, Txt_Item.Text, aprovacao, statusChamado,
                                        Combo_Urgencia.Text, Combo_Prioridade.Text, Txt_Titulo.Text, Txt_Descricao.Text, dataAbertura, entregaEstimada);

            MessageBox.Show("Novo chamado aberto por " + Txt_Usuario.Text + "!" +
                            "\nNúmero do chamado: " + Label_NumeroChamado.Text +
                            "\nStatus do chamado: " + statusChamado +
                            "\nData de abertura: " + dataAbertura.Date.ToString("dd/MM/yyyy") +
                            "\nEstimativa de atendimento até: " + entregaEstimada.Date.ToString("dd/MM/yyyy") +
                            "\n\nQuaisquer atualizações sobre o chamado, você receberá através do e-mail " +
                            ", ou você pode consultar via sistema ou pode consultar via ChatBot, opção 3, ok?" +
                            "\n\nAtenciosamente," +
                            "\nEquipe de suporte técnico.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                            email.To.Add(Txt_Email.Text);

                            email.Subject = "Novo chamado - " + Label_NumeroChamado.Text;
                            email.IsBodyHtml = false;
                            email.Body = "Novo chamado aberto por " + Txt_Usuario.Text + "." +
                                      "\nNúmero do chamado: " + Label_NumeroChamado.Text +
                                      "\nStatus do chamado: " + statusChamado +
                                      "\nData de abertura: " + dataAbertura.Date.ToString("dd/MM/yyyy") +
                                      "\nEstimativa de atendimento até: " + entregaEstimada.Date.ToString("dd/MM/yyyy") +
                                      "\nQuaisquer atualizações sobre o chamado, você receberá através do e-mail ou pode consultar via ChatBot do Telegram ou sistema." +
                                      "\n\nAtenciosamente," +
                                      "\n" +
                                      "\nÉ um prazer atendê-los!";

                            //Enviar e-mail
                            smtp.Send(email);

                        MessageBox.Show("Comprovante de chamado enviado via e-mail!.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                TelegramBotClient telegramBot = new TelegramBotClient("");
                telegramBot.SendTextMessageAsync("", "<b>Novo chamado aberto por " + Txt_Usuario.Text + " via sistema!</b>" +
                                                               "\n\nNúmero do chamado: " + Label_NumeroChamado.Text +
                                                               "\nStatus do chamado: " + statusChamado + 
                                                               "\nData de abertura: " + dataAbertura.Date.ToString("dd/MM/yyyy") +
                                                               "\nEstimativa de atendimento até: " + entregaEstimada.Date.ToString("dd/MM/yyyy") +
                                                               "\nQuaisquer atualizações sobre o chamado, você receberá através do e-mail ou pode consultar via ChatBot do Telegram ou sistema." + 
                                                               "\n\nAtenciosamente, " + 
                                                               "Equipe de Suporte Técnico.", ParseMode.Html);
                MessageBox.Show("Equipe de suporte avisada via Telegram!.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao enviar e-mail!.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                finally
                {
                }     
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Todas as informações não salvas serão perdidas!", "Deseja continuar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private bool ValidarPreenchimento()
        {
            if (Txt_Categoria.Text == "")
            {
                MessageBox.Show("Categoria está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Categoria.Text.Length > 70)
            {
                MessageBox.Show("Categoria está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Subcategoria.Text == "")
            {
                MessageBox.Show("Subcategoria está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Subcategoria.Text.Length > 70)
            {
                MessageBox.Show("Subcategoria está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Item.Text == "")
            {
                MessageBox.Show("Item está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Item.Text.Length > 30)
            {
                MessageBox.Show("Item está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Combo_Urgencia.Text == "Urgência")
            {
                MessageBox.Show("Selecione a urgência.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Combo_Prioridade.Text == "Prioridade")
            {
                MessageBox.Show("Selecione a prioridade.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Titulo.Text == "")
            {
                MessageBox.Show("Título está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Titulo.Text.Length > 40)
            {
                MessageBox.Show("Título está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Descricao.Text == "")
            {
                MessageBox.Show("Problema está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Descricao.Text.Length > 200)
            {
                MessageBox.Show("Problema está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
