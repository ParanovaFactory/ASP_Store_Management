using StoreManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreManagement.Sale
{
    public partial class SaleDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["SaleId"]);
            Entities entities = new Entities();
            var value = entities.Tbl_Sales.Find(id);
            value.SaleStatus = false;
            entities.SaveChanges();
            Response.Redirect("SaleList.aspx");
        }
    }
}