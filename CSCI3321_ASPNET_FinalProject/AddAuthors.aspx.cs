using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSCI3321_ASPNET_FinalProject
{
    public partial class AddAuthors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            //INSERT INTO Publishers VALUES (AuthorLastName_fromUser, AuthorFirstName_fromUser, Gender_fromUser, Birthdate_fromUser)
            cmd.CommandText = "INSERT INTO Authors VALUES ('" + txtAuthorLastName.Text + "', '" + txtAuthorFirstName.Text + "'" +
                ", '" + txtGender.Text + "' , '" + txtBirthdate.Text + "')";

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Response.Redirect("AuthorList.aspx");
        }
    }
}