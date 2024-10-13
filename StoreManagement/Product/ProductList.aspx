<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Admin.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="StoreManagement.Product.ProductList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-hover">
        <tr>
            <th scope="col">Id</th>
            <th scope="col">Name</th>
            <th scope="col">Brand</th>
            <th scope="col">Category</th>
            <th scope="col">Price</th>
            <th scope="col">Stock</th>
            <th scope="col">Delete</th>
            <th scope="col">Update</th>
        </tr>
        <tbody>
            <tr>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <th><%#Eval("ProductId")%></th>
                            <td><%#Eval("ProductName")%></td>
                            <td><%#Eval("ProductBrand")%></td>
                            <td><%#Eval("CategoryName")%></td>
                            <td><%#Eval("ProductPreis")%></td>
                            <td><%#Eval("ProductStock")%></td>
                            <td>
                                <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"ProductDelete.aspx?ProductId="+Eval("ProductId") %>' runat="server" CssClass="btn btn-danger">Delete</asp:HyperLink>
                            </td>
                            <td>
                                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#"ProductEdit.aspx?ProductId="+Eval("ProductId") %>' CssClass="btn btn-warning">Update</asp:HyperLink></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tr>
        </tbody>
    </table>
    <a href="ProductAdd.aspx" class="btn btn-info">Add Product</a>

</asp:Content>
