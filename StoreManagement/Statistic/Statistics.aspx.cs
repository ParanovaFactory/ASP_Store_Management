using StoreManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreManagement.Statistic
{
    public partial class Statistics : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Entities db = new Entities();
            Label1.Text = db.Tbl_Products.Count().ToString();
            Label2.Text = db.Tbl_Customers.Count().ToString();
            Label3.Text = db.Tbl_Sales.Sum(x => x.SalePreis).ToString();
            Label4.Text = db.Tbl_Categories.Count().ToString();
            Label5.Text = db.Tbl_Products.Count(x => x.ProductStatus == true).ToString();
            Label6.Text = db.Tbl_Products.Count(x => x.ProductStatus == false).ToString();
            Label7.Text = (from x in db.Tbl_Products orderby x.ProductStock descending select x.ProductName).FirstOrDefault();
        }
    }
}