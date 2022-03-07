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
    public partial class studentpromo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            int student = Int32.Parse(sid.Text);
            String promo =  pid.Text;
            SqlCommand issuepromo = new SqlCommand("AdminIssuePromocodeToStudent", conn);
            issuepromo.CommandType = CommandType.StoredProcedure;
            issuepromo.Parameters.Add(new SqlParameter("@sid", student));
            issuepromo.Parameters.Add(new SqlParameter("@pid", promo));
            conn.Open();
            issuepromo.ExecuteNonQuery();
            conn.Close();



        }
    }
}