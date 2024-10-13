<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Admin.Master" AutoEventWireup="true" CodeBehind="SaleList.aspx.cs" Inherits="StoreManagement.Sale.SaleList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-hover">
        <tr>
            <th scope="col">Id</th>
            <th scope="col">Product</th>
            <th scope="col">Customer</th>
            <th scope="col">Employee</th>
            <th scope="col">Preis</th>
            <th scope="col">Delete</th>
            <th scope="col">Update</th>
        </tr>
        <tbody>
            <tr>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <th><%#Eval("SaleId")%></th>
                            <td><%#Eval("ProductName")%></td>
                            <td><%#Eval("CustomerName")%>
                                <%#Eval("CustomerSurname") %>
                            </td>
                            <td><%#Eval("EmployeeNameAndSurname")%></td>
                            <td><%#Eval("SalePreis")%></td>
                            <td>
                                <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"SaleDelete.aspx?SaleId="+Eval("SaleId") %>' runat="server" CssClass="btn btn-danger">Delete</asp:HyperLink>
                            </td>
                            <td>
                                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#"SaleEdit.aspx?SaleId="+Eval("SaleId") %>' CssClass="btn btn-warning">Update</asp:HyperLink></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tr>
        </tbody>
    </table>
    <a href="SaleAdd.aspx" class="btn btn-info">Add Sale</a>

</asp:Content>
