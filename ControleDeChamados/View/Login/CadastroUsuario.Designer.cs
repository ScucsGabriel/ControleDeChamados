namespace ControleDeChamados.View.Login
{
    partial class FormCadastroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroUsuario));
            this.Txt_SenhaUsuario = new System.Windows.Forms.TextBox();
            this.Txt_NomeUsuario = new System.Windows.Forms.TextBox();
            this.Label_SenhaUsuario = new System.Windows.Forms.Label();
            this.Label_NomeUsuario = new System.Windows.Forms.Label();
            this.Txt_RepetirSenhaUsuario = new System.Windows.Forms.TextBox();
            this.Label_RepetirSenhaUsuario = new System.Windows.Forms.Label();
            this.Txt_EmailUsuario = new System.Windows.Forms.TextBox();
            this.Label_EmailUsuario = new System.Windows.Forms.Label();
            this.Label_TipoUsuario = new System.Windows.Forms.Label();
            this.Combo_TipoUsuario = new System.Windows.Forms.ComboBox();
            this.Label_Funcao = new System.Windows.Forms.Label();
            this.Combo_Funcao = new System.Windows.Forms.ComboBox();
            this.Btn_MostrarSenhaCadastro = new System.Windows.Forms.Button();
            this.Btn_MostrarRepetirSenhaCadastro = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Btn_CancelarCadastro = new System.Windows.Forms.Button();
            this.Btn_SalvarCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_SenhaUsuario
            // 
            this.Txt_SenhaUsuario.Location = new System.Drawing.Point(102, 72);
            this.Txt_SenhaUsuario.MaxLength = 30;
            this.Txt_SenhaUsuario.Name = "Txt_SenhaUsuario";
            this.Txt_SenhaUsuario.Size = new System.Drawing.Size(212, 23);
            this.Txt_SenhaUsuario.TabIndex = 3;
            this.Txt_SenhaUsuario.UseSystemPasswordChar = true;
            // 
            // Txt_NomeUsuario
            // 
            this.Txt_NomeUsuario.Location = new System.Drawing.Point(102, 30);
            this.Txt_NomeUsuario.MaxLength = 50;
            this.Txt_NomeUsuario.Name = "Txt_NomeUsuario";
            this.Txt_NomeUsuario.Size = new System.Drawing.Size(212, 23);
            this.Txt_NomeUsuario.TabIndex = 1;
            // 
            // Label_SenhaUsuario
            // 
            this.Label_SenhaUsuario.AutoSize = true;
            this.Label_SenhaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.Label_SenhaUsuario.Location = new System.Drawing.Point(54, 75);
            this.Label_SenhaUsuario.Name = "Label_SenhaUsuario";
            this.Label_SenhaUsuario.Size = new System.Drawing.Size(42, 15);
            this.Label_SenhaUsuario.TabIndex = 13;
            this.Label_SenhaUsuario.Text = "Senha:";
            // 
            // Label_NomeUsuario
            // 
            this.Label_NomeUsuario.AutoSize = true;
            this.Label_NomeUsuario.BackColor = System.Drawing.Color.Transparent;
            this.Label_NomeUsuario.Location = new System.Drawing.Point(53, 33);
            this.Label_NomeUsuario.Name = "Label_NomeUsuario";
            this.Label_NomeUsuario.Size = new System.Drawing.Size(43, 15);
            this.Label_NomeUsuario.TabIndex = 11;
            this.Label_NomeUsuario.Text = "Nome:";
            // 
            // Txt_RepetirSenhaUsuario
            // 
            this.Txt_RepetirSenhaUsuario.Location = new System.Drawing.Point(449, 72);
            this.Txt_RepetirSenhaUsuario.MaxLength = 30;
            this.Txt_RepetirSenhaUsuario.Name = "Txt_RepetirSenhaUsuario";
            this.Txt_RepetirSenhaUsuario.Size = new System.Drawing.Size(212, 23);
            this.Txt_RepetirSenhaUsuario.TabIndex = 5;
            this.Txt_RepetirSenhaUsuario.UseSystemPasswordChar = true;
            // 
            // Label_RepetirSenhaUsuario
            // 
            this.Label_RepetirSenhaUsuario.AutoSize = true;
            this.Label_RepetirSenhaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.Label_RepetirSenhaUsuario.Location = new System.Drawing.Point(356, 75);
            this.Label_RepetirSenhaUsuario.Name = "Label_RepetirSenhaUsuario";
            this.Label_RepetirSenhaUsuario.Size = new System.Drawing.Size(87, 15);
            this.Label_RepetirSenhaUsuario.TabIndex = 14;
            this.Label_RepetirSenhaUsuario.Text = "Repita a Senha:";
            // 
            // Txt_EmailUsuario
            // 
            this.Txt_EmailUsuario.Location = new System.Drawing.Point(449, 33);
            this.Txt_EmailUsuario.MaxLength = 100;
            this.Txt_EmailUsuario.Name = "Txt_EmailUsuario";
            this.Txt_EmailUsuario.Size = new System.Drawing.Size(212, 23);
            this.Txt_EmailUsuario.TabIndex = 2;
            // 
            // Label_EmailUsuario
            // 
            this.Label_EmailUsuario.AutoSize = true;
            this.Label_EmailUsuario.BackColor = System.Drawing.Color.Transparent;
            this.Label_EmailUsuario.Location = new System.Drawing.Point(399, 36);
            this.Label_EmailUsuario.Name = "Label_EmailUsuario";
            this.Label_EmailUsuario.Size = new System.Drawing.Size(44, 15);
            this.Label_EmailUsuario.TabIndex = 12;
            this.Label_EmailUsuario.Text = "E-mail:";
            // 
            // Label_TipoUsuario
            // 
            this.Label_TipoUsuario.AutoSize = true;
            this.Label_TipoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.Label_TipoUsuario.Location = new System.Drawing.Point(367, 127);
            this.Label_TipoUsuario.Name = "Label_TipoUsuario";
            this.Label_TipoUsuario.Size = new System.Drawing.Size(76, 15);
            this.Label_TipoUsuario.TabIndex = 16;
            this.Label_TipoUsuario.Text = "Tipo Usuário:";
            // 
            // Combo_TipoUsuario
            // 
            this.Combo_TipoUsuario.FormattingEnabled = true;
            this.Combo_TipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Comum"});
            this.Combo_TipoUsuario.Location = new System.Drawing.Point(449, 124);
            this.Combo_TipoUsuario.Name = "Combo_TipoUsuario";
            this.Combo_TipoUsuario.Size = new System.Drawing.Size(212, 23);
            this.Combo_TipoUsuario.TabIndex = 8;
            this.Combo_TipoUsuario.Text = "-- Selecione --";
            // 
            // Label_Funcao
            // 
            this.Label_Funcao.AutoSize = true;
            this.Label_Funcao.BackColor = System.Drawing.Color.Transparent;
            this.Label_Funcao.Location = new System.Drawing.Point(47, 127);
            this.Label_Funcao.Name = "Label_Funcao";
            this.Label_Funcao.Size = new System.Drawing.Size(49, 15);
            this.Label_Funcao.TabIndex = 15;
            this.Label_Funcao.Text = "Função:";
            // 
            // Combo_Funcao
            // 
            this.Combo_Funcao.FormattingEnabled = true;
            this.Combo_Funcao.Items.AddRange(new object[] {
            "Administrativo",
            "Controladoria",
            "Diretoria",
            "Facilities",
            "Financeiro",
            "Gerência",
            "Jurídico",
            "Marketing",
            "RH",
            "Supervisão",
            "TI"});
            this.Combo_Funcao.Location = new System.Drawing.Point(102, 124);
            this.Combo_Funcao.Name = "Combo_Funcao";
            this.Combo_Funcao.Size = new System.Drawing.Size(212, 23);
            this.Combo_Funcao.TabIndex = 7;
            this.Combo_Funcao.Text = "-- Selecione --";
            // 
            // Btn_MostrarSenhaCadastro
            // 
            this.Btn_MostrarSenhaCadastro.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_MostrarSenhaCadastro.FlatAppearance.BorderSize = 0;
            this.Btn_MostrarSenhaCadastro.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.Btn_MostrarSenhaCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.Btn_MostrarSenhaCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.Btn_MostrarSenhaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MostrarSenhaCadastro.Image = ((System.Drawing.Image)(resources.GetObject("Btn_MostrarSenhaCadastro.Image")));
            this.Btn_MostrarSenhaCadastro.Location = new System.Drawing.Point(287, 75);
            this.Btn_MostrarSenhaCadastro.Name = "Btn_MostrarSenhaCadastro";
            this.Btn_MostrarSenhaCadastro.Size = new System.Drawing.Size(16, 16);
            this.Btn_MostrarSenhaCadastro.TabIndex = 9;
            this.Btn_MostrarSenhaCadastro.UseVisualStyleBackColor = false;
            this.Btn_MostrarSenhaCadastro.Click += new System.EventHandler(this.Btn_MostrarSenhaCadastro_Click);
            // 
            // Btn_MostrarRepetirSenhaCadastro
            // 
            this.Btn_MostrarRepetirSenhaCadastro.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_MostrarRepetirSenhaCadastro.FlatAppearance.BorderSize = 0;
            this.Btn_MostrarRepetirSenhaCadastro.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.Btn_MostrarRepetirSenhaCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.Btn_MostrarRepetirSenhaCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.Btn_MostrarRepetirSenhaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MostrarRepetirSenhaCadastro.Image = ((System.Drawing.Image)(resources.GetObject("Btn_MostrarRepetirSenhaCadastro.Image")));
            this.Btn_MostrarRepetirSenhaCadastro.Location = new System.Drawing.Point(633, 75);
            this.Btn_MostrarRepetirSenhaCadastro.Name = "Btn_MostrarRepetirSenhaCadastro";
            this.Btn_MostrarRepetirSenhaCadastro.Size = new System.Drawing.Size(16, 16);
            this.Btn_MostrarRepetirSenhaCadastro.TabIndex = 9;
            this.Btn_MostrarRepetirSenhaCadastro.UseVisualStyleBackColor = false;
            this.Btn_MostrarRepetirSenhaCadastro.Click += new System.EventHandler(this.Btn_MostrarRepetirSenhaCadastro_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(683, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Btn_CancelarCadastro
            // 
            this.Btn_CancelarCadastro.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_CancelarCadastro.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.Btn_CancelarCadastro.FlatAppearance.BorderSize = 0;
            this.Btn_CancelarCadastro.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Info;
            this.Btn_CancelarCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.Btn_CancelarCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Info;
            this.Btn_CancelarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CancelarCadastro.Image = ((System.Drawing.Image)(resources.GetObject("Btn_CancelarCadastro.Image")));
            this.Btn_CancelarCadastro.Location = new System.Drawing.Point(60, 3);
            this.Btn_CancelarCadastro.Name = "Btn_CancelarCadastro";
            this.Btn_CancelarCadastro.Size = new System.Drawing.Size(23, 21);
            this.Btn_CancelarCadastro.TabIndex = 14;
            this.Btn_CancelarCadastro.UseVisualStyleBackColor = false;
            this.Btn_CancelarCadastro.Click += new System.EventHandler(this.Btn_CancelarConfiguracoes_Click);
            // 
            // Btn_SalvarCadastro
            // 
            this.Btn_SalvarCadastro.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_SalvarCadastro.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.Btn_SalvarCadastro.FlatAppearance.BorderSize = 0;
            this.Btn_SalvarCadastro.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Info;
            this.Btn_SalvarCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.Btn_SalvarCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Info;
            this.Btn_SalvarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SalvarCadastro.Image = ((System.Drawing.Image)(resources.GetObject("Btn_SalvarCadastro.Image")));
            this.Btn_SalvarCadastro.Location = new System.Drawing.Point(12, 1);
            this.Btn_SalvarCadastro.Name = "Btn_SalvarCadastro";
            this.Btn_SalvarCadastro.Size = new System.Drawing.Size(28, 25);
            this.Btn_SalvarCadastro.TabIndex = 13;
            this.Btn_SalvarCadastro.UseVisualStyleBackColor = false;
            this.Btn_SalvarCadastro.Click += new System.EventHandler(this.Btn_SalvarCadastro_Click);
            // 
            // FormCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(683, 167);
            this.Controls.Add(this.Btn_SalvarCadastro);
            this.Controls.Add(this.Btn_CancelarCadastro);
            this.Controls.Add(this.Btn_MostrarRepetirSenhaCadastro);
            this.Controls.Add(this.Btn_MostrarSenhaCadastro);
            this.Controls.Add(this.Combo_Funcao);
            this.Controls.Add(this.Label_Funcao);
            this.Controls.Add(this.Combo_TipoUsuario);
            this.Controls.Add(this.Label_TipoUsuario);
            this.Controls.Add(this.Label_EmailUsuario);
            this.Controls.Add(this.Txt_EmailUsuario);
            this.Controls.Add(this.Label_RepetirSenhaUsuario);
            this.Controls.Add(this.Txt_RepetirSenhaUsuario);
            this.Controls.Add(this.Label_NomeUsuario);
            this.Controls.Add(this.Label_SenhaUsuario);
            this.Controls.Add(this.Txt_NomeUsuario);
            this.Controls.Add(this.Txt_SenhaUsuario);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.FormCadastroUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_SenhaUsuario;
        private System.Windows.Forms.TextBox Txt_NomeUsuario;
        private System.Windows.Forms.Label Label_SenhaUsuario;
        private System.Windows.Forms.Label Label_NomeUsuario;
        private System.Windows.Forms.TextBox Txt_RepetirSenhaUsuario;
        private System.Windows.Forms.Label Label_RepetirSenhaUsuario;
        private System.Windows.Forms.TextBox Txt_EmailUsuario;
        private System.Windows.Forms.Label Label_EmailUsuario;
        private System.Windows.Forms.Label Label_TipoUsuario;
        private System.Windows.Forms.ComboBox Combo_TipoUsuario;
        private System.Windows.Forms.Label Label_Funcao;
        private System.Windows.Forms.ComboBox Combo_Funcao;
        private System.Windows.Forms.Button Btn_MostrarSenhaCadastro;
        private System.Windows.Forms.Button Btn_MostrarRepetirSenhaCadastro;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button Btn_CancelarCadastro;
        private System.Windows.Forms.Button Btn_SalvarCadastro;
    }
}