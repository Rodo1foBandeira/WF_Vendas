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
        private new List<Cliente> ListaClientes = new List<Cliente>() { new Cliente { Id = 1, Nome = "Mostrão", Cidade = "Ibitinga", Endereco = "Rua do Sapão", Telefone = "33", Cpf = 123 } };

        protected void Page_Load(object sender, EventArgs e)
        {
            preencherGrid();
        }

        private void preencherGrid()
        {
            ClienteGridView.DataSource = ListaClientes;
            ClienteGridView.DataBind();
        }

        protected void ClienteGridView_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            ClienteGridView.EditIndex = -1;
            preencherGrid();
        }

        protected void ClienteGridView_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            ClienteGridView.EditIndex = e.NewEditIndex;
            preencherGrid();
        }

        protected void ClienteGridView_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            //Obtem cada valor único do DataKeyNames
            int id = Convert.ToInt32(ClienteGridView.DataKeys[e.RowIndex].Value.ToString());
            //Obtem o valor do TextBox no EditItemTemplet da linha clicada
            string nome = ((TextBox)ClienteGridView.Rows[e.RowIndex].FindControl("txtnome")).Text;
            string telefone = ((TextBox)ClienteGridView.Rows[e.RowIndex].FindControl("txttelefone")).Text;
            string cidade = ((TextBox)ClienteGridView.Rows[e.RowIndex].FindControl("txtcidade")).Text;
            string endereco = ((TextBox)ClienteGridView.Rows[e.RowIndex].FindControl("txtendereco")).Text;
            int cpf = Convert.ToInt32(((TextBox)ClienteGridView.Rows[e.RowIndex].FindControl("txtcpf")).Text);

            //ListaClientes.Find(x => x.Id == id).SetNome(nome).SetTelefone(telefone).SetCidade(cidade).SetEndereco(endereco).SetCpf(cpf);
            var item = ListaClientes.Find(x => x.Id == id);
            item.Nome = nome;
            item.Telefone = telefone;
            item.Cidade = cidade;
            item.Endereco = endereco;
            item.Cpf = cpf;

            //nenhuma linha no modo de edição
            ClienteGridView.EditIndex = -1;
            //preenche o grid nomvanete
            preencherGrid();
        }

        protected void ClienteGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(ClienteGridView.DataKeys[e.RowIndex].Value.ToString());

            ListaClientes.RemoveAll(x => x.Id == id);

            preencherGrid();
        }

        protected void ClienteGridView_RowCreate(object sender, GridViewCommandEventArgs e)
        {
            
        }
    }
}