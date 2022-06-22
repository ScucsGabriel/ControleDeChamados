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
    public partial class FormConfiguracoes : Form
    {
        int resposta = 0, idUsuarioLog = 0;
        public FormConfiguracoes(int idUsuarioLogado)
        {
            InitializeComponent();
            idUsuarioLog = idUsuarioLogado;
        }

        private void Btn_PesquisarEmail_Click(object sender, EventArgs e)
        {
            UsuarioController pesquisarEmail = new UsuarioController();

            if (resposta == 1)
            {
                if (pesquisarEmail.ConsultarUsuarioPorEmail(Txt_Email.Text).Count < 1)
                {
                    MessageBox.Show("Não há registros para este usuário!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }                
                else
                {
                    Txt_Usuario.Visible = true;
                    Panel_Usuario.Visible = true;
                    Txt_Funcao.Visible = true;
                    Panel_Funcao.Visible = true;
                    Combo_TipoUsuarioConfiguracoes.Visible = true;

                    foreach (var item in pesquisarEmail.ConsultarUsuarioPorEmail(Txt_Email.Text))
                    {
                        idUsuarioLog = item.idUsuario;
                        Txt_Usuario.Text = item.nomeUsuario;
                        Txt_Funcao.Text = item.funcaoUsuario;
                        Combo_TipoUsuarioConfiguracoes.ValueMember = item.tipoUsuario;
                        Combo_TipoUsuarioConfiguracoes.Text = item.tipoUsuario;
                    }
                }                
            }
            else
            {
                Txt_Usuario.Text = "";
                Txt_Funcao.Text = "";
            }
        }

        private void Btn_CancelarConfiguracoes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Todas as informações não salvas serão perdidas!", "Deseja continuar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void FormConfiguracoes_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(127, 0, 255);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            Label_Configuracoes.BackColor = Color.FromArgb(153, 50, 205);
            Btn_AlterarUsuario.BackColor = Color.FromArgb(153, 50, 205);
            Btn_AlterarUsuario.FlatAppearance.BorderColor = Color.FromArgb(153, 50, 205);
            Btn_AlterarUsuario.FlatAppearance.CheckedBackColor = Color.FromArgb(153, 50, 205);
            Btn_AlterarUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(153, 50, 205);
            Btn_AlterarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(153, 50, 205);
            Btn_DesativarUsuario.BackColor = Color.FromArgb(153, 50, 205);
            Btn_DesativarUsuario.FlatAppearance.BorderColor = Color.FromArgb(153, 50, 205);
            Btn_DesativarUsuario.FlatAppearance.CheckedBackColor = Color.FromArgb(153, 50, 205);
            Btn_DesativarUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(153, 50, 205);
            Btn_DesativarUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(153, 50, 205);
            Btn_SalvarConfiguracoes.BackColor = Color.FromArgb(153, 50, 205);
            Btn_SalvarConfiguracoes.FlatAppearance.BorderColor = Color.FromArgb(153, 50, 205);
            Btn_SalvarConfiguracoes.FlatAppearance.CheckedBackColor = Color.FromArgb(153, 50, 205);
            Btn_SalvarConfiguracoes.FlatAppearance.MouseDownBackColor = Color.FromArgb(153, 50, 205);
            Btn_SalvarConfiguracoes.FlatAppearance.MouseOverBackColor = Color.FromArgb(153, 50, 205);
            Btn_CancelarConfiguracoes.BackColor = Color.FromArgb(127, 0, 255);
            Btn_CancelarConfiguracoes.FlatAppearance.BorderColor = Color.FromArgb(127, 0, 255);
            Btn_CancelarConfiguracoes.FlatAppearance.CheckedBackColor = Color.FromArgb(127, 0, 255);
            Btn_CancelarConfiguracoes.FlatAppearance.MouseDownBackColor = Color.FromArgb(127, 0, 255);
            Btn_CancelarConfiguracoes.FlatAppearance.MouseOverBackColor = Color.FromArgb(127, 0, 255);
            Btn_PesquisarEmail.BackColor = Color.FromArgb(127, 0, 255);
            Btn_PesquisarEmail.FlatAppearance.BorderColor = Color.FromArgb(127, 0, 255);
            Btn_PesquisarEmail.FlatAppearance.CheckedBackColor = Color.FromArgb(127, 0, 255);
            Btn_PesquisarEmail.FlatAppearance.MouseDownBackColor = Color.FromArgb(127, 0, 255);
            Btn_PesquisarEmail.FlatAppearance.MouseOverBackColor = Color.FromArgb(127, 0, 255);
            Txt_Email.BackColor = Color.FromArgb(127, 0, 255);
            Txt_Email.PlaceholderText = "E-mail";
            Panel_Email.BackColor = Color.White;
            Panel_Email.ForeColor = Color.White;
            Txt_Usuario.BackColor = Color.FromArgb(127, 0, 255);
            Txt_Usuario.PlaceholderText = "Nome";
            Panel_Usuario.BackColor = Color.White;
            Panel_Usuario.ForeColor = Color.White;
            Txt_Funcao.BackColor = Color.FromArgb(127, 0, 255);
            Txt_Funcao.PlaceholderText = "Função";
            Panel_Funcao.BackColor = Color.White;
            Panel_Funcao.ForeColor = Color.White;
            Combo_TipoUsuarioConfiguracoes.BackColor = Color.FromArgb(127, 0, 255);
            Combo_TipoUsuarioConfiguracoes.FlatStyle = FlatStyle.Flat;
        }

        private void Btn_AlterarUsuario_Click(object sender, EventArgs e)
        {
            Txt_Email.Text = "";
            Txt_Email.Visible = true;
            Panel_Email.Visible = true;
            Btn_PesquisarEmail.Visible = true;

            Txt_Usuario.Visible = false;
            Panel_Usuario.Visible = false;
            Txt_Funcao.Visible = false;
            Panel_Funcao.Visible = false;
            Combo_TipoUsuarioConfiguracoes.Visible = false;

            resposta = 1;
        }

        private void Btn_DesativaUsuario_Click(object sender, EventArgs e)
        {
            Txt_Email.Text = "";
            Txt_Email.Visible = true;
            Panel_Email.Visible = true;
            Btn_PesquisarEmail.Visible = false;

            Txt_Usuario.Visible = false;
            Panel_Usuario.Visible = false;
            Txt_Funcao.Visible = false;
            Panel_Funcao.Visible = false;
            Combo_TipoUsuarioConfiguracoes.Visible = false;

            Txt_Usuario.Text = "";
            Txt_Funcao.Text = "";
            Combo_TipoUsuarioConfiguracoes.Text = "-- Selecione --";

            resposta = 2;
        }

        private void Btn_SalvarConfiguracoes_Click(object sender, EventArgs e)
        {
            if (resposta == 1)
            {
                if (!ValidarPreenchimento())
                    return;

                if (MessageBox.Show("Deseja realmente salvar?", "Salvar Dados",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    UsuarioController confirmacao = new UsuarioController();
                    if (confirmacao.ConsultarUsuarioPorEmail(Txt_Email.Text).Count < 1)
                    {
                        MessageBox.Show("Não há registros para este usuário!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        confirmacao.AtualizarDadosUsuario(idUsuarioLog, Txt_Email.Text, Txt_Usuario.Text,
                        Txt_Funcao.Text, Combo_TipoUsuarioConfiguracoes.Text);
                        MessageBox.Show("Cadastro atualizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Close();
                }
                else
                    return;
            }
            else if (resposta == 2)
            {
                if (MessageBox.Show("Deseja realmente deletar o usuário?", "Confirmar Deleção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    UsuarioController confirmacao = new UsuarioController();
                    if (confirmacao.ConsultarUsuarioPorEmail(Txt_Email.Text).Count < 1)
                    {
                        MessageBox.Show("Não há registros para este usuário!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        foreach (var item in confirmacao.ConsultarUsuarioPorEmail(Txt_Email.Text))
                        {
                            idUsuarioLog = item.idUsuario;
                        }
                        confirmacao.DesativarUsuario(idUsuarioLog);
                        MessageBox.Show("Usuário desativado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Close();
                }
                else
                    return;
            }
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

        private void Txt_Email_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && resposta == 1)
            {
                UsuarioController pesquisarEmail = new UsuarioController();

                if (resposta == 1)
                {
                    if (pesquisarEmail.ConsultarUsuarioPorEmail(Txt_Email.Text).Count < 1)
                    {
                        MessageBox.Show("Não há registros para este usuário!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        Txt_Usuario.Visible = true;
                        Panel_Usuario.Visible = true;
                        Txt_Funcao.Visible = true;
                        Panel_Funcao.Visible = true;
                        Combo_TipoUsuarioConfiguracoes.Visible = true;

                        foreach (var item in pesquisarEmail.ConsultarUsuarioPorEmail(Txt_Email.Text))
                        {
                            idUsuarioLog = item.idUsuario;
                            Txt_Usuario.Text = item.nomeUsuario;
                            Txt_Funcao.Text = item.funcaoUsuario;
                            Combo_TipoUsuarioConfiguracoes.ValueMember = item.tipoUsuario;
                            Combo_TipoUsuarioConfiguracoes.Text = item.tipoUsuario;
                        }
                    }
                }
                else
                {
                    Txt_Usuario.Text = "";
                    Txt_Funcao.Text = "";
                }
            }
        }

        private bool ValidarPreenchimento()
        {

            if (Txt_Usuario.Text == "")
            {
                MessageBox.Show("Nome do usuário está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNome(Txt_Usuario.Text) == false)
            {
                MessageBox.Show("Nome do usuário não contém somente letras.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!Txt_Usuario.Text.Contains(" "))
            {
                MessageBox.Show("Nome do usuário não contém um sobrenome.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Usuario.Text.Length > 50)
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
            else if (Combo_TipoUsuarioConfiguracoes.Text == "Tipo")
            {
                MessageBox.Show("Selecione o tipo de usuário.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
