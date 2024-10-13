using StoreManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreManagement.Product
{
    public partial class ProductEdit : System.Web.UI.Page
    {
        int id;
        Entities entities = new Entities();

        protected void Page_Load(object sender, EventArgs e)
        {
            var values = entities.Tbl_Categories.ToList();
            DropDownList1.DataSource = values;
            DropDownList1.DataTextField = "CategoryName";
            DropDownList1.DataValueField = "CategoryId"; 
            DropDownList1.DataBind();

            id = Convert.ToInt32(Request.QueryString["ProductId"]);
            if (Page.IsPostBack == false)
            {
                try
                {
                    var value = entities.Tbl_Products.Find(id);
                    txtName.Text = value.ProductName;
                    txtBrand.Text = value.ProductBrand;
                    txtPrice.Text = value.ProductPreis.ToString();
                    txtStock.Text = value.ProductStock.ToString();
                    DropDownList1.SelectedIndex = Convert.ToInt32(value.ProductCategory) - 1;
                }
                catch (Exception)
                {
                    txtName.Text = "Product Name";
                    txtBrand.Text = "Product Brand";
                    txtPrice.Text = "Product Preis";
                    txtStock.Text = "Product Stock";
                    DropDownList1.Text = "Product Category";
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var value = entities.Tbl_Products.Find(id);
            value.ProductName = txtName.Text;
            value.ProductBrand = txtBrand.Text;
            value.ProductCategory = Convert.ToByte(DropDownList1.SelectedValue);
            value.ProductPreis = Convert.ToDecimal(txtPrice.Text);
            value.ProductStock = short.Parse(txtStock.Text);
            entities.SaveChanges();
            Response.Redirect("ProductList.aspx");
        }
    }
}