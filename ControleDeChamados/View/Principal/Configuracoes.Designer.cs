namespace ControleDeChamados.View.Principal
{
    partial class FormConfiguracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguracoes));
            this.Combo_TipoUsuarioConfiguracoes = new System.Windows.Forms.ComboBox();
            this.Btn_PesquisarEmail = new System.Windows.Forms.Button();
            this.Btn_SalvarConfiguracoes = new System.Windows.Forms.Button();
            this.Btn_CancelarConfiguracoes = new System.Windows.Forms.Button();
            this.Btn_AlterarUsuario = new System.Windows.Forms.Button();
            this.Btn_DesativarUsuario = new System.Windows.Forms.Button();
            this.Txt_Funcao = new System.Windows.Forms.TextBox();
            this.Panel_Funcao = new System.Windows.Forms.Panel();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Panel_Email = new System.Windows.Forms.Panel();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Panel_Usuario = new System.Windows.Forms.Panel();
            this.Label_Configuracoes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Combo_TipoUsuarioConfiguracoes
            // 
            this.Combo_TipoUsuarioConfiguracoes.BackColor = System.Drawing.SystemColors.Window;
            this.Combo_TipoUsuarioConfiguracoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_TipoUsuarioConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Combo_TipoUsuarioConfiguracoes.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Combo_TipoUsuarioConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.Combo_TipoUsuarioConfiguracoes.FormattingEnabled = true;
            this.Combo_TipoUsuarioConfiguracoes.Items.AddRange(new object[] {
            "Tipo",
            "Administrador",
            "Comum"});
            this.Combo_TipoUsuarioConfiguracoes.Location = new System.Drawing.Point(281, 158);
            this.Combo_TipoUsuarioConfiguracoes.Name = "Combo_TipoUsuarioConfiguracoes";
            this.Combo_TipoUsuarioConfiguracoes.Size = new System.Drawing.Size(212, 23);
            this.Combo_TipoUsuarioConfiguracoes.TabIndex = 8;
            this.Combo_TipoUsuarioConfiguracoes.Visible = false;
            // 
            // Btn_PesquisarEmail
            // 
            this.Btn_PesquisarEmail.BackColor = System.Drawing.Color.Transparent;
            this.Btn_PesquisarEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_PesquisarEmail.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.Btn_PesquisarEmail.FlatAppearance.BorderSize = 0;
            this.Btn_PesquisarEmail.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Btn_PesquisarEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_PesquisarEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_PesquisarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_PesquisarEmail.Image = ((System.Drawing.Image)(resources.GetObject("Btn_PesquisarEmail.Image")));
            this.Btn_PesquisarEmail.Location = new System.Drawing.Point(236, 125);
            this.Btn_PesquisarEmail.Name = "Btn_PesquisarEmail";
            this.Btn_PesquisarEmail.Size = new System.Drawing.Size(28, 27);
            this.Btn_PesquisarEmail.TabIndex = 5;
            this.Btn_PesquisarEmail.UseVisualStyleBackColor = false;
            this.Btn_PesquisarEmail.Visible = false;
            this.Btn_PesquisarEmail.Click += new System.EventHandler(this.Btn_PesquisarEmail_Click);
            // 
            // Btn_SalvarConfiguracoes
            // 
            this.Btn_SalvarConfiguracoes.BackColor = System.Drawing.Color.Black;
            this.Btn_SalvarConfiguracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_SalvarConfiguracoes.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.Btn_SalvarConfiguracoes.FlatAppearance.BorderSize = 0;
            this.Btn_SalvarConfiguracoes.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Btn_SalvarConfiguracoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_SalvarConfiguracoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_SalvarConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SalvarConfiguracoes.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_SalvarConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.Btn_SalvarConfiguracoes.Location = new System.Drawing.Point(18, 215);
            this.Btn_SalvarConfiguracoes.Name = "Btn_SalvarConfiguracoes";
            this.Btn_SalvarConfiguracoes.Size = new System.Drawing.Size(475, 31);
            this.Btn_SalvarConfiguracoes.TabIndex = 9;
            this.Btn_SalvarConfiguracoes.Text = "Salvar";
            this.Btn_SalvarConfiguracoes.UseVisualStyleBackColor = false;
            this.Btn_SalvarConfiguracoes.Click += new System.EventHandler(this.Btn_SalvarConfiguracoes_Click);
            // 
            // Btn_CancelarConfiguracoes
            // 
            this.Btn_CancelarConfiguracoes.BackColor = System.Drawing.Color.Transparent;
            this.Btn_CancelarConfiguracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CancelarConfiguracoes.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.Btn_CancelarConfiguracoes.FlatAppearance.BorderSize = 0;
            this.Btn_CancelarConfiguracoes.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Btn_CancelarConfiguracoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_CancelarConfiguracoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_CancelarConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CancelarConfiguracoes.Image = ((System.Drawing.Image)(resources.GetObject("Btn_CancelarConfiguracoes.Image")));
            this.Btn_CancelarConfiguracoes.Location = new System.Drawing.Point(470, 1);
            this.Btn_CancelarConfiguracoes.Name = "Btn_CancelarConfiguracoes";
            this.Btn_CancelarConfiguracoes.Size = new System.Drawing.Size(23, 21);
            this.Btn_CancelarConfiguracoes.TabIndex = 10;
            this.Btn_CancelarConfiguracoes.UseVisualStyleBackColor = false;
            this.Btn_CancelarConfiguracoes.Click += new System.EventHandler(this.Btn_CancelarConfiguracoes_Click);
            // 
            // Btn_AlterarUsuario
            // 
            this.Btn_AlterarUsuario.BackColor = System.Drawing.Color.Black;
            this.Btn_AlterarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_AlterarUsuario.FlatAppearance.BorderSize = 0;
            this.Btn_AlterarUsuario.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Btn_AlterarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_AlterarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_AlterarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AlterarUsuario.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_AlterarUsuario.ForeColor = System.Drawing.Color.White;
            this.Btn_AlterarUsuario.Location = new System.Drawing.Point(13, 46);
            this.Btn_AlterarUsuario.Name = "Btn_AlterarUsuario";
            this.Btn_AlterarUsuario.Size = new System.Drawing.Size(86, 23);
            this.Btn_AlterarUsuario.TabIndex = 2;
            this.Btn_AlterarUsuario.Text = "Alterar";
            this.Btn_AlterarUsuario.UseVisualStyleBackColor = false;
            this.Btn_AlterarUsuario.Click += new System.EventHandler(this.Btn_AlterarUsuario_Click);
            // 
            // Btn_DesativarUsuario
            // 
            this.Btn_DesativarUsuario.BackColor = System.Drawing.Color.Black;
            this.Btn_DesativarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_DesativarUsuario.FlatAppearance.BorderSize = 0;
            this.Btn_DesativarUsuario.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Btn_DesativarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_DesativarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_DesativarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DesativarUsuario.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_DesativarUsuario.ForeColor = System.Drawing.Color.White;
            this.Btn_DesativarUsuario.Location = new System.Drawing.Point(103, 46);
            this.Btn_DesativarUsuario.Name = "Btn_DesativarUsuario";
            this.Btn_DesativarUsuario.Size = new System.Drawing.Size(107, 23);
            this.Btn_DesativarUsuario.TabIndex = 3;
            this.Btn_DesativarUsuario.Text = "Desativar";
            this.Btn_DesativarUsuario.UseVisualStyleBackColor = false;
            this.Btn_DesativarUsuario.Click += new System.EventHandler(this.Btn_DesativaUsuario_Click);
            // 
            // Txt_Funcao
            // 
            this.Txt_Funcao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_Funcao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Funcao.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Txt_Funcao.ForeColor = System.Drawing.Color.White;
            this.Txt_Funcao.Location = new System.Drawing.Point(18, 171);
            this.Txt_Funcao.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Txt_Funcao.MaxLength = 100;
            this.Txt_Funcao.Name = "Txt_Funcao";
            this.Txt_Funcao.Size = new System.Drawing.Size(212, 15);
            this.Txt_Funcao.TabIndex = 7;
            this.Txt_Funcao.Visible = false;
            // 
            // Panel_Funcao
            // 
            this.Panel_Funcao.BackColor = System.Drawing.Color.Black;
            this.Panel_Funcao.Location = new System.Drawing.Point(18, 187);
            this.Panel_Funcao.Name = "Panel_Funcao";
            this.Panel_Funcao.Size = new System.Drawing.Size(212, 1);
            this.Panel_Funcao.TabIndex = 13;
            this.Panel_Funcao.Visible = false;
            // 
            // Txt_Email
            // 
            this.Txt_Email.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Email.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Txt_Email.ForeColor = System.Drawing.Color.White;
            this.Txt_Email.Location = new System.Drawing.Point(18, 128);
            this.Txt_Email.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Txt_Email.MaxLength = 100;
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(212, 15);
            this.Txt_Email.TabIndex = 4;
            this.Txt_Email.Visible = false;
            this.Txt_Email.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_Email_KeyUp);
            // 
            // Panel_Email
            // 
            this.Panel_Email.BackColor = System.Drawing.Color.Black;
            this.Panel_Email.Location = new System.Drawing.Point(18, 144);
            this.Panel_Email.Name = "Panel_Email";
            this.Panel_Email.Size = new System.Drawing.Size(212, 1);
            this.Panel_Email.TabIndex = 11;
            this.Panel_Email.Visible = false;
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Usuario.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Txt_Usuario.ForeColor = System.Drawing.Color.White;
            this.Txt_Usuario.Location = new System.Drawing.Point(281, 125);
            this.Txt_Usuario.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Txt_Usuario.MaxLength = 100;
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(212, 15);
            this.Txt_Usuario.TabIndex = 6;
            this.Txt_Usuario.Visible = false;
            // 
            // Panel_Usuario
            // 
            this.Panel_Usuario.BackColor = System.Drawing.Color.Black;
            this.Panel_Usuario.Location = new System.Drawing.Point(281, 141);
            this.Panel_Usuario.Name = "Panel_Usuario";
            this.Panel_Usuario.Size = new System.Drawing.Size(212, 1);
            this.Panel_Usuario.TabIndex = 12;
            this.Panel_Usuario.Visible = false;
            // 
            // Label_Configuracoes
            // 
            this.Label_Configuracoes.AutoSize = true;
            this.Label_Configuracoes.BackColor = System.Drawing.Color.Black;
            this.Label_Configuracoes.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Configuracoes.ForeColor = System.Drawing.Color.White;
            this.Label_Configuracoes.Location = new System.Drawing.Point(165, 13);
            this.Label_Configuracoes.Name = "Label_Configuracoes";
            this.Label_Configuracoes.Size = new System.Drawing.Size(137, 15);
            this.Label_Configuracoes.TabIndex = 1;
            this.Label_Configuracoes.Text = "Configurações";
            this.Label_Configuracoes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 258);
            this.Controls.Add(this.Label_Configuracoes);
            this.Controls.Add(this.Panel_Usuario);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.Panel_Email);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.Panel_Funcao);
            this.Controls.Add(this.Txt_Funcao);
            this.Controls.Add(this.Btn_DesativarUsuario);
            this.Controls.Add(this.Btn_AlterarUsuario);
            this.Controls.Add(this.Btn_CancelarConfiguracoes);
            this.Controls.Add(this.Btn_SalvarConfiguracoes);
            this.Controls.Add(this.Btn_PesquisarEmail);
            this.Controls.Add(this.Combo_TipoUsuarioConfiguracoes);
            this.Name = "FormConfiguracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.FormConfiguracoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Combo_TipoUsuarioConfiguracoes;
        private System.Windows.Forms.Button Btn_BuscaEmailUsuario;
        private System.Windows.Forms.Button Btn_PesquisarEmail;
        private System.Windows.Forms.Button Btn_SalvarConfiguracoes;
        private System.Windows.Forms.Button Btn_CancelarConfiguracoes;
        private System.Windows.Forms.Button Btn_AlterarUsuario;
        private System.Windows.Forms.Button Btn_DesativarUsuario;
        private System.Windows.Forms.TextBox Txt_Funcao;
        private System.Windows.Forms.Panel Panel_Funcao;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Panel Panel_Email;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Panel Panel_Usuario;
        private System.Windows.Forms.Label Label_Configuracoes;
    }
}