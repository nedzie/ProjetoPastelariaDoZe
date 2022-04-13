using ProjetoPastelariaDoZe.WinFormsApp.Compartilhado;

namespace ProjetoPastelariaDoZe.WinFormsApp
{
    public partial class Login : Form
    {
        /// <summary>
        /// Construtor da classe Login
        /// </summary>
        public Login()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesForm(this);
            this.Text = Properties.Resources.ResourceManager.GetString("formLogin.Text");
        }

        private void ButtonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxNome_Enter(object sender, EventArgs e)
        {
            textBoxNome.BackColor = Color.Pink;
        }

        private void textBoxNome_Leave(object sender, EventArgs e)
        {
            textBoxNome.BackColor = Color.White;
        }

        private void textBoxSenha_Enter(object sender, EventArgs e)
        {
            textBoxSenha.BackColor = Color.Blue;
        }

        private void textBoxSenha_Leave(object sender, EventArgs e)
        {
            textBoxSenha.BackColor = Color.White;
        }
    }
}
