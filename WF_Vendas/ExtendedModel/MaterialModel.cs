using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WF_Vendas
{
    public partial class MaterialModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime? DataEntrada { get; set; }
        public TipoModel Tipo { get; set; }
        public decimal Valor { get; set; }
        public FornecedorModel Fornecedor { get; set; }
    }
}