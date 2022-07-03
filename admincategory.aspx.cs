using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class admincategory : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds;
    void mycon()
    {
        con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        con.Open();
    }


    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        mycon();
        cmd = new SqlCommand("select * from categorylist where category=@tb", con);
        cmd.Parameters.AddWithValue("@tb",TextBox1.Text);
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds);
        int a = ds.Tables[0].Rows.Count;
        con.Close();
        if (a > 0)
        {
            Response.Write("<script>alert('data already exits by this categorty')</script>");
        }
        else
        {
            mycon();
            cmd = new SqlCommand("insert into categorylist values(@ct,@st)", con);
            cmd.Parameters.AddWithValue("@ct", TextBox1.Text);
            cmd.Parameters.AddWithValue("@st", DropDownList1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('data saved successfully')</script>");
        }
       
    }

    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        Response.Redirect("adminshowcategory.aspx");

    }
}