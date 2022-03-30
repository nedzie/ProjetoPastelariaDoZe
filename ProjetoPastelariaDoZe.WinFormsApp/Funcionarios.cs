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
            UserControlControleUsuarioGeral opcoes = new();
            opcoes.Dock = DockStyle.Bottom;

            Controls.Add(opcoes);
        }

        private void ButtonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
