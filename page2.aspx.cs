using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class page2 : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds;
    void mycon()
    {
        con=new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        con.Open();
    }
    void fillgrid()
    {
        mycon();
        cmd = new SqlCommand("select * from subcatlist", con);
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();

        con.Close();
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList2.Text = "select page";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        mycon();
        cmd = new SqlCommand("insert into subcatlist values(@ct,@sc,@st)", con);
        cmd.Parameters.AddWithValue("@ct", DropDownList3.Text);
        cmd.Parameters.AddWithValue("@sc",TextBox1.Text);
        cmd.Parameters.AddWithValue("@st", DropDownList2.Text);
        cmd.ExecuteNonQuery();
        con.Close();
        fillgrid();

    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect(DropDownList1.Text);
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}