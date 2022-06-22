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
            this.Txt_UsuarioLogin = new System.Windows.Forms.TextBox();
            this.Txt_SenhaLogin = new System.Windows.Forms.TextBox();
            this.Btn_MostrarSenha = new System.Windows.Forms.Button();
            this.Label_Login = new System.Windows.Forms.Label();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.Btn_NovoUsuario = new System.Windows.Forms.Button();
            this.Btn_NovaSenha = new System.Windows.Forms.Button();
            this.Pic_Usuario = new System.Windows.Forms.PictureBox();
            this.Pic_Senha = new System.Windows.Forms.PictureBox();
            this.Panel_Usuario = new System.Windows.Forms.Panel();
            this.Panel_Senha = new System.Windows.Forms.Panel();
            this.Btn_Sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Senha)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_UsuarioLogin
            // 
            this.Txt_UsuarioLogin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_UsuarioLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_UsuarioLogin.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Txt_UsuarioLogin.ForeColor = System.Drawing.Color.White;
            this.Txt_UsuarioLogin.Location = new System.Drawing.Point(38, 53);
            this.Txt_UsuarioLogin.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Txt_UsuarioLogin.MaxLength = 100;
            this.Txt_UsuarioLogin.Name = "Txt_UsuarioLogin";
            this.Txt_UsuarioLogin.Size = new System.Drawing.Size(362, 15);
            this.Txt_UsuarioLogin.TabIndex = 2;
            // 
            // Txt_SenhaLogin
            // 
            this.Txt_SenhaLogin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_SenhaLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_SenhaLogin.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Txt_SenhaLogin.ForeColor = System.Drawing.Color.White;
            this.Txt_SenhaLogin.Location = new System.Drawing.Point(38, 94);
            this.Txt_SenhaLogin.MaxLength = 30;
            this.Txt_SenhaLogin.Name = "Txt_SenhaLogin";
            this.Txt_SenhaLogin.Size = new System.Drawing.Size(364, 15);
            this.Txt_SenhaLogin.TabIndex = 3;
            this.Txt_SenhaLogin.UseSystemPasswordChar = true;
            this.Txt_SenhaLogin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_SenhaLogin_KeyUp);
            // 
            // Btn_MostrarSenha
            // 
            this.Btn_MostrarSenha.BackColor = System.Drawing.Color.Transparent;
            this.Btn_MostrarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_MostrarSenha.FlatAppearance.BorderSize = 0;
            this.Btn_MostrarSenha.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Btn_MostrarSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_MostrarSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_MostrarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MostrarSenha.Image = ((System.Drawing.Image)(resources.GetObject("Btn_MostrarSenha.Image")));
            this.Btn_MostrarSenha.Location = new System.Drawing.Point(367, 75);
            this.Btn_MostrarSenha.Name = "Btn_MostrarSenha";
            this.Btn_MostrarSenha.Size = new System.Drawing.Size(33, 36);
            this.Btn_MostrarSenha.TabIndex = 4;
            this.Btn_MostrarSenha.UseVisualStyleBackColor = false;
            this.Btn_MostrarSenha.Click += new System.EventHandler(this.Btn_MostrarSenha_Click);
            // 
            // Label_Login
            // 
            this.Label_Login.AutoSize = true;
            this.Label_Login.BackColor = System.Drawing.Color.Black;
            this.Label_Login.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Login.ForeColor = System.Drawing.Color.White;
            this.Label_Login.Location = new System.Drawing.Point(174, 13);
            this.Label_Login.Name = "Label_Login";
            this.Label_Login.Size = new System.Drawing.Size(57, 15);
            this.Label_Login.TabIndex = 1;
            this.Label_Login.Text = "Login";
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.Color.Black;
            this.Btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Login.FlatAppearance.BorderSize = 0;
            this.Btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Login.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Login.ForeColor = System.Drawing.Color.White;
            this.Btn_Login.Location = new System.Drawing.Point(12, 132);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(395, 33);
            this.Btn_Login.TabIndex = 4;
            this.Btn_Login.Text = "Entrar";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // Btn_NovoUsuario
            // 
            this.Btn_NovoUsuario.BackColor = System.Drawing.Color.Black;
            this.Btn_NovoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_NovoUsuario.FlatAppearance.BorderSize = 0;
            this.Btn_NovoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_NovoUsuario.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_NovoUsuario.ForeColor = System.Drawing.Color.White;
            this.Btn_NovoUsuario.Location = new System.Drawing.Point(12, 200);
            this.Btn_NovoUsuario.Name = "Btn_NovoUsuario";
            this.Btn_NovoUsuario.Size = new System.Drawing.Size(99, 25);
            this.Btn_NovoUsuario.TabIndex = 5;
            this.Btn_NovoUsuario.Text = "Cadastre-se";
            this.Btn_NovoUsuario.UseVisualStyleBackColor = false;
            this.Btn_NovoUsuario.Click += new System.EventHandler(this.Btn_NovoUsuario_Click);
            // 
            // Btn_NovaSenha
            // 
            this.Btn_NovaSenha.BackColor = System.Drawing.Color.Black;
            this.Btn_NovaSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_NovaSenha.FlatAppearance.BorderSize = 0;
            this.Btn_NovaSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_NovaSenha.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_NovaSenha.ForeColor = System.Drawing.Color.White;
            this.Btn_NovaSenha.Location = new System.Drawing.Point(257, 200);
            this.Btn_NovaSenha.Name = "Btn_NovaSenha";
            this.Btn_NovaSenha.Size = new System.Drawing.Size(150, 25);
            this.Btn_NovaSenha.TabIndex = 6;
            this.Btn_NovaSenha.Text = "Esqueceu a Senha?";
            this.Btn_NovaSenha.UseVisualStyleBackColor = false;
            this.Btn_NovaSenha.Click += new System.EventHandler(this.Btn_NovaSenha_Click);
            // 
            // Pic_Usuario
            // 
            this.Pic_Usuario.BackColor = System.Drawing.SystemColors.Window;
            this.Pic_Usuario.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Usuario.Image")));
            this.Pic_Usuario.Location = new System.Drawing.Point(10, 44);
            this.Pic_Usuario.Name = "Pic_Usuario";
            this.Pic_Usuario.Size = new System.Drawing.Size(25, 25);
            this.Pic_Usuario.TabIndex = 12;
            this.Pic_Usuario.TabStop = false;
            // 
            // Pic_Senha
            // 
            this.Pic_Senha.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Senha.Image")));
            this.Pic_Senha.Location = new System.Drawing.Point(10, 86);
            this.Pic_Senha.Name = "Pic_Senha";
            this.Pic_Senha.Size = new System.Drawing.Size(25, 25);
            this.Pic_Senha.TabIndex = 13;
            this.Pic_Senha.TabStop = false;
            // 
            // Panel_Usuario
            // 
            this.Panel_Usuario.BackColor = System.Drawing.Color.White;
            this.Panel_Usuario.ForeColor = System.Drawing.Color.Black;
            this.Panel_Usuario.Location = new System.Drawing.Point(38, 68);
            this.Panel_Usuario.Name = "Panel_Usuario";
            this.Panel_Usuario.Size = new System.Drawing.Size(362, 1);
            this.Panel_Usuario.TabIndex = 8;
            // 
            // Panel_Senha
            // 
            this.Panel_Senha.BackColor = System.Drawing.Color.Black;
            this.Panel_Senha.Location = new System.Drawing.Point(38, 110);
            this.Panel_Senha.Name = "Panel_Senha";
            this.Panel_Senha.Size = new System.Drawing.Size(364, 1);
            this.Panel_Senha.TabIndex = 9;
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.BackColor = System.Drawing.Color.White;
            this.Btn_Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Sair.BackgroundImage")));
            this.Btn_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Sair.FlatAppearance.BorderSize = 0;
            this.Btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sair.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Sair.ForeColor = System.Drawing.Color.Black;
            this.Btn_Sair.Location = new System.Drawing.Point(382, 3);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(25, 25);
            this.Btn_Sair.TabIndex = 7;
            this.Btn_Sair.UseVisualStyleBackColor = false;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(412, 249);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Panel_Senha);
            this.Controls.Add(this.Panel_Usuario);
            this.Controls.Add(this.Pic_Senha);
            this.Controls.Add(this.Pic_Usuario);
            this.Controls.Add(this.Btn_NovaSenha);
            this.Controls.Add(this.Btn_NovoUsuario);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Label_Login);
            this.Controls.Add(this.Btn_MostrarSenha);
            this.Controls.Add(this.Txt_SenhaLogin);
            this.Controls.Add(this.Txt_UsuarioLogin);
            this.Name = "FormUsuario";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUsuario_FormClosed);
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Senha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_UsuarioLogin;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.TextBox Txt_SenhaLogin;
        private System.Windows.Forms.Button Btn_MostrarSenha;
        private System.Windows.Forms.Label Label_Login;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Button Btn_NovoUsuario;
        private System.Windows.Forms.Button Btn_NovaSenha;
        private System.Windows.Forms.PictureBox Pic_Usuario;
        private System.Windows.Forms.PictureBox Pic_Senha;
        private System.Windows.Forms.Panel Panel_Usuario;
        private System.Windows.Forms.Panel Panel_Senha;
        private System.Windows.Forms.Button Btn_Sair;
    }
}