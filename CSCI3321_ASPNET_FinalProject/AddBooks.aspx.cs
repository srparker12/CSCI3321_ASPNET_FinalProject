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
    public partial class AddBooks : System.Web.UI.Page
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

            //INSERT INTO Publishers VALUES (PublisherName_fromUser, Address_fromUser, City_fromUser, PostalCode_fromUser, Country_fromUser, Phone_fromUser)
            cmd.CommandText = "INSERT INTO Books VALUES ('" + txtBookTitle.Text + "', " + ddlAuthorName.SelectedValue + ", '" + txtBookPrice.Text + "' , '" + txtPublishDate.Text + "' , " + ddlPublisherName.SelectedValue + " , " + ddlGenre.SelectedValue + ", '" + txtWordCount.Text + "')";

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Response.Redirect("BookAdded.aspx");
        }

    }
}