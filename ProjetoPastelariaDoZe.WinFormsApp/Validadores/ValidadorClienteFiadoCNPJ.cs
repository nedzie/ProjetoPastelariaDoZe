using FluentValidation;
using ProjetoPastelariaDoZe.DAO;

namespace ProjetoPastelariaDoZe.WinFormsApp.Validadores
{
    /// <summary>
    /// Validador de cliente para quando não compra fiado e usa CNPJ
    /// </summary>
    public class ValidadorClienteFiadoCNPJ : AbstractValidator<DAO.Cliente>
    {
        private const string padraoCNPJ = "^[0-9]{2}.[0-9]{3}.[0-9]{3}.[0-9]{4}.[0-9]{2}";
        /// <summary>
        /// Construtor da classe ValidadorFuncionario para quando o cliente não compra fiado e usa CNPJ
        /// </summary>
        public ValidadorClienteFiadoCNPJ()
        {
            RuleFor(x => x.Nome)
                .NotNull()
                .NotEmpty()
                .MaximumLength(120);

            RuleFor(x => x.CNPJ)
                .NotNull()
                .NotEmpty()
                .Matches(padraoCNPJ)
                .MinimumLength(14)
                .MaximumLength(18);

            RuleFor(x => x.Telefone)
                .NotNull()
                .NotEmpty()
                .MinimumLength(14)
                .MaximumLength(15);

            RuleFor(x => x.Senha)
                .NotNull()
                .NotEmpty()
                .MaximumLength(200);
        }
    }
}
