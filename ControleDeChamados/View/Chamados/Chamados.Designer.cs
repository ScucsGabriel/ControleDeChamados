namespace ControleDeChamados.View.Chamados
{
    partial class FormChamados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChamados));
            this.Label_ConsultarChamados = new System.Windows.Forms.Label();
            this.Btn_PesquisarChamado = new System.Windows.Forms.Button();
            this.Txt_NumeroChamado = new System.Windows.Forms.TextBox();
            this.Panel_NumeroChamado = new System.Windows.Forms.Panel();
            this.LstView_ConsultarChamados = new System.Windows.Forms.ListView();
            this.Label_TotalChamados = new System.Windows.Forms.Label();
            this.Label_NumeroTotalChamados = new System.Windows.Forms.Label();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.Btn_Detalhes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_ConsultarChamados
            // 
            this.Label_ConsultarChamados.AutoSize = true;
            this.Label_ConsultarChamados.BackColor = System.Drawing.Color.Black;
            this.Label_ConsultarChamados.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_ConsultarChamados.ForeColor = System.Drawing.Color.White;
            this.Label_ConsultarChamados.Location = new System.Drawing.Point(268, 42);
            this.Label_ConsultarChamados.Name = "Label_ConsultarChamados";
            this.Label_ConsultarChamados.Size = new System.Drawing.Size(187, 15);
            this.Label_ConsultarChamados.TabIndex = 1;
            this.Label_ConsultarChamados.Text = "Consultar Chamados";
            this.Label_ConsultarChamados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Btn_PesquisarChamado
            // 
            this.Btn_PesquisarChamado.BackColor = System.Drawing.Color.Transparent;
            this.Btn_PesquisarChamado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_PesquisarChamado.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.Btn_PesquisarChamado.FlatAppearance.BorderSize = 0;
            this.Btn_PesquisarChamado.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Btn_PesquisarChamado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_PesquisarChamado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_PesquisarChamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_PesquisarChamado.Image = ((System.Drawing.Image)(resources.GetObject("Btn_PesquisarChamado.Image")));
            this.Btn_PesquisarChamado.Location = new System.Drawing.Point(257, 88);
            this.Btn_PesquisarChamado.Name = "Btn_PesquisarChamado";
            this.Btn_PesquisarChamado.Size = new System.Drawing.Size(28, 27);
            this.Btn_PesquisarChamado.TabIndex = 5;
            this.Btn_PesquisarChamado.UseVisualStyleBackColor = false;
            this.Btn_PesquisarChamado.Click += new System.EventHandler(this.Btn_PesquisarChamado_Click);
            // 
            // Txt_NumeroChamado
            // 
            this.Txt_NumeroChamado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Txt_NumeroChamado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_NumeroChamado.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Txt_NumeroChamado.ForeColor = System.Drawing.Color.White;
            this.Txt_NumeroChamado.Location = new System.Drawing.Point(39, 91);
            this.Txt_NumeroChamado.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Txt_NumeroChamado.MaxLength = 100;
            this.Txt_NumeroChamado.Name = "Txt_NumeroChamado";
            this.Txt_NumeroChamado.Size = new System.Drawing.Size(212, 15);
            this.Txt_NumeroChamado.TabIndex = 4;
            this.Txt_NumeroChamado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_NumeroChamado_KeyUp);
            // 
            // Panel_NumeroChamado
            // 
            this.Panel_NumeroChamado.BackColor = System.Drawing.Color.Black;
            this.Panel_NumeroChamado.Location = new System.Drawing.Point(39, 107);
            this.Panel_NumeroChamado.Name = "Panel_NumeroChamado";
            this.Panel_NumeroChamado.Size = new System.Drawing.Size(212, 1);
            this.Panel_NumeroChamado.TabIndex = 11;
            // 
            // LstView_ConsultarChamados
            // 
            this.LstView_ConsultarChamados.HideSelection = false;
            this.LstView_ConsultarChamados.Location = new System.Drawing.Point(39, 121);
            this.LstView_ConsultarChamados.Name = "LstView_ConsultarChamados";
            this.LstView_ConsultarChamados.Size = new System.Drawing.Size(666, 242);
            this.LstView_ConsultarChamados.TabIndex = 12;
            this.LstView_ConsultarChamados.UseCompatibleStateImageBehavior = false;
            // 
            // Label_TotalChamados
            // 
            this.Label_TotalChamados.AutoSize = true;
            this.Label_TotalChamados.BackColor = System.Drawing.Color.Black;
            this.Label_TotalChamados.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_TotalChamados.ForeColor = System.Drawing.Color.White;
            this.Label_TotalChamados.Location = new System.Drawing.Point(39, 380);
            this.Label_TotalChamados.Name = "Label_TotalChamados";
            this.Label_TotalChamados.Size = new System.Drawing.Size(187, 15);
            this.Label_TotalChamados.TabIndex = 1;
            this.Label_TotalChamados.Text = "Total de Chamados:";
            this.Label_TotalChamados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_NumeroTotalChamados
            // 
            this.Label_NumeroTotalChamados.AutoSize = true;
            this.Label_NumeroTotalChamados.BackColor = System.Drawing.Color.Black;
            this.Label_NumeroTotalChamados.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_NumeroTotalChamados.ForeColor = System.Drawing.Color.White;
            this.Label_NumeroTotalChamados.Location = new System.Drawing.Point(242, 380);
            this.Label_NumeroTotalChamados.Name = "Label_NumeroTotalChamados";
            this.Label_NumeroTotalChamados.Size = new System.Drawing.Size(17, 15);
            this.Label_NumeroTotalChamados.TabIndex = 1;
            this.Label_NumeroTotalChamados.Text = "0";
            this.Label_NumeroTotalChamados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Fechar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.Btn_Fechar.FlatAppearance.BorderSize = 0;
            this.Btn_Fechar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Btn_Fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Fechar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Fechar.Image")));
            this.Btn_Fechar.Location = new System.Drawing.Point(682, 12);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(23, 21);
            this.Btn_Fechar.TabIndex = 11;
            this.Btn_Fechar.UseVisualStyleBackColor = false;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // Btn_Detalhes
            // 
            this.Btn_Detalhes.BackColor = System.Drawing.Color.Black;
            this.Btn_Detalhes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Detalhes.FlatAppearance.BorderSize = 0;
            this.Btn_Detalhes.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Btn_Detalhes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Detalhes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Detalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Detalhes.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Detalhes.ForeColor = System.Drawing.Color.White;
            this.Btn_Detalhes.Location = new System.Drawing.Point(606, 83);
            this.Btn_Detalhes.Name = "Btn_Detalhes";
            this.Btn_Detalhes.Size = new System.Drawing.Size(99, 23);
            this.Btn_Detalhes.TabIndex = 2;
            this.Btn_Detalhes.Text = "Detalhes";
            this.Btn_Detalhes.UseVisualStyleBackColor = false;
            this.Btn_Detalhes.Visible = false;
            this.Btn_Detalhes.Click += new System.EventHandler(this.Btn_Detalhes_Click);
            // 
            // FormChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.Btn_Detalhes);
            this.Controls.Add(this.Btn_Fechar);
            this.Controls.Add(this.Label_NumeroTotalChamados);
            this.Controls.Add(this.Label_TotalChamados);
            this.Controls.Add(this.LstView_ConsultarChamados);
            this.Controls.Add(this.Panel_NumeroChamado);
            this.Controls.Add(this.Txt_NumeroChamado);
            this.Controls.Add(this.Btn_PesquisarChamado);
            this.Controls.Add(this.Label_ConsultarChamados);
            this.Name = "FormChamados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Chamados";
            this.Load += new System.EventHandler(this.FormChamados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_ConsultarChamados;
        private System.Windows.Forms.Button Btn_PesquisarChamado;
        private System.Windows.Forms.TextBox Txt_NumeroChamado;
        private System.Windows.Forms.Panel Panel_NumeroChamado;
        private System.Windows.Forms.ListView LstView_ConsultarChamados;
        private System.Windows.Forms.Label Label_TotalChamados;
        private System.Windows.Forms.Label Label_NumeroTotalChamados;
        private System.Windows.Forms.Button Btn_Fechar;
        private System.Windows.Forms.Button Btn_Detalhes;
    }
}