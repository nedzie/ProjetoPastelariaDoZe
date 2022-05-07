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
    /// Classe auxiliar Clientes
    /// </summary>
    public partial class Clientes : Form
    {
        /// <summary>
        /// Construtor da classe Clientes
        /// </summary>
        public Clientes()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesForm(this);
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            this.Text = Properties.Resources.ResourceManager.GetString("formClientes.Text");
            UserControlControleUsuarioGeral opcoes = new();
            opcoes.Dock = DockStyle.Bottom;
            Size = new Size(Size.Width, Size.Height + opcoes.Size.Height);
            this.Controls.Add(opcoes);
            opcoes.buttonSair.Click += ButtonSair_Click;
            MaximizeBox = false;
            maskedTextBoxCNPJ.Enabled = false;
            maskedTextBoxCPF.Enabled = false;
            numericUpDownDiaDoFiado.Enabled = false;
        }

        private void ButtonSair_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButtonFisica_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxCPF.Enabled = true;
            maskedTextBoxCNPJ.Enabled = false;
            maskedTextBoxCNPJ.Clear();
            maskedTextBoxCPF.Focus();
        }

        private void radioButtonJuridica_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBoxCNPJ.Enabled = true;
            maskedTextBoxCPF.Enabled = false;
            maskedTextBoxCPF.Clear();
            maskedTextBoxCNPJ.Focus();
        }

        private void radioButtonFiadoSim_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownDiaDoFiado.Enabled = true;
            numericUpDownDiaDoFiado.Focus();
        }

        private void radioButtonFiadoNao_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownDiaDoFiado.Enabled = false;
            numericUpDownDiaDoFiado.ResetText();
        }
    }
}