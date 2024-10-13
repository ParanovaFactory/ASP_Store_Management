using StoreManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreManagement.Product
{
    public partial class ProductAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Entities entities = new Entities();

            var values = entities.Tbl_Categories.ToList();
            DropDownList1.DataTextField = "CategoryName";
            DropDownList1.DataValueField = "CategoryId";
            DropDownList1.DataSource = values;
            DropDownList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Entities entities = new Entities();
            Tbl_Products tbl = new Tbl_Products();
            tbl.ProductName = txtName.Text;
            tbl.ProductBrand = txtBrand.Text;
            tbl.ProductCategory = byte.Parse(DropDownList1.SelectedValue);
            tbl.ProductPreis = Convert.ToDecimal(txtPrice.Text);
            tbl.ProductStock = short.Parse(txtStock.Text);
            tbl.ProductStatus = true;
            entities.Tbl_Products.Add(tbl);
            entities.SaveChanges();
            Response.Redirect("ProductList.aspx");
        }
    }
}