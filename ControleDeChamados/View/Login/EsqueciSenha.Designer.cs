namespace ControleDeChamados.View.Login
{
    partial class FormEsqueciSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEsqueciSenha));
            this.Label_UsuarioEsqueciSenha = new System.Windows.Forms.Label();
            this.Txt_UsuarioEsqueciSenha = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Btn_CancelarEsqueciSenha = new System.Windows.Forms.Button();
            this.Btn_ResetarSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_UsuarioEsqueciSenha
            // 
            this.Label_UsuarioEsqueciSenha.AutoSize = true;
            this.Label_UsuarioEsqueciSenha.BackColor = System.Drawing.Color.Transparent;
            this.Label_UsuarioEsqueciSenha.Location = new System.Drawing.Point(27, 40);
            this.Label_UsuarioEsqueciSenha.Name = "Label_UsuarioEsqueciSenha";
            this.Label_UsuarioEsqueciSenha.Size = new System.Drawing.Size(50, 15);
            this.Label_UsuarioEsqueciSenha.TabIndex = 4;
            this.Label_UsuarioEsqueciSenha.Text = "Usuário:";
            // 
            // Txt_UsuarioEsqueciSenha
            // 
            this.Txt_UsuarioEsqueciSenha.Location = new System.Drawing.Point(83, 37);
            this.Txt_UsuarioEsqueciSenha.MaxLength = 100;
            this.Txt_UsuarioEsqueciSenha.Name = "Txt_UsuarioEsqueciSenha";
            this.Txt_UsuarioEsqueciSenha.Size = new System.Drawing.Size(212, 23);
            this.Txt_UsuarioEsqueciSenha.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(345, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Btn_CancelarEsqueciSenha
            // 
            this.Btn_CancelarEsqueciSenha.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_CancelarEsqueciSenha.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.Btn_CancelarEsqueciSenha.FlatAppearance.BorderSize = 0;
            this.Btn_CancelarEsqueciSenha.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Info;
            this.Btn_CancelarEsqueciSenha.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.Btn_CancelarEsqueciSenha.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Info;
            this.Btn_CancelarEsqueciSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CancelarEsqueciSenha.Image = ((System.Drawing.Image)(resources.GetObject("Btn_CancelarEsqueciSenha.Image")));
            this.Btn_CancelarEsqueciSenha.Location = new System.Drawing.Point(12, 0);
            this.Btn_CancelarEsqueciSenha.Name = "Btn_CancelarEsqueciSenha";
            this.Btn_CancelarEsqueciSenha.Size = new System.Drawing.Size(23, 21);
            this.Btn_CancelarEsqueciSenha.TabIndex = 14;
            this.Btn_CancelarEsqueciSenha.UseVisualStyleBackColor = false;
            this.Btn_CancelarEsqueciSenha.Click += new System.EventHandler(this.Btn_CancelarConfiguracoes_Click);
            // 
            // Btn_ResetarSenha
            // 
            this.Btn_ResetarSenha.BackColor = System.Drawing.Color.Transparent;
            this.Btn_ResetarSenha.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.Btn_ResetarSenha.FlatAppearance.BorderSize = 0;
            this.Btn_ResetarSenha.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Window;
            this.Btn_ResetarSenha.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.Btn_ResetarSenha.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.Btn_ResetarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ResetarSenha.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ResetarSenha.Image")));
            this.Btn_ResetarSenha.Location = new System.Drawing.Point(301, 34);
            this.Btn_ResetarSenha.Name = "Btn_ResetarSenha";
            this.Btn_ResetarSenha.Size = new System.Drawing.Size(28, 27);
            this.Btn_ResetarSenha.TabIndex = 12;
            this.Btn_ResetarSenha.UseVisualStyleBackColor = false;
            this.Btn_ResetarSenha.Click += new System.EventHandler(this.Btn_ResetarSenha_Click);
            // 
            // FormEsqueciSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(345, 130);
            this.Controls.Add(this.Btn_ResetarSenha);
            this.Controls.Add(this.Btn_CancelarEsqueciSenha);
            this.Controls.Add(this.Txt_UsuarioEsqueciSenha);
            this.Controls.Add(this.Label_UsuarioEsqueciSenha);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormEsqueciSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esqueci a Senha";
            this.Load += new System.EventHandler(this.FormEsqueciSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_UsuarioEsqueciSenha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Txt_UsuarioEsqueciSenha;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button Btn_CancelarEsqueciSenha;
        private System.Windows.Forms.Button Btn_ResetarSenha;
    }
}