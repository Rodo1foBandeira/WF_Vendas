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
    
    public partial class Material
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Nullable<System.DateTime> DataEntrada { get; set; }
        public int Tipo_Id { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public Nullable<int> Fornecedor_Id { get; set; }
    }
}
