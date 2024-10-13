using StoreManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreManagement.Customer
{
    public partial class CustomerAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Entities entities = new Entities();
            Tbl_Customers tbl = new Tbl_Customers();
            tbl.CustomerName = txtName.Text;
            tbl.CustomerSurname = txtSurname.Text;
            tbl.CustomerStatus = true;
            entities.Tbl_Customers.Add(tbl);
            entities.SaveChanges();
            Response.Redirect("CustomerList.aspx");
        }
    }
}