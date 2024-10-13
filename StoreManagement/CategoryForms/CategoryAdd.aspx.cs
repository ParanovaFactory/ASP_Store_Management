using StoreManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreManagement.CategoryForms
{
    public partial class CategoryAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Entities entities = new Entities();
            Tbl_Categories tbl = new Tbl_Categories();
            tbl.CategoryName = txtCategory.Text;
            tbl.CategoryStatus = true;
            entities.Tbl_Categories.Add(tbl);
            entities.SaveChanges();
            Response.Redirect("CategoryList.aspx");
        }
    }
}