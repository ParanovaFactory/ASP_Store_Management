<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Admin.Master" AutoEventWireup="true" CodeBehind="CategoryList.aspx.cs" Inherits="StoreManagement.CategoryForms.CategoryList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-hover">
        <tr>
            <th scope="col">Id</th>
            <th scope="col">Name</th>
            <th scope="col">Delete</th>
            <th scope="col">Update</th>
        </tr>
        <tbody>
            <tr>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <th><%#Eval("CategoryId")%></th>
                            <td><%#Eval("CategoryName")%></td>
                            <td>
                                <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"CategoryDelete.aspx?CategoryId="+Eval("CategoryId") %>' runat="server" CssClass="btn btn-danger">Delete</asp:HyperLink>
                            </td>
                            <td>
                                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#"CategoryEdit.aspx?CategoryId="+Eval("CategoryId") %>' CssClass="btn btn-warning">Update</asp:HyperLink></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tr>
        </tbody>
    </table>
    <a href="CategoryAdd.aspx" class="btn btn-info">Add Category</a>

</asp:Content>
