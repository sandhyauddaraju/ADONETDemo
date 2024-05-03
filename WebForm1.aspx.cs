using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADONETDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = @"Data Source=DESKTOP-H1V54BF\SQLEXPRESS;Initial Catalog=Bulky;Integrated Security=True";
            SqlConnection con = new SqlConnection(CS);
            SqlCommand cmd = new SqlCommand("select * from AspNetUsers", con);
            con.Open();
           // SqlDataReader reader = cmd.ExecuteReader();
            GridView1.DataSource = cmd.ExecuteReader();
            GridView1.DataBind();
        }
    }
}