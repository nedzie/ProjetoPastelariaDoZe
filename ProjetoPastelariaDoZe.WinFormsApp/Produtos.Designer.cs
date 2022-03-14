namespace ProjetoPastelariaDoZe.WinFormsApp
{
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
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.labelValorUnitario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelFoto = new System.Windows.Forms.Label();
            this.ButtonImportarFoto = new System.Windows.Forms.Button();
            this.PictureBoxFotoDoProduto = new System.Windows.Forms.PictureBox();
            this.ButtonCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFotoDoProduto)).BeginInit();
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
            this.textBoxNome.Location = new System.Drawing.Point(118, 42);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.PlaceholderText = "Nome do produto";
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
            this.labelDescricao.Text = "Descrição:";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(118, 121);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.PlaceholderText = "Descrição do produto";
            this.textBoxDescricao.Size = new System.Drawing.Size(444, 23);
            this.textBoxDescricao.TabIndex = 3;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 199);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "R$";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 5;
            // 
            // labelFoto
            // 
            this.labelFoto.AutoSize = true;
            this.labelFoto.ForeColor = System.Drawing.Color.White;
            this.labelFoto.Location = new System.Drawing.Point(118, 247);
            this.labelFoto.Name = "labelFoto";
            this.labelFoto.Size = new System.Drawing.Size(34, 15);
            this.labelFoto.TabIndex = 6;
            this.labelFoto.Text = "Foto:";
            // 
            // ButtonImportarFoto
            // 
            this.ButtonImportarFoto.BackColor = System.Drawing.Color.White;
            this.ButtonImportarFoto.Location = new System.Drawing.Point(122, 378);
            this.ButtonImportarFoto.Name = "ButtonImportarFoto";
            this.ButtonImportarFoto.Size = new System.Drawing.Size(104, 40);
            this.ButtonImportarFoto.TabIndex = 7;
            this.ButtonImportarFoto.Text = "Importar...";
            this.ButtonImportarFoto.UseVisualStyleBackColor = false;
            // 
            // PictureBoxFotoDoProduto
            // 
            this.PictureBoxFotoDoProduto.Location = new System.Drawing.Point(122, 265);
            this.PictureBoxFotoDoProduto.Name = "PictureBoxFotoDoProduto";
            this.PictureBoxFotoDoProduto.Size = new System.Drawing.Size(138, 107);
            this.PictureBoxFotoDoProduto.TabIndex = 8;
            this.PictureBoxFotoDoProduto.TabStop = false;
            // 
            // ButtonCadastrar
            // 
            this.ButtonCadastrar.BackColor = System.Drawing.Color.White;
            this.ButtonCadastrar.Location = new System.Drawing.Point(568, 372);
            this.ButtonCadastrar.Name = "ButtonCadastrar";
            this.ButtonCadastrar.Size = new System.Drawing.Size(144, 53);
            this.ButtonCadastrar.TabIndex = 9;
            this.ButtonCadastrar.Text = "Cadastrar";
            this.ButtonCadastrar.UseVisualStyleBackColor = false;
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonCadastrar);
            this.Controls.Add(this.PictureBoxFotoDoProduto);
            this.Controls.Add(this.ButtonImportarFoto);
            this.Controls.Add(this.labelFoto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelValorUnitario);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Name = "Produtos";
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFotoDoProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelDescricao;
        private TextBox textBoxDescricao;
        private Label labelValorUnitario;
        private TextBox textBox1;
        private Label labelFoto;
        private Button ButtonImportarFoto;
        private PictureBox PictureBoxFotoDoProduto;
        private Button ButtonCadastrar;
    }
}