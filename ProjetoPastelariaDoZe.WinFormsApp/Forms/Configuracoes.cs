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
            this.Text = Properties.Resources.ResourceManager.GetString("formConfiguracoes.Text");
            comboBoxIdiomas.SelectedItem = ConfigurationManager.AppSettings.Get("IdiomaRegiao");
        }

        private void ButtonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Esse é o método de manipulação
        private void buttonSalvarIdioma_Click(object sender, EventArgs e) // Sender = Objeto que gerou o evento (Clique no botão > botão que gerou) | e = Informações do evento
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("IdiomaRegiao");
            config.AppSettings.Settings.Add("IdiomaRegiao", comboBoxIdiomas.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            Close();

            _ = MessageBox.Show(Properties.Resources.ResourceManager.GetString("MessageBox.Text"));

            if(checkBoxReiniciar.Checked)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }
    }
}
