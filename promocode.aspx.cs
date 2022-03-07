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
    public partial class promocode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            DateTime issue = DateTime.Now;
            DateTime expiry = DateTime.Parse(expirydate.Text);
            String pcode = code.Text;
            Decimal disc = Decimal.Parse(discount.Text);
            int id = (int)Session["user"];
            SqlCommand createpromo = new SqlCommand("AdminCreatePromocode", conn);
            createpromo.CommandType = CommandType.StoredProcedure;
            createpromo.Parameters.Add(new SqlParameter("@code", pcode));
            createpromo.Parameters.Add(new SqlParameter("@isuueDate", issue));
            createpromo.Parameters.Add(new SqlParameter("@expiryDate", expiry));
            createpromo.Parameters.Add(new SqlParameter("@discount", disc));
            createpromo.Parameters.Add(new SqlParameter("@adminId", id));
            conn.Open();
            createpromo.ExecuteNonQuery();
            conn.Close();
            Response.Write("you added the promocode successfully");




        }
    }
}