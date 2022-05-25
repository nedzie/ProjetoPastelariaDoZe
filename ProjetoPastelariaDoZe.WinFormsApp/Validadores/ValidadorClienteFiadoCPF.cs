using FluentValidation;
using ProjetoPastelariaDoZe.DAO;

namespace ProjetoPastelariaDoZe.WinFormsApp.Validadores
{
    /// <summary>
    /// Validador da classe Cliente para quando o cliente compra fiado e usa CPF
    /// </summary>
    public class ValidadorClienteFiadoCPF : AbstractValidator<DAO.Cliente>
    {
        private const string padraoCPF = "^[0-9]{3}.[0-9]{3}.[0-9]{3}-[0-9]{2}$";
        /// <summary>
        /// Construtor da classe Cliente para quando o cliente compra fiado e usa CPF
        /// </summary>
        public ValidadorClienteFiadoCPF()
        {
            RuleFor(x => x.Nome)
                .NotNull()
                .NotEmpty()
                .MaximumLength(120);

            RuleFor(x => x.CPF)
                .NotNull()
                .NotEmpty()
                .Matches(padraoCPF)
                .MinimumLength(14)
                .MaximumLength(14);

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
