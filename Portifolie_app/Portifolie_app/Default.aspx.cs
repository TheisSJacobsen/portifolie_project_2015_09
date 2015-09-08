using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


namespace Portifolie_app
{
    public partial class Default : System.Web.UI.Page
    {
        private portifoliedbEntities db = new portifoliedbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
    }
}