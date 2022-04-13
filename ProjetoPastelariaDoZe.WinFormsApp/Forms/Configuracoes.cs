using ProjetoPastelariaDoZe.WinFormsApp.Compartilhado;
using System.Configuration;

namespace ProjetoPastelariaDoZe.WinFormsApp
{
    public partial class Configuracoes : Form
    {
        public Configuracoes()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesForm(this);
            this.Text = Properties.Resources.ResourceManager.GetString("formConfiguracoes.Text");
            //labelTaxaJurosDiaria.Text = Properties.Resources.ResourceManager.GetString("labelTaxaJurosDiaria.Text");
            //textBoxTaxaJurosDiaria.PlaceholderText = Properties.Resources.ResourceManager.GetString("textBoxTaxaJurosDiaria.PlaceholderText");
            //labelMultaPorAtraso.Text = Properties.Resources.ResourceManager.GetString("labelMultaPorAtraso.Text");
            //textBoxMultaPorAtraso.PlaceholderText = Properties.Resources.ResourceManager.GetString("textBoxMultaPorAtraso.PlaceholderText");
            //buttonSalvar.Text = Properties.Resources.ResourceManager.GetString("buttonSalvar.Text");
            //buttonFechar.Text = Properties.Resources.ResourceManager.GetString("buttonFechar.Text");
            comboBoxIdiomas.SelectedItem = ConfigurationManager.AppSettings.Get("IdiomaRegiao");
        }

        private void ButtonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvarIdioma_Click(object sender, EventArgs e)
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
