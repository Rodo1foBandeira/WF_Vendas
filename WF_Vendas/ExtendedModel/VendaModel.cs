using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WF_Vendas
{
    public partial class VendaModel
    {
        public int Id { get; set; }
        public FornecedorModel Fornecedor { get; set; }
        public ClienteModel Cliente { get; set; }
        public MaterialModel Material { get; set; }
        public DateTime? DataVenda { get; set; }
    }
}