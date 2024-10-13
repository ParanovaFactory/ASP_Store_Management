using StoreManagement.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreManagement.CategoryForms
{
    public partial class CategoryEdit : System.Web.UI.Page
    {
        int id;
        Entities entities = new Entities();

        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["CategoryId"]);

            if (Page.IsPostBack == false)
            {
                try
                {
                    txtCategory.Text = entities.Tbl_Categories.Find(id).CategoryName;
                }
                catch (Exception)
                {
                    txtCategory.Text = "Enter Name";
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var value = entities.Tbl_Categories.Find(id);
            value.CategoryName = txtCategory.Text;
            entities.SaveChanges();
            Response.Redirect("CategoryList.aspx");
        }
    }
}