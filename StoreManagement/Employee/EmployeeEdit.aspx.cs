using StoreManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreManagement.Employee
{
    public partial class EmployeeEdit : System.Web.UI.Page
    {
        int id;
        Entities entities = new Entities();

        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["EmployeeId"]);

            if (Page.IsPostBack == false)
            {
                try
                {
                    txtName.Text = entities.Tbl_Employees.Find(id).EmployeeNameAndSurname;
                }
                catch (Exception)
                {
                    txtName.Text = "Enter Name and Surname";
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var value = entities.Tbl_Employees.Find(id);
            value.EmployeeNameAndSurname = txtName.Text;
            entities.SaveChanges();
            Response.Redirect("EmployeeList.aspx");
        }
    }
}