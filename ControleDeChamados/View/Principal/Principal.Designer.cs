namespace ControleDeChamados.View.Principal
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_TotalChamados = new System.Windows.Forms.Button();
            this.Link_Configurações = new System.Windows.Forms.LinkLabel();
            this.Link_AbrirChamado = new System.Windows.Forms.LinkLabel();
            this.Link_Sair = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Link_TrocarSenha = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total de Chamados";
            // 
            // Btn_TotalChamados
            // 
            this.Btn_TotalChamados.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_TotalChamados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_TotalChamados.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_TotalChamados.FlatAppearance.BorderSize = 0;
            this.Btn_TotalChamados.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Btn_TotalChamados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_TotalChamados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_TotalChamados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_TotalChamados.Font = new System.Drawing.Font("Arial Narrow", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_TotalChamados.Location = new System.Drawing.Point(55, 91);
            this.Btn_TotalChamados.Name = "Btn_TotalChamados";
            this.Btn_TotalChamados.Size = new System.Drawing.Size(116, 152);
            this.Btn_TotalChamados.TabIndex = 1;
            this.Btn_TotalChamados.Text = "0";
            this.Btn_TotalChamados.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Btn_TotalChamados.UseVisualStyleBackColor = false;
            this.Btn_TotalChamados.Click += new System.EventHandler(this.Btn_TotalChamados_Click);
            // 
            // Link_Configurações
            // 
            this.Link_Configurações.AutoSize = true;
            this.Link_Configurações.BackColor = System.Drawing.SystemColors.Info;
            this.Link_Configurações.Location = new System.Drawing.Point(955, 0);
            this.Link_Configurações.Name = "Link_Configurações";
            this.Link_Configurações.Size = new System.Drawing.Size(84, 15);
            this.Link_Configurações.TabIndex = 2;
            this.Link_Configurações.TabStop = true;
            this.Link_Configurações.Text = "Configurações";
            this.Link_Configurações.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Configurações_LinkClicked);
            // 
            // Link_AbrirChamado
            // 
            this.Link_AbrirChamado.AutoSize = true;
            this.Link_AbrirChamado.BackColor = System.Drawing.SystemColors.Info;
            this.Link_AbrirChamado.Location = new System.Drawing.Point(12, 0);
            this.Link_AbrirChamado.Name = "Link_AbrirChamado";
            this.Link_AbrirChamado.Size = new System.Drawing.Size(88, 15);
            this.Link_AbrirChamado.TabIndex = 3;
            this.Link_AbrirChamado.TabStop = true;
            this.Link_AbrirChamado.Text = "Abrir Chamado";
            this.Link_AbrirChamado.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_AbrirChamado_LinkClicked);
            // 
            // Link_Sair
            // 
            this.Link_Sair.AutoSize = true;
            this.Link_Sair.BackColor = System.Drawing.SystemColors.Info;
            this.Link_Sair.Location = new System.Drawing.Point(1045, 0);
            this.Link_Sair.Name = "Link_Sair";
            this.Link_Sair.Size = new System.Drawing.Size(26, 15);
            this.Link_Sair.TabIndex = 4;
            this.Link_Sair.TabStop = true;
            this.Link_Sair.Text = "Sair";
            this.Link_Sair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Sair_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1185, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Link_TrocarSenha
            // 
            this.Link_TrocarSenha.AutoSize = true;
            this.Link_TrocarSenha.BackColor = System.Drawing.SystemColors.Info;
            this.Link_TrocarSenha.Location = new System.Drawing.Point(875, 0);
            this.Link_TrocarSenha.Name = "Link_TrocarSenha";
            this.Link_TrocarSenha.Size = new System.Drawing.Size(74, 15);
            this.Link_TrocarSenha.TabIndex = 6;
            this.Link_TrocarSenha.TabStop = true;
            this.Link_TrocarSenha.Text = "Trocar Senha";
            this.Link_TrocarSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_TrocarSenha_LinkClicked);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1185, 537);
            this.Controls.Add(this.Link_TrocarSenha);
            this.Controls.Add(this.Link_Sair);
            this.Controls.Add(this.Link_AbrirChamado);
            this.Controls.Add(this.Link_Configurações);
            this.Controls.Add(this.Btn_TotalChamados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormPrincipal";
            this.Text = "Tela Inicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_TotalChamados;
        private System.Windows.Forms.LinkLabel Link_Configurações;
        private System.Windows.Forms.LinkLabel Link_AbrirChamado;
        private System.Windows.Forms.LinkLabel Link_Sair;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.LinkLabel Link_TrocarSenha;
    }
}