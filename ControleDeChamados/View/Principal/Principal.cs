using ControleDeChamados.View.Chamados;
using ControleDeChamados.View.Login;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace ControleDeChamados.View.Principal
{
    public partial class FormPrincipal : Form
    {
        int idUsuarioLogado = 0;
        string tipoUsuarioLogado = "";
        public FormPrincipal(int idUsuario, string tipoUsuario)
        {
            InitializeComponent();
            idUsuarioLogado = idUsuario;
            tipoUsuarioLogado = tipoUsuario;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Btn_TotalChamados_Click(object sender, EventArgs e)
        {
            FormChamados formChamados = new FormChamados();
            formChamados.ShowDialog();
        }

        private void Link_Configurações_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tipoUsuarioLogado == "Comum")
            {
                MessageBox.Show("Você não tem privilégios suficientes para acessar o painel de configurações. Contate um Administrador.",
                    "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else 
            {
                FormConfiguracoes formConfiguracoes = new FormConfiguracoes(idUsuarioLogado);
                formConfiguracoes.ShowDialog();
            }
        }

        //private async void Link_Acessar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    string path = @"C:\Users\win\OneDrive\Área de Trabalho\ImagensSM";
        //    string resultado = CapturarTela(path);

        //    if (resultado != "")
        //    {
        //        using (var imgEnvio = Image.FromFile(resultado))
        //        {
        //            var stream = new MemoryStream();
        //            imgEnvio.Save(stream, ImageFormat.Png);
        //            stream.Position = 0;

        //            TelegramBotClient telegramBot = new TelegramBotClient("5543170318:AAHoRt1BT45l-OzZmzZf3I12-j_XIC0uZJY");
        //            await telegramBot.SendPhotoAsync("-617447420", stream, "Resultados do dia - " + DateTime.Now.Date.ToString("dd/MM/yyyy"), ParseMode.Html);
        //            MessageBox.Show("Técnico avisado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //    else
        //        MessageBox.Show("Não foi possível capturar a tela.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}

        //private string CapturarTela(string path)
        //{
        //    try
        //    {
        //        this.Hide();

        //        Thread.Sleep(3000);

        //        var computadorTela = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

        //        var arquivoDestino = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

        //        var g = Graphics.FromImage(arquivoDestino);

        //        g.CopyFromScreen(new Point(0, 0), new Point(0, 0), computadorTela);

        //        var nomeArquivo = path + "\\" + DateTime.Now.ToString().ToString().Replace(" ", "_").Replace("/", "").Replace(":", "") + ".png";

        //        arquivoDestino.Save(nomeArquivo, System.Drawing.Imaging.ImageFormat.Png);

        //        this.Visible = true;

        //        return nomeArquivo;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Falha: " + ex.Message);
        //        return "";
        //    }
        //}

        private void Link_Sair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            this.Hide();

            FormUsuario formUsuario = new FormUsuario();
            formUsuario.ShowDialog();
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Link_AbrirChamado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Link_TrocarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormTrocarSenha formTrocarSenha = new FormTrocarSenha(idUsuarioLogado);
            formTrocarSenha.ShowDialog();
        }
    }
}
