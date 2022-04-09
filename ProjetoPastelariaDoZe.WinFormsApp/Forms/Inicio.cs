using ProjetoPastelariaDoZe.WinFormsApp.Compartilhado;

namespace ProjetoPastelariaDoZe.WinFormsApp
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesForm(this);
            this.Text = Properties.Resources.ResourceManager.GetString("formInicio.Text");
            //buttonLogin.Text = Properties.Resources.ResourceManager.GetString("buttonLogin.Text");
            //buttonInicio.Text = Properties.Resources.ResourceManager.GetString("buttonInicio.Text");
            //buttonCaixa.Text = Properties.Resources.ResourceManager.GetString("buttonCaixa.Text");
            //buttonFuncionarios.Text = Properties.Resources.ResourceManager.GetString("buttonFuncionarios.Text");
            //buttonComanda.Text = Properties.Resources.ResourceManager.GetString("buttonComandas.Text");
            //buttonClientes.Text = Properties.Resources.ResourceManager.GetString("buttonClientes.Text");
            //buttonProdutos.Text = Properties.Resources.ResourceManager.GetString("buttonProdutos.Text");
            //buttonSobre.Text = Properties.Resources.ResourceManager.GetString("buttonSobre.Text");
            //buttonConfiguracoes.Text = Properties.Resources.ResourceManager.GetString("buttonConfiguracoes.Text"); // Em ordem!!!
        }

        private void ButtonLogin_MouseClick(object sender, MouseEventArgs e)
        {
            Login login = new();
            login.StartPosition = FormStartPosition.CenterParent;
            login.ShowDialog(); // Modal
        }

        private void ButtonConfiguracoes_MouseClick(object sender, MouseEventArgs e)
        {
            Configuracoes configuracoes = new();
            configuracoes.Show(); // Janela normal
        }

        private void ButtonFuncionarios_MouseClick(object sender, MouseEventArgs e)
        {
            Funcionarios funcionarios = new();
            funcionarios.Show();
        }

        private void ButtonClientes_MouseClick(object sender, MouseEventArgs e)
        {
            Clientes clientes = new();
            clientes.Show();
        }

        private void ButtonProdutos_MouseClick(object sender, MouseEventArgs e)
        {
            Produtos produtos = new();
            produtos.Show();
        }

        private void ButtonSobre_MouseClick(object sender, MouseEventArgs e)
        {
            Sobre sobre = new();
            sobre.StartPosition = FormStartPosition.CenterParent;
            sobre.ShowDialog();
        }

        private void ButtonComanda_MouseClick(object sender, MouseEventArgs e)
        {
            Comandas comanda = new();
            comanda.Show();
        }
    }
}