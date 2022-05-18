namespace ProjetoPastelariaDoZe.WinFormsApp.Entidades
{
    /// <summary>
    /// 
    /// </summary>
    public class Funcionario
    {
        /// <summary>
        /// Nome do funcionário
        /// </summary>
        public string? Nome { get; set; }

        /// <summary>
        /// CPF do funcionário
        /// </summary>
        public string? CPF { get; set; }

        /// <summary>
        /// Matrícula do funcionário
        /// </summary>
        public string? Matricula { get; set; }

        /// <summary>
        /// Telefone do funcionário
        /// </summary>
        public string? Telefone{ get; set; }

        /// <summary>
        /// Senha do funcionário
        /// </summary>
        public string? Senha { get; set; }

        /// <summary>
        /// Grupo do funcionário
        /// </summary>
        public int Grupo { get; set; }
    }
}
