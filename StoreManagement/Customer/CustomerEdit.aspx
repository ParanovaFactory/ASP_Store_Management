<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Admin.Master" AutoEventWireup="true" CodeBehind="CustomerEdit.aspx.cs" Inherits="StoreManagement.Customer.CustomerEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="form1" runat="server">
    <div class="form-group">
        <label for="InputName">Name</label>
        <asp:TextBox ID="txtName" runat="server" class="form-control" placeholder="Name"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="InputSurname">Surname</label>
        <asp:TextBox ID="txtSurname" runat="server" class="form-control" placeholder="Surname"></asp:TextBox>
    </div>
        <asp:Button ID="Button1" runat="server" class="btn btn-success" Text="SUBMIT" OnClick="Button1_Click" />
</form>

</asp:Content>
