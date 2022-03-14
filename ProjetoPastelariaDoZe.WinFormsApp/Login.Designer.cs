﻿namespace ProjetoPastelariaDoZe.WinFormsApp
{
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
            this.panelFundoLogin = new System.Windows.Forms.Panel();
            this.ButtonCadastrar = new System.Windows.Forms.Button();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panelFundoLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFundoLogin
            // 
            this.panelFundoLogin.Controls.Add(this.ButtonCadastrar);
            this.panelFundoLogin.Controls.Add(this.buttonEntrar);
            this.panelFundoLogin.Controls.Add(this.textBoxSenha);
            this.panelFundoLogin.Controls.Add(this.textBoxUsuario);
            this.panelFundoLogin.Controls.Add(this.labelSenha);
            this.panelFundoLogin.Controls.Add(this.labelUsuario);
            this.panelFundoLogin.Controls.Add(this.labelLogin);
            this.panelFundoLogin.Location = new System.Drawing.Point(12, 12);
            this.panelFundoLogin.Name = "panelFundoLogin";
            this.panelFundoLogin.Size = new System.Drawing.Size(475, 352);
            this.panelFundoLogin.TabIndex = 0;
            // 
            // ButtonCadastrar
            // 
            this.ButtonCadastrar.BackColor = System.Drawing.Color.White;
            this.ButtonCadastrar.Location = new System.Drawing.Point(397, 327);
            this.ButtonCadastrar.Name = "ButtonCadastrar";
            this.ButtonCadastrar.Size = new System.Drawing.Size(75, 25);
            this.ButtonCadastrar.TabIndex = 6;
            this.ButtonCadastrar.Text = "Cadastrar";
            this.ButtonCadastrar.UseVisualStyleBackColor = false;
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.BackColor = System.Drawing.Color.White;
            this.buttonEntrar.FlatAppearance.BorderSize = 0;
            this.buttonEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.buttonEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntrar.Location = new System.Drawing.Point(116, 252);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(150, 30);
            this.buttonEntrar.TabIndex = 5;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = false;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.BackColor = System.Drawing.Color.White;
            this.textBoxSenha.Location = new System.Drawing.Point(116, 196);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PlaceholderText = "********";
            this.textBoxSenha.Size = new System.Drawing.Size(220, 23);
            this.textBoxSenha.TabIndex = 4;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BackColor = System.Drawing.Color.White;
            this.textBoxUsuario.Location = new System.Drawing.Point(116, 110);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.PlaceholderText = "Seu usuário";
            this.textBoxUsuario.Size = new System.Drawing.Size(220, 23);
            this.textBoxUsuario.TabIndex = 3;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.ForeColor = System.Drawing.Color.White;
            this.labelSenha.Location = new System.Drawing.Point(116, 167);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(39, 15);
            this.labelSenha.TabIndex = 2;
            this.labelSenha.Text = "Senha";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.ForeColor = System.Drawing.Color.White;
            this.labelUsuario.Location = new System.Drawing.Point(116, 79);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(47, 15);
            this.labelUsuario.TabIndex = 1;
            this.labelUsuario.Text = "Usuário";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.ForeColor = System.Drawing.Color.White;
            this.labelLogin.Location = new System.Drawing.Point(188, 15);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(99, 45);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(499, 376);
            this.Controls.Add(this.panelFundoLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.panelFundoLogin.ResumeLayout(false);
            this.panelFundoLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelFundoLogin;
        private Button buttonEntrar;
        private TextBox textBoxSenha;
        private TextBox textBoxUsuario;
        private Label labelSenha;
        private Label labelUsuario;
        private Label labelLogin;
        private Button ButtonCadastrar;
    }
}