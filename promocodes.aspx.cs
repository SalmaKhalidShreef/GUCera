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
    public partial class promocodes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand promocodes = new SqlCommand("viewPromocode", conn);
            promocodes.CommandType = CommandType.StoredProcedure;
            int sid = (int)Session["user"];
            promocodes.Parameters.Add(new SqlParameter("@sid", sid));
            conn.Open();
            promocodes.ExecuteNonQuery();
            SqlDataReader sdr = promocodes.ExecuteReader();
            while (sdr.Read())
            {
                System.Web.UI.HtmlControls.HtmlGenericControl code = new HtmlGenericControl("h3");
                code.InnerText = "CODE : " + sdr["code"];
                form1.Controls.Add(code);
                System.Web.UI.HtmlControls.HtmlGenericControl idate = new HtmlGenericControl("h3");
                idate.InnerText = "isuueDate : " + sdr["isuueDate"];
                form1.Controls.Add(idate);
                System.Web.UI.HtmlControls.HtmlGenericControl edate = new HtmlGenericControl("h3");
                edate.InnerText = "expiryDate : " + sdr["expiryDate"];
                form1.Controls.Add(edate);
                System.Web.UI.HtmlControls.HtmlGenericControl discount = new HtmlGenericControl("h3");
                discount.InnerText = "discount : " + sdr["discount"];
                form1.Controls.Add(discount);
                System.Web.UI.HtmlControls.HtmlGenericControl admin = new HtmlGenericControl("h3");
                admin.InnerText = "admin ID: " + sdr["adminId"];
                form1.Controls.Add(admin);

            }
        }
    }
}