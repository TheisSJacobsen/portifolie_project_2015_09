using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
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
            
            //string connection = WebConfigurationManager.ConnectionStrings["portifoliedbEntities"].ConnectionString;
            //MySqlConnection conn = new MySqlConnection(connection);
            //MySqlCommand com = new 
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

        //public class portifoliedbEntities : DbContext
        //{
        //    public DbSet<string> UserName { get; set; }
        //}

    }
}