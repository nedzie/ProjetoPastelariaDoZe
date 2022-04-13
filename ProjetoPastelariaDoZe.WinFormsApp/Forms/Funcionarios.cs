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
    /// Classe responsável pelo form Funcionários
    /// </summary>
    public partial class Funcionarios : Form
    {
        /// <summary>
        /// Construtor da classe Funcionários
        /// </summary>
        public Funcionarios()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesForm(this);
            this.Text = Properties.Resources.ResourceManager.GetString("formFuncionarios.Text");
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
