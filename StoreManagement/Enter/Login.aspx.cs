using StoreManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreManagement.Enter
{
    public partial class Login1 : System.Web.UI.Page
    {
        Entities entities = new Entities();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var value = from x in entities.Tbl_Admins where x.AdminUsername == TxtUsername.Text && x.AdminPassword == TxtPassword.Text select x;
                if (value.Any())
                {
                    Response.Redirect("../CategoryForms/CategoryList.aspx");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}