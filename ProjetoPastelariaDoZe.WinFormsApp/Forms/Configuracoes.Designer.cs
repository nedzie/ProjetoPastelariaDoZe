namespace ProjetoPastelariaDoZe.WinFormsApp
{
    /// <summary>
    /// Classe auxiliar Configuracoes
    /// </summary>
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
            this.tabPageParametros = new System.Windows.Forms.TabPage();
            this.textBoxMultaPorAtraso = new System.Windows.Forms.TextBox();
            this.labelMultaPorAtraso = new System.Windows.Forms.Label();
            this.textBoxTaxaJurosDiaria = new System.Windows.Forms.TextBox();
            this.tabPageIdiomaRegiao = new System.Windows.Forms.TabPage();
            this.checkBoxReiniciar = new System.Windows.Forms.CheckBox();
            this.comboBoxIdiomas = new System.Windows.Forms.ComboBox();
            this.panelFundoConfiguracoes.SuspendLayout();
            this.tabControlParametrosParaCobranca.SuspendLayout();
            this.tabPageParametros.SuspendLayout();
            this.tabPageIdiomaRegiao.SuspendLayout();
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
            this.panelFundoConfiguracoes.Location = new System.Drawing.Point(12, 12);
            this.panelFundoConfiguracoes.Name = "panelFundoConfiguracoes";
            this.panelFundoConfiguracoes.Size = new System.Drawing.Size(643, 270);
            this.panelFundoConfiguracoes.TabIndex = 1;
            // 
            // tabControlParametrosParaCobranca
            // 
            this.tabControlParametrosParaCobranca.Controls.Add(this.tabPageParametros);
            this.tabControlParametrosParaCobranca.Controls.Add(this.tabPageIdiomaRegiao);
            this.tabControlParametrosParaCobranca.Location = new System.Drawing.Point(3, 3);
            this.tabControlParametrosParaCobranca.Multiline = true;
            this.tabControlParametrosParaCobranca.Name = "tabControlParametrosParaCobranca";
            this.tabControlParametrosParaCobranca.SelectedIndex = 0;
            this.tabControlParametrosParaCobranca.Size = new System.Drawing.Size(637, 256);
            this.tabControlParametrosParaCobranca.TabIndex = 0;
            // 
            // tabPageParametros
            // 
            this.tabPageParametros.BackColor = System.Drawing.Color.Black;
            this.tabPageParametros.Controls.Add(this.textBoxMultaPorAtraso);
            this.tabPageParametros.Controls.Add(this.labelMultaPorAtraso);
            this.tabPageParametros.Controls.Add(this.textBoxTaxaJurosDiaria);
            this.tabPageParametros.Controls.Add(this.labelTaxaJurosDiaria);
            this.tabPageParametros.Location = new System.Drawing.Point(4, 24);
            this.tabPageParametros.Name = "tabPageParametros";
            this.tabPageParametros.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParametros.Size = new System.Drawing.Size(629, 228);
            this.tabPageParametros.TabIndex = 0;
            this.tabPageParametros.Text = "Parâmetros para cobrança";
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
            this.tabPageIdiomaRegiao.Controls.Add(this.checkBoxReiniciar);
            this.tabPageIdiomaRegiao.Controls.Add(this.comboBoxIdiomas);
            this.tabPageIdiomaRegiao.Location = new System.Drawing.Point(4, 24);
            this.tabPageIdiomaRegiao.Name = "tabPageIdiomaRegiao";
            this.tabPageIdiomaRegiao.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIdiomaRegiao.Size = new System.Drawing.Size(629, 228);
            this.tabPageIdiomaRegiao.TabIndex = 1;
            this.tabPageIdiomaRegiao.Text = "Idioma/Região";
            // 
            // checkBoxReiniciar
            // 
            this.checkBoxReiniciar.AutoSize = true;
            this.checkBoxReiniciar.FlatAppearance.BorderSize = 0;
            this.checkBoxReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxReiniciar.ForeColor = System.Drawing.Color.White;
            this.checkBoxReiniciar.Location = new System.Drawing.Point(192, 33);
            this.checkBoxReiniciar.Name = "checkBoxReiniciar";
            this.checkBoxReiniciar.Size = new System.Drawing.Size(295, 19);
            this.checkBoxReiniciar.TabIndex = 2;
            this.checkBoxReiniciar.Text = "Reiniciar para aplicar o novo idioma imediatamente";
            this.checkBoxReiniciar.UseVisualStyleBackColor = true;
            // 
            // comboBoxIdiomas
            // 
            this.comboBoxIdiomas.FormattingEnabled = true;
            this.comboBoxIdiomas.Items.AddRange(new object[] {
            "pt-BR",
            "en-US",
            "es"});
            this.comboBoxIdiomas.Location = new System.Drawing.Point(16, 29);
            this.comboBoxIdiomas.Name = "comboBoxIdiomas";
            this.comboBoxIdiomas.Size = new System.Drawing.Size(121, 23);
            this.comboBoxIdiomas.TabIndex = 1;
            // 
            // Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(667, 288);
            this.Controls.Add(this.panelFundoConfiguracoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Configuracoes";
            this.Text = "Configurações";
            this.panelFundoConfiguracoes.ResumeLayout(false);
            this.tabControlParametrosParaCobranca.ResumeLayout(false);
            this.tabPageParametros.ResumeLayout(false);
            this.tabPageParametros.PerformLayout();
            this.tabPageIdiomaRegiao.ResumeLayout(false);
            this.tabPageIdiomaRegiao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelTaxaJurosDiaria;
        private Panel panelFundoConfiguracoes;
        private Label labelMultaPorAtraso;
        private TextBox textBoxMultaPorAtraso;
        private TextBox textBoxTaxaJurosDiaria;
        private TabControl tabControlParametrosParaCobranca;
        private TabPage tabPageParametros;
        private TabPage tabPageIdiomaRegiao;
        private ComboBox comboBoxIdiomas;
        private CheckBox checkBoxReiniciar;
    }
}