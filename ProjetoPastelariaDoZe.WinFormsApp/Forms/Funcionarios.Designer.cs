namespace ProjetoPastelariaDoZe.WinFormsApp
{
    partial class Funcionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionarios));
            this.labelNome = new System.Windows.Forms.Label();
            this.PanelFuncionarios = new System.Windows.Forms.Panel();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.radioButtonBalcao = new System.Windows.Forms.RadioButton();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelGrupo = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.PanelFuncionarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.ForeColor = System.Drawing.Color.White;
            this.labelNome.Location = new System.Drawing.Point(52, 14);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(43, 15);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // PanelFuncionarios
            // 
            this.PanelFuncionarios.BackColor = System.Drawing.Color.Transparent;
            this.PanelFuncionarios.Controls.Add(this.buttonCadastrar);
            this.PanelFuncionarios.Controls.Add(this.textBoxSenha);
            this.PanelFuncionarios.Controls.Add(this.textBoxTelefone);
            this.PanelFuncionarios.Controls.Add(this.textBoxMatricula);
            this.PanelFuncionarios.Controls.Add(this.radioButtonBalcao);
            this.PanelFuncionarios.Controls.Add(this.radioButtonAdmin);
            this.PanelFuncionarios.Controls.Add(this.textBoxCPF);
            this.PanelFuncionarios.Controls.Add(this.textBoxNome);
            this.PanelFuncionarios.Controls.Add(this.labelGrupo);
            this.PanelFuncionarios.Controls.Add(this.labelSenha);
            this.PanelFuncionarios.Controls.Add(this.labelTelefone);
            this.PanelFuncionarios.Controls.Add(this.labelMatricula);
            this.PanelFuncionarios.Controls.Add(this.labelCPF);
            this.PanelFuncionarios.Controls.Add(this.labelNome);
            this.PanelFuncionarios.Location = new System.Drawing.Point(12, 12);
            this.PanelFuncionarios.Name = "PanelFuncionarios";
            this.PanelFuncionarios.Size = new System.Drawing.Size(441, 282);
            this.PanelFuncionarios.TabIndex = 1;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.Color.White;
            this.buttonCadastrar.FlatAppearance.BorderSize = 0;
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrar.Location = new System.Drawing.Point(289, 118);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(100, 30);
            this.buttonCadastrar.TabIndex = 7;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(52, 238);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PlaceholderText = "********";
            this.textBoxSenha.Size = new System.Drawing.Size(196, 23);
            this.textBoxSenha.TabIndex = 4;
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(52, 194);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.PlaceholderText = "(00) 0 0000 0000";
            this.textBoxTelefone.ReadOnly = true;
            this.textBoxTelefone.Size = new System.Drawing.Size(196, 23);
            this.textBoxTelefone.TabIndex = 3;
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(52, 137);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.PlaceholderText = "000000";
            this.textBoxMatricula.Size = new System.Drawing.Size(196, 23);
            this.textBoxMatricula.TabIndex = 2;
            // 
            // radioButtonBalcao
            // 
            this.radioButtonBalcao.AutoSize = true;
            this.radioButtonBalcao.ForeColor = System.Drawing.Color.White;
            this.radioButtonBalcao.Location = new System.Drawing.Point(289, 82);
            this.radioButtonBalcao.Name = "radioButtonBalcao";
            this.radioButtonBalcao.Size = new System.Drawing.Size(60, 19);
            this.radioButtonBalcao.TabIndex = 6;
            this.radioButtonBalcao.TabStop = true;
            this.radioButtonBalcao.Text = "Balcão";
            this.radioButtonBalcao.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.ForeColor = System.Drawing.Color.White;
            this.radioButtonAdmin.Location = new System.Drawing.Point(289, 57);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(61, 19);
            this.radioButtonAdmin.TabIndex = 5;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Admin";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(52, 82);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.PlaceholderText = "000.000.000-00";
            this.textBoxCPF.Size = new System.Drawing.Size(196, 23);
            this.textBoxCPF.TabIndex = 1;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(52, 32);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.PlaceholderText = "Nome empregado";
            this.textBoxNome.Size = new System.Drawing.Size(196, 23);
            this.textBoxNome.TabIndex = 0;
            // 
            // labelGrupo
            // 
            this.labelGrupo.AutoSize = true;
            this.labelGrupo.ForeColor = System.Drawing.Color.White;
            this.labelGrupo.Location = new System.Drawing.Point(289, 26);
            this.labelGrupo.Name = "labelGrupo";
            this.labelGrupo.Size = new System.Drawing.Size(43, 15);
            this.labelGrupo.TabIndex = 5;
            this.labelGrupo.Text = "Grupo:";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.ForeColor = System.Drawing.Color.White;
            this.labelSenha.Location = new System.Drawing.Point(52, 220);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(42, 15);
            this.labelSenha.TabIndex = 4;
            this.labelSenha.Text = "Senha:";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.ForeColor = System.Drawing.Color.White;
            this.labelTelefone.Location = new System.Drawing.Point(52, 176);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(54, 15);
            this.labelTelefone.TabIndex = 3;
            this.labelTelefone.Text = "Telefone:";
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.ForeColor = System.Drawing.Color.White;
            this.labelMatricula.Location = new System.Drawing.Point(52, 119);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(60, 15);
            this.labelMatricula.TabIndex = 2;
            this.labelMatricula.Text = "Matrícula:";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.ForeColor = System.Drawing.Color.White;
            this.labelCPF.Location = new System.Drawing.Point(52, 61);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(31, 15);
            this.labelCPF.TabIndex = 1;
            this.labelCPF.Text = "CPF:";
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(482, 319);
            this.Controls.Add(this.PanelFuncionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            this.PanelFuncionarios.ResumeLayout(false);
            this.PanelFuncionarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelNome;
        private Panel PanelFuncionarios;
        private RadioButton radioButtonBalcao;
        private RadioButton radioButtonAdmin;
        private TextBox textBoxCPF;
        private TextBox textBoxNome;
        private Label labelGrupo;
        private Label labelSenha;
        private Label labelTelefone;
        private Label labelMatricula;
        private Label labelCPF;
        private Button buttonCadastrar;
        private TextBox textBoxSenha;
        private TextBox textBoxTelefone;
        private TextBox textBoxMatricula;
    }
}