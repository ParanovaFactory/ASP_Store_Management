<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Admin.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="StoreManagement.PopUp.Customer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#Modal1">
     Add New Customer
 </button>
 <div class="modal" id="Modal1">
     <div class="modal-dialog">
         <div class="modal-content">
             <div class="modal-header">
                 <h2 class="modal-title">Add New Customer</h2>
             </div>
             <form runat="server">
                 <div class="modal-body">
                     <label>
                       Name
                     </label>
                     <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                     <br />
                     <label>
                         Surname
                     </label>
                     <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
                     <br />
                     <asp:Button ID="Button1" runat="server" Text="Save" CssClass="btn btn-primary" OnClick="Button1_Click" />
                     <asp:Button ID="Button2" runat="server" Text="Cancel" CssClass="btn btn-danger" data-dismiss="modal" />
                 </div>
             </form>
         </div>
     </div>
 </div>
 
 <table class="table table-bordered" style="margin-top:20px">
     <tr>
         <th>ID</th>
         <th>Name</th>
         <th>Surname</th>
     </tr>
     <asp:Repeater ID="Repeater1" runat="server">
         <ItemTemplate>
             <tr>
                 <td><%# Eval("CurtomerId") %></td>
                 <td><%# Eval("CustomerName") %></td>
                 <td><%# Eval("CustomerSurname") %></td>
             </tr>
         </ItemTemplate>
     </asp:Repeater>
 </table>

</asp:Content>
