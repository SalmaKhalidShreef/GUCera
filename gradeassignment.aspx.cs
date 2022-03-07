using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class gradeassignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void grade_ass(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            int instid = (int)Session["user"];
            int sid = Int16.Parse(studentID.Text);
            int cid = Int16.Parse(courseID.Text);
            int assnum = Int16.Parse(assignn.Text);
            String assignt = asstype.Text;
            decimal assg = decimal.Parse(assgrade.Text);
            

            SqlCommand InstructorgradeAssignmentOfAStudentproc = new SqlCommand("InstructorgradeAssignmentOfAStudent", conn);
            InstructorgradeAssignmentOfAStudentproc.CommandType = CommandType.StoredProcedure;
            InstructorgradeAssignmentOfAStudentproc.Parameters.Add(new SqlParameter("@instrId", instid));
            InstructorgradeAssignmentOfAStudentproc.Parameters.Add(new SqlParameter("@sid", sid));
            InstructorgradeAssignmentOfAStudentproc.Parameters.Add(new SqlParameter("@cid", cid));
            InstructorgradeAssignmentOfAStudentproc.Parameters.Add(new SqlParameter("@assignmentNumber", assnum));
            InstructorgradeAssignmentOfAStudentproc.Parameters.Add(new SqlParameter("@type", assignt));
            InstructorgradeAssignmentOfAStudentproc.Parameters.Add(new SqlParameter("@grade", assg));
            conn.Open();
            InstructorgradeAssignmentOfAStudentproc.ExecuteNonQuery();
            conn.Close();
            Response.Write("you graded the assignment successfully");
        }
    }
}