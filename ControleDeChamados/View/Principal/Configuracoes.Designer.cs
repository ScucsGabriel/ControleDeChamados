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
            this.Link_AlterarUsuario = new System.Windows.Forms.LinkLabel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.Label_UsuarioConfiguracoes = new System.Windows.Forms.Label();
            this.Txt_UsuarioConfiguracoes = new System.Windows.Forms.TextBox();
            this.Label_EmailConfiguracoes = new System.Windows.Forms.Label();
            this.Txt_EmailConfiguracoes = new System.Windows.Forms.TextBox();
            this.Label_FuncaoConfiguracoes = new System.Windows.Forms.Label();
            this.Label_TipoUsuarioConfiguracoes = new System.Windows.Forms.Label();
            this.Combo_FuncaoConfiguracoes = new System.Windows.Forms.ComboBox();
            this.Combo_TipoUsuarioConfiguracoes = new System.Windows.Forms.ComboBox();
            this.Btn_PesquisarEmail = new System.Windows.Forms.Button();
            this.Btn_SalvarConfiguracoes = new System.Windows.Forms.Button();
            this.Btn_CancelarConfiguracoes = new System.Windows.Forms.Button();
            this.Link_DeletarUsuario = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Link_AlterarUsuario
            // 
            this.Link_AlterarUsuario.AutoSize = true;
            this.Link_AlterarUsuario.BackColor = System.Drawing.SystemColors.Info;
            this.Link_AlterarUsuario.Location = new System.Drawing.Point(0, 0);
            this.Link_AlterarUsuario.Name = "Link_AlterarUsuario";
            this.Link_AlterarUsuario.Size = new System.Drawing.Size(85, 15);
            this.Link_AlterarUsuario.TabIndex = 8;
            this.Link_AlterarUsuario.TabStop = true;
            this.Link_AlterarUsuario.Text = "Alterar Usuário";
            this.Link_AlterarUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_AlterarUsuario_LinkClicked);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(643, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // Label_UsuarioConfiguracoes
            // 
            this.Label_UsuarioConfiguracoes.AutoSize = true;
            this.Label_UsuarioConfiguracoes.BackColor = System.Drawing.Color.Transparent;
            this.Label_UsuarioConfiguracoes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_UsuarioConfiguracoes.Location = new System.Drawing.Point(372, 56);
            this.Label_UsuarioConfiguracoes.Name = "Label_UsuarioConfiguracoes";
            this.Label_UsuarioConfiguracoes.Size = new System.Drawing.Size(50, 15);
            this.Label_UsuarioConfiguracoes.TabIndex = 11;
            this.Label_UsuarioConfiguracoes.Text = "Usuário:";
            this.Label_UsuarioConfiguracoes.Visible = false;
            // 
            // Txt_UsuarioConfiguracoes
            // 
            this.Txt_UsuarioConfiguracoes.Location = new System.Drawing.Point(428, 53);
            this.Txt_UsuarioConfiguracoes.Name = "Txt_UsuarioConfiguracoes";
            this.Txt_UsuarioConfiguracoes.Size = new System.Drawing.Size(206, 23);
            this.Txt_UsuarioConfiguracoes.TabIndex = 3;
            this.Txt_UsuarioConfiguracoes.Visible = false;
            this.Txt_UsuarioConfiguracoes.WordWrap = false;
            // 
            // Label_EmailConfiguracoes
            // 
            this.Label_EmailConfiguracoes.AutoSize = true;
            this.Label_EmailConfiguracoes.BackColor = System.Drawing.Color.Transparent;
            this.Label_EmailConfiguracoes.Location = new System.Drawing.Point(43, 56);
            this.Label_EmailConfiguracoes.Name = "Label_EmailConfiguracoes";
            this.Label_EmailConfiguracoes.Size = new System.Drawing.Size(44, 15);
            this.Label_EmailConfiguracoes.TabIndex = 10;
            this.Label_EmailConfiguracoes.Text = "E-mail:";
            this.Label_EmailConfiguracoes.Visible = false;
            // 
            // Txt_EmailConfiguracoes
            // 
            this.Txt_EmailConfiguracoes.Location = new System.Drawing.Point(93, 53);
            this.Txt_EmailConfiguracoes.Name = "Txt_EmailConfiguracoes";
            this.Txt_EmailConfiguracoes.Size = new System.Drawing.Size(206, 23);
            this.Txt_EmailConfiguracoes.TabIndex = 1;
            this.Txt_EmailConfiguracoes.Visible = false;
            // 
            // Label_FuncaoConfiguracoes
            // 
            this.Label_FuncaoConfiguracoes.AutoSize = true;
            this.Label_FuncaoConfiguracoes.BackColor = System.Drawing.Color.Transparent;
            this.Label_FuncaoConfiguracoes.Location = new System.Drawing.Point(38, 100);
            this.Label_FuncaoConfiguracoes.Name = "Label_FuncaoConfiguracoes";
            this.Label_FuncaoConfiguracoes.Size = new System.Drawing.Size(49, 15);
            this.Label_FuncaoConfiguracoes.TabIndex = 12;
            this.Label_FuncaoConfiguracoes.Text = "Função:";
            this.Label_FuncaoConfiguracoes.Visible = false;
            // 
            // Label_TipoUsuarioConfiguracoes
            // 
            this.Label_TipoUsuarioConfiguracoes.AutoSize = true;
            this.Label_TipoUsuarioConfiguracoes.BackColor = System.Drawing.Color.Transparent;
            this.Label_TipoUsuarioConfiguracoes.Location = new System.Drawing.Point(346, 100);
            this.Label_TipoUsuarioConfiguracoes.Name = "Label_TipoUsuarioConfiguracoes";
            this.Label_TipoUsuarioConfiguracoes.Size = new System.Drawing.Size(76, 15);
            this.Label_TipoUsuarioConfiguracoes.TabIndex = 13;
            this.Label_TipoUsuarioConfiguracoes.Text = "Tipo Usuário:";
            this.Label_TipoUsuarioConfiguracoes.Visible = false;
            // 
            // Combo_FuncaoConfiguracoes
            // 
            this.Combo_FuncaoConfiguracoes.FormattingEnabled = true;
            this.Combo_FuncaoConfiguracoes.Items.AddRange(new object[] {
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
            this.Combo_FuncaoConfiguracoes.Location = new System.Drawing.Point(93, 97);
            this.Combo_FuncaoConfiguracoes.Name = "Combo_FuncaoConfiguracoes";
            this.Combo_FuncaoConfiguracoes.Size = new System.Drawing.Size(206, 23);
            this.Combo_FuncaoConfiguracoes.TabIndex = 4;
            this.Combo_FuncaoConfiguracoes.Text = "-- Selecione --";
            this.Combo_FuncaoConfiguracoes.Visible = false;
            // 
            // Combo_TipoUsuarioConfiguracoes
            // 
            this.Combo_TipoUsuarioConfiguracoes.FormattingEnabled = true;
            this.Combo_TipoUsuarioConfiguracoes.Items.AddRange(new object[] {
            "Administrador",
            "Comum"});
            this.Combo_TipoUsuarioConfiguracoes.Location = new System.Drawing.Point(428, 97);
            this.Combo_TipoUsuarioConfiguracoes.Name = "Combo_TipoUsuarioConfiguracoes";
            this.Combo_TipoUsuarioConfiguracoes.Size = new System.Drawing.Size(206, 23);
            this.Combo_TipoUsuarioConfiguracoes.TabIndex = 5;
            this.Combo_TipoUsuarioConfiguracoes.Text = "-- Selecione --";
            this.Combo_TipoUsuarioConfiguracoes.Visible = false;
            // 
            // Btn_PesquisarEmail
            // 
            this.Btn_PesquisarEmail.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.Btn_PesquisarEmail.FlatAppearance.BorderSize = 0;
            this.Btn_PesquisarEmail.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.Btn_PesquisarEmail.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.Btn_PesquisarEmail.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.Btn_PesquisarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_PesquisarEmail.Image = ((System.Drawing.Image)(resources.GetObject("Btn_PesquisarEmail.Image")));
            this.Btn_PesquisarEmail.Location = new System.Drawing.Point(305, 53);
            this.Btn_PesquisarEmail.Name = "Btn_PesquisarEmail";
            this.Btn_PesquisarEmail.Size = new System.Drawing.Size(28, 27);
            this.Btn_PesquisarEmail.TabIndex = 2;
            this.Btn_PesquisarEmail.UseVisualStyleBackColor = true;
            this.Btn_PesquisarEmail.Visible = false;
            this.Btn_PesquisarEmail.Click += new System.EventHandler(this.Btn_PesquisarEmail_Click);
            // 
            // Btn_SalvarConfiguracoes
            // 
            this.Btn_SalvarConfiguracoes.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_SalvarConfiguracoes.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.Btn_SalvarConfiguracoes.FlatAppearance.BorderSize = 0;
            this.Btn_SalvarConfiguracoes.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Info;
            this.Btn_SalvarConfiguracoes.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.Btn_SalvarConfiguracoes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Info;
            this.Btn_SalvarConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SalvarConfiguracoes.Image = ((System.Drawing.Image)(resources.GetObject("Btn_SalvarConfiguracoes.Image")));
            this.Btn_SalvarConfiguracoes.Location = new System.Drawing.Point(356, 1);
            this.Btn_SalvarConfiguracoes.Name = "Btn_SalvarConfiguracoes";
            this.Btn_SalvarConfiguracoes.Size = new System.Drawing.Size(28, 25);
            this.Btn_SalvarConfiguracoes.TabIndex = 6;
            this.Btn_SalvarConfiguracoes.UseVisualStyleBackColor = false;
            this.Btn_SalvarConfiguracoes.Click += new System.EventHandler(this.Btn_SalvarConfiguracoes_Click);
            // 
            // Btn_CancelarConfiguracoes
            // 
            this.Btn_CancelarConfiguracoes.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_CancelarConfiguracoes.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.Btn_CancelarConfiguracoes.FlatAppearance.BorderSize = 0;
            this.Btn_CancelarConfiguracoes.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Info;
            this.Btn_CancelarConfiguracoes.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.Btn_CancelarConfiguracoes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Info;
            this.Btn_CancelarConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CancelarConfiguracoes.Image = ((System.Drawing.Image)(resources.GetObject("Btn_CancelarConfiguracoes.Image")));
            this.Btn_CancelarConfiguracoes.Location = new System.Drawing.Point(413, 3);
            this.Btn_CancelarConfiguracoes.Name = "Btn_CancelarConfiguracoes";
            this.Btn_CancelarConfiguracoes.Size = new System.Drawing.Size(23, 21);
            this.Btn_CancelarConfiguracoes.TabIndex = 7;
            this.Btn_CancelarConfiguracoes.UseVisualStyleBackColor = false;
            this.Btn_CancelarConfiguracoes.Click += new System.EventHandler(this.Btn_CancelarConfiguracoes_Click);
            // 
            // Link_DeletarUsuario
            // 
            this.Link_DeletarUsuario.AutoSize = true;
            this.Link_DeletarUsuario.BackColor = System.Drawing.SystemColors.Info;
            this.Link_DeletarUsuario.Location = new System.Drawing.Point(107, 1);
            this.Link_DeletarUsuario.Name = "Link_DeletarUsuario";
            this.Link_DeletarUsuario.Size = new System.Drawing.Size(98, 15);
            this.Link_DeletarUsuario.TabIndex = 9;
            this.Link_DeletarUsuario.TabStop = true;
            this.Link_DeletarUsuario.Text = "Desativar Usuário";
            this.Link_DeletarUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_DeletarUsuario_LinkClicked);
            // 
            // FormConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(643, 146);
            this.Controls.Add(this.Link_DeletarUsuario);
            this.Controls.Add(this.Btn_CancelarConfiguracoes);
            this.Controls.Add(this.Btn_SalvarConfiguracoes);
            this.Controls.Add(this.Btn_PesquisarEmail);
            this.Controls.Add(this.Combo_TipoUsuarioConfiguracoes);
            this.Controls.Add(this.Combo_FuncaoConfiguracoes);
            this.Controls.Add(this.Label_TipoUsuarioConfiguracoes);
            this.Controls.Add(this.Label_FuncaoConfiguracoes);
            this.Controls.Add(this.Txt_EmailConfiguracoes);
            this.Controls.Add(this.Label_EmailConfiguracoes);
            this.Controls.Add(this.Txt_UsuarioConfiguracoes);
            this.Controls.Add(this.Label_UsuarioConfiguracoes);
            this.Controls.Add(this.Link_AlterarUsuario);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FormConfiguracoes";
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.FormConfiguracoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel Link_AlterarUsuario;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Label Label_UsuarioConfiguracoes;
        private System.Windows.Forms.TextBox Txt_UsuarioConfiguracoes;
        private System.Windows.Forms.Label Label_EmailConfiguracoes;
        private System.Windows.Forms.TextBox Txt_EmailConfiguracoes;
        private System.Windows.Forms.Label Label_FuncaoConfiguracoes;
        private System.Windows.Forms.Label Label_TipoUsuarioConfiguracoes;
        private System.Windows.Forms.ComboBox Combo_FuncaoConfiguracoes;
        private System.Windows.Forms.ComboBox Combo_TipoUsuarioConfiguracoes;
        private System.Windows.Forms.Button Btn_BuscaEmailUsuario;
        private System.Windows.Forms.Button Btn_PesquisarEmail;
        private System.Windows.Forms.Button Btn_SalvarConfiguracoes;
        private System.Windows.Forms.Button Btn_CancelarConfiguracoes;
        private System.Windows.Forms.LinkLabel Link_DeletarUsuario;
    }
}