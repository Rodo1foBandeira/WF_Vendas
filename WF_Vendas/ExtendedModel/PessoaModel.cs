﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WF_Vendas
{
    public partial class PessoaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
    }
}