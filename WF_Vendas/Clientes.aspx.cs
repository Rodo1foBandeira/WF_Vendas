using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WF_Vendas
{
    public partial class Clientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            preencherGrid();
        }

        private void preencherGrid()
        {
            var clientes = new List<Cliente>() { new Cliente { Id = 1, Nome = "Mostrão", Cidade = "Ibitinga", Endereco = "Rua do Sapão", Telefone = "33", Cpf = 123 } };
            ClienteGridView.DataSource = clientes;
            ClienteGridView.DataBind();
        }
    }
}