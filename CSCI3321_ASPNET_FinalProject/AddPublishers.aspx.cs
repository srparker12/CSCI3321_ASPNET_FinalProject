using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace CSCI3321_ASPNET_FinalProject
{
    public partial class AddPublishers : System.Web.UI.Page
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
            cmd.CommandText = "INSERT INTO Publishers VALUES ('" + txtPublisherName.Text + "', '" + txtAddress.Text + "'" +
                ", '" + txtCity.Text + "' , '" + txtPostalCode.Text + "' , '" + txtCountry.Text + "' , '" + txtPhone.Text + "')";

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Response.Redirect("PublisherList.aspx");
        }
    }
}