//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WF_Vendas
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public Nullable<int> Cpf { get; set; }

        public Cliente SetNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public Cliente SetTelefone(string telefone)
        {
            Telefone = telefone;
            return this;
        }

        public Cliente SetCidade(string cidade)
        {
            Cidade = cidade;
            return this;
        }

        public Cliente SetEndereco(string endereco)
        {
            Endereco = endereco;
            return this;
        }

        public Cliente SetCpf(int? cpf)
        {
            Cpf = cpf;
            return this;
        }
    }
}
