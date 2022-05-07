namespace ProjetoPastelariaDoZe.WinFormsApp
{
    /// <summary>
    /// Classe Produtos, onde são definidas as informações dos produtos
    /// </summary>
    partial class Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxDescricaoProduto = new System.Windows.Forms.TextBox();
            this.labelValorUnitario = new System.Windows.Forms.Label();
            this.textBoxValorUnitario = new System.Windows.Forms.TextBox();
            this.labelFoto = new System.Windows.Forms.Label();
            this.buttonImportar = new System.Windows.Forms.Button();
            this.PictureBoxFotoDoProduto = new System.Windows.Forms.PictureBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.panelProdutos = new System.Windows.Forms.Panel();
            this.maskedTextBoxValorUnitario = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFotoDoProduto)).BeginInit();
            this.panelProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.ForeColor = System.Drawing.Color.White;
            this.labelNome.Location = new System.Drawing.Point(118, 24);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(43, 15);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNome.Location = new System.Drawing.Point(118, 42);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.PlaceholderText = "Nome produto:";
            this.textBoxNome.Size = new System.Drawing.Size(235, 23);
            this.textBoxNome.TabIndex = 0;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.ForeColor = System.Drawing.Color.White;
            this.labelDescricao.Location = new System.Drawing.Point(118, 82);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(61, 15);
            this.labelDescricao.TabIndex = 2;
            this.labelDescricao.Text = "Descriçao:";
            // 
            // textBoxDescricaoProduto
            // 
            this.textBoxDescricaoProduto.Location = new System.Drawing.Point(118, 121);
            this.textBoxDescricaoProduto.Name = "textBoxDescricaoProduto";
            this.textBoxDescricaoProduto.PlaceholderText = "Descrição do produto";
            this.textBoxDescricaoProduto.Size = new System.Drawing.Size(298, 23);
            this.textBoxDescricaoProduto.TabIndex = 1;
            // 
            // labelValorUnitario
            // 
            this.labelValorUnitario.AutoSize = true;
            this.labelValorUnitario.ForeColor = System.Drawing.Color.White;
            this.labelValorUnitario.Location = new System.Drawing.Point(118, 170);
            this.labelValorUnitario.Name = "labelValorUnitario";
            this.labelValorUnitario.Size = new System.Drawing.Size(104, 15);
            this.labelValorUnitario.TabIndex = 4;
            this.labelValorUnitario.Text = "Valor unitário (R$):";
            // 
            // textBoxValorUnitario
            // 
            this.textBoxValorUnitario.Location = new System.Drawing.Point(118, 199);
            this.textBoxValorUnitario.Name = "textBoxValorUnitario";
            this.textBoxValorUnitario.PlaceholderText = "R$";
            this.textBoxValorUnitario.Size = new System.Drawing.Size(100, 23);
            this.textBoxValorUnitario.TabIndex = 2;
            // 
            // labelFoto
            // 
            this.labelFoto.AutoSize = true;
            this.labelFoto.ForeColor = System.Drawing.Color.White;
            this.labelFoto.Location = new System.Drawing.Point(535, 24);
            this.labelFoto.Name = "labelFoto";
            this.labelFoto.Size = new System.Drawing.Size(34, 15);
            this.labelFoto.TabIndex = 6;
            this.labelFoto.Text = "Foto:";
            // 
            // buttonImportar
            // 
            this.buttonImportar.BackColor = System.Drawing.Color.White;
            this.buttonImportar.FlatAppearance.BorderSize = 0;
            this.buttonImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImportar.Location = new System.Drawing.Point(527, 158);
            this.buttonImportar.Name = "buttonImportar";
            this.buttonImportar.Size = new System.Drawing.Size(104, 40);
            this.buttonImportar.TabIndex = 3;
            this.buttonImportar.Text = "Importar...";
            this.buttonImportar.UseVisualStyleBackColor = false;
            // 
            // PictureBoxFotoDoProduto
            // 
            this.PictureBoxFotoDoProduto.BackColor = System.Drawing.Color.DimGray;
            this.PictureBoxFotoDoProduto.Location = new System.Drawing.Point(539, 42);
            this.PictureBoxFotoDoProduto.Name = "PictureBoxFotoDoProduto";
            this.PictureBoxFotoDoProduto.Size = new System.Drawing.Size(138, 107);
            this.PictureBoxFotoDoProduto.TabIndex = 8;
            this.PictureBoxFotoDoProduto.TabStop = false;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.Color.White;
            this.buttonCadastrar.FlatAppearance.BorderSize = 0;
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrar.Location = new System.Drawing.Point(539, 235);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(144, 53);
            this.buttonCadastrar.TabIndex = 4;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            // 
            // panelProdutos
            // 
            this.panelProdutos.BackColor = System.Drawing.Color.Transparent;
            this.panelProdutos.Controls.Add(this.maskedTextBoxValorUnitario);
            this.panelProdutos.Controls.Add(this.buttonImportar);
            this.panelProdutos.Location = new System.Drawing.Point(12, 12);
            this.panelProdutos.Name = "panelProdutos";
            this.panelProdutos.Size = new System.Drawing.Size(776, 295);
            this.panelProdutos.TabIndex = 11;
            // 
            // maskedTextBoxValorUnitario
            // 
            this.maskedTextBoxValorUnitario.Location = new System.Drawing.Point(106, 223);
            this.maskedTextBoxValorUnitario.Mask = "999.999,99";
            this.maskedTextBoxValorUnitario.Name = "maskedTextBoxValorUnitario";
            this.maskedTextBoxValorUnitario.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxValorUnitario.TabIndex = 4;
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 324);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.PictureBoxFotoDoProduto);
            this.Controls.Add(this.labelFoto);
            this.Controls.Add(this.textBoxValorUnitario);
            this.Controls.Add(this.labelValorUnitario);
            this.Controls.Add(this.textBoxDescricaoProduto);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.panelProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFotoDoProduto)).EndInit();
            this.panelProdutos.ResumeLayout(false);
            this.panelProdutos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelDescricao;
        private TextBox textBoxDescricaoProduto;
        private Label labelValorUnitario;
        private TextBox textBoxValorUnitario;
        private Label labelFoto;
        private Button buttonImportar;
        private PictureBox PictureBoxFotoDoProduto;
        private Button buttonCadastrar;
        private Panel panelProdutos;
        private MaskedTextBox maskedTextBoxValorUnitario;
    }
}