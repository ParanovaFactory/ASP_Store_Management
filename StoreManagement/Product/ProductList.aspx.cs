using StoreManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreManagement.Product
{
    public partial class ProductList : System.Web.UI.Page
    {

        Entities entities = new Entities();

        protected void Page_Load(object sender, EventArgs e)
        {
            var values = entities.Tbl_Products.Select(x => new
            {
                x.ProductId,
                x.ProductName,
                x.ProductBrand,
                x.Tbl_Categories.CategoryName,
                x.ProductPreis,
                x.ProductStock,
                x.ProductStatus
            }).Where(y => y.ProductStatus == true).ToList();

            Repeater1.DataSource = values;
            Repeater1.DataBind();
        }
    }
}