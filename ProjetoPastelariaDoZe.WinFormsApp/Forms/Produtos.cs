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
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesForm(this);
            this.Text = Properties.Resources.ResourceManager.GetString("formProdutos.Text");
            //labelNome.Text = Properties.Resources.ResourceManager.GetString("labelNome.Text");
            //textBoxNome.PlaceholderText = Properties.Resources.ResourceManager.GetString("textBoxNome.PlaceholderText");
            //labelDescricao.Text = Properties.Resources.ResourceManager.GetString("labelDescricao.Text");
            //textBoxDescricao.PlaceholderText = Properties.Resources.ResourceManager.GetString("textBoxDescricaoProduto.PlaceholderText");
            //labelValorUnitario.Text = Properties.Resources.ResourceManager.GetString("labelValorUnitario.Text");
            //textBoxValorUnitario.PlaceholderText = Properties.Resources.ResourceManager.GetString("textBoxValorUnitario.PlaceholderText");
            //labelFoto.Text = Properties.Resources.ResourceManager.GetString("labelFoto.Text");
            //ButtonImportar.Text = Properties.Resources.ResourceManager.GetString("buttonImportar.Text");
            //ButtonCadastrar.Text = Properties.Resources.ResourceManager.GetString("buttonCadastrar.Text");
            //ButtonFechar.Text = Properties.Resources.ResourceManager.GetString("buttonFechar.Text");
            UserControlControleUsuarioGeral opcoes = new();
            Size = new(Size.Width, Size.Height + opcoes.Size.Height);
            opcoes.Dock = DockStyle.Bottom;
            this.Controls.Add(opcoes);
        }

        private void ButtonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}