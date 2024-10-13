<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Admin.Master" AutoEventWireup="true" CodeBehind="CustomerList.aspx.cs" Inherits="StoreManagement.Customer.CustomerList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-hover">
        <tr>
            <th scope="col">Id</th>
            <th scope="col">Name</th>
            <th scope="col">Surname</th>
            <th scope="col">Delete</th>
            <th scope="col">Update</th>
        </tr>
        <tbody>
            <tr>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <th><%#Eval("CurtomerId")%></th>
                            <td><%#Eval("CustomerName")%></td>
                            <td><%#Eval("CustomerSurname")%></td>
                            <td>
                                <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"CustomerDelete.aspx?CurtomerId="+Eval("CurtomerId") %>' runat="server" CssClass="btn btn-danger">Delete</asp:HyperLink>
                            </td>
                            <td>
                                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#"CustomerEdit.aspx?CurtomerId="+Eval("CurtomerId") %>' CssClass="btn btn-warning">Update</asp:HyperLink></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tr>
        </tbody>
    </table>
    <a href="CustomerAdd.aspx" class="btn btn-info">Add Customer</a>

</asp:Content>
