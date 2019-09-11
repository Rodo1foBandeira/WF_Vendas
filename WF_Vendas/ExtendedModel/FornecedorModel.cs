using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WF_Vendas
{
    public partial class FornecedorModel : PessoaModel
    {
        public int Cnpj { get; set; }

        // Todo: calculo digitos de validação
    }
}