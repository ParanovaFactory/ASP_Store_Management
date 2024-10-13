using StoreManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreManagement.Customer
{
    public partial class CustomerDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["CurtomerId"]);
            Entities entities = new Entities();
            var value = entities.Tbl_Customers.Find(id);
            value.CustomerStatus = false;
            entities.SaveChanges();
            Response.Redirect("CUstomerList.aspx");
        }
    }
}