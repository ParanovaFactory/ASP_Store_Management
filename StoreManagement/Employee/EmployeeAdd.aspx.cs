using StoreManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreManagement.Employee
{
    public partial class EmployeeAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Entities entities = new Entities();
            Tbl_Employees tbl = new Tbl_Employees();
            tbl.EmployeeNameAndSurname = txtName.Text;
            tbl.EmployeeStatus = true;
            entities.Tbl_Employees.Add(tbl);
            entities.SaveChanges();
            Response.Redirect("EmployeeList.aspx");
        }
    }
}