using StoreManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreManagement.Sale
{
    public partial class SaleList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Entities entities = new Entities();
            var values = entities.Tbl_Sales.Select(x => new
            {
                x.SaleId,
                x.Tbl_Products.ProductName,
                x.Tbl_Customers.CustomerName,
                x.Tbl_Customers.CustomerSurname,
                x.Tbl_Employees.EmployeeNameAndSurname,
                x.SalePreis,
                x.SaleStatus
            }).Where(y => y.SaleStatus == true).ToList();

            Repeater1.DataSource = values;
            Repeater1.DataBind();
        }
    }
}