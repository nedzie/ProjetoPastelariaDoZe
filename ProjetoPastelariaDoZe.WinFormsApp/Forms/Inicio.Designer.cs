namespace ProjetoPastelariaDoZe.WinFormsApp
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.buttonCaixa = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonSobre = new System.Windows.Forms.Button();
            this.buttonConfiguracoes = new System.Windows.Forms.Button();
            this.buttonFuncionarios = new System.Windows.Forms.Button();
            this.buttonProdutos = new System.Windows.Forms.Button();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonComandas = new System.Windows.Forms.Button();
            this.buttonInicio = new System.Windows.Forms.Button();
            this.panelMenuSuperior = new System.Windows.Forms.Panel();
            this.LabelCabecalho = new System.Windows.Forms.Label();
            this.panelMenuGeral = new System.Windows.Forms.Panel();
            this.LabelCorpo = new System.Windows.Forms.Label();
            this.panelMenuLateral.SuspendLayout();
            this.panelMenuSuperior.SuspendLayout();
            this.panelMenuGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackColor = System.Drawing.Color.Black;
            this.panelMenuLateral.Controls.Add(this.buttonCaixa);
            this.panelMenuLateral.Controls.Add(this.buttonLogin);
            this.panelMenuLateral.Controls.Add(this.buttonSobre);
            this.panelMenuLateral.Controls.Add(this.buttonConfiguracoes);
            this.panelMenuLateral.Controls.Add(this.buttonFuncionarios);
            this.panelMenuLateral.Controls.Add(this.buttonProdutos);
            this.panelMenuLateral.Controls.Add(this.buttonClientes);
            this.panelMenuLateral.Controls.Add(this.buttonComandas);
            this.panelMenuLateral.Controls.Add(this.buttonInicio);
            resources.ApplyResources(this.panelMenuLateral, "panelMenuLateral");
            this.panelMenuLateral.Name = "panelMenuLateral";
            // 
            // buttonCaixa
            // 
            this.buttonCaixa.BackColor = System.Drawing.Color.Transparent;
            this.buttonCaixa.FlatAppearance.BorderSize = 0;
            this.buttonCaixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            resources.ApplyResources(this.buttonCaixa, "buttonCaixa");
            this.buttonCaixa.ForeColor = System.Drawing.Color.White;
            this.buttonCaixa.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.caixa_solido_branco;
            this.buttonCaixa.Name = "buttonCaixa";
            this.buttonCaixa.UseVisualStyleBackColor = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonLogin, "buttonLogin");
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.user_friends_solid;
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonLogin_MouseClick);
            // 
            // buttonSobre
            // 
            this.buttonSobre.BackColor = System.Drawing.Color.Transparent;
            this.buttonSobre.FlatAppearance.BorderSize = 0;
            this.buttonSobre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            resources.ApplyResources(this.buttonSobre, "buttonSobre");
            this.buttonSobre.ForeColor = System.Drawing.Color.White;
            this.buttonSobre.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.sobre_solido_branco;
            this.buttonSobre.Name = "buttonSobre";
            this.buttonSobre.UseVisualStyleBackColor = false;
            this.buttonSobre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonSobre_MouseClick);
            // 
            // buttonConfiguracoes
            // 
            this.buttonConfiguracoes.BackColor = System.Drawing.Color.Transparent;
            this.buttonConfiguracoes.FlatAppearance.BorderSize = 0;
            this.buttonConfiguracoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            resources.ApplyResources(this.buttonConfiguracoes, "buttonConfiguracoes");
            this.buttonConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.buttonConfiguracoes.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.barras_configuracoes_solido_branco;
            this.buttonConfiguracoes.Name = "buttonConfiguracoes";
            this.buttonConfiguracoes.UseVisualStyleBackColor = false;
            this.buttonConfiguracoes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonConfiguracoes_MouseClick);
            // 
            // buttonFuncionarios
            // 
            this.buttonFuncionarios.BackColor = System.Drawing.Color.Transparent;
            this.buttonFuncionarios.FlatAppearance.BorderSize = 0;
            this.buttonFuncionarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            resources.ApplyResources(this.buttonFuncionarios, "buttonFuncionarios");
            this.buttonFuncionarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFuncionarios.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.funcionarios_solido_branco;
            this.buttonFuncionarios.Name = "buttonFuncionarios";
            this.buttonFuncionarios.UseVisualStyleBackColor = false;
            this.buttonFuncionarios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonFuncionarios_MouseClick);
            // 
            // buttonProdutos
            // 
            this.buttonProdutos.BackColor = System.Drawing.Color.Transparent;
            this.buttonProdutos.FlatAppearance.BorderSize = 0;
            this.buttonProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            resources.ApplyResources(this.buttonProdutos, "buttonProdutos");
            this.buttonProdutos.ForeColor = System.Drawing.Color.White;
            this.buttonProdutos.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.produtos_solido_branco;
            this.buttonProdutos.Name = "buttonProdutos";
            this.buttonProdutos.UseVisualStyleBackColor = false;
            this.buttonProdutos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonProdutos_MouseClick);
            // 
            // buttonClientes
            // 
            this.buttonClientes.BackColor = System.Drawing.Color.Transparent;
            this.buttonClientes.FlatAppearance.BorderSize = 0;
            this.buttonClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(175)))));
            resources.ApplyResources(this.buttonClientes, "buttonClientes");
            this.buttonClientes.ForeColor = System.Drawing.Color.White;
            this.buttonClientes.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.clientes_solido_branco;
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.UseVisualStyleBackColor = false;
            this.buttonClientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonClientes_MouseClick);
            // 
            // buttonComandas
            // 
            this.buttonComandas.BackColor = System.Drawing.Color.Transparent;
            this.buttonComandas.FlatAppearance.BorderSize = 0;
            this.buttonComandas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            resources.ApplyResources(this.buttonComandas, "buttonComandas");
            this.buttonComandas.ForeColor = System.Drawing.Color.White;
            this.buttonComandas.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.comanda_solido_branco;
            this.buttonComandas.Name = "buttonComandas";
            this.buttonComandas.UseVisualStyleBackColor = false;
            this.buttonComandas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonComanda_MouseClick);
            // 
            // buttonInicio
            // 
            this.buttonInicio.BackColor = System.Drawing.Color.Transparent;
            this.buttonInicio.FlatAppearance.BorderSize = 0;
            this.buttonInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.buttonInicio, "buttonInicio");
            this.buttonInicio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonInicio.Image = global::ProjetoPastelariaDoZe.WinFormsApp.Properties.Resources.inicio_solido_branco;
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.UseVisualStyleBackColor = false;
            // 
            // panelMenuSuperior
            // 
            this.panelMenuSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMenuSuperior.Controls.Add(this.LabelCabecalho);
            resources.ApplyResources(this.panelMenuSuperior, "panelMenuSuperior");
            this.panelMenuSuperior.Name = "panelMenuSuperior";
            // 
            // LabelCabecalho
            // 
            resources.ApplyResources(this.LabelCabecalho, "LabelCabecalho");
            this.LabelCabecalho.ForeColor = System.Drawing.Color.White;
            this.LabelCabecalho.Name = "LabelCabecalho";
            // 
            // panelMenuGeral
            // 
            this.panelMenuGeral.BackColor = System.Drawing.Color.Gray;
            this.panelMenuGeral.Controls.Add(this.LabelCorpo);
            resources.ApplyResources(this.panelMenuGeral, "panelMenuGeral");
            this.panelMenuGeral.Name = "panelMenuGeral";
            // 
            // LabelCorpo
            // 
            resources.ApplyResources(this.LabelCorpo, "LabelCorpo");
            this.LabelCorpo.ForeColor = System.Drawing.Color.White;
            this.LabelCorpo.Name = "LabelCorpo";
            // 
            // Inicio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.panelMenuGeral);
            this.Controls.Add(this.panelMenuSuperior);
            this.Controls.Add(this.panelMenuLateral);
            this.Name = "Inicio";
            this.panelMenuLateral.ResumeLayout(false);
            this.panelMenuSuperior.ResumeLayout(false);
            this.panelMenuSuperior.PerformLayout();
            this.panelMenuGeral.ResumeLayout(false);
            this.panelMenuGeral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenuLateral;
        private Panel panelMenuSuperior;
        private Panel panelMenuGeral;
        private Button buttonInicio;
        private Button buttonComandas;
        private Button buttonFuncionarios;
        private Button buttonProdutos;
        private Button buttonClientes;
        private Button buttonLogin;
        private Button buttonSobre;
        private Button buttonConfiguracoes;
        private Label LabelCabecalho;
        private Label LabelCorpo;
        private Button buttonCaixa;
    }
}