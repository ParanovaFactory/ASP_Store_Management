using StoreManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreManagement.Employee
{
    public partial class EmployeeDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["EmployeeId"]);
            Entities entities = new Entities();
            var value = entities.Tbl_Employees.Find(id);
            value.EmployeeStatus = false;
            entities.SaveChanges();
            Response.Redirect("EmployeeList.aspx");
        }
    }
}