using FluentValidation.Results;
using ProjetoPastelariaDoZe.DAO;
using ProjetoPastelariaDoZe.WinFormsApp.Compartilhado;
using ProjetoPastelariaDoZe.WinFormsApp.Validadores.ModuloProduto;
using System.Configuration;

namespace ProjetoPastelariaDoZe.WinFormsApp
{
    /// <summary>
    /// Classe auxiliar Produtos
    /// </summary>
    public partial class FormProdutos : Form
    {
        /// <summary>
        /// Instância DAO dentro da classe FormProdutos
        /// </summary>
        public readonly ProdutoDAO? dao;
        /// <summary>
        /// Construtor da classe Produtos
        /// </summary>
        public FormProdutos()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesForm(this);
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            this.Text = Properties.Resources.ResourceManager.GetString("formProdutos.Text");
            UserControlControleUsuarioGeral opcoes = new()
            {
                Dock = DockStyle.Bottom
            };
            Size = new(Size.Width, Size.Height + opcoes.Size.Height);
            this.Controls.Add(opcoes);
            opcoes.buttonSalvar.Click += ButtonSalvar_Click;
            opcoes.buttonSair.Click += ButtonSair_Click;

            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string connectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            dao = new(provider, connectionString);
        }

        private void ButtonSalvar_Click(object? sender, EventArgs e)
        {
            Produto produto = new();

            ConfigurarParametrosProduto(produto);

            ValidadorProduto vp = new();

            ValidationResult vr = vp.Validate(produto);

            if (!vr.IsValid)
                MessageBox.Show(vr.ToString());
            else
            {
                try
                {
                    dao!.InserirDBProvider(produto);

                    MessageBox.Show("Deu boa");
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ConfigurarParametrosProduto(Produto produto)
        {
            produto.Numero = 0;
            produto.Nome = textBoxNome.Text;
            if (textBoxDescricaoProduto.Text != null)
                produto.Descricao = textBoxDescricaoProduto.Text;
            if(textBoxValorUnitario.Text != string.Empty)
                produto.ValorUn = Convert.ToDecimal(textBoxValorUnitario.Text);
            produto.Foto = Funcoes.ConverterImagemParaByteArray(pictureBoxImagem.Image);
        }

        private void pictureBoxImagem_Click(object sender, EventArgs e)
        {
            openFileDialogImagem.Title = "Imagem do produto"; //Trocar para outras culturas
            openFileDialogImagem.Filter = "Images (*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG;*.)|*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG;*.icon;*.JFIF";

            if(openFileDialogImagem.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImagem.Image = Image.FromFile(openFileDialogImagem.FileName);

                pictureBoxImagem.Image = new Bitmap(pictureBoxImagem.Image, new Size(130, 98));

                pictureBoxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void ButtonSair_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}