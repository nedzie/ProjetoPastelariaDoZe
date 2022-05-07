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

        private void Inicio_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIconSystemTray.Visible = true;
                notifyIconSystemTray.BalloonTipText = Properties.Resources.ResourceManager.GetString("BalloonTipText.Text");
                notifyIconSystemTray.BalloonTipTitle = Properties.Resources.ResourceManager.GetString("BalloonTipTitle.Text");
                notifyIconSystemTray.ShowBalloonTip(1000);
                
            }
            else if(FormWindowState.Normal == this.WindowState)
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
    }
}