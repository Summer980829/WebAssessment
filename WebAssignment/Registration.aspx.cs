using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace prototype1
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            //if (IsPostBack)
            //{
            //  //  SqlConnection conn = new SqlConnection();
            //} 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Your registeration is successful");
        }
    }
}