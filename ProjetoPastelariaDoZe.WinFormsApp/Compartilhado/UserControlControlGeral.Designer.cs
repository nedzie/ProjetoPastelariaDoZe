namespace ProjetoPastelariaDoZe.WinFormsApp
{
    /// <summary>
    /// Classe auxiliar UserControlControleUsuarioGeral - Criada para evitar repetição de códigos. 
    /// Pode ser utilizada em diversas partes do cógido. 
    /// Modular.
    /// </summary>
    partial class UserControlControleUsuarioGeral
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonSalvar = new System.Windows.Forms.Button();
            this.ButtonEditar = new System.Windows.Forms.Button();
            this.ButtonExcluir = new System.Windows.Forms.Button();
            this.ButtonSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonSalvar
            // 
            this.ButtonSalvar.BackColor = System.Drawing.Color.LimeGreen;
            this.ButtonSalvar.FlatAppearance.BorderSize = 0;
            this.ButtonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSalvar.ForeColor = System.Drawing.Color.White;
            this.ButtonSalvar.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.salvar_solido_branco;
            this.ButtonSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSalvar.Location = new System.Drawing.Point(0, 0);
            this.ButtonSalvar.Name = "ButtonSalvar";
            this.ButtonSalvar.Size = new System.Drawing.Size(100, 49);
            this.ButtonSalvar.TabIndex = 0;
            this.ButtonSalvar.Text = "Salvar";
            this.ButtonSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSalvar.UseVisualStyleBackColor = false;
            this.ButtonSalvar.Click += new System.EventHandler(this.ButtonSalvar_Click);
            // 
            // ButtonEditar
            // 
            this.ButtonEditar.BackColor = System.Drawing.Color.Goldenrod;
            this.ButtonEditar.FlatAppearance.BorderSize = 0;
            this.ButtonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonEditar.ForeColor = System.Drawing.Color.White;
            this.ButtonEditar.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.editar_solido_branco;
            this.ButtonEditar.Location = new System.Drawing.Point(100, 0);
            this.ButtonEditar.Name = "ButtonEditar";
            this.ButtonEditar.Size = new System.Drawing.Size(100, 49);
            this.ButtonEditar.TabIndex = 1;
            this.ButtonEditar.Text = "Editar";
            this.ButtonEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonEditar.UseVisualStyleBackColor = false;
            this.ButtonEditar.Click += new System.EventHandler(this.ButtonEditar_Click);
            // 
            // ButtonExcluir
            // 
            this.ButtonExcluir.BackColor = System.Drawing.Color.IndianRed;
            this.ButtonExcluir.FlatAppearance.BorderSize = 0;
            this.ButtonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExcluir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonExcluir.ForeColor = System.Drawing.Color.White;
            this.ButtonExcluir.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.apagar_solido_branco;
            this.ButtonExcluir.Location = new System.Drawing.Point(200, 0);
            this.ButtonExcluir.Name = "ButtonExcluir";
            this.ButtonExcluir.Size = new System.Drawing.Size(100, 49);
            this.ButtonExcluir.TabIndex = 2;
            this.ButtonExcluir.Text = "Excluir";
            this.ButtonExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonExcluir.UseVisualStyleBackColor = false;
            this.ButtonExcluir.Click += new System.EventHandler(this.ButtonExcluir_Click);
            // 
            // ButtonSair
            // 
            this.ButtonSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonSair.FlatAppearance.BorderSize = 0;
            this.ButtonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSair.ForeColor = System.Drawing.Color.White;
            this.ButtonSair.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.fechar_solido_branco;
            this.ButtonSair.Location = new System.Drawing.Point(300, 0);
            this.ButtonSair.Name = "ButtonSair";
            this.ButtonSair.Size = new System.Drawing.Size(100, 49);
            this.ButtonSair.TabIndex = 3;
            this.ButtonSair.Text = "Sair";
            this.ButtonSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSair.UseVisualStyleBackColor = false;
            this.ButtonSair.Click += new System.EventHandler(this.ButtonSair_Click);
            // 
            // UserControlControleUsuarioGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonSair);
            this.Controls.Add(this.ButtonExcluir);
            this.Controls.Add(this.ButtonEditar);
            this.Controls.Add(this.ButtonSalvar);
            this.Name = "UserControlControleUsuarioGeral";
            this.Size = new System.Drawing.Size(400, 49);
            this.ResumeLayout(false);

        }

        #endregion
        /// <summary>
        /// Botão para salvar ações
        /// </summary>
        public Button ButtonSalvar;
        /// <summary>
        /// Botão para editar campos selecionados
        /// </summary>
        public Button ButtonEditar;
        /// <summary>
        /// Botão para excluir campos selecionados
        /// </summary>
        public Button ButtonExcluir;
        /// <summary>
        /// Botão para fechar ambientes
        /// </summary>
        public Button ButtonSair;
    }
}
