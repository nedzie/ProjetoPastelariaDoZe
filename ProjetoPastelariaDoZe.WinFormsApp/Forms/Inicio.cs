using ProjetoPastelariaDoZe.DAO;
using ProjetoPastelariaDoZe.DAO.Compartilhado;
using ProjetoPastelariaDoZe.WinFormsApp.Compartilhado;
using System.ComponentModel;
using System.Data;

namespace ProjetoPastelariaDoZe.WinFormsApp
{
    /// <summary>
    /// Classe auxiliar Inicio
    /// </summary>
    public partial class Inicio : Form
    {
        EntidadeBase? dao;
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

            toolStripMenuItemLogin.Click += new EventHandler(buttonLogin_Click!);
            toolStripMenuItemFuncionarios.Click += new EventHandler(buttonFuncionarios_Click!);
            toolStripMenuItemClientes.Click += new EventHandler(buttonClientes_Click!);
            toolStripMenuItemProdutos.Click += new EventHandler(buttonProdutos_Click!);
            toolStripMenuItemConfiguracoes.Click += new EventHandler(buttonConfiguracoes_Click!);
            toolStripMenuItemSobre.Click += new EventHandler(buttonSobre_Click!);
            toolStripMenuItemSair.Click += ToolStripMenuItemSystemTraySair_Click;

            toolStripMenuItemSystemTrayAbrir.Click += ToolStripMenuItemSystemTrayAbrir_Click;
            toolStripMenuItemSystemTraySair.Click += ToolStripMenuItemSystemTraySair_Click;
            toolStripMenuItemSystemTraySobre.Click += new EventHandler(buttonSobre_Click!);

            buttonSair.Click += ToolStripMenuItemSystemTraySair_Click;

            ComponentResourceManager resources = new(typeof(Properties.Resources));
            foreach (ToolStripItem c in contextMenuStripInicio.Items)
            {
                resources.ApplyResources(c, c.Name);
            }
            foreach (ToolStripItem c in contextMenuStripSystemTray.Items)
            {
                resources.ApplyResources(c, c.Name);
            }
        }

        private void ToolStripMenuItemSystemTraySair_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItemSystemTrayAbrir_Click(object? sender, EventArgs e)
        {
            this.Show();
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Fechar fechar = new()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            if (fechar.ShowDialog() == DialogResult.No)
                e.Cancel = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login login = new()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            login.ShowDialog(); // Modal
        }

        private void buttonFuncionarios_Click(object sender, EventArgs e)
        {
            Opcao o = new();

            var res = o.ShowDialog();

            FormFuncionario funcionarios = new();
            {
                StartPosition = FormStartPosition.CenterScreen;
            };

            if (res == DialogResult.OK)
            {
                funcionarios.ShowDialog(); // Modal
                AtualizarTela(funcionarios.dao);
            }
            else if (res == DialogResult.Yes)
                AtualizarTela(funcionarios.dao);
        }
        private void buttonClientes_Click(object sender, EventArgs e)
        {
            Opcao o = new();

            var res = o.ShowDialog();

            FormCliente clientes = new FormCliente
            {
                StartPosition = FormStartPosition.CenterScreen
            };

            if (res == DialogResult.OK)
            {
                clientes.ShowDialog();
                AtualizarTela(clientes.dao);
            }
            else if (res == DialogResult.Yes)
                AtualizarTela(clientes.dao);

        }

        private void buttonComandas_Click(object sender, EventArgs e)
        {
            Comandas comanda = new();
            comanda.Show();
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
            Sobre sobre = new()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            sobre.ShowDialog();
        }

        private void Inicio_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIconSystemTray.Visible = true;
                notifyIconSystemTray.BalloonTipText = Properties.Resources.ResourceManager.GetString("BalloonTipText.Text");
                notifyIconSystemTray.BalloonTipTitle = Properties.Resources.ResourceManager.GetString("BalloonTipTitle.Text");
                notifyIconSystemTray.ShowBalloonTip(1000);

            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIconSystemTray.Visible = false;
            }
        }
        private void notifyIconSystemTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconSystemTray.Visible = false;
        }
        /// <summary>
        /// C�digo para povoar a tela principal com as informa��es escolhidas. <br></br>
        /// </summary>
        /// <param name="objetoDAO">Objeto em quest�o</param>
        private void AtualizarTela(object objetoDAO)
        {
            Funcionario funcionario = new Funcionario
            {
                Numero = 0
            };

            Cliente cliente = new Cliente
            {
                Numero = 0
            };

            var tipo = objetoDAO.GetType();

            switch (tipo.Name)
            {
                case "FuncionarioDAO":
                    dao = (FuncionarioDAO)objetoDAO;
                    break;
                case "ClienteDAO":
                    dao = (ClienteDAO)objetoDAO;
                    break;
                case "ProdutoDAO":
                    //dao = (ProdutoDao)objetoDAO;
                    break;
            }

            try
            {
                DataTable linhas = dao!.SelectDBProvider(cliente);

                dataGridViewDados.Columns.Clear();
                dataGridViewDados.AutoGenerateColumns = true;
                dataGridViewDados.DataSource = linhas;
                dataGridViewDados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}