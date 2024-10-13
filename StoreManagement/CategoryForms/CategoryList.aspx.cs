using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StoreManagement.Entity;

namespace StoreManagement.CategoryForms
{
    public partial class CategoryList : System.Web.UI.Page
    {
        Entities entities = new Entities();

        protected void Page_Load(object sender, EventArgs e)
        {
            var values = entities.Tbl_Categories.Where(x =>x.CategoryStatus == true).ToList();
            Repeater1.DataSource = values;
            Repeater1.DataBind();
        }
    }
}