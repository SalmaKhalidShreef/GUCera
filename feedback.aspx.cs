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
    public partial class feedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand courses = new SqlCommand("StudentTakeCourse", conn);
            courses.CommandType = CommandType.StoredProcedure;
            int id = (int)Session["user"];
            conn.Open();
            SqlCommand com = new SqlCommand("select c.name , st.cid From Course c inner join StudentTakeCourse st on st.sid = @id and c.id = st.cid", conn);
            com.Parameters.Add(new SqlParameter("@id", id));

            // table name   
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);  // fill dataset  
            DropDownList1.DataTextField = ds.Tables[0].Columns["name"].ToString(); // text field name of table dispalyed in dropdown       
            DropDownList1.DataValueField = ds.Tables[0].Columns["cid"].ToString();
            // to retrive specific  textfield name   
            DropDownList1.DataSource = ds.Tables[0];      //assigning datasource to the dropdownlist  
            DropDownList1.DataBind();  //binding dropdownlist 
            String cmmnt = comment.Text;
            SqlCommand addfeed = new SqlCommand("addFeedback", conn);
            addfeed.CommandType = CommandType.StoredProcedure;
            addfeed.Parameters.Add(new SqlParameter("@sid", id));
            addfeed.Parameters.Add(new SqlParameter("@cid ", DropDownList1.SelectedValue));
            addfeed.Parameters.Add(new SqlParameter("@comment ", cmmnt));
            addfeed.ExecuteNonQuery();

            conn.Close();
        }

        protected void add_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["MyDbConn"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand courses = new SqlCommand("StudentTakeCourse", conn);
            courses.CommandType = CommandType.StoredProcedure;
            int id = (int)Session["user"];
            conn.Open();
            String cmmnt = comment.Text;
            SqlCommand addfeed = new SqlCommand("addFeedback", conn);
            addfeed.CommandType = CommandType.StoredProcedure;
            addfeed.Parameters.Add(new SqlParameter("@sid", id));
            addfeed.Parameters.Add(new SqlParameter("@cid ", DropDownList1.SelectedValue));
            addfeed.Parameters.Add(new SqlParameter("@comment ", cmmnt));
            addfeed.ExecuteNonQuery();

            conn.Close();


        }
    }
    }

    
