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
    public partial class FormProdutos : Form
    {
        /// <summary>
        /// Construtor da classe Produtos
        /// </summary>
        public FormProdutos()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesForm(this);
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            this.Text = Properties.Resources.ResourceManager.GetString("formProdutos.Text");
            UserControlControleUsuarioGeral opcoes = new();
            Size = new(Size.Width, Size.Height + opcoes.Size.Height);
            opcoes.Dock = DockStyle.Bottom;
            this.Controls.Add(opcoes);
            opcoes.buttonSair.Click += ButtonSair_Click;
            MaximizeBox = false;
        }

        private void ButtonSair_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxValorUnitario_Click(object sender, EventArgs e)
        {
            Funcoes.AplicaMascaraMoeda(textBoxValorUnitario);
        }
    }
}