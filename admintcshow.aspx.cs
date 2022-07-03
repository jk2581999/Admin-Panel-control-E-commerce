using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class admintcshow : System.Web.UI.Page
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
    void fillgrid()
    {
        mycon();
        cmd = new SqlCommand("select * from thirdcat", con);
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();

        con.Close();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        fillgrid();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("admintc.aspx");
    }
}