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
    /// <summary>
    /// Classe auxiliar Produtos
    /// </summary>
    public partial class Produtos : Form
    {
        /// <summary>
        /// Construtor da classe Produtos
        /// </summary>
        public Produtos()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesForm(this);
            this.Text = Properties.Resources.ResourceManager.GetString("formProdutos.Text");
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