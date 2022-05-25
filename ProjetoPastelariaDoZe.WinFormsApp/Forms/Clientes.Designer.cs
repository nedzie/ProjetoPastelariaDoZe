﻿namespace ProjetoPastelariaDoZe.WinFormsApp
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.panelClientes = new System.Windows.Forms.Panel();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCPF = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.labelCNPJ = new System.Windows.Forms.Label();
            this.radioButtonJuridica = new System.Windows.Forms.RadioButton();
            this.radioButtonFisica = new System.Windows.Forms.RadioButton();
            this.labelOpcaoCliente = new System.Windows.Forms.Label();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.labelDiaDoFiado = new System.Windows.Forms.Label();
            this.numericUpDownDiaDoFiado = new System.Windows.Forms.NumericUpDown();
            this.radioButtonFiadoNao = new System.Windows.Forms.RadioButton();
            this.radioButtonFiadoSim = new System.Windows.Forms.RadioButton();
            this.labelMarcaFiado = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiaDoFiado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClientes
            // 
            this.panelClientes.Controls.Add(this.maskedTextBoxTelefone);
            this.panelClientes.Controls.Add(this.maskedTextBoxCPF);
            this.panelClientes.Controls.Add(this.maskedTextBoxCNPJ);
            this.panelClientes.Controls.Add(this.labelCNPJ);
            this.panelClientes.Controls.Add(this.radioButtonJuridica);
            this.panelClientes.Controls.Add(this.radioButtonFisica);
            this.panelClientes.Controls.Add(this.labelOpcaoCliente);
            this.panelClientes.Controls.Add(this.buttonCadastrar);
            this.panelClientes.Controls.Add(this.labelDiaDoFiado);
            this.panelClientes.Controls.Add(this.numericUpDownDiaDoFiado);
            this.panelClientes.Controls.Add(this.textBoxSenha);
            this.panelClientes.Controls.Add(this.textBoxNome);
            this.panelClientes.Controls.Add(this.labelSenha);
            this.panelClientes.Controls.Add(this.labelTelefone);
            this.panelClientes.Controls.Add(this.labelCPF);
            this.panelClientes.Controls.Add(this.labelNome);
            this.panelClientes.Controls.Add(this.groupBox1);
            this.panelClientes.Location = new System.Drawing.Point(12, 12);
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Size = new System.Drawing.Size(443, 446);
            this.panelClientes.TabIndex = 0;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Enabled = false;
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(0, 365);
            this.maskedTextBoxTelefone.Mask = "(00) 90000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxTelefone.TabIndex = 20;
            // 
            // maskedTextBoxCPF
            // 
            this.maskedTextBoxCPF.Enabled = false;
            this.maskedTextBoxCPF.Location = new System.Drawing.Point(0, 273);
            this.maskedTextBoxCPF.Mask = "000\\.000\\.000-00";
            this.maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            this.maskedTextBoxCPF.Size = new System.Drawing.Size(144, 23);
            this.maskedTextBoxCPF.TabIndex = 19;
            // 
            // maskedTextBoxCNPJ
            // 
            this.maskedTextBoxCNPJ.Enabled = false;
            this.maskedTextBoxCNPJ.Location = new System.Drawing.Point(0, 317);
            this.maskedTextBoxCNPJ.Mask = "00\\.000\\.000/0000-00";
            this.maskedTextBoxCNPJ.Name = "maskedTextBoxCNPJ";
            this.maskedTextBoxCNPJ.Size = new System.Drawing.Size(144, 23);
            this.maskedTextBoxCNPJ.TabIndex = 18;
            // 
            // labelCNPJ
            // 
            this.labelCNPJ.AutoSize = true;
            this.labelCNPJ.ForeColor = System.Drawing.Color.White;
            this.labelCNPJ.Location = new System.Drawing.Point(0, 299);
            this.labelCNPJ.Name = "labelCNPJ";
            this.labelCNPJ.Size = new System.Drawing.Size(37, 15);
            this.labelCNPJ.TabIndex = 17;
            this.labelCNPJ.Text = "CNPJ:";
            // 
            // radioButtonJuridica
            // 
            this.radioButtonJuridica.AutoSize = true;
            this.radioButtonJuridica.Enabled = false;
            this.radioButtonJuridica.ForeColor = System.Drawing.Color.White;
            this.radioButtonJuridica.Location = new System.Drawing.Point(0, 233);
            this.radioButtonJuridica.Name = "radioButtonJuridica";
            this.radioButtonJuridica.Size = new System.Drawing.Size(65, 19);
            this.radioButtonJuridica.TabIndex = 2;
            this.radioButtonJuridica.TabStop = true;
            this.radioButtonJuridica.Text = "Jurídica";
            this.radioButtonJuridica.UseVisualStyleBackColor = true;
            this.radioButtonJuridica.CheckedChanged += new System.EventHandler(this.radioButtonJuridica_CheckedChanged);
            // 
            // radioButtonFisica
            // 
            this.radioButtonFisica.AutoSize = true;
            this.radioButtonFisica.Enabled = false;
            this.radioButtonFisica.ForeColor = System.Drawing.Color.White;
            this.radioButtonFisica.Location = new System.Drawing.Point(0, 208);
            this.radioButtonFisica.Name = "radioButtonFisica";
            this.radioButtonFisica.Size = new System.Drawing.Size(54, 19);
            this.radioButtonFisica.TabIndex = 1;
            this.radioButtonFisica.TabStop = true;
            this.radioButtonFisica.Text = "Física";
            this.radioButtonFisica.UseVisualStyleBackColor = true;
            this.radioButtonFisica.CheckedChanged += new System.EventHandler(this.radioButtonFisica_CheckedChanged);
            // 
            // labelOpcaoCliente
            // 
            this.labelOpcaoCliente.AutoSize = true;
            this.labelOpcaoCliente.ForeColor = System.Drawing.Color.White;
            this.labelOpcaoCliente.Location = new System.Drawing.Point(0, 184);
            this.labelOpcaoCliente.Name = "labelOpcaoCliente";
            this.labelOpcaoCliente.Size = new System.Drawing.Size(137, 15);
            this.labelOpcaoCliente.TabIndex = 13;
            this.labelOpcaoCliente.Text = "Pessoa física ou jurídica?";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.Color.White;
            this.buttonCadastrar.FlatAppearance.BorderSize = 0;
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrar.ForeColor = System.Drawing.Color.Black;
            this.buttonCadastrar.Location = new System.Drawing.Point(275, 391);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(165, 43);
            this.buttonCadastrar.TabIndex = 8;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // labelDiaDoFiado
            // 
            this.labelDiaDoFiado.AutoSize = true;
            this.labelDiaDoFiado.ForeColor = System.Drawing.Color.White;
            this.labelDiaDoFiado.Location = new System.Drawing.Point(0, 75);
            this.labelDiaDoFiado.Name = "labelDiaDoFiado";
            this.labelDiaDoFiado.Size = new System.Drawing.Size(166, 15);
            this.labelDiaDoFiado.TabIndex = 12;
            this.labelDiaDoFiado.Text = "Dia do fiado (0 - dias corridos)";
            // 
            // numericUpDownDiaDoFiado
            // 
            this.numericUpDownDiaDoFiado.Enabled = false;
            this.numericUpDownDiaDoFiado.Location = new System.Drawing.Point(0, 104);
            this.numericUpDownDiaDoFiado.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownDiaDoFiado.Name = "numericUpDownDiaDoFiado";
            this.numericUpDownDiaDoFiado.Size = new System.Drawing.Size(45, 23);
            this.numericUpDownDiaDoFiado.TabIndex = 7;
            // 
            // radioButtonFiadoNao
            // 
            this.radioButtonFiadoNao.AutoSize = true;
            this.radioButtonFiadoNao.ForeColor = System.Drawing.Color.White;
            this.radioButtonFiadoNao.Location = new System.Drawing.Point(6, 66);
            this.radioButtonFiadoNao.Name = "radioButtonFiadoNao";
            this.radioButtonFiadoNao.Size = new System.Drawing.Size(47, 19);
            this.radioButtonFiadoNao.TabIndex = 6;
            this.radioButtonFiadoNao.TabStop = true;
            this.radioButtonFiadoNao.Text = "Não";
            this.radioButtonFiadoNao.UseVisualStyleBackColor = true;
            this.radioButtonFiadoNao.CheckedChanged += new System.EventHandler(this.radioButtonFiadoNao_CheckedChanged);
            // 
            // radioButtonFiadoSim
            // 
            this.radioButtonFiadoSim.AutoSize = true;
            this.radioButtonFiadoSim.ForeColor = System.Drawing.Color.White;
            this.radioButtonFiadoSim.Location = new System.Drawing.Point(6, 41);
            this.radioButtonFiadoSim.Name = "radioButtonFiadoSim";
            this.radioButtonFiadoSim.Size = new System.Drawing.Size(45, 19);
            this.radioButtonFiadoSim.TabIndex = 5;
            this.radioButtonFiadoSim.TabStop = true;
            this.radioButtonFiadoSim.Text = "Sim";
            this.radioButtonFiadoSim.UseVisualStyleBackColor = true;
            this.radioButtonFiadoSim.CheckedChanged += new System.EventHandler(this.radioButtonFiadoSim_CheckedChanged);
            // 
            // labelMarcaFiado
            // 
            this.labelMarcaFiado.AutoSize = true;
            this.labelMarcaFiado.ForeColor = System.Drawing.Color.White;
            this.labelMarcaFiado.Location = new System.Drawing.Point(6, 19);
            this.labelMarcaFiado.Name = "labelMarcaFiado";
            this.labelMarcaFiado.Size = new System.Drawing.Size(75, 15);
            this.labelMarcaFiado.TabIndex = 8;
            this.labelMarcaFiado.Text = "Marca fiado?";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Enabled = false;
            this.textBoxSenha.Location = new System.Drawing.Point(0, 411);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.PlaceholderText = "********";
            this.textBoxSenha.Size = new System.Drawing.Size(257, 23);
            this.textBoxSenha.TabIndex = 4;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Enabled = false;
            this.textBoxNome.Location = new System.Drawing.Point(0, 158);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.PlaceholderText = "Nome do cliente";
            this.textBoxNome.Size = new System.Drawing.Size(257, 23);
            this.textBoxNome.TabIndex = 0;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.ForeColor = System.Drawing.Color.White;
            this.labelSenha.Location = new System.Drawing.Point(0, 391);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(42, 15);
            this.labelSenha.TabIndex = 3;
            this.labelSenha.Text = "Senha:";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.ForeColor = System.Drawing.Color.White;
            this.labelTelefone.Location = new System.Drawing.Point(0, 347);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(54, 15);
            this.labelTelefone.TabIndex = 2;
            this.labelTelefone.Text = "Telefone:";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.ForeColor = System.Drawing.Color.White;
            this.labelCPF.Location = new System.Drawing.Point(0, 255);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(31, 15);
            this.labelCPF.TabIndex = 1;
            this.labelCPF.Text = "CPF:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.ForeColor = System.Drawing.Color.White;
            this.labelNome.Location = new System.Drawing.Point(0, 140);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(43, 15);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelMarcaFiado);
            this.groupBox1.Controls.Add(this.radioButtonFiadoSim);
            this.groupBox1.Controls.Add(this.radioButtonFiadoNao);
            this.groupBox1.Location = new System.Drawing.Point(191, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(465, 463);
            this.Controls.Add(this.panelClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.panelClientes.ResumeLayout(false);
            this.panelClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiaDoFiado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelClientes;
        private TextBox textBoxNome;
        private Label labelSenha;
        private Label labelTelefone;
        private Label labelCPF;
        private Label labelNome;
        private TextBox textBoxSenha;
        private Label labelMarcaFiado;
        private RadioButton radioButtonFiadoNao;
        private RadioButton radioButtonFiadoSim;
        private Label labelDiaDoFiado;
        private NumericUpDown numericUpDownDiaDoFiado;
        private Button buttonCadastrar;
        private Label labelCNPJ;
        private RadioButton radioButtonJuridica;
        private RadioButton radioButtonFisica;
        private Label labelOpcaoCliente;
        private MaskedTextBox maskedTextBoxCPF;
        private MaskedTextBox maskedTextBoxCNPJ;
        private MaskedTextBox maskedTextBoxTelefone;
        private GroupBox groupBox1;
    }
}