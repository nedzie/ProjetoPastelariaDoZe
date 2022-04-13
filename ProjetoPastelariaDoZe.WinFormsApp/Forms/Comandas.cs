using ProjetoPastelariaDoZe.WinFormsApp.Compartilhado;

namespace ProjetoPastelariaDoZe.WinFormsApp
{   /// <summary>
    /// Classe comandas
    /// </summary>
    public partial class Comandas : Form
    {
        /// <summary>
        /// Construtor da classe Comandas
        /// </summary>
        public Comandas()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesForm(this);
            this.Text = Properties.Resources.ResourceManager.GetString("formComandas.Text");
            UserControlControleUsuarioGeral opcoes = new();
            opcoes.Dock = DockStyle.Bottom;
            Size = new(Size.Width, Size.Height + opcoes.Size.Height);
            this.Controls.Add(opcoes);
        }
        /// <summary>
        /// Captura o evento de click para fechar o form Comandas
        /// </summary>
        /// <param name="sender">Define o objecto que está enviando a informação</param>
        /// <param name="e">Pois agora</param>
        private void ButtonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}