<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Admin.Master" AutoEventWireup="true" CodeBehind="EmployeeList.aspx.cs" Inherits="StoreManagement.Employee.EmployeeList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <table class="table table-hover">
     <tr>
         <th scope="col">Id</th>
         <th scope="col">Employee</th>
         <th scope="col">Delete</th>
         <th scope="col">Update</th>
     </tr>
     <tbody>
         <tr>
             <asp:Repeater ID="Repeater1" runat="server">
                 <ItemTemplate>
                     <tr>
                         <th><%#Eval("EmployeeId")%></th>
                         <td><%#Eval("EmployeeNameAndSurname")%></td>
                         <td>
                             <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"EmployeeDelete.aspx?EmployeeId="+Eval("EmployeeId") %>' runat="server" CssClass="btn btn-danger">Delete</asp:HyperLink>
                         </td>
                         <td>
                             <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#"EmployeeEdit.aspx?EmployeeId="+Eval("EmployeeId") %>' CssClass="btn btn-warning">Update</asp:HyperLink></td>
                     </tr>
                 </ItemTemplate>
             </asp:Repeater>
         </tr>
     </tbody>
 </table>
 <a href="EmployeeAdd.aspx" class="btn btn-info">Add Employee</a>

</asp:Content>
