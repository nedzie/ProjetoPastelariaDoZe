﻿namespace ProjetoPastelariaDoZe.WinFormsApp
{
    /// <summary>
    /// Classe responsável pelo form Login
    /// </summary>
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelFundoLogin = new System.Windows.Forms.Panel();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.labelNovoUsuario = new System.Windows.Forms.Label();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panelFundoLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFundoLogin
            // 
            this.panelFundoLogin.Controls.Add(this.buttonFechar);
            this.panelFundoLogin.Controls.Add(this.labelNovoUsuario);
            this.panelFundoLogin.Controls.Add(this.buttonCadastrar);
            this.panelFundoLogin.Controls.Add(this.buttonEntrar);
            this.panelFundoLogin.Controls.Add(this.textBoxSenha);
            this.panelFundoLogin.Controls.Add(this.textBoxNome);
            this.panelFundoLogin.Controls.Add(this.labelSenha);
            this.panelFundoLogin.Controls.Add(this.labelNome);
            this.panelFundoLogin.Controls.Add(this.labelLogin);
            this.panelFundoLogin.Location = new System.Drawing.Point(12, 12);
            this.panelFundoLogin.Name = "panelFundoLogin";
            this.panelFundoLogin.Size = new System.Drawing.Size(475, 329);
            this.panelFundoLogin.TabIndex = 0;
            // 
            // buttonFechar
            // 
            this.buttonFechar.BackColor = System.Drawing.Color.White;
            this.buttonFechar.FlatAppearance.BorderSize = 0;
            this.buttonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFechar.Location = new System.Drawing.Point(376, 281);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 23);
            this.buttonFechar.TabIndex = 8;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.ButtonFechar_Click);
            // 
            // labelNovoUsuario
            // 
            this.labelNovoUsuario.AutoSize = true;
            this.labelNovoUsuario.ForeColor = System.Drawing.Color.White;
            this.labelNovoUsuario.Location = new System.Drawing.Point(36, 252);
            this.labelNovoUsuario.Name = "labelNovoUsuario";
            this.labelNovoUsuario.Size = new System.Drawing.Size(83, 15);
            this.labelNovoUsuario.TabIndex = 7;
            this.labelNovoUsuario.Text = "Novo usuário?";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.Color.White;
            this.buttonCadastrar.FlatAppearance.BorderSize = 0;
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrar.Location = new System.Drawing.Point(36, 279);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(83, 25);
            this.buttonCadastrar.TabIndex = 6;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.BackColor = System.Drawing.Color.White;
            this.buttonEntrar.FlatAppearance.BorderSize = 0;
            this.buttonEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntrar.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.arrow_right_solid_1_;
            this.buttonEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEntrar.Location = new System.Drawing.Point(36, 210);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(94, 30);
            this.buttonEntrar.TabIndex = 5;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = false;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.BackColor = System.Drawing.Color.White;
            this.textBoxSenha.Location = new System.Drawing.Point(36, 149);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PlaceholderText = "********";
            this.textBoxSenha.Size = new System.Drawing.Size(150, 23);
            this.textBoxSenha.TabIndex = 4;
            this.textBoxSenha.Enter += new System.EventHandler(this.textBoxSenha_Enter);
            this.textBoxSenha.Leave += new System.EventHandler(this.textBoxSenha_Leave);
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.Color.White;
            this.textBoxNome.Location = new System.Drawing.Point(36, 95);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.PlaceholderText = "Seu nome";
            this.textBoxNome.Size = new System.Drawing.Size(150, 23);
            this.textBoxNome.TabIndex = 3;
            this.textBoxNome.Enter += new System.EventHandler(this.textBoxNome_Enter);
            this.textBoxNome.Leave += new System.EventHandler(this.textBoxNome_Leave);
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.ForeColor = System.Drawing.Color.White;
            this.labelSenha.Location = new System.Drawing.Point(36, 131);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(39, 15);
            this.labelSenha.TabIndex = 2;
            this.labelSenha.Text = "Senha";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.ForeColor = System.Drawing.Color.White;
            this.labelNome.Location = new System.Drawing.Point(36, 73);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.ForeColor = System.Drawing.Color.White;
            this.labelLogin.Location = new System.Drawing.Point(179, 15);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(99, 45);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(499, 353);
            this.Controls.Add(this.panelFundoLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Conectar-se";
            this.panelFundoLogin.ResumeLayout(false);
            this.panelFundoLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelFundoLogin;
        private Button buttonEntrar;
        private TextBox textBoxSenha;
        private TextBox textBoxNome;
        private Label labelSenha;
        private Label labelNome;
        private Label labelLogin;
        private Button buttonCadastrar;
        private Button buttonFechar;
        private Label labelNovoUsuario;
    }
}