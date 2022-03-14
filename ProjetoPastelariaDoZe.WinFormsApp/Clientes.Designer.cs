namespace ProjetoPastelariaDoZe.WinFormsApp
{
    partial class Clientes
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
            this.panelClientes = new System.Windows.Forms.Panel();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.labelDiaDoFiado = new System.Windows.Forms.Label();
            this.numericUpDownDiaDoFiado = new System.Windows.Forms.NumericUpDown();
            this.radioButtonFiadoNao = new System.Windows.Forms.RadioButton();
            this.radioButtonFiadoSim = new System.Windows.Forms.RadioButton();
            this.labelMarcaFiado = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.panelClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiaDoFiado)).BeginInit();
            this.SuspendLayout();
            // 
            // panelClientes
            // 
            this.panelClientes.Controls.Add(this.buttonCadastrar);
            this.panelClientes.Controls.Add(this.labelDiaDoFiado);
            this.panelClientes.Controls.Add(this.numericUpDownDiaDoFiado);
            this.panelClientes.Controls.Add(this.radioButtonFiadoNao);
            this.panelClientes.Controls.Add(this.radioButtonFiadoSim);
            this.panelClientes.Controls.Add(this.labelMarcaFiado);
            this.panelClientes.Controls.Add(this.textBoxSenha);
            this.panelClientes.Controls.Add(this.textBoxTelefone);
            this.panelClientes.Controls.Add(this.textBoxCPF);
            this.panelClientes.Controls.Add(this.textBoxNome);
            this.panelClientes.Controls.Add(this.labelSenha);
            this.panelClientes.Controls.Add(this.labelTelefone);
            this.panelClientes.Controls.Add(this.labelCPF);
            this.panelClientes.Controls.Add(this.labelNome);
            this.panelClientes.Location = new System.Drawing.Point(12, 12);
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Size = new System.Drawing.Size(776, 426);
            this.panelClientes.TabIndex = 0;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.FlatAppearance.BorderSize = 0;
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrar.Location = new System.Drawing.Point(215, 268);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(312, 43);
            this.buttonCadastrar.TabIndex = 13;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            // 
            // labelDiaDoFiado
            // 
            this.labelDiaDoFiado.AutoSize = true;
            this.labelDiaDoFiado.Location = new System.Drawing.Point(533, 93);
            this.labelDiaDoFiado.Name = "labelDiaDoFiado";
            this.labelDiaDoFiado.Size = new System.Drawing.Size(166, 15);
            this.labelDiaDoFiado.TabIndex = 12;
            this.labelDiaDoFiado.Text = "Dia do fiado (0 - dias corridos)";
            // 
            // numericUpDownDiaDoFiado
            // 
            this.numericUpDownDiaDoFiado.Location = new System.Drawing.Point(533, 122);
            this.numericUpDownDiaDoFiado.Name = "numericUpDownDiaDoFiado";
            this.numericUpDownDiaDoFiado.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownDiaDoFiado.TabIndex = 11;
            // 
            // radioButtonFiadoNao
            // 
            this.radioButtonFiadoNao.AutoSize = true;
            this.radioButtonFiadoNao.Location = new System.Drawing.Point(533, 65);
            this.radioButtonFiadoNao.Name = "radioButtonFiadoNao";
            this.radioButtonFiadoNao.Size = new System.Drawing.Size(47, 19);
            this.radioButtonFiadoNao.TabIndex = 10;
            this.radioButtonFiadoNao.TabStop = true;
            this.radioButtonFiadoNao.Text = "Não";
            this.radioButtonFiadoNao.UseVisualStyleBackColor = true;
            // 
            // radioButtonFiadoSim
            // 
            this.radioButtonFiadoSim.AutoSize = true;
            this.radioButtonFiadoSim.Location = new System.Drawing.Point(533, 40);
            this.radioButtonFiadoSim.Name = "radioButtonFiadoSim";
            this.radioButtonFiadoSim.Size = new System.Drawing.Size(45, 19);
            this.radioButtonFiadoSim.TabIndex = 9;
            this.radioButtonFiadoSim.TabStop = true;
            this.radioButtonFiadoSim.Text = "Sim";
            this.radioButtonFiadoSim.UseVisualStyleBackColor = true;
            // 
            // labelMarcaFiado
            // 
            this.labelMarcaFiado.AutoSize = true;
            this.labelMarcaFiado.Location = new System.Drawing.Point(533, 18);
            this.labelMarcaFiado.Name = "labelMarcaFiado";
            this.labelMarcaFiado.Size = new System.Drawing.Size(75, 15);
            this.labelMarcaFiado.TabIndex = 8;
            this.labelMarcaFiado.Text = "Marca fiado?";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(28, 228);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(100, 23);
            this.textBoxSenha.TabIndex = 7;
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(28, 171);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(144, 23);
            this.textBoxTelefone.TabIndex = 6;
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(28, 104);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(144, 23);
            this.textBoxCPF.TabIndex = 5;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(28, 36);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(257, 23);
            this.textBoxNome.TabIndex = 4;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(28, 210);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(42, 15);
            this.labelSenha.TabIndex = 3;
            this.labelSenha.Text = "Senha:";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(28, 143);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(54, 15);
            this.labelTelefone.TabIndex = 2;
            this.labelTelefone.Text = "Telefone:";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(28, 73);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(31, 15);
            this.labelCPF.TabIndex = 1;
            this.labelCPF.Text = "CPF:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(28, 18);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(43, 15);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelClientes);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.panelClientes.ResumeLayout(false);
            this.panelClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiaDoFiado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelClientes;
        private TextBox textBoxCPF;
        private TextBox textBoxNome;
        private Label labelSenha;
        private Label labelTelefone;
        private Label labelCPF;
        private Label labelNome;
        private TextBox textBoxTelefone;
        private TextBox textBoxSenha;
        private Label labelMarcaFiado;
        private RadioButton radioButtonFiadoNao;
        private RadioButton radioButtonFiadoSim;
        private Label labelDiaDoFiado;
        private NumericUpDown numericUpDownDiaDoFiado;
        private Button buttonCadastrar;
    }
}