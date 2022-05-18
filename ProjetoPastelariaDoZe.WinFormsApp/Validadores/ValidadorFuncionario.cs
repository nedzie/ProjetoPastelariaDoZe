using FluentValidation;
using ProjetoPastelariaDoZe.WinFormsApp.Entidades;

namespace ProjetoPastelariaDoZe.WinFormsApp.Validadores
{
    /// <summary>
    /// Classe validadora de informações do tipo funcionário
    /// </summary>
    public class ValidadorFuncionario : AbstractValidator<Funcionario>
    {
        /// <summary>
        /// Construtor do validador de funcionário
        /// </summary>
        public ValidadorFuncionario()
        {
            RuleFor(x => x.Nome)
                .NotNull()
                .NotEmpty()
                .MaximumLength(120);
            string CPF = "^[0-9]{3}.[0-9]{3}.[0-9]{3}-[0-9]{2}$";
            RuleFor(x => x.CPF)
                .NotNull()
                .NotEmpty()
                .Matches(CPF)
                .MaximumLength(14);

            RuleFor(x => x.Matricula)
                .NotNull()
                .NotEmpty()
                .MaximumLength(10);

            RuleFor(x => x.Telefone)
                .NotNull()
                .NotEmpty()
                .MaximumLength(15);

            RuleFor(x => x.Senha)
                .NotNull()
                .NotEmpty()
                .MaximumLength(200);

            RuleFor(x => x.Grupo)
                .NotNull()
                .NotEmpty();
        }
    }
}
