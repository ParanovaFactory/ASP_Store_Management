using StoreManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreManagement.Sale
{
    public partial class SaleEdit : System.Web.UI.Page
    {
        int id;
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

            id = Convert.ToInt32(Request.QueryString["SaleId"]);

            if (Page.IsPostBack == false)
            {
                try
                {
                    var value = entities.Tbl_Sales.Find(id);
                    DropDownProduct.SelectedIndex = Convert.ToInt32(value.SaleProduct) - 1;
                    DropDownCustomer.SelectedIndex = Convert.ToInt32(value.SaleCustomer) - 1;
                    DropDownEmployee.SelectedIndex = Convert.ToInt32(value.SaleEmployee) - 1;
                    txtPrice.Text = value.SalePreis.ToString();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var tbl = entities.Tbl_Sales.Find(id);
            tbl.SaleProduct = Convert.ToInt32(DropDownProduct.SelectedValue);
            tbl.SaleCustomer = Convert.ToInt32(DropDownCustomer.SelectedValue);
            tbl.SaleEmployee = byte.Parse(DropDownEmployee.SelectedValue);
            tbl.SalePreis = decimal.Parse(txtPrice.Text);
            entities.SaveChanges();
            Response.Redirect("SaleList.aspx");
        }
    }
}