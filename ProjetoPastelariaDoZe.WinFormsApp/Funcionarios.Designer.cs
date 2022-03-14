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
            this.labelNome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonBalcao = new System.Windows.Forms.RadioButton();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelGrupo = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.textBoxMatrícula = new System.Windows.Forms.TextBox();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(52, 14);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(43, 15);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCadastrar);
            this.panel1.Controls.Add(this.textBoxSenha);
            this.panel1.Controls.Add(this.textBoxTelefone);
            this.panel1.Controls.Add(this.textBoxMatrícula);
            this.panel1.Controls.Add(this.radioButtonBalcao);
            this.panel1.Controls.Add(this.radioButtonAdmin);
            this.panel1.Controls.Add(this.textBoxCPF);
            this.panel1.Controls.Add(this.textBoxNome);
            this.panel1.Controls.Add(this.labelGrupo);
            this.panel1.Controls.Add(this.labelSenha);
            this.panel1.Controls.Add(this.labelTelefone);
            this.panel1.Controls.Add(this.labelMatricula);
            this.panel1.Controls.Add(this.labelCPF);
            this.panel1.Controls.Add(this.labelNome);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 1;
            // 
            // radioButtonBalcao
            // 
            this.radioButtonBalcao.AutoSize = true;
            this.radioButtonBalcao.Location = new System.Drawing.Point(52, 333);
            this.radioButtonBalcao.Name = "radioButtonBalcao";
            this.radioButtonBalcao.Size = new System.Drawing.Size(60, 19);
            this.radioButtonBalcao.TabIndex = 9;
            this.radioButtonBalcao.TabStop = true;
            this.radioButtonBalcao.Text = "Balcão";
            this.radioButtonBalcao.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(52, 308);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(61, 19);
            this.radioButtonAdmin.TabIndex = 8;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Admin";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(52, 82);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(196, 23);
            this.textBoxCPF.TabIndex = 7;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(52, 32);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(196, 23);
            this.textBoxNome.TabIndex = 6;
            // 
            // labelGrupo
            // 
            this.labelGrupo.AutoSize = true;
            this.labelGrupo.Location = new System.Drawing.Point(52, 277);
            this.labelGrupo.Name = "labelGrupo";
            this.labelGrupo.Size = new System.Drawing.Size(43, 15);
            this.labelGrupo.TabIndex = 5;
            this.labelGrupo.Text = "Grupo:";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(52, 220);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(42, 15);
            this.labelSenha.TabIndex = 4;
            this.labelSenha.Text = "Senha:";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(52, 176);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(54, 15);
            this.labelTelefone.TabIndex = 3;
            this.labelTelefone.Text = "Telefone:";
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Location = new System.Drawing.Point(52, 119);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(60, 15);
            this.labelMatricula.TabIndex = 2;
            this.labelMatricula.Text = "Matrícula:";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(52, 61);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(31, 15);
            this.labelCPF.TabIndex = 1;
            this.labelCPF.Text = "CPF:";
            // 
            // textBoxMatrícula
            // 
            this.textBoxMatrícula.Location = new System.Drawing.Point(52, 137);
            this.textBoxMatrícula.Name = "textBoxMatrícula";
            this.textBoxMatrícula.Size = new System.Drawing.Size(196, 23);
            this.textBoxMatrícula.TabIndex = 10;
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(52, 194);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(196, 23);
            this.textBoxTelefone.TabIndex = 11;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(52, 238);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(196, 23);
            this.textBoxSenha.TabIndex = 12;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(52, 369);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(100, 30);
            this.buttonCadastrar.TabIndex = 13;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Funcionarios";
            this.Text = "Funcionarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelNome;
        private Panel panel1;
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
        private TextBox textBoxMatrícula;
    }
}