namespace ProjetoPastelariaDoZe.WinFormsApp
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
            resources.ApplyResources(this.panelFundoLogin, "panelFundoLogin");
            this.panelFundoLogin.Name = "panelFundoLogin";
            // 
            // buttonFechar
            // 
            this.buttonFechar.BackColor = System.Drawing.Color.White;
            this.buttonFechar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonFechar, "buttonFechar");
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.ButtonFechar_Click);
            // 
            // labelNovoUsuario
            // 
            resources.ApplyResources(this.labelNovoUsuario, "labelNovoUsuario");
            this.labelNovoUsuario.ForeColor = System.Drawing.Color.White;
            this.labelNovoUsuario.Name = "labelNovoUsuario";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.Color.White;
            this.buttonCadastrar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonCadastrar, "buttonCadastrar");
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.BackColor = System.Drawing.Color.White;
            this.buttonEntrar.FlatAppearance.BorderSize = 0;
            this.buttonEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.buttonEntrar, "buttonEntrar");
            this.buttonEntrar.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.arrow_right_solid_1_;
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.UseVisualStyleBackColor = false;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.textBoxSenha, "textBoxSenha");
            this.textBoxSenha.Name = "textBoxSenha";
            // 
            // textBoxNome
            // 
            this.textBoxNome.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.textBoxNome, "textBoxNome");
            this.textBoxNome.Name = "textBoxNome";
            // 
            // labelSenha
            // 
            resources.ApplyResources(this.labelSenha, "labelSenha");
            this.labelSenha.ForeColor = System.Drawing.Color.White;
            this.labelSenha.Name = "labelSenha";
            // 
            // labelNome
            // 
            resources.ApplyResources(this.labelNome, "labelNome");
            this.labelNome.ForeColor = System.Drawing.Color.White;
            this.labelNome.Name = "labelNome";
            // 
            // labelLogin
            // 
            resources.ApplyResources(this.labelLogin, "labelLogin");
            this.labelLogin.ForeColor = System.Drawing.Color.White;
            this.labelLogin.Name = "labelLogin";
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panelFundoLogin);
            this.Name = "Login";
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