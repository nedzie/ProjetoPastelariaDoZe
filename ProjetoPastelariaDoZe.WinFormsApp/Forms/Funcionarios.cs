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
    public partial class Funcionarios : Form
    {
        public Funcionarios()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesForm(this);
            this.Text = Properties.Resources.ResourceManager.GetString("formFuncionarios.Text");
            //labelNome.Text = Properties.Resources.ResourceManager.GetString("labelNome.Text");
            //textBoxNome.PlaceholderText = Properties.Resources.ResourceManager.GetString("textBoxNome.PlaceholderText");
            //labelCPF.Text = Properties.Resources.ResourceManager.GetString("labelCPF.Text");
            //textBoxCPF.PlaceholderText = Properties.Resources.ResourceManager.GetString("textBoxCPF.PlaceholderText");
            //labelMatricula.Text = Properties.Resources.ResourceManager.GetString("labelMatricula.Text");
            //textBoxMatricula.PlaceholderText = Properties.Resources.ResourceManager.GetString("textBoxMatricula.PlaceholderText");
            //labelTelefone.Text = Properties.Resources.ResourceManager.GetString("labelTelefone.Text");
            //textBoxTelefone.PlaceholderText = Properties.Resources.ResourceManager.GetString("textBoxTelefone.PlaceholderText");
            //labelSenha.Text = Properties.Resources.ResourceManager.GetString("labelSenha.Text");
            //textBoxSenha.PlaceholderText = Properties.Resources.ResourceManager.GetString("textBoxSenha.PlaceholderText");
            //labelGrupo.Text = Properties.Resources.ResourceManager.GetString("labelGrupo.Text");
            //radioButtonAdmin.Text = Properties.Resources.ResourceManager.GetString("radioButtonAdmin.Text");
            //radioButtonBalcao.Text = Properties.Resources.ResourceManager.GetString("radioButtonBalcao.Text");
            //buttonCadastrar.Text = Properties.Resources.ResourceManager.GetString("buttonCadastrar.Text");
            //buttonFechar.Text = Properties.Resources.ResourceManager.GetString("buttonFechar.Text");
            UserControlControleUsuarioGeral opcoes = new();
            opcoes.Dock = DockStyle.Bottom;
            Size = new(Size.Width, Size.Height + opcoes.Size.Height);
            this.Controls.Add(opcoes);
        }

        private void ButtonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
