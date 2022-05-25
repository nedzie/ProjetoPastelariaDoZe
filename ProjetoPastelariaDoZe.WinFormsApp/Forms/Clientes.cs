using ProjetoPastelariaDoZe.WinFormsApp.Compartilhado;
using ProjetoPastelariaDoZe.DAO;
using ProjetoPastelariaDoZe.WinFormsApp.Validadores;
using FluentValidation.Results;
using System.Configuration;

namespace ProjetoPastelariaDoZe.WinFormsApp
{
    /// <summary>
    /// Classe auxiliar Clientes
    /// </summary>
    public partial class Cliente : Form
    {
        private readonly ClienteDAO dao;
        /// <summary>
        /// Construtor da classe Clientes
        /// </summary>
        public Cliente()
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

            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string connectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;

            dao = new(provider, connectionString);
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
            textBoxNome.Enabled = true;
            radioButtonFisica.Enabled = true;
            radioButtonJuridica.Enabled = true;
            maskedTextBoxCPF.Enabled = true;
            maskedTextBoxCNPJ.Enabled = true;
            maskedTextBoxTelefone.Enabled = true;
            textBoxSenha.Enabled = true;
        }

        private void radioButtonFiadoNao_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownDiaDoFiado.ResetText();
            textBoxSenha.ResetText();
            textBoxNome.Enabled = true;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            DAO.Cliente cliente = new();
            ValidadorClienteFiadoCPF validadorFiadoCPF = new(); 
            ValidadorClienteFiadoCNPJ validadorFiadoCNPJ = new();
            ValidadorClienteComum validadorVista = new();
            ConfigurarAtributos(cliente);


            ValidationResult vr;
            if (cliente.MarcaFiado == 1)
            {
                if (cliente.CPF != null)
                    vr = validadorFiadoCPF.Validate(cliente);
                else
                    vr = validadorFiadoCNPJ.Validate(cliente);
            }
            else
                vr = validadorVista.Validate(cliente);

            if (!vr.IsValid)
                MessageBox.Show(vr.ToString());
            else
            {
                try
                {
                    //dao.InserirDBProvider(cliente);
                    MessageBox.Show("Deu boa");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            }

        private void ConfigurarAtributos(DAO.Cliente cliente)
        {
            cliente.MarcaFiado = radioButtonFiadoSim.Checked ? 1 : 0;

            if (cliente.MarcaFiado == 1)
            {
                cliente.DiaDoFiado = Convert.ToInt32(numericUpDownDiaDoFiado.Value);

                cliente.Nome = textBoxNome.Text;

                if (radioButtonFisica.Checked)
                    cliente.CPF = maskedTextBoxCPF.Text;
                if (radioButtonJuridica.Checked)
                    cliente.CNPJ = maskedTextBoxCNPJ.Text;

                cliente.Telefone = maskedTextBoxTelefone.Text;

                cliente.Senha = textBoxSenha.Text;
            }
            else
                cliente.Nome = textBoxNome.Text;
        }
    }
}