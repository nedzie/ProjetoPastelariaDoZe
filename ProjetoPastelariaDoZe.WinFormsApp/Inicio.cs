namespace ProjetoPastelariaDoZe.WinFormsApp
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
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