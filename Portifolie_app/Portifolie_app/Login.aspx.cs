using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Web.Configuration;


namespace Portifolie_app
{
    public partial class Login : System.Web.UI.Page
    {
        private portifoliedbEntities db = new portifoliedbEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            //List<tbluser> listUsers = db.tbluser.ToList();
            
            txtUserName.Text = db.tbluser.Find(1).userName;
        }

        protected void btnForgot_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Better remember it then!";
        }

        protected void btnNewUser_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Better make a new one then!";
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "You get in!";
        }
    }
}