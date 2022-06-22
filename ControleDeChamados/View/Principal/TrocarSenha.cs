using ControleDeChamados.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControleDeChamados.View.Principal
{
    public partial class FormTrocarSenha : Form
    {
        int idBuscaUsuarioLogado = 0;
        public FormTrocarSenha(int idUsuarioLogado)
        {
            InitializeComponent();
            idBuscaUsuarioLogado = idUsuarioLogado;
        }

        private bool ValidarPreenchimento()
        {

            if (Txt_SenhaAtual.Text == "")
            {
                MessageBox.Show("Senha atual está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_SenhaAtual.Text.Length > 30)
            {
                MessageBox.Show("Senha atual está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_NovaSenha.Text == "")
            {
                MessageBox.Show("Nova senha está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_NovaSenha.Text.Length > 30)
            {
                MessageBox.Show("Nova senha está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_RepetirSenha.Text == "")
            {
                MessageBox.Show("A senha repetida está vazia.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_RepetirSenha.Text.Length > 30)
            {
                MessageBox.Show("A senha repetida está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_RepetirSenha.Text != Txt_NovaSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Btn_SalvarSenha_Click(object sender, EventArgs e)
        {
            UsuarioController inserirSenha = new UsuarioController();

            if (!ValidarPreenchimento())
                return;

            string senhaAtual = "";

            foreach (var item in inserirSenha.ConsultarUsuarioPorId(idBuscaUsuarioLogado))
            {
                senhaAtual = item.senhaUsuario;
            }

            if (senhaAtual != Txt_SenhaAtual.Text)
            {
                MessageBox.Show("A senha atual está errada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                inserirSenha.AtualizarSenha(idBuscaUsuarioLogado, Txt_NovaSenha.Text);

                MessageBox.Show("Senha atualizada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_SenhaAtual.Text = "";
                Txt_NovaSenha.Text = "";
                Txt_RepetirSenha.Text = "";
                return;
            }
        }

        private void Btn_CancelarSenha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTrocarSenha_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(127, 0, 255);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            Label_TrocarSenha.BackColor = Color.FromArgb(153, 50, 205);
            Btn_SalvarSenha.BackColor = Color.FromArgb(153, 50, 205);
            Btn_SalvarSenha.FlatAppearance.BorderColor = Color.FromArgb(153, 50, 205);
            Btn_SalvarSenha.FlatAppearance.CheckedBackColor = Color.FromArgb(153, 50, 205);
            Btn_SalvarSenha.FlatAppearance.MouseDownBackColor = Color.FromArgb(153, 50, 205);
            Btn_SalvarSenha.FlatAppearance.MouseOverBackColor = Color.FromArgb(153, 50, 205);
            Txt_SenhaAtual.BackColor = Color.FromArgb(127, 0, 255);
            Txt_SenhaAtual.PlaceholderText = "Senha Atual";
            Panel_SenhaAtual.BackColor = Color.White;
            Panel_SenhaAtual.ForeColor = Color.White;
            Txt_NovaSenha.BackColor = Color.FromArgb(127, 0, 255);
            Txt_NovaSenha.PlaceholderText = "Nova Senha";
            Panel_NovaSenha.BackColor = Color.White;
            Panel_NovaSenha.ForeColor = Color.White;
            Txt_RepetirSenha.BackColor = Color.FromArgb(127, 0, 255);
            Txt_RepetirSenha.PlaceholderText = "Repetir Senha";
            Panel_RepetirSenha.BackColor = Color.White;
            Panel_RepetirSenha.ForeColor = Color.White;
        }

        private void Btn_MostrarNovaSenha_Click(object sender, EventArgs e)
        {
            if (Txt_NovaSenha.UseSystemPasswordChar == true)
                Txt_NovaSenha.UseSystemPasswordChar = false;
            else
                Txt_NovaSenha.UseSystemPasswordChar = true;
        }

        private void Btn_MostrarRepetirSenha_Click(object sender, EventArgs e)
        {
            if (Txt_RepetirSenha.UseSystemPasswordChar == true)
                Txt_RepetirSenha.UseSystemPasswordChar = false;
            else
                Txt_RepetirSenha.UseSystemPasswordChar = true;
        }

        private void Btn_MostrarSenhaAtual_Click_1(object sender, EventArgs e)
        {
            if (Txt_SenhaAtual.UseSystemPasswordChar == true)
                Txt_SenhaAtual.UseSystemPasswordChar = false;
            else
                Txt_SenhaAtual.UseSystemPasswordChar = true;
        }
    }
}
