using StoreManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreManagement.Customer
{
    public partial class CustomerList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Entities entities = new Entities();
            var values = entities.Tbl_Customers.Where(x => x.CustomerStatus == true).ToList();
            Repeater1.DataSource = values;
            Repeater1.DataBind();
        }
    }
}