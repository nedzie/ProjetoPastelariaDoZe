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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesForm(this);
            this.Text = Properties.Resources.ResourceManager.GetString("formClientes.Text");
            //labelNome.Text = Properties.Resources.ResourceManager.GetString("labelNome.Text");
            //textBoxNome.PlaceholderText = Properties.Resources.ResourceManager.GetString("textBoxNome.PlaceholderText");
            //labelCPF.Text = Properties.Resources.ResourceManager.GetString("labelCPF.Text");
            //textBoxCPF.PlaceholderText = Properties.Resources.ResourceManager.GetString("textBoxCPF.PlaceholderText");
            //labelTelefone.Text = Properties.Resources.ResourceManager.GetString("labelTelefone.Text");
            //labelSenha.Text = Properties.Resources.ResourceManager.GetString("labelSenha.Text");
            //textBoxSenha.Text = Properties.Resources.ResourceManager.GetString("textBoxSenha.PlaceholderText");
            //buttonCadastrar.Text = Properties.Resources.ResourceManager.GetString("buttonCadastrar.Text");
            //labelMarcaFiado.Text = Properties.Resources.ResourceManager.GetString("labelMarcaFiado.Text");
            //radioButtonFiadoSim.Text = Properties.Resources.ResourceManager.GetString("radioButtonFiadoSim.Text");
            //radioButtonFiadoNao.Text = Properties.Resources.ResourceManager.GetString("radioButtonFiadoNao.Text");
            //labelDiaDoFiado.Text = Properties.Resources.ResourceManager.GetString("labelDiaDoFiado.Text");
            //ButtonFechar.Text = Properties.Resources.ResourceManager.GetString("buttonFechar.Text");
            UserControlControleUsuarioGeral opcoes = new();
            opcoes.Dock = DockStyle.Bottom;
            Size = new Size(Size.Width, Size.Height + opcoes.Size.Height);
            this.Controls.Add(opcoes);
        }

        private void ButtonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
