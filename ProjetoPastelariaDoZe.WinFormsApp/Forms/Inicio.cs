using ProjetoPastelariaDoZe.WinFormsApp.Compartilhado;
using System.ComponentModel;

namespace ProjetoPastelariaDoZe.WinFormsApp
{
    /// <summary>
    /// Classe auxiliar Inicio
    /// </summary>
    public partial class Inicio : Form
    {
        /// <summary>
        /// Construtor da classe Inicio
        /// </summary>
        public Inicio()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesForm(this);
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            this.Text = Properties.Resources.ResourceManager.GetString("formInicio.Text");
            MaximizeBox = false;
            //Button início?
            toolStripMenuItemLogin.Click += new EventHandler(buttonLogin_Click!);
            toolStripMenuItemFuncionarios.Click += new EventHandler(buttonFuncionarios_Click!);
            toolStripMenuItemClientes.Click += new EventHandler(buttonClientes_Click!);
            toolStripMenuItemProdutos.Click += new EventHandler(buttonProdutos_Click!);
            toolStripMenuItemConfiguracoes.Click += new EventHandler(buttonConfiguracoes_Click!);
            //Falta o 'sair'


            ComponentResourceManager resources = new(typeof(Properties.Resources));
            foreach (ToolStripItem c in contextMenuStripInicio.Items)
            {
                resources.ApplyResources(c, c.Name);
            }
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Fechar fechar = new();
            fechar.StartPosition = FormStartPosition.CenterParent;
            if (fechar.ShowDialog() == DialogResult.No)
                e.Cancel = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login login = new();
            login.StartPosition = FormStartPosition.CenterParent;
            login.ShowDialog(); // Modal
        }

        private void buttonFuncionarios_Click(object sender, EventArgs e)
        {
            Funcionarios funcionarios = new();
            funcionarios.Show();
        }

        private void buttonComandas_Click(object sender, EventArgs e)
        {
            Comandas comanda = new();
            comanda.Show();
        }
        private void buttonClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new();
            clientes.Show();
        }
        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            Produtos produtos = new();
            produtos.Show();
        }
        private void buttonConfiguracoes_Click(object sender, EventArgs e)
        {
            Configuracoes configuracoes = new();
            configuracoes.Show(); // Janela normal
        }
        private void buttonSobre_Click(object sender, EventArgs e)
        {
            Sobre sobre = new();
            sobre.StartPosition = FormStartPosition.CenterParent;
            sobre.ShowDialog();
        }
    }
}