using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPastelariaDoZe.DAO
{
    public class Cliente
    {
        /// <summary>
        /// O número (id) de cada cliente
        /// </summary>
        public int Numero { get; set; }
        /// <summary>
        /// Nome do cliente
        /// </summary>
        public string? Nome { get; set; }

        /// <summary>
        /// CPF do cliente
        /// </summary>
        public string? CPF { get; set; }

        /// <summary>
        /// Telefone do cliente
        /// </summary>
        public string? Telefone { get; set; }

        /// <summary>
        /// Senha do funcionário
        /// </summary>
        public string? Senha { get; set; }

        /// <summary>
        /// Campo que indica se o cliente marca fiado ------ 0 = não | 1 = sim
        /// </summary>
        public int? MarcaFiado { get; set; }

        /// <summary>
        /// Campo que indica o dia do fiado, caso o campo MarcaFiado tenha valor de '1' ------ 1~31 = dia fixo, 0 = dias corridos
        /// </summary>
        public int? DiaDoFiado { get; set; }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public Cliente(string nome, string cpf, string tel, string senha, int mf, int ddf)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Telefone = tel;
            this.Senha = senha;
            this.MarcaFiado = mf;
            this.DiaDoFiado = ddf;
        }
    }

    public class ClienteDAO
    {

    }
}
