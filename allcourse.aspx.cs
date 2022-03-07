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
    public partial class allcourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand showcourse = new SqlCommand("AdminViewAllCourses", conn);
            showcourse.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader rdr = showcourse.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                HtmlGenericControl div = new HtmlGenericControl("div");
                Label name = new Label();
                String courseName = rdr.GetString(rdr.GetOrdinal("name"));
                String creditHours = (rdr.GetInt32(rdr.GetOrdinal("creditHours"))).ToString();
                String price = (rdr.GetDecimal(rdr.GetOrdinal("price"))).ToString();
               


                if ( !rdr.IsDBNull(rdr.GetOrdinal("accepted")) )
                {
                    if ((rdr.GetBoolean(rdr.GetOrdinal("accepted"))).ToString() == "0")
                    {
                        String accepted = "not accepted";
                        name.Text += " (the course is " + accepted+")";
                    }
                    else
                    {
                        String accepted = "  accepted";
                        name.Text += " (the course is " + accepted+")";

                    }

                }
                else
                {
                    String accepted = "not accepted";
                    name.Text += " (the course is " + accepted + ")";
                }
                

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
    }
}