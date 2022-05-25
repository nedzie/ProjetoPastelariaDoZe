﻿using System;
using System.Collections.Generic;
using System.Data.Common;
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
        /// CNPJ do cliente
        /// </summary>
        public string? CNPJ { get; set; }

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

        public Cliente()
        {

        }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public Cliente(string nome, string cpf, string cnpj, string tel, string senha, int mf, int ddf)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.CNPJ = cnpj;
            this.Telefone = tel;
            this.Senha = senha;
            this.MarcaFiado = mf;
            this.DiaDoFiado = ddf;
        }
    }

    public class ClienteDAO
    {
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }

        public ClienteDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            this.factory = DbProviderFactories.GetFactory(Provider);
        }

        public void InserirDBProvider(Cliente cliente)
        {
            using var conexao = factory.CreateConnection(); // Conexão com o BD
            conexao!.ConnectionString = StringConexao; // Informa a ConnectionString, o caminho para o BD
            using var comando = factory.CreateCommand(); // Cria o comando para o BD
            comando!.Connection = conexao; // Atribui a conexão

            ConfigurarParametrosCliente(cliente, comando);

            conexao.Open();

            comando.CommandText =
                @"INSERT INTO
                        TB_CLIENTE
                            (
                            NOME,
                            CPF,
                            TELEFONE,
                            SENHA,
                            MARCAFIADO,
                            DIADOFIADO
                            )
                        VALUES
                            (
                            @NOME,
                            @CPF,
                            @TELEFONE,
                            @SENHA,
                            @MARCAFIADO,
                            @DIADOFIADO
                            )";

            var linhas = comando.ExecuteNonQuery();
        }

        private void ConfigurarParametrosCliente(Cliente cliente, DbCommand comando)
        {
            var nome = comando.CreateParameter();
            nome.ParameterName = "@NOME";
            nome.Value = cliente.Nome;
            comando.Parameters.Add(nome);

            var cpf = comando.CreateParameter();
            cpf.ParameterName = "@CPF";
            cpf.Value = string.IsNullOrEmpty(cliente.CPF) ? DBNull.Value : cliente.CPF;
            comando.Parameters.Add(cpf);

            var cnpj = comando.CreateParameter();
            cnpj.ParameterName = "@CNPJ";
            cpf.Value = string.IsNullOrEmpty(cliente.CNPJ) ? DBNull.Value : cliente.CNPJ;

            var telefone = comando.CreateParameter();
            telefone.ParameterName = "@TELEFONE";
            telefone.Value = string.IsNullOrEmpty(cliente.Telefone) ? DBNull.Value : cliente.Telefone;
            comando.Parameters.Add(telefone);

            var senha = comando.CreateParameter();
            senha.ParameterName = "@SENHA";
            senha.Value = string.IsNullOrEmpty(cliente.Senha) ? DBNull.Value : cliente.Senha;
            comando.Parameters.Add(senha);

            var marcaFiado = comando.CreateParameter();
            marcaFiado.ParameterName = "MARCAFIADO";
            marcaFiado.Value = cliente.MarcaFiado;
            comando.Parameters.Add(marcaFiado);

            var diaDoFiado = comando.CreateParameter();
            diaDoFiado.ParameterName = "@DIADOFIADO";
            diaDoFiado.Value = cliente.DiaDoFiado == 0 ? DBNull.Value : cliente.DiaDoFiado;
            comando.Parameters.Add(diaDoFiado);
        }
    }
}
