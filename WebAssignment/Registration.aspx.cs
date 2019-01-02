using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;
using System.Data.Entity;
using System.Data;
using System.Data.Entity.Core.EntityClient;

namespace prototype1
{
    public partial class Registration : System.Web.UI.Page
    {
        public static String efConnectionString = "metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=\"Data Source=(LocalDB)\\MSSQLLocalDB;attachdbfilename=|DataDirectory|\\taruc.mdf;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework\"";
        public static EntityConnectionStringBuilder builder = new EntityConnectionStringBuilder(efConnectionString);
        public String regularConnectionString = builder.ProviderConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            //if (IsPostBack)
            //{
            //  //  SqlConnection conn = new SqlConnection();
            //} 
            StudentRegister.Visible = false;
            LecturerRegister.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Your registeration is successful");
        }

        protected void ddlAccType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlAccType.SelectedValue.Equals("Lecturer"))
            {
                LecturerRegister.Visible = true;
                StudentRegister.Visible = false;

                //if (Roles.RoleExists("Lecturer"))
                //{
                //    Roles.AddUserToRole(CreateUserWizard1.UserName, "Lecturer");
                //}
                //else
                //{
                //    Roles.CreateRole("Lecturer");
                //    Roles.AddUserToRole(CreateUserWizard1.UserName, "Lecturer");
                //}

            }
            else if (ddlAccType.SelectedValue.Equals("Student"))
            {
                StudentRegister.Visible = true;
                LecturerRegister.Visible = false;

                //if (Roles.RoleExists("Student"))
                //{
                //    Roles.AddUserToRole(CreateUserWizard1.UserName, "Student");
                //}
                //else
                //{
                //    Roles.CreateRole("Student");
                //    Roles.AddUserToRole(CreateUserWizard1.UserName, "Student");
                //}
            }
            else
            {
                StudentRegister.Visible = false;
                LecturerRegister.Visible = false;
            }
        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {
            if (Roles.RoleExists("Lecturer"))
            {
                Roles.AddUserToRole(CreateUserWizard1.UserName, "Lecturer");
            }
            else
            {
                Roles.CreateRole("Lecturer");
                Roles.AddUserToRole(CreateUserWizard1.UserName, "Lecturer");
            }

        }

        protected void CreateUserWizard2_CreatedUser1(object sender, EventArgs e)
        {
            if (Roles.RoleExists("Student"))
            {
                Roles.AddUserToRole(CreateUserWizard2.UserName, "Student");
            }
            else
            {
                Roles.CreateRole("Student");
                Roles.AddUserToRole(CreateUserWizard2.UserName, "Student");
            }
        }
    }
}