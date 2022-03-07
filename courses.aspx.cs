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
    public partial class courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand courses = new SqlCommand("availableCourses",conn);
            courses.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader rdr = courses.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                string courseName = (string)rdr["name"];
                int courseID = (int)rdr["id"];
                Button btn = new Button();
                btn.Text = "view Course Details";
                btn.ID = courseName;
                btn.Click += (s, ev) => {
                    Session["courseID"] = courseID;
                    Session["courseName"] = courseName;
                    Response.Redirect("coursePage.aspx");
                };

                System.Web.UI.HtmlControls.HtmlGenericControl tag = new HtmlGenericControl("h3");
                tag.InnerText = courseName;
                form1.Controls.Add(tag);
                form1.Controls.Add(btn);
               
            }
        }
       
    }
}