using StoreManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreManagement.PopUp
{
    public partial class Customer : System.Web.UI.Page
    {
        Entities entities = new Entities();

        protected void Page_Load(object sender, EventArgs e)
        {
            var value = entities.Tbl_Customers.ToList();
            Repeater1.DataSource = value;
            Repeater1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Tbl_Customers tbl = new Tbl_Customers();
            tbl.CustomerName = TextBox1.Text;
            tbl.CustomerSurname = TextBox2.Text;
            tbl.CustomerStatus = true;
            entities.Tbl_Customers.Add(tbl);
            entities.SaveChanges();
            Response.Redirect("Customer.aspx");
        }
    }
}