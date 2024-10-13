<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Admin.Master" AutoEventWireup="true" CodeBehind="SaleAdd.aspx.cs" Inherits="StoreManagement.Sale.SaleAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="form1" runat="server">
        <div class="form-group">
            <label for="InputName">Product</label>
            <asp:DropDownList ID="DropDownProduct" runat="server" class="form-control"></asp:DropDownList>
        </div>
        <div class="form-group">
            <label for="InputBrand">Customer</label>
            <asp:DropDownList ID="DropDownCustomer" runat="server" class="form-control"></asp:DropDownList>
        </div>
        <div class="form-group">
            <label for="InputCategory">Employee</label>
            <asp:DropDownList ID="DropDownEmployee" runat="server" class="form-control"></asp:DropDownList>
        </div>
        <div class="form-group">
            <label for="InputPrice">Price</label>
            <asp:TextBox ID="txtPrice" runat="server" class="form-control" placeholder="Price"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" class="btn btn-success" Text="SUBMIT" OnClick="Button1_Click" />
    </form>

</asp:Content>
