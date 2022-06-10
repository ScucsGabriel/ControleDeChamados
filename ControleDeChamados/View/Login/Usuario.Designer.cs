namespace ControleDeChamados.View.Login
{
    partial class FormUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.Label_UsuarioLogin = new System.Windows.Forms.Label();
            this.Label_SenhaLogin = new System.Windows.Forms.Label();
            this.Txt_UsuarioLogin = new System.Windows.Forms.TextBox();
            this.Txt_SenhaLogin = new System.Windows.Forms.TextBox();
            this.Link_NovoUsuario = new System.Windows.Forms.LinkLabel();
            this.Link_EsqueciSenha = new System.Windows.Forms.LinkLabel();
            this.Link_Login = new System.Windows.Forms.LinkLabel();
            this.Btn_MostrarSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_UsuarioLogin
            // 
            this.Label_UsuarioLogin.AutoSize = true;
            this.Label_UsuarioLogin.BackColor = System.Drawing.Color.Transparent;
            this.Label_UsuarioLogin.Location = new System.Drawing.Point(19, 28);
            this.Label_UsuarioLogin.Name = "Label_UsuarioLogin";
            this.Label_UsuarioLogin.Size = new System.Drawing.Size(50, 15);
            this.Label_UsuarioLogin.TabIndex = 7;
            this.Label_UsuarioLogin.Text = "Usuário:";
            // 
            // Label_SenhaLogin
            // 
            this.Label_SenhaLogin.AutoSize = true;
            this.Label_SenhaLogin.BackColor = System.Drawing.Color.Transparent;
            this.Label_SenhaLogin.Location = new System.Drawing.Point(27, 70);
            this.Label_SenhaLogin.Name = "Label_SenhaLogin";
            this.Label_SenhaLogin.Size = new System.Drawing.Size(42, 15);
            this.Label_SenhaLogin.TabIndex = 8;
            this.Label_SenhaLogin.Text = "Senha:";
            // 
            // Txt_UsuarioLogin
            // 
            this.Txt_UsuarioLogin.Location = new System.Drawing.Point(75, 25);
            this.Txt_UsuarioLogin.MaxLength = 100;
            this.Txt_UsuarioLogin.Name = "Txt_UsuarioLogin";
            this.Txt_UsuarioLogin.Size = new System.Drawing.Size(212, 23);
            this.Txt_UsuarioLogin.TabIndex = 1;
            // 
            // Txt_SenhaLogin
            // 
            this.Txt_SenhaLogin.Location = new System.Drawing.Point(75, 67);
            this.Txt_SenhaLogin.MaxLength = 30;
            this.Txt_SenhaLogin.Name = "Txt_SenhaLogin";
            this.Txt_SenhaLogin.Size = new System.Drawing.Size(212, 23);
            this.Txt_SenhaLogin.TabIndex = 2;
            this.Txt_SenhaLogin.UseSystemPasswordChar = true;
            this.Txt_SenhaLogin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_SenhaLogin_KeyUp);
            // 
            // Link_NovoUsuario
            // 
            this.Link_NovoUsuario.AutoSize = true;
            this.Link_NovoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.Link_NovoUsuario.Location = new System.Drawing.Point(12, 229);
            this.Link_NovoUsuario.Name = "Link_NovoUsuario";
            this.Link_NovoUsuario.Size = new System.Drawing.Size(79, 15);
            this.Link_NovoUsuario.TabIndex = 5;
            this.Link_NovoUsuario.TabStop = true;
            this.Link_NovoUsuario.Text = "Novo Usuario";
            this.Link_NovoUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_NovoUsuario_LinkClicked);
            // 
            // Link_EsqueciSenha
            // 
            this.Link_EsqueciSenha.AutoSize = true;
            this.Link_EsqueciSenha.BackColor = System.Drawing.Color.Transparent;
            this.Link_EsqueciSenha.Location = new System.Drawing.Point(197, 229);
            this.Link_EsqueciSenha.Name = "Link_EsqueciSenha";
            this.Link_EsqueciSenha.Size = new System.Drawing.Size(90, 15);
            this.Link_EsqueciSenha.TabIndex = 6;
            this.Link_EsqueciSenha.TabStop = true;
            this.Link_EsqueciSenha.Text = "Esqueci a senha";
            this.Link_EsqueciSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_EsqueciSenha_LinkClicked);
            // 
            // Link_Login
            // 
            this.Link_Login.AutoSize = true;
            this.Link_Login.BackColor = System.Drawing.Color.Transparent;
            this.Link_Login.Location = new System.Drawing.Point(250, 155);
            this.Link_Login.Name = "Link_Login";
            this.Link_Login.Size = new System.Drawing.Size(37, 15);
            this.Link_Login.TabIndex = 4;
            this.Link_Login.TabStop = true;
            this.Link_Login.Text = "Login";
            this.Link_Login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Login_LinkClicked);
            // 
            // Btn_MostrarSenha
            // 
            this.Btn_MostrarSenha.BackColor = System.Drawing.Color.Transparent;
            this.Btn_MostrarSenha.FlatAppearance.BorderSize = 0;
            this.Btn_MostrarSenha.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.Btn_MostrarSenha.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.Btn_MostrarSenha.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.Btn_MostrarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MostrarSenha.Image = ((System.Drawing.Image)(resources.GetObject("Btn_MostrarSenha.Image")));
            this.Btn_MostrarSenha.Location = new System.Drawing.Point(260, 70);
            this.Btn_MostrarSenha.Name = "Btn_MostrarSenha";
            this.Btn_MostrarSenha.Size = new System.Drawing.Size(16, 16);
            this.Btn_MostrarSenha.TabIndex = 9;
            this.Btn_MostrarSenha.UseVisualStyleBackColor = false;
            this.Btn_MostrarSenha.Click += new System.EventHandler(this.Btn_MostrarSenha_Click);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(308, 253);
            this.Controls.Add(this.Btn_MostrarSenha);
            this.Controls.Add(this.Link_Login);
            this.Controls.Add(this.Link_EsqueciSenha);
            this.Controls.Add(this.Link_NovoUsuario);
            this.Controls.Add(this.Txt_SenhaLogin);
            this.Controls.Add(this.Txt_UsuarioLogin);
            this.Controls.Add(this.Label_SenhaLogin);
            this.Controls.Add(this.Label_UsuarioLogin);
            this.Name = "FormUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUsuario_FormClosed);
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_UsuarioLogin;
        private System.Windows.Forms.Label Label_SenhaLogin;
        private System.Windows.Forms.TextBox Txt_UsuarioLogin;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.TextBox Txt_SenhaLogin;
        private System.Windows.Forms.LinkLabel Link_NovoUsuario;
        private System.Windows.Forms.LinkLabel Link_EsqueciSenha;
        private System.Windows.Forms.LinkLabel Link_Login;
        private System.Windows.Forms.Button Btn_MostrarSenha;
    }
}