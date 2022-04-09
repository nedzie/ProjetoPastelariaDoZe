namespace ProjetoPastelariaDoZe.WinFormsApp
{
    partial class Configuracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracoes));
            this.labelTaxaJurosDiaria = new System.Windows.Forms.Label();
            this.panelFundoConfiguracoes = new System.Windows.Forms.Panel();
            this.tabControlParametrosParaCobranca = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxMultaPorAtraso = new System.Windows.Forms.TextBox();
            this.labelMultaPorAtraso = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.textBoxTaxaJurosDiaria = new System.Windows.Forms.TextBox();
            this.tabPageIdiomaRegiao = new System.Windows.Forms.TabPage();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.panelFundoConfiguracoes.SuspendLayout();
            this.tabControlParametrosParaCobranca.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTaxaJurosDiaria
            // 
            this.labelTaxaJurosDiaria.AutoSize = true;
            this.labelTaxaJurosDiaria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTaxaJurosDiaria.ForeColor = System.Drawing.Color.White;
            this.labelTaxaJurosDiaria.Location = new System.Drawing.Point(6, 21);
            this.labelTaxaJurosDiaria.Name = "labelTaxaJurosDiaria";
            this.labelTaxaJurosDiaria.Size = new System.Drawing.Size(149, 17);
            this.labelTaxaJurosDiaria.TabIndex = 0;
            this.labelTaxaJurosDiaria.Text = "Taxa de juros diária (%):";
            // 
            // panelFundoConfiguracoes
            // 
            this.panelFundoConfiguracoes.BackColor = System.Drawing.Color.Transparent;
            this.panelFundoConfiguracoes.Controls.Add(this.tabControlParametrosParaCobranca);
            this.panelFundoConfiguracoes.Controls.Add(this.buttonFechar);
            this.panelFundoConfiguracoes.Location = new System.Drawing.Point(12, 12);
            this.panelFundoConfiguracoes.Name = "panelFundoConfiguracoes";
            this.panelFundoConfiguracoes.Size = new System.Drawing.Size(643, 421);
            this.panelFundoConfiguracoes.TabIndex = 1;
            // 
            // tabControlParametrosParaCobranca
            // 
            this.tabControlParametrosParaCobranca.Controls.Add(this.tabPage1);
            this.tabControlParametrosParaCobranca.Controls.Add(this.tabPageIdiomaRegiao);
            this.tabControlParametrosParaCobranca.Location = new System.Drawing.Point(3, 3);
            this.tabControlParametrosParaCobranca.Multiline = true;
            this.tabControlParametrosParaCobranca.Name = "tabControlParametrosParaCobranca";
            this.tabControlParametrosParaCobranca.SelectedIndex = 0;
            this.tabControlParametrosParaCobranca.Size = new System.Drawing.Size(637, 256);
            this.tabControlParametrosParaCobranca.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.textBoxMultaPorAtraso);
            this.tabPage1.Controls.Add(this.labelMultaPorAtraso);
            this.tabPage1.Controls.Add(this.buttonSalvar);
            this.tabPage1.Controls.Add(this.textBoxTaxaJurosDiaria);
            this.tabPage1.Controls.Add(this.labelTaxaJurosDiaria);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(629, 228);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Parâmetros para cobrança";
            // 
            // textBoxMultaPorAtraso
            // 
            this.textBoxMultaPorAtraso.Location = new System.Drawing.Point(193, 50);
            this.textBoxMultaPorAtraso.Name = "textBoxMultaPorAtraso";
            this.textBoxMultaPorAtraso.PlaceholderText = "R$";
            this.textBoxMultaPorAtraso.Size = new System.Drawing.Size(97, 23);
            this.textBoxMultaPorAtraso.TabIndex = 2;
            // 
            // labelMultaPorAtraso
            // 
            this.labelMultaPorAtraso.AutoSize = true;
            this.labelMultaPorAtraso.ForeColor = System.Drawing.Color.White;
            this.labelMultaPorAtraso.Location = new System.Drawing.Point(193, 23);
            this.labelMultaPorAtraso.Name = "labelMultaPorAtraso";
            this.labelMultaPorAtraso.Size = new System.Drawing.Size(121, 15);
            this.labelMultaPorAtraso.TabIndex = 3;
            this.labelMultaPorAtraso.Text = "Multa por atraso (R$):";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.White;
            this.buttonSalvar.FlatAppearance.BorderSize = 0;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Location = new System.Drawing.Point(306, 178);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(150, 30);
            this.buttonSalvar.TabIndex = 4;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            // 
            // textBoxTaxaJurosDiaria
            // 
            this.textBoxTaxaJurosDiaria.Location = new System.Drawing.Point(19, 48);
            this.textBoxTaxaJurosDiaria.Name = "textBoxTaxaJurosDiaria";
            this.textBoxTaxaJurosDiaria.PlaceholderText = "%";
            this.textBoxTaxaJurosDiaria.Size = new System.Drawing.Size(126, 23);
            this.textBoxTaxaJurosDiaria.TabIndex = 1;
            // 
            // tabPageIdiomaRegiao
            // 
            this.tabPageIdiomaRegiao.BackColor = System.Drawing.Color.Black;
            this.tabPageIdiomaRegiao.Location = new System.Drawing.Point(4, 24);
            this.tabPageIdiomaRegiao.Name = "tabPageIdiomaRegiao";
            this.tabPageIdiomaRegiao.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIdiomaRegiao.Size = new System.Drawing.Size(462, 214);
            this.tabPageIdiomaRegiao.TabIndex = 1;
            this.tabPageIdiomaRegiao.Text = "Idioma/Região";
            // 
            // buttonFechar
            // 
            this.buttonFechar.BackColor = System.Drawing.Color.White;
            this.buttonFechar.FlatAppearance.BorderSize = 0;
            this.buttonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFechar.Location = new System.Drawing.Point(568, 395);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 23);
            this.buttonFechar.TabIndex = 5;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.ButtonFechar_Click);
            // 
            // Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(667, 445);
            this.Controls.Add(this.panelFundoConfiguracoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Configuracoes";
            this.Text = "Configurações";
            this.panelFundoConfiguracoes.ResumeLayout(false);
            this.tabControlParametrosParaCobranca.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelTaxaJurosDiaria;
        private Panel panelFundoConfiguracoes;
        private Button buttonSalvar;
        private Label labelMultaPorAtraso;
        private TextBox textBoxMultaPorAtraso;
        private TextBox textBoxTaxaJurosDiaria;
        private Button buttonFechar;
        private TabControl tabControlParametrosParaCobranca;
        private TabPage tabPage1;
        private TabPage tabPageIdiomaRegiao;
    }
}