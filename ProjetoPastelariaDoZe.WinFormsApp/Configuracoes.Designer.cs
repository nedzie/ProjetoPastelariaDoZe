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
            this.labelTaxaJuroDiaria = new System.Windows.Forms.Label();
            this.panelFundoConfiguracoes = new System.Windows.Forms.Panel();
            this.textBoxTaxaJurosDiaria = new System.Windows.Forms.TextBox();
            this.textBoxMultaPorAtraso = new System.Windows.Forms.TextBox();
            this.labelMultaPorAtraso = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.panelFundoConfiguracoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTaxaJuroDiaria
            // 
            this.labelTaxaJuroDiaria.AutoSize = true;
            this.labelTaxaJuroDiaria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTaxaJuroDiaria.Location = new System.Drawing.Point(97, 63);
            this.labelTaxaJuroDiaria.Name = "labelTaxaJuroDiaria";
            this.labelTaxaJuroDiaria.Size = new System.Drawing.Size(126, 17);
            this.labelTaxaJuroDiaria.TabIndex = 0;
            this.labelTaxaJuroDiaria.Text = "Taxa de juros diária:";
            // 
            // panelFundoConfiguracoes
            // 
            this.panelFundoConfiguracoes.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            // textBoxTaxaJurosDiaria
            // 
            this.textBoxTaxaJurosDiaria.Location = new System.Drawing.Point(97, 83);
            this.textBoxTaxaJurosDiaria.Name = "textBoxTaxaJurosDiaria";
            this.textBoxTaxaJurosDiaria.Size = new System.Drawing.Size(126, 23);
            this.textBoxTaxaJurosDiaria.TabIndex = 1;
            // 
            // textBoxMultaPorAtraso
            // 
            this.textBoxMultaPorAtraso.Location = new System.Drawing.Point(272, 83);
            this.textBoxMultaPorAtraso.Name = "textBoxMultaPorAtraso";
            this.textBoxMultaPorAtraso.Size = new System.Drawing.Size(97, 23);
            this.textBoxMultaPorAtraso.TabIndex = 2;
            // 
            // labelMultaPorAtraso
            // 
            this.labelMultaPorAtraso.AutoSize = true;
            this.labelMultaPorAtraso.Location = new System.Drawing.Point(272, 65);
            this.labelMultaPorAtraso.Name = "labelMultaPorAtraso";
            this.labelMultaPorAtraso.Size = new System.Drawing.Size(97, 15);
            this.labelMultaPorAtraso.TabIndex = 3;
            this.labelMultaPorAtraso.Text = "Multa por atraso:";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(168, 155);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(150, 30);
            this.buttonSalvar.TabIndex = 4;
            this.buttonSalvar.Text = "Salvar configurações";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 319);
            this.Controls.Add(this.panelFundoConfiguracoes);
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
    }
}