<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/Admin.Master" AutoEventWireup="true" CodeBehind="ProductAdd.aspx.cs" Inherits="StoreManagement.Product.ProductAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="form1" runat="server">
        <div class="form-group">
            <label for="InputName">Name</label>
            <asp:TextBox ID="txtName" runat="server" class="form-control" placeholder="Name"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="InputBrand">Brand</label>
            <asp:TextBox ID="txtBrand" runat="server" class="form-control" placeholder="Brand"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="InputCategory">Category</label>
            <asp:DropDownList ID="DropDownList1" runat="server" class="form-control"></asp:DropDownList>
        </div>
        <div class="form-group">
            <label for="InputPrice">Price</label>
            <asp:TextBox ID="txtPrice" runat="server" class="form-control" placeholder="Price"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="InputStock">Stock</label>
            <asp:TextBox ID="txtStock" runat="server" class="form-control" placeholder="Stock"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" class="btn btn-success" Text="SUBMIT" OnClick="Button1_Click" />
    </form>

</asp:Content>
