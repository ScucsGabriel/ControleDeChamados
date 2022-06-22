using ControleDeChamados.Controller;
using ControleDeChamados.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControleDeChamados.View.Chamados
{
    public partial class FormChamados : Form
    {
        int idUsuario = 0;
        string funcaoUsuario = "";
        public FormChamados(int idUsuarioLogado)
        {
            InitializeComponent();
            idUsuario = idUsuarioLogado;
            UsuarioController pesquisarFuncaoUsuario = new UsuarioController();
            foreach (var item in pesquisarFuncaoUsuario.ConsultarUsuarioPorId(idUsuario))
            {
                funcaoUsuario = item.funcaoUsuario;
            }
        }

        private void LimparFormLista()
        {
            LstView_ConsultarChamados.Columns.Clear();
            LstView_ConsultarChamados.Items.Clear();
        }

        private void FormChamados_Load(object sender, EventArgs e)
        {
            LimparFormLista();
            LstView_ConsultarChamados.FullRowSelect = true;
            this.BackColor = Color.FromArgb(127, 0, 255);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            Label_ConsultarChamados.BackColor = Color.FromArgb(153, 50, 205);
            Btn_PesquisarChamado.BackColor = Color.FromArgb(127, 0, 255);
            Btn_PesquisarChamado.FlatAppearance.BorderColor = Color.FromArgb(127, 0, 255);
            Btn_PesquisarChamado.FlatAppearance.CheckedBackColor = Color.FromArgb(127, 0, 255);
            Btn_PesquisarChamado.FlatAppearance.MouseDownBackColor = Color.FromArgb(127, 0, 255);
            Btn_PesquisarChamado.FlatAppearance.MouseOverBackColor = Color.FromArgb(127, 0, 255);
            Btn_Detalhes.BackColor = Color.FromArgb(153, 50, 205);
            Btn_Detalhes.FlatAppearance.BorderColor = Color.FromArgb(153, 50, 205);
            Btn_Detalhes.FlatAppearance.CheckedBackColor = Color.FromArgb(153, 50, 205);
            Btn_Detalhes.FlatAppearance.MouseDownBackColor = Color.FromArgb(153, 50, 205);
            Btn_Detalhes.FlatAppearance.MouseOverBackColor = Color.FromArgb(153, 50, 205);
            if (funcaoUsuario.ToLower().Contains("ti") || funcaoUsuario.ToLower().Contains("administrador"))
                Btn_Detalhes.Visible = true;
            else
                Btn_Detalhes.Visible = false;
            Txt_NumeroChamado.BackColor = Color.FromArgb(127, 0, 255);
            Txt_NumeroChamado.PlaceholderText = "Número do Chamado";
            Panel_NumeroChamado.BackColor = Color.White;
            Panel_NumeroChamado.ForeColor = Color.White;

        }
        private void Btn_PesquisarChamado_Click(object sender, EventArgs e)
        {         
            if ((funcaoUsuario.ToLower().Contains("ti") || funcaoUsuario.ToLower().Contains("administrador")) && Txt_NumeroChamado.Text == "")
            {
                PreencherListView_FilaChamados();
            }
            else if (Txt_NumeroChamado.Text == "" && !(funcaoUsuario.ToLower().Contains("ti") || funcaoUsuario.ToLower().Contains("administrador")))
            {
                MessageBox.Show("Digite o número do chamado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                PreencherListView_NumeroChamado(Txt_NumeroChamado.Text, funcaoUsuario);
            }
        }
        private void PreencherListView_FilaChamados()
        {
            LimparFormLista();
            PreencherColumnHeader();
            ChamadoController pesquisarChamado = new ChamadoController();
            int resultadoBusca = pesquisarChamado.ConsultarFilaChamados().Count;

            if (resultadoBusca == 0)
            {
                MessageBox.Show("Nenhum chamado encontrado.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {               
                foreach (var item in pesquisarChamado.ConsultarFilaChamados())
                {
                   ListViewItem listViewItem = new ListViewItem(new[]
                   { item.numeroChamado.ToString(), item.titulo.ToString(), item.statusChamado.ToString(),
                     item.dataAbertura.ToString("dd/MM/yyyy"), item.entregaEstimada.ToString("dd/MM/yyyy")});

                     LstView_ConsultarChamados.Items.Add(listViewItem);
                     Label_NumeroTotalChamados.Text = Convert.ToString(LstView_ConsultarChamados.Items.Count);
                }

                LstView_ConsultarChamados.View = System.Windows.Forms.View.Details;
                
            }
        }
        private void PreencherListView_NumeroChamado(string numeroChamado, string funcaoUsuario)
        {
            LimparFormLista();
            PreencherColumnHeader();
            ChamadoController pesquisarChamado = new ChamadoController();
            int resultadoBusca = pesquisarChamado.ConsultarNumeroChamado(Txt_NumeroChamado.Text).Count;

            if (resultadoBusca == 0)
            {
                MessageBox.Show("Não há nenhum chamado aberto com este número!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }           
            else
            {
                if (pesquisarChamado.ConsultarNumeroChamadoUsuario(idUsuario, Txt_NumeroChamado.Text).Count < 1 && !(funcaoUsuario.ToLower().Contains("ti") 
                                                                                                                    || funcaoUsuario.ToLower().Contains("administrador")))
                {
                    MessageBox.Show("Não há nenhum chamado aberto com este número para o usuário que está pesquisando!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    foreach (var item in pesquisarChamado.ConsultarNumeroChamado(Txt_NumeroChamado.Text))
                    {
                        ListViewItem listViewItem = new ListViewItem(new[]
                        { item.numeroChamado.ToString(), item.titulo.ToString(), item.statusChamado.ToString(),
                          item.dataAbertura.ToString("dd/MM/yyyy"), item.entregaEstimada.ToString("dd/MM/yyyy")});

                        LstView_ConsultarChamados.Items.Add(listViewItem);
                        Label_NumeroTotalChamados.Text = Convert.ToString(LstView_ConsultarChamados.Items.Count);
                    }

                    LstView_ConsultarChamados.View = System.Windows.Forms.View.Details;
                }                
            }
        }
        private void PreencherColumnHeader()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            ColumnHeader columnHeader4 = new ColumnHeader();
            ColumnHeader columnHeader5 = new ColumnHeader();

            columnHeader1.Text = "Número Chamado";
            columnHeader2.Text = "Título";
            columnHeader3.Text = "Status";
            columnHeader4.Text = "Data Abertura";
            columnHeader5.Text = "Estimativa";

            LstView_ConsultarChamados.Columns.Add(columnHeader1);
            LstView_ConsultarChamados.Columns.Add(columnHeader2);
            LstView_ConsultarChamados.Columns.Add(columnHeader3);
            LstView_ConsultarChamados.Columns.Add(columnHeader4);
            LstView_ConsultarChamados.Columns.Add(columnHeader5);

            LstView_ConsultarChamados.GridLines = true;
        }
        private void Txt_NumeroChamado_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && Txt_NumeroChamado.Text != "")
            {
                PreencherListView_NumeroChamado(Txt_NumeroChamado.Text, funcaoUsuario);
            }
        }
        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Detalhes_Click(object sender, EventArgs e)
        {
            if (LstView_ConsultarChamados.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (LstView_ConsultarChamados.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ChamadoController detalhesChamado = new ChamadoController();
            List<Chamado> chamadoSelecionado = new List<Chamado>();
            string numeroChamado = LstView_ConsultarChamados.SelectedItems[0].SubItems[0].Text;

            foreach (var item in detalhesChamado.ConsultarNumeroChamadoDetalhes(numeroChamado))
            {
                Chamado chamado = new Chamado();
                chamado.idChamado = item.idChamado;
                chamado.idChamadoUsuario = item.idChamadoUsuario;
                chamado.numeroChamado = item.numeroChamado;
                chamado.categoria = item.categoria;
                chamado.subCategoria = item.subCategoria;
                chamado.item = item.item;
                chamado.aprovacao = chamado.aprovacao;
                chamado.statusChamado = item.statusChamado;
                chamado.urgencia = item.urgencia;
                chamado.prioridade = item.prioridade;
                chamado.titulo = item.titulo;
                chamado.descricao = item.descricao;
                chamado.dataAbertura = item.dataAbertura;
                chamado.entregaEstimada = item.entregaEstimada;

                chamadoSelecionado.Add(chamado);
            }

            FormDetalhesChamado formDetalhesChamado = new FormDetalhesChamado(idUsuario, chamadoSelecionado);
            formDetalhesChamado.ShowDialog();


        }
    }
}
