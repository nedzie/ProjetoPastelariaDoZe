using FluentValidation.Results;
using ProjetoPastelariaDoZe.WinFormsApp.Compartilhado;
using ProjetoPastelariaDoZe.WinFormsApp.Entidades;
using ProjetoPastelariaDoZe.WinFormsApp.Validadores;

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
            Funcoes.EventoFocoCampos(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown!);
            this.Text = Properties.Resources.ResourceManager.GetString("formFuncionarios.Text");
            UserControlControleUsuarioGeral opcoes = new();
            opcoes.Dock = DockStyle.Bottom;
            Size = new(Size.Width, Size.Height + opcoes.Size.Height);
            this.Controls.Add(opcoes);
            opcoes.buttonSair.Click += ButtonSair_Click;
            MaximizeBox = false;
        }

        private void ButtonSair_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new();

            funcionario.Nome = textBoxNome.Text;
            funcionario.Matricula = textBoxMatricula.Text;
            funcionario.CPF = maskedTextBoxCPF.Text;
            funcionario.Telefone = maskedTextBoxTelefone.Text;
            funcionario.Senha = textBoxSenha.Text;
            if (radioButtonAdmin.Checked)
                funcionario.Grupo = 1;
            if (radioButtonBalcao.Checked)
                funcionario.Grupo = 2;

            ValidadorFuncionario vf = new();

            ValidationResult vr = vf.Validate(funcionario);

            if (!vr.IsValid)
            {
                MessageBox.Show(vr.ToString());
            }
            else
            {
                MessageBox.Show("Deu boa!");
                this.Close();
            }
        }
    }
}