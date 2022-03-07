using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace GUCera
{
    public partial class notyet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand shownotyet = new SqlCommand("AdminViewNonAcceptedCourses", conn);
            shownotyet.CommandType = CommandType.StoredProcedure;
            conn.Open();
             
            SqlDataReader rdr = shownotyet.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                HtmlGenericControl div = new HtmlGenericControl("div");
                Label name = new Label();
                String courseName = rdr.GetString(rdr.GetOrdinal("name"));
                String creditHours = (rdr.GetInt32(rdr.GetOrdinal("creditHours"))).ToString();
                String price = (rdr.GetDecimal(rdr.GetOrdinal("price"))).ToString();

                name.Text += "  name:" + courseName + " credit hours:" + creditHours + " price:" + price;
                if (!rdr.IsDBNull(rdr.GetOrdinal("content")))
                {
                    String content = rdr.GetString(rdr.GetOrdinal("content"));
                    name.Text += "  content:" + content;

                }
                div.Controls.Add(name);
                form1.Controls.Add(div);
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            int cid = Int16.Parse(courseid.Text);
            int aid = (int)Session["user"];
            SqlCommand acceptcourse = new SqlCommand("AdminAcceptRejectCourse", conn);
            acceptcourse.CommandType = CommandType.StoredProcedure;
            acceptcourse.Parameters.Add(new SqlParameter("@adminid", aid));
            acceptcourse.Parameters.Add(new SqlParameter("@courseId", cid));
            conn.Open();
            acceptcourse.ExecuteNonQuery();
            conn.Close();
            Response.Write("you accepted the course successfully");

        }
    }
}