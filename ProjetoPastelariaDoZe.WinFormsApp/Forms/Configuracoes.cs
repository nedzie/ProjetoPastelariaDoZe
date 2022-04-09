using ProjetoPastelariaDoZe.WinFormsApp.Compartilhado;

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
        }

        private void ButtonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
