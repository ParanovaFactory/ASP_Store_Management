using StoreManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreManagement.CategoryForms
{
    public partial class CategoryDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id;
            id = Convert.ToInt32(Request.QueryString["CategoryId"]);
            Entities entities = new Entities();
            var value = entities.Tbl_Categories.Find(id);
            value.CategoryStatus = false;
            entities.SaveChanges();
            Response.Redirect("CategoryList.aspx");
        }
    }
}