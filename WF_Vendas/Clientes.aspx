<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" Title="Clientes" CodeBehind="Clientes.aspx.cs" Inherits="WF_Vendas.Clientes" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>Manutenção de clientes</h2>
            </hgroup>            
        </div>
    </section>
</asp:Content>

<asp:Content ID="clientes" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:GridView ID="ClienteGridView" runat="server" AutoGenerateColumns="False"
        DataKeyNames="id">
       
        <Columns>
            <asp:TemplateField HeaderText="Cod.">
                <ItemTemplate>    <%#Container.DataItemIndex+1 %>    </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Nome">
                <ItemTemplate>    <%#Eval("nome") %>    </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtnome" runat="server" Text='<%#Eval("nome") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Telefone">
                <ItemTemplate>    <%#Eval("telefone") %>    </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txttelefone" runat="server" Text='<%#Eval("telefone") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>    
            
            <asp:TemplateField HeaderText="Cidade">
                <ItemTemplate>    <%#Eval("cidade") %>    </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtcidade" runat="server" Text='<%#Eval("cidade") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Endereco">
                <ItemTemplate>    <%#Eval("endereco") %>    </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtendereco" runat="server" Text='<%#Eval("endereco") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Cpf">
                <ItemTemplate>    <%#Eval("cpf") %>    </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="txtcpf" runat="server" Text='<%#Eval("cpf") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>

            <asp:ButtonField ButtonType="Button" CommandName="Edit" Text="Editar" />
            <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Excluir" />

        </Columns>
    </asp:GridView>
</asp:Content>