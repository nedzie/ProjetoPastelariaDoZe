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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.labelValorUnitario = new System.Windows.Forms.Label();
            this.textBoxValorUnitario = new System.Windows.Forms.TextBox();
            this.labelFoto = new System.Windows.Forms.Label();
            this.buttonImportar = new System.Windows.Forms.Button();
            this.PictureBoxFotoDoProduto = new System.Windows.Forms.PictureBox();
            this.ButtonCadastrar = new System.Windows.Forms.Button();
            this.ButtonFechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFotoDoProduto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            resources.ApplyResources(this.labelNome, "labelNome");
            this.labelNome.ForeColor = System.Drawing.Color.White;
            this.labelNome.Name = "labelNome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxNome, "textBoxNome");
            this.textBoxNome.Name = "textBoxNome";
            // 
            // labelDescricao
            // 
            resources.ApplyResources(this.labelDescricao, "labelDescricao");
            this.labelDescricao.ForeColor = System.Drawing.Color.White;
            this.labelDescricao.Name = "labelDescricao";
            // 
            // textBoxDescricao
            // 
            resources.ApplyResources(this.textBoxDescricao, "textBoxDescricao");
            this.textBoxDescricao.Name = "textBoxDescricao";
            // 
            // labelValorUnitario
            // 
            resources.ApplyResources(this.labelValorUnitario, "labelValorUnitario");
            this.labelValorUnitario.ForeColor = System.Drawing.Color.White;
            this.labelValorUnitario.Name = "labelValorUnitario";
            // 
            // textBoxValorUnitario
            // 
            resources.ApplyResources(this.textBoxValorUnitario, "textBoxValorUnitario");
            this.textBoxValorUnitario.Name = "textBoxValorUnitario";
            // 
            // labelFoto
            // 
            resources.ApplyResources(this.labelFoto, "labelFoto");
            this.labelFoto.ForeColor = System.Drawing.Color.White;
            this.labelFoto.Name = "labelFoto";
            // 
            // buttonImportar
            // 
            this.buttonImportar.BackColor = System.Drawing.Color.White;
            this.buttonImportar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonImportar, "buttonImportar");
            this.buttonImportar.Name = "buttonImportar";
            this.buttonImportar.UseVisualStyleBackColor = false;
            // 
            // PictureBoxFotoDoProduto
            // 
            this.PictureBoxFotoDoProduto.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.PictureBoxFotoDoProduto, "PictureBoxFotoDoProduto");
            this.PictureBoxFotoDoProduto.Name = "PictureBoxFotoDoProduto";
            this.PictureBoxFotoDoProduto.TabStop = false;
            // 
            // ButtonCadastrar
            // 
            this.ButtonCadastrar.BackColor = System.Drawing.Color.White;
            this.ButtonCadastrar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ButtonCadastrar, "ButtonCadastrar");
            this.ButtonCadastrar.Name = "ButtonCadastrar";
            this.ButtonCadastrar.UseVisualStyleBackColor = false;
            // 
            // ButtonFechar
            // 
            this.ButtonFechar.BackColor = System.Drawing.Color.White;
            this.ButtonFechar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ButtonFechar, "ButtonFechar");
            this.ButtonFechar.Name = "ButtonFechar";
            this.ButtonFechar.UseVisualStyleBackColor = false;
            this.ButtonFechar.Click += new System.EventHandler(this.ButtonFechar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ButtonFechar);
            this.panel1.Controls.Add(this.buttonImportar);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // Produtos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.ButtonCadastrar);
            this.Controls.Add(this.PictureBoxFotoDoProduto);
            this.Controls.Add(this.labelFoto);
            this.Controls.Add(this.textBoxValorUnitario);
            this.Controls.Add(this.labelValorUnitario);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.panel1);
            this.Name = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFotoDoProduto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNome;
        private TextBox textBoxNome;
        private Label labelDescricao;
        private TextBox textBoxDescricao;
        private Label labelValorUnitario;
        private TextBox textBoxValorUnitario;
        private Label labelFoto;
        private Button buttonImportar;
        private PictureBox PictureBoxFotoDoProduto;
        private Button ButtonCadastrar;
        private Button ButtonFechar;
        private Panel panel1;
    }
}