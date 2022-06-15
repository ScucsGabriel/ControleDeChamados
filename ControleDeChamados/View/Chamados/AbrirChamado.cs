using ControleDeChamados.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
        private void Btn_CancelarAbrirChamado_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Todas as informações não salvas serão perdidas!", "Deseja continuar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void Btn_SalvarAbrirChamado_Click(object sender, EventArgs e)
        {

        }

        private void Label_Usuario_Click(object sender, EventArgs e)
        {

        }

        private void FormAbrirChamado_Load(object sender, EventArgs e)
        {
            Combo_Subcategoria.Items.Clear();
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

                Label_NumeroChamado.Text = "Ticket#" + Convert.ToString(calculadoraChamado + 1);
            }
                

            UsuarioController buscaUsuario = new UsuarioController();
            foreach (var itemUsuario in buscaUsuario.ConsultarUsuarioPorId(idUsuario))
            {
                Txt_NomeUsuario.Text = itemUsuario.nomeUsuario;
                Txt_EmailUsuario.Text = itemUsuario.emailUsuario;
                Txt_FuncaoUsuario.Text = itemUsuario.funcaoUsuario;
            }            
        }

        private void Combo_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combo_Categoria.SelectedText == "Acessos")
            {
                Combo_Subcategoria.Items.Clear();
                Combo_Subcategoria.Items.Add("Teste");
                Combo_Subcategoria.Enabled = true;
                Combo_Subcategoria.Refresh();
            }
        }

        private void Combo_Categoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Combo_Categoria.SelectedText == "Acessos")
            {
                Combo_Subcategoria.Items.Clear();
                Combo_Subcategoria.Items.Add("Teste");
                Combo_Subcategoria.Enabled = true;
                Combo_Subcategoria.Refresh();
            }
        }
    }
}
