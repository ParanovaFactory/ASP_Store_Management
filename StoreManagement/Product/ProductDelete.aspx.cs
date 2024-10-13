using StoreManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreManagement.Product
{
    public partial class ProductDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["ProductId"]);
            Entities entities = new Entities();
            var value = entities.Tbl_Products.Find(id);
            value.ProductStatus = false;
            entities.SaveChanges();
            Response.Redirect("ProductList.aspx");
        }
    }
}