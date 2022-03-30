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
            UserControlControleUsuarioGeral opcoes = new();
            opcoes.Dock = DockStyle.Bottom;

            Controls.Add(opcoes);

            Size size = new Size(Size.Width, Size.Height + opcoes.Size.Height);
        }

        private void ButtonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
