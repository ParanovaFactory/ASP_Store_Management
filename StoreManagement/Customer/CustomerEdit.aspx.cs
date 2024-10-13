using StoreManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreManagement.Customer
{
    public partial class CustomerEdit : System.Web.UI.Page
    {
        int id;
        Entities entities = new Entities();

        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["CurtomerId"]);

            if (Page.IsPostBack == false)
            {
                try
                {
                    txtName.Text = entities.Tbl_Customers.Find(id).CustomerName;
                    txtSurname.Text = entities.Tbl_Customers.Find(id).CustomerSurname;
                }
                catch (Exception)
                {
                    txtName.Text = "Enter Name";
                    txtSurname.Text = "Enter Surname";
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var value = entities.Tbl_Customers.Find(id);
            value.CustomerName = txtName.Text;
            value.CustomerSurname = txtSurname.Text;
            entities.SaveChanges();
            Response.Redirect("CustomerList.aspx");
        }
    }
}