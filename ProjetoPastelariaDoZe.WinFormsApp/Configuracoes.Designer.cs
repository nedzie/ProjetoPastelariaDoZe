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
            this.labelTaxaJuroDiaria = new System.Windows.Forms.Label();
            this.panelFundoConfiguracoes = new System.Windows.Forms.Panel();
            this.ButtonFechar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.labelMultaPorAtraso = new System.Windows.Forms.Label();
            this.textBoxMultaPorAtraso = new System.Windows.Forms.TextBox();
            this.textBoxTaxaJurosDiaria = new System.Windows.Forms.TextBox();
            this.panelFundoConfiguracoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTaxaJuroDiaria
            // 
            this.labelTaxaJuroDiaria.AutoSize = true;
            this.labelTaxaJuroDiaria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTaxaJuroDiaria.ForeColor = System.Drawing.Color.White;
            this.labelTaxaJuroDiaria.Location = new System.Drawing.Point(23, 19);
            this.labelTaxaJuroDiaria.Name = "labelTaxaJuroDiaria";
            this.labelTaxaJuroDiaria.Size = new System.Drawing.Size(149, 17);
            this.labelTaxaJuroDiaria.TabIndex = 0;
            this.labelTaxaJuroDiaria.Text = "Taxa de juros diária (%):";
            // 
            // panelFundoConfiguracoes
            // 
            this.panelFundoConfiguracoes.BackColor = System.Drawing.Color.Transparent;
            this.panelFundoConfiguracoes.Controls.Add(this.ButtonFechar);
            this.panelFundoConfiguracoes.Controls.Add(this.buttonSalvar);
            this.panelFundoConfiguracoes.Controls.Add(this.labelMultaPorAtraso);
            this.panelFundoConfiguracoes.Controls.Add(this.textBoxMultaPorAtraso);
            this.panelFundoConfiguracoes.Controls.Add(this.textBoxTaxaJurosDiaria);
            this.panelFundoConfiguracoes.Controls.Add(this.labelTaxaJuroDiaria);
            this.panelFundoConfiguracoes.Location = new System.Drawing.Point(12, 12);
            this.panelFundoConfiguracoes.Name = "panelFundoConfiguracoes";
            this.panelFundoConfiguracoes.Size = new System.Drawing.Size(476, 295);
            this.panelFundoConfiguracoes.TabIndex = 1;
            // 
            // ButtonFechar
            // 
            this.ButtonFechar.BackColor = System.Drawing.Color.White;
            this.ButtonFechar.FlatAppearance.BorderSize = 0;
            this.ButtonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFechar.Location = new System.Drawing.Point(401, 272);
            this.ButtonFechar.Name = "ButtonFechar";
            this.ButtonFechar.Size = new System.Drawing.Size(75, 23);
            this.ButtonFechar.TabIndex = 5;
            this.ButtonFechar.Text = "Fechar";
            this.ButtonFechar.UseVisualStyleBackColor = false;
            this.ButtonFechar.Click += new System.EventHandler(this.ButtonFechar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.Color.White;
            this.buttonSalvar.FlatAppearance.BorderSize = 0;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Location = new System.Drawing.Point(23, 169);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(150, 30);
            this.buttonSalvar.TabIndex = 4;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            // 
            // labelMultaPorAtraso
            // 
            this.labelMultaPorAtraso.AutoSize = true;
            this.labelMultaPorAtraso.ForeColor = System.Drawing.Color.White;
            this.labelMultaPorAtraso.Location = new System.Drawing.Point(210, 21);
            this.labelMultaPorAtraso.Name = "labelMultaPorAtraso";
            this.labelMultaPorAtraso.Size = new System.Drawing.Size(121, 15);
            this.labelMultaPorAtraso.TabIndex = 3;
            this.labelMultaPorAtraso.Text = "Multa por atraso (R$):";
            // 
            // textBoxMultaPorAtraso
            // 
            this.textBoxMultaPorAtraso.Location = new System.Drawing.Point(210, 39);
            this.textBoxMultaPorAtraso.Name = "textBoxMultaPorAtraso";
            this.textBoxMultaPorAtraso.PlaceholderText = "R$";
            this.textBoxMultaPorAtraso.Size = new System.Drawing.Size(97, 23);
            this.textBoxMultaPorAtraso.TabIndex = 2;
            // 
            // textBoxTaxaJurosDiaria
            // 
            this.textBoxTaxaJurosDiaria.Location = new System.Drawing.Point(23, 39);
            this.textBoxTaxaJurosDiaria.Name = "textBoxTaxaJurosDiaria";
            this.textBoxTaxaJurosDiaria.PlaceholderText = "%";
            this.textBoxTaxaJurosDiaria.Size = new System.Drawing.Size(126, 23);
            this.textBoxTaxaJurosDiaria.TabIndex = 1;
            // 
            // Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(500, 319);
            this.Controls.Add(this.panelFundoConfiguracoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Configuracoes";
            this.Text = "Configurações";
            this.panelFundoConfiguracoes.ResumeLayout(false);
            this.panelFundoConfiguracoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label labelTaxaJuroDiaria;
        private Panel panelFundoConfiguracoes;
        private Button buttonSalvar;
        private Label labelMultaPorAtraso;
        private TextBox textBoxMultaPorAtraso;
        private TextBox textBoxTaxaJurosDiaria;
        private Button ButtonFechar;
    }
}