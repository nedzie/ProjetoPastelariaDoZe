using ProjetoPastelariaDoZe.WinFormsApp.Compartilhado;
using System.Configuration;

namespace ProjetoPastelariaDoZe.WinFormsApp
{
    public partial class Configuracoes : Form
    {
        /// <summary>
        /// Construtor da classe Configuracoes
        /// </summary>
        public Configuracoes()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesForm(this);
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            this.Text = Properties.Resources.ResourceManager.GetString("formConfiguracoes.Text");
            comboBoxIdiomas.SelectedItem = ConfigurationManager.AppSettings.Get("IdiomaRegiao");
            UserControlControleUsuarioGeral opcoes = new();
            Size = new(Size.Width, Size.Height + opcoes.Size.Height);
            opcoes.Dock = DockStyle.Bottom;
            this.Controls.Add(opcoes);
            opcoes.buttonSair.Click += ButtonSair_Click;
            opcoes.buttonSalvar.Click += ButtonSalvar_Click;
            MaximizeBox = false;
        }
        private void ButtonSalvar_Click(object? sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("IdiomaRegiao");
            config.AppSettings.Settings.Add("IdiomaRegiao", comboBoxIdiomas.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            Close();
            _ = MessageBox.Show(Properties.Resources.ResourceManager.GetString("MessageBox.Text"));

            if (checkBoxReiniciar.Checked)
            {
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                Environment.Exit(0);
            }
        }
        private void ButtonSair_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}