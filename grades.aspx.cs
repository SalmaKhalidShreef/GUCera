using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class grades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }
        protected void viewG_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand viewGrade = new SqlCommand("viewAssignGrades", conn);
            int id = (int)Session["user"];
            String cidd = courseId.Text;
            int cid = (int)Convert.ToInt32(cidd);
            String assNo = no.Text;
            int number = (int)Convert.ToInt64(assNo);
            viewGrade.CommandType = CommandType.StoredProcedure;
            viewGrade.Parameters.Add(new SqlParameter("@sid", id));
            viewGrade.Parameters.Add(new SqlParameter("@cid", cid));
            viewGrade.Parameters.Add(new SqlParameter("@assignnumber", number));
            String Type = "";
            if (typeofAssign.SelectedIndex == 0)
            {
                Type = "quiz";
            }
            else if (typeofAssign.SelectedIndex == 1)
            {
                Type = "project";
            }
            else if (typeofAssign.SelectedIndex == 2)
            {
                Type = "Exam";
            }

            viewGrade.Parameters.Add(new SqlParameter("@assignType", Type));
            SqlParameter grade = viewGrade.Parameters.Add("@assignGrade", SqlDbType.Int);
            grade.Direction = ParameterDirection.Output;
            conn.Open();

            viewGrade.ExecuteNonQuery();

            //Label4.Text = conn.InfoMessage;
            conn.Close();
            Label4.Text = grade.Value.ToString();
        }

    }
}
 