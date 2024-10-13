using StoreManagement.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreManagement.Sale
{
    public partial class SaleAdd : System.Web.UI.Page
    {
        Entities entities = new Entities();

        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownProduct.DataSource = entities.Tbl_Products.ToList();
            DropDownProduct.DataTextField = "ProductName";
            DropDownProduct.DataValueField = "ProductId";
            DropDownProduct.DataBind();

            DropDownCustomer.DataSource = entities.Tbl_Customers.ToList();
            DropDownCustomer.DataTextField = "CustomerName";
            DropDownCustomer.DataValueField = "CurtomerId";
            DropDownCustomer.DataBind();

            DropDownEmployee.DataSource = entities.Tbl_Employees.ToList();
            DropDownEmployee.DataTextField = "EmployeeNameAndSurname";
            DropDownEmployee.DataValueField = "EmployeeId";
            DropDownEmployee.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Tbl_Sales tbl=new Tbl_Sales();
            tbl.SaleProduct = int.Parse(DropDownProduct.SelectedValue);
            tbl.SaleCustomer = int.Parse(DropDownCustomer.SelectedValue);
            tbl.SaleEmployee = byte.Parse(DropDownEmployee.SelectedValue);
            tbl.SalePreis = decimal.Parse(txtPrice.Text);
            tbl.SaleStatus = true;
            entities.Tbl_Sales.Add(tbl);
            entities.SaveChanges();
            Response.Redirect("SaleList.aspx");
        }
    }
}