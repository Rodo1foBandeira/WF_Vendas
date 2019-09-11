using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WF_Vendas
{
    public partial class ClienteModel : PessoaModel
    {
        public int Cpf { get; set; }

        // Todo: calculo digitos de validação
    }
}