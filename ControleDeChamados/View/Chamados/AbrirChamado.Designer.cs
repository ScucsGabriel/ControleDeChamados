namespace ControleDeChamados.View.Chamados
{
    partial class FormAbrirChamado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbrirChamado));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Btn_CancelarAbrirChamado = new System.Windows.Forms.Button();
            this.Btn_SalvarAbrirChamado = new System.Windows.Forms.Button();
            this.Label_Chamado = new System.Windows.Forms.Label();
            this.Label_NumeroChamado = new System.Windows.Forms.Label();
            this.Label_Usuario = new System.Windows.Forms.Label();
            this.Txt_NomeUsuario = new System.Windows.Forms.TextBox();
            this.Label_EmailUsuario = new System.Windows.Forms.Label();
            this.Txt_EmailUsuario = new System.Windows.Forms.TextBox();
            this.Label_FuncaoUsuario = new System.Windows.Forms.Label();
            this.Txt_FuncaoUsuario = new System.Windows.Forms.TextBox();
            this.Label_CategoriaChamado = new System.Windows.Forms.Label();
            this.Combo_Categoria = new System.Windows.Forms.ComboBox();
            this.Label_SubcategoriaChamado = new System.Windows.Forms.Label();
            this.Combo_Subcategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Btn_CancelarAbrirChamado
            // 
            this.Btn_CancelarAbrirChamado.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_CancelarAbrirChamado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_CancelarAbrirChamado.BackgroundImage")));
            this.Btn_CancelarAbrirChamado.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.Btn_CancelarAbrirChamado.FlatAppearance.BorderSize = 0;
            this.Btn_CancelarAbrirChamado.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Info;
            this.Btn_CancelarAbrirChamado.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.Btn_CancelarAbrirChamado.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Info;
            this.Btn_CancelarAbrirChamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CancelarAbrirChamado.Location = new System.Drawing.Point(56, 0);
            this.Btn_CancelarAbrirChamado.Name = "Btn_CancelarAbrirChamado";
            this.Btn_CancelarAbrirChamado.Size = new System.Drawing.Size(23, 24);
            this.Btn_CancelarAbrirChamado.TabIndex = 14;
            this.Btn_CancelarAbrirChamado.UseVisualStyleBackColor = false;
            this.Btn_CancelarAbrirChamado.Click += new System.EventHandler(this.Btn_CancelarAbrirChamado_Click);
            // 
            // Btn_SalvarAbrirChamado
            // 
            this.Btn_SalvarAbrirChamado.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_SalvarAbrirChamado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_SalvarAbrirChamado.BackgroundImage")));
            this.Btn_SalvarAbrirChamado.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.Btn_SalvarAbrirChamado.FlatAppearance.BorderSize = 0;
            this.Btn_SalvarAbrirChamado.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Info;
            this.Btn_SalvarAbrirChamado.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.Btn_SalvarAbrirChamado.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Info;
            this.Btn_SalvarAbrirChamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SalvarAbrirChamado.Location = new System.Drawing.Point(12, 0);
            this.Btn_SalvarAbrirChamado.Name = "Btn_SalvarAbrirChamado";
            this.Btn_SalvarAbrirChamado.Size = new System.Drawing.Size(23, 25);
            this.Btn_SalvarAbrirChamado.TabIndex = 13;
            this.Btn_SalvarAbrirChamado.UseVisualStyleBackColor = false;
            this.Btn_SalvarAbrirChamado.Click += new System.EventHandler(this.Btn_SalvarAbrirChamado_Click);
            // 
            // Label_Chamado
            // 
            this.Label_Chamado.AutoSize = true;
            this.Label_Chamado.Location = new System.Drawing.Point(43, 56);
            this.Label_Chamado.Name = "Label_Chamado";
            this.Label_Chamado.Size = new System.Drawing.Size(62, 15);
            this.Label_Chamado.TabIndex = 15;
            this.Label_Chamado.Text = "Chamado:";
            // 
            // Label_NumeroChamado
            // 
            this.Label_NumeroChamado.AutoSize = true;
            this.Label_NumeroChamado.Location = new System.Drawing.Point(111, 56);
            this.Label_NumeroChamado.Name = "Label_NumeroChamado";
            this.Label_NumeroChamado.Size = new System.Drawing.Size(13, 15);
            this.Label_NumeroChamado.TabIndex = 15;
            this.Label_NumeroChamado.Text = "0";
            // 
            // Label_Usuario
            // 
            this.Label_Usuario.AutoSize = true;
            this.Label_Usuario.Location = new System.Drawing.Point(55, 94);
            this.Label_Usuario.Name = "Label_Usuario";
            this.Label_Usuario.Size = new System.Drawing.Size(50, 15);
            this.Label_Usuario.TabIndex = 15;
            this.Label_Usuario.Text = "Usuário:";
            this.Label_Usuario.Click += new System.EventHandler(this.Label_Usuario_Click);
            // 
            // Txt_NomeUsuario
            // 
            this.Txt_NomeUsuario.Enabled = false;
            this.Txt_NomeUsuario.Location = new System.Drawing.Point(111, 91);
            this.Txt_NomeUsuario.Name = "Txt_NomeUsuario";
            this.Txt_NomeUsuario.Size = new System.Drawing.Size(231, 23);
            this.Txt_NomeUsuario.TabIndex = 16;
            // 
            // Label_EmailUsuario
            // 
            this.Label_EmailUsuario.AutoSize = true;
            this.Label_EmailUsuario.Location = new System.Drawing.Point(55, 138);
            this.Label_EmailUsuario.Name = "Label_EmailUsuario";
            this.Label_EmailUsuario.Size = new System.Drawing.Size(44, 15);
            this.Label_EmailUsuario.TabIndex = 15;
            this.Label_EmailUsuario.Text = "E-mail:";
            this.Label_EmailUsuario.Click += new System.EventHandler(this.Label_Usuario_Click);
            // 
            // Txt_EmailUsuario
            // 
            this.Txt_EmailUsuario.Enabled = false;
            this.Txt_EmailUsuario.Location = new System.Drawing.Point(111, 135);
            this.Txt_EmailUsuario.Name = "Txt_EmailUsuario";
            this.Txt_EmailUsuario.Size = new System.Drawing.Size(231, 23);
            this.Txt_EmailUsuario.TabIndex = 16;
            // 
            // Label_FuncaoUsuario
            // 
            this.Label_FuncaoUsuario.AutoSize = true;
            this.Label_FuncaoUsuario.Location = new System.Drawing.Point(50, 176);
            this.Label_FuncaoUsuario.Name = "Label_FuncaoUsuario";
            this.Label_FuncaoUsuario.Size = new System.Drawing.Size(49, 15);
            this.Label_FuncaoUsuario.TabIndex = 15;
            this.Label_FuncaoUsuario.Text = "Função:";
            this.Label_FuncaoUsuario.Click += new System.EventHandler(this.Label_Usuario_Click);
            // 
            // Txt_FuncaoUsuario
            // 
            this.Txt_FuncaoUsuario.Enabled = false;
            this.Txt_FuncaoUsuario.Location = new System.Drawing.Point(111, 176);
            this.Txt_FuncaoUsuario.Name = "Txt_FuncaoUsuario";
            this.Txt_FuncaoUsuario.Size = new System.Drawing.Size(231, 23);
            this.Txt_FuncaoUsuario.TabIndex = 16;
            // 
            // Label_CategoriaChamado
            // 
            this.Label_CategoriaChamado.AutoSize = true;
            this.Label_CategoriaChamado.Location = new System.Drawing.Point(421, 94);
            this.Label_CategoriaChamado.Name = "Label_CategoriaChamado";
            this.Label_CategoriaChamado.Size = new System.Drawing.Size(61, 15);
            this.Label_CategoriaChamado.TabIndex = 15;
            this.Label_CategoriaChamado.Text = "Categoria:";
            this.Label_CategoriaChamado.Click += new System.EventHandler(this.Label_Usuario_Click);
            // 
            // Combo_Categoria
            // 
            this.Combo_Categoria.FormattingEnabled = true;
            this.Combo_Categoria.Items.AddRange(new object[] {
            "Acessos",
            "Hardware",
            "Outros",
            "Software"});
            this.Combo_Categoria.Location = new System.Drawing.Point(488, 91);
            this.Combo_Categoria.Name = "Combo_Categoria";
            this.Combo_Categoria.Size = new System.Drawing.Size(212, 23);
            this.Combo_Categoria.TabIndex = 7;
            this.Combo_Categoria.Text = "-- Selecione --";
            this.Combo_Categoria.SelectedIndexChanged += new System.EventHandler(this.Combo_Categoria_SelectedIndexChanged);
            this.Combo_Categoria.SelectionChangeCommitted += new System.EventHandler(this.Combo_Categoria_SelectionChangeCommitted);
            // 
            // Label_SubcategoriaChamado
            // 
            this.Label_SubcategoriaChamado.AutoSize = true;
            this.Label_SubcategoriaChamado.Location = new System.Drawing.Point(403, 138);
            this.Label_SubcategoriaChamado.Name = "Label_SubcategoriaChamado";
            this.Label_SubcategoriaChamado.Size = new System.Drawing.Size(79, 15);
            this.Label_SubcategoriaChamado.TabIndex = 15;
            this.Label_SubcategoriaChamado.Text = "Subcategoria:";
            this.Label_SubcategoriaChamado.Click += new System.EventHandler(this.Label_Usuario_Click);
            // 
            // Combo_Subcategoria
            // 
            this.Combo_Subcategoria.Enabled = false;
            this.Combo_Subcategoria.FormattingEnabled = true;
            this.Combo_Subcategoria.Location = new System.Drawing.Point(488, 135);
            this.Combo_Subcategoria.Name = "Combo_Subcategoria";
            this.Combo_Subcategoria.Size = new System.Drawing.Size(212, 23);
            this.Combo_Subcategoria.TabIndex = 7;
            this.Combo_Subcategoria.Text = "-- Selecione --";
            // 
            // FormAbrirChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Combo_Subcategoria);
            this.Controls.Add(this.Label_SubcategoriaChamado);
            this.Controls.Add(this.Combo_Categoria);
            this.Controls.Add(this.Label_CategoriaChamado);
            this.Controls.Add(this.Txt_FuncaoUsuario);
            this.Controls.Add(this.Label_FuncaoUsuario);
            this.Controls.Add(this.Txt_EmailUsuario);
            this.Controls.Add(this.Label_EmailUsuario);
            this.Controls.Add(this.Txt_NomeUsuario);
            this.Controls.Add(this.Label_Usuario);
            this.Controls.Add(this.Label_NumeroChamado);
            this.Controls.Add(this.Label_Chamado);
            this.Controls.Add(this.Btn_SalvarAbrirChamado);
            this.Controls.Add(this.Btn_CancelarAbrirChamado);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormAbrirChamado";
            this.Text = "Abrir Chamado";
            this.Load += new System.EventHandler(this.FormAbrirChamado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button Btn_CancelarAbrirChamado;
        private System.Windows.Forms.Button Btn_SalvarAbrirChamado;
        private System.Windows.Forms.Label Label_Chamado;
        private System.Windows.Forms.Label Label_NumeroChamado;
        private System.Windows.Forms.Label Label_Usuario;
        private System.Windows.Forms.TextBox Txt_NomeUsuario;
        private System.Windows.Forms.Label Label_EmailUsuario;
        private System.Windows.Forms.TextBox Txt_EmailUsuario;
        private System.Windows.Forms.Label Label_FuncaoUsuario;
        private System.Windows.Forms.TextBox Txt_FuncaoUsuario;
        private System.Windows.Forms.Label Label_CategoriaChamado;
        private System.Windows.Forms.ComboBox Combo_Categoria;
        private System.Windows.Forms.Label Label_SubcategoriaChamado;
        private System.Windows.Forms.ComboBox Combo_Subcategoria;
    }
}