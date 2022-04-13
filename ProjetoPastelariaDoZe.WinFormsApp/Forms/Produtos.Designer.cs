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
            this.ButtonFechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFotoDoProduto)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.textBoxNome.TabIndex = 1;
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
            this.textBoxDescricaoProduto.TabIndex = 3;
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
            this.textBoxValorUnitario.TabIndex = 5;
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
            this.buttonImportar.TabIndex = 7;
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
            this.buttonCadastrar.TabIndex = 9;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            // 
            // ButtonFechar
            // 
            this.ButtonFechar.BackColor = System.Drawing.Color.White;
            this.ButtonFechar.FlatAppearance.BorderSize = 0;
            this.ButtonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFechar.Location = new System.Drawing.Point(698, 253);
            this.ButtonFechar.Name = "ButtonFechar";
            this.ButtonFechar.Size = new System.Drawing.Size(75, 23);
            this.ButtonFechar.TabIndex = 10;
            this.ButtonFechar.Text = "Fechar";
            this.ButtonFechar.UseVisualStyleBackColor = false;
            this.ButtonFechar.Click += new System.EventHandler(this.ButtonFechar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ButtonFechar);
            this.panel1.Controls.Add(this.buttonImportar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 295);
            this.panel1.TabIndex = 11;
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
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Produtos";
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFotoDoProduto)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private Button ButtonFechar;
        private Panel panel1;
    }
}