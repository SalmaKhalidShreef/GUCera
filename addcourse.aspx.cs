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
    public partial class addcourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void OnInfoMessage(object sender, SqlInfoMessageEventArgs args)
        {
            foreach (SqlError err in args.Errors)
            {
                String s = err.Message;
                String ss = "You added the course successfully and the course ID is: ";

                Label.Text= ss+s;
                
            }
        }
        protected void add_Course(object sender, EventArgs e)
        {
            try
            {
                Label.Text = "";
                string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                int credithrs = Int16.Parse(credithours.Text);
                string name = cname.Text;
                decimal courseprice = decimal.Parse(price.Text);
                int instid = (int)Session["user"];
                SqlCommand InstAddCourseproc = new SqlCommand("InstAddCourse", conn);
                InstAddCourseproc.CommandType = CommandType.StoredProcedure;
                InstAddCourseproc.Parameters.Add(new SqlParameter("@creditHours", credithrs));
                InstAddCourseproc.Parameters.Add(new SqlParameter("@name", name));
                InstAddCourseproc.Parameters.Add(new SqlParameter("@price", courseprice));
                InstAddCourseproc.Parameters.Add(new SqlParameter("@instructorId", instid));
                conn.Open();
                conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);
                InstAddCourseproc.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                Label.Text = ex.Message;
                return;
            }
             


        }

        protected void upd_desc(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                Label.Text = "";
                int instid = (int)Session["user"];
                int crID = Int16.Parse(crssid.Text);
                string des = crsdes.Text;

                SqlCommand UpdateCourseDescriptionproc = new SqlCommand("UpdateCourseDescription", conn);
                UpdateCourseDescriptionproc.CommandType = CommandType.StoredProcedure;
                UpdateCourseDescriptionproc.Parameters.Add(new SqlParameter("@instrId", instid));
                UpdateCourseDescriptionproc.Parameters.Add(new SqlParameter("@courseId", crID));
                UpdateCourseDescriptionproc.Parameters.Add(new SqlParameter("@courseDescription", des));
                conn.Open();
                conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);
                UpdateCourseDescriptionproc.ExecuteNonQuery();
                conn.Close();
                 
            }
            catch (Exception ex)
            {
                Label.Text = ex.Message;
                return;
            }
        }

        protected void upd_con(object sender, EventArgs e)
        {
            try
            {   
                string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                Label.Text = "";
                int instid = (int)Session["user"];
                int corID = Int16.Parse(crssid.Text);
                string con = crsdes.Text;

                SqlCommand UpdateCourseContentproc = new SqlCommand("UpdateCourseContent", conn);
                UpdateCourseContentproc.CommandType = CommandType.StoredProcedure;
                UpdateCourseContentproc.Parameters.Add(new SqlParameter("@instrId", instid));
                UpdateCourseContentproc.Parameters.Add(new SqlParameter("@courseId", corID));
                UpdateCourseContentproc.Parameters.Add(new SqlParameter("@content", con));
                conn.Open();
                conn.InfoMessage += new SqlInfoMessageEventHandler(OnInfoMessage);
                UpdateCourseContentproc.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {   
                Label.Text = ex.Message;
                return;
            }
        }
    }
}