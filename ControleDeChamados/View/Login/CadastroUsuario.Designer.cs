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
            this.Combo_TipoUsuario = new System.Windows.Forms.ComboBox();
            this.Btn_CancelarCadastro = new System.Windows.Forms.Button();
            this.Btn_SalvarCadastro = new System.Windows.Forms.Button();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Panel_Nome = new System.Windows.Forms.Panel();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Panel_Email = new System.Windows.Forms.Panel();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Btn_MostrarSenha = new System.Windows.Forms.Button();
            this.Panel_Senha = new System.Windows.Forms.Panel();
            this.Txt_Repetir = new System.Windows.Forms.TextBox();
            this.Btn_MostrarRepetirSenha = new System.Windows.Forms.Button();
            this.Panel_RepetirSenha = new System.Windows.Forms.Panel();
            this.Txt_Funcao = new System.Windows.Forms.TextBox();
            this.Panel_Funcao = new System.Windows.Forms.Panel();
            this.Label_Cadastro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Combo_TipoUsuario
            // 
            this.Combo_TipoUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.Combo_TipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_TipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Combo_TipoUsuario.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Combo_TipoUsuario.ForeColor = System.Drawing.Color.White;
            this.Combo_TipoUsuario.FormattingEnabled = true;
            this.Combo_TipoUsuario.Items.AddRange(new object[] {
            "Tipo",
            "Administrador",
            "Comum"});
            this.Combo_TipoUsuario.Location = new System.Drawing.Point(253, 124);
            this.Combo_TipoUsuario.Name = "Combo_TipoUsuario";
            this.Combo_TipoUsuario.Size = new System.Drawing.Size(212, 23);
            this.Combo_TipoUsuario.TabIndex = 9;
            // 
            // Btn_CancelarCadastro
            // 
            this.Btn_CancelarCadastro.BackColor = System.Drawing.Color.Transparent;
            this.Btn_CancelarCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CancelarCadastro.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.Btn_CancelarCadastro.FlatAppearance.BorderSize = 0;
            this.Btn_CancelarCadastro.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Btn_CancelarCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_CancelarCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_CancelarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CancelarCadastro.Image = ((System.Drawing.Image)(resources.GetObject("Btn_CancelarCadastro.Image")));
            this.Btn_CancelarCadastro.Location = new System.Drawing.Point(442, 3);
            this.Btn_CancelarCadastro.Name = "Btn_CancelarCadastro";
            this.Btn_CancelarCadastro.Size = new System.Drawing.Size(23, 21);
            this.Btn_CancelarCadastro.TabIndex = 11;
            this.Btn_CancelarCadastro.UseVisualStyleBackColor = false;
            this.Btn_CancelarCadastro.Click += new System.EventHandler(this.Btn_CancelarConfiguracoes_Click);
            // 
            // Btn_SalvarCadastro
            // 
            this.Btn_SalvarCadastro.BackColor = System.Drawing.Color.Black;
            this.Btn_SalvarCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_SalvarCadastro.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.Btn_SalvarCadastro.FlatAppearance.BorderSize = 0;
            this.Btn_SalvarCadastro.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Btn_SalvarCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_SalvarCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_SalvarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SalvarCadastro.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_SalvarCadastro.ForeColor = System.Drawing.Color.White;
            this.Btn_SalvarCadastro.Location = new System.Drawing.Point(9, 163);
            this.Btn_SalvarCadastro.Name = "Btn_SalvarCadastro";
            this.Btn_SalvarCadastro.Size = new System.Drawing.Size(455, 35);
            this.Btn_SalvarCadastro.TabIndex = 10;
            this.Btn_SalvarCadastro.Text = "Salvar";
            this.Btn_SalvarCadastro.UseVisualStyleBackColor = false;
            this.Btn_SalvarCadastro.Click += new System.EventHandler(this.Btn_SalvarCadastro_Click);
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Nome.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Txt_Nome.ForeColor = System.Drawing.Color.White;
            this.Txt_Nome.Location = new System.Drawing.Point(9, 52);
            this.Txt_Nome.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Txt_Nome.MaxLength = 100;
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(212, 15);
            this.Txt_Nome.TabIndex = 2;
            // 
            // Panel_Nome
            // 
            this.Panel_Nome.BackColor = System.Drawing.Color.Black;
            this.Panel_Nome.Location = new System.Drawing.Point(9, 68);
            this.Panel_Nome.Name = "Panel_Nome";
            this.Panel_Nome.Size = new System.Drawing.Size(212, 1);
            this.Panel_Nome.TabIndex = 12;
            // 
            // Txt_Email
            // 
            this.Txt_Email.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Email.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Txt_Email.ForeColor = System.Drawing.Color.White;
            this.Txt_Email.Location = new System.Drawing.Point(253, 52);
            this.Txt_Email.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Txt_Email.MaxLength = 100;
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(212, 15);
            this.Txt_Email.TabIndex = 3;
            // 
            // Panel_Email
            // 
            this.Panel_Email.BackColor = System.Drawing.Color.Black;
            this.Panel_Email.Location = new System.Drawing.Point(253, 68);
            this.Panel_Email.Name = "Panel_Email";
            this.Panel_Email.Size = new System.Drawing.Size(212, 1);
            this.Panel_Email.TabIndex = 13;
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_Senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Senha.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Txt_Senha.ForeColor = System.Drawing.Color.White;
            this.Txt_Senha.Location = new System.Drawing.Point(9, 93);
            this.Txt_Senha.MaxLength = 30;
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.Size = new System.Drawing.Size(212, 15);
            this.Txt_Senha.TabIndex = 4;
            this.Txt_Senha.UseSystemPasswordChar = true;
            // 
            // Btn_MostrarSenha
            // 
            this.Btn_MostrarSenha.BackColor = System.Drawing.Color.Transparent;
            this.Btn_MostrarSenha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_MostrarSenha.BackgroundImage")));
            this.Btn_MostrarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_MostrarSenha.FlatAppearance.BorderSize = 0;
            this.Btn_MostrarSenha.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Btn_MostrarSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_MostrarSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_MostrarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MostrarSenha.Location = new System.Drawing.Point(203, 92);
            this.Btn_MostrarSenha.Name = "Btn_MostrarSenha";
            this.Btn_MostrarSenha.Size = new System.Drawing.Size(17, 16);
            this.Btn_MostrarSenha.TabIndex = 5;
            this.Btn_MostrarSenha.UseVisualStyleBackColor = false;
            this.Btn_MostrarSenha.Click += new System.EventHandler(this.Btn_MostrarSenha_Click);
            // 
            // Panel_Senha
            // 
            this.Panel_Senha.BackColor = System.Drawing.Color.Black;
            this.Panel_Senha.Location = new System.Drawing.Point(9, 110);
            this.Panel_Senha.Name = "Panel_Senha";
            this.Panel_Senha.Size = new System.Drawing.Size(212, 1);
            this.Panel_Senha.TabIndex = 14;
            // 
            // Txt_Repetir
            // 
            this.Txt_Repetir.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_Repetir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Repetir.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Txt_Repetir.ForeColor = System.Drawing.Color.White;
            this.Txt_Repetir.Location = new System.Drawing.Point(253, 94);
            this.Txt_Repetir.MaxLength = 30;
            this.Txt_Repetir.Name = "Txt_Repetir";
            this.Txt_Repetir.Size = new System.Drawing.Size(212, 15);
            this.Txt_Repetir.TabIndex = 6;
            this.Txt_Repetir.UseSystemPasswordChar = true;
            // 
            // Btn_MostrarRepetirSenha
            // 
            this.Btn_MostrarRepetirSenha.BackColor = System.Drawing.Color.Transparent;
            this.Btn_MostrarRepetirSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_MostrarRepetirSenha.FlatAppearance.BorderSize = 0;
            this.Btn_MostrarRepetirSenha.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Btn_MostrarRepetirSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_MostrarRepetirSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_MostrarRepetirSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MostrarRepetirSenha.Image = ((System.Drawing.Image)(resources.GetObject("Btn_MostrarRepetirSenha.Image")));
            this.Btn_MostrarRepetirSenha.Location = new System.Drawing.Point(447, 93);
            this.Btn_MostrarRepetirSenha.Name = "Btn_MostrarRepetirSenha";
            this.Btn_MostrarRepetirSenha.Size = new System.Drawing.Size(17, 16);
            this.Btn_MostrarRepetirSenha.TabIndex = 7;
            this.Btn_MostrarRepetirSenha.UseVisualStyleBackColor = false;
            this.Btn_MostrarRepetirSenha.Click += new System.EventHandler(this.Btn_MostrarRepetirSenha_Click);
            // 
            // Panel_RepetirSenha
            // 
            this.Panel_RepetirSenha.BackColor = System.Drawing.Color.Black;
            this.Panel_RepetirSenha.Location = new System.Drawing.Point(253, 111);
            this.Panel_RepetirSenha.Name = "Panel_RepetirSenha";
            this.Panel_RepetirSenha.Size = new System.Drawing.Size(212, 1);
            this.Panel_RepetirSenha.TabIndex = 15;
            // 
            // Txt_Funcao
            // 
            this.Txt_Funcao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_Funcao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Funcao.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Txt_Funcao.ForeColor = System.Drawing.Color.White;
            this.Txt_Funcao.Location = new System.Drawing.Point(9, 129);
            this.Txt_Funcao.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Txt_Funcao.MaxLength = 100;
            this.Txt_Funcao.Name = "Txt_Funcao";
            this.Txt_Funcao.Size = new System.Drawing.Size(212, 15);
            this.Txt_Funcao.TabIndex = 8;
            // 
            // Panel_Funcao
            // 
            this.Panel_Funcao.BackColor = System.Drawing.Color.Black;
            this.Panel_Funcao.Location = new System.Drawing.Point(9, 145);
            this.Panel_Funcao.Name = "Panel_Funcao";
            this.Panel_Funcao.Size = new System.Drawing.Size(212, 1);
            this.Panel_Funcao.TabIndex = 16;
            // 
            // Label_Cadastro
            // 
            this.Label_Cadastro.AutoSize = true;
            this.Label_Cadastro.BackColor = System.Drawing.Color.Black;
            this.Label_Cadastro.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Cadastro.ForeColor = System.Drawing.Color.White;
            this.Label_Cadastro.Location = new System.Drawing.Point(177, 9);
            this.Label_Cadastro.Name = "Label_Cadastro";
            this.Label_Cadastro.Size = new System.Drawing.Size(87, 15);
            this.Label_Cadastro.TabIndex = 1;
            this.Label_Cadastro.Text = "Cadastro";
            this.Label_Cadastro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(483, 218);
            this.Controls.Add(this.Label_Cadastro);
            this.Controls.Add(this.Panel_Funcao);
            this.Controls.Add(this.Txt_Funcao);
            this.Controls.Add(this.Panel_RepetirSenha);
            this.Controls.Add(this.Btn_MostrarRepetirSenha);
            this.Controls.Add(this.Txt_Repetir);
            this.Controls.Add(this.Panel_Senha);
            this.Controls.Add(this.Btn_MostrarSenha);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Panel_Email);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Panel_Nome);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.Btn_SalvarCadastro);
            this.Controls.Add(this.Btn_CancelarCadastro);
            this.Controls.Add(this.Combo_TipoUsuario);
            this.Name = "FormCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.FormCadastroUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Combo_TipoUsuario;
        private System.Windows.Forms.Button Btn_CancelarCadastro;
        private System.Windows.Forms.Button Btn_SalvarCadastro;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.Panel Panel_Nome;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Panel Panel_Email;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.Button Btn_MostrarSenha;
        private System.Windows.Forms.Panel Panel_Senha;
        private System.Windows.Forms.TextBox Txt_Repetir;
        private System.Windows.Forms.Button Btn_MostrarRepetirSenha;
        private System.Windows.Forms.Panel Panel_RepetirSenha;
        private System.Windows.Forms.TextBox Txt_Funcao;
        private System.Windows.Forms.Panel Panel_Funcao;
        private System.Windows.Forms.Label Label_Cadastro;
    }
}