using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class coursePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = (string) Session["courseName"];
            int cid = (int)Session["courseID"];
            int sid = (int)Session["user"];
            string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand infoProc = new SqlCommand("courseInformation", conn);
            infoProc.CommandType = CommandType.StoredProcedure;
            
            infoProc.Parameters.Add(new SqlParameter("@id", cid));
            conn.Open();
            infoProc.ExecuteNonQuery();
            SqlDataReader rdr = infoProc.ExecuteReader(CommandBehavior.CloseConnection);

            while (rdr.Read())
            {

                System.Web.UI.HtmlControls.HtmlGenericControl tag = new HtmlGenericControl("h1");
                tag.InnerText = name;
                form1.Controls.Add(tag);
                System.Web.UI.HtmlControls.HtmlGenericControl courseid = new HtmlGenericControl("h3");
                courseid.InnerText = "Course ID:" + rdr["id"].ToString();
                form1.Controls.Add(courseid);
                System.Web.UI.HtmlControls.HtmlGenericControl credit = new HtmlGenericControl("h3");
                credit.InnerText = "Credit Hours:" + rdr["creditHours"].ToString();
                form1.Controls.Add(credit);
                System.Web.UI.HtmlControls.HtmlGenericControl description = new HtmlGenericControl("h3");
                description.InnerText = "Course Description:" + rdr["courseDescription"];
                form1.Controls.Add(description);
                System.Web.UI.HtmlControls.HtmlGenericControl price = new HtmlGenericControl("h3");
                price.InnerText = "Price:" + rdr["courseDescription"];
                form1.Controls.Add(price);
                System.Web.UI.HtmlControls.HtmlGenericControl content= new HtmlGenericControl("h3");
                content.InnerText = "course content:" + rdr["content"];
                form1.Controls.Add(content);
                Session["instrID"]= (int)rdr["instructorId"];
             
                
                Button btn = new Button();
                btn.Text = "Enroll";
                btn.Click +=  new EventHandler(click);
                form1.Controls.Add(btn);

           

            }         

        }
        protected void click(object sender, EventArgs e) {

            int cid = (int)Session["courseID"];
            int sid = (int)Session["user"];

            string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand enroll = new SqlCommand("enrollInCourse", conn);
             enroll.CommandType = CommandType.StoredProcedure;
             enroll.Parameters.Add(new SqlParameter("@sid", sid));
             enroll.Parameters.Add(new SqlParameter("@cid", cid));
             enroll.Parameters.Add(new SqlParameter("@instr",Session["instrID"]));
             conn.Open();
             enroll.ExecuteNonQuery();
             conn.Close();
             Response.Write("enrollment successful");

        

        }



    }
}