using ProjetoPastelariaDoZe.WinFormsApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPastelariaDoZe.WinFormsApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesForm(this);
            this.Text = Properties.Resources.ResourceManager.GetString("formLogin.Text");
            //labelLogin.Text = Properties.Resources.ResourceManager.GetString("labelLogin.Text");
            //labelNome.Text = Properties.Resources.ResourceManager.GetString("labelNome.Text");
            //textBoxNome.PlaceholderText = Properties.Resources.ResourceManager.GetString("textBoxNome.PlaceholderText");
            //labelSenha.Text = Properties.Resources.ResourceManager.GetString("labelSenha.Text");
            //textBoxSenha.PlaceholderText = Properties.Resources.ResourceManager.GetString("textBoxSenha.PlaceholderText");
            //buttonEntrar.Text = Properties.Resources.ResourceManager.GetString("buttonEntrar.Text");
            //labelNovoUsuario.Text = Properties.Resources.ResourceManager.GetString("labelNovoUsuario.Text");
            //ButtonCadastrar.Text = Properties.Resources.ResourceManager.GetString("buttonCadastrar.Text");
            //buttonFechar.Text = Properties.Resources.ResourceManager.GetString("buttonFechar.Text");
        }

        private void ButtonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
