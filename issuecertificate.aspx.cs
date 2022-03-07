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
    public partial class issuecertificate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void issue_c(object sender,EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            int cid = Int16.Parse(couID.Text);
            int sid = Int16.Parse(stuID.Text);
            int instid = (int)Session["user"];
            DateTime issued = DateTime.Parse(issdate.Text);
            SqlCommand InstructorIssueCertificateToStudentproc = new SqlCommand("InstructorIssueCertificateToStudent", conn);
            InstructorIssueCertificateToStudentproc.CommandType = CommandType.StoredProcedure;
            InstructorIssueCertificateToStudentproc.Parameters.Add(new SqlParameter("@cid", cid));
            InstructorIssueCertificateToStudentproc.Parameters.Add(new SqlParameter("@sid", sid));
            InstructorIssueCertificateToStudentproc.Parameters.Add(new SqlParameter("@insId", instid));
            InstructorIssueCertificateToStudentproc.Parameters.Add(new SqlParameter("@issueDate", issued));
            conn.Open();
            InstructorIssueCertificateToStudentproc.ExecuteNonQuery();
            conn.Close();
            Response.Write("you issued the certificate successfully");
        }
    }
}