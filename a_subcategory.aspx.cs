using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class a_subcategory : System.Web.UI.Page
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
        if (!IsPostBack)
        {
            mycon();
            cmd = new SqlCommand("select * from categorylist",con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "category";
            DropDownList1.DataValueField = "cat_id";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0,"--select category--");
            con.Close();
        }
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        mycon();
        cmd = new SqlCommand("select * from subcatlist where subcategory=@tb", con);
        cmd.Parameters.AddWithValue("@tb", TextBox1.Text);
        da = new SqlDataAdapter(cmd);
        ds = new DataSet();
        da.Fill(ds);
        int a = ds.Tables[0].Rows.Count;
        con.Close();
        if (a > 0)
        {
            Response.Write("<script>alert('data already exits by this categorty')</script>");
        }
        else { 
        
        mycon();
        cmd = new SqlCommand("insert into subcatlist values(@ct,@sc,@st)", con);
        cmd.Parameters.AddWithValue("@ct", DropDownList1.SelectedItem.ToString());
        cmd.Parameters.AddWithValue("@sc", TextBox1.Text);
        cmd.Parameters.AddWithValue("@st", DropDownList3.Text);
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Write("<script>alert('successfully saved')</script>");
        }
    }
    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        Response.Redirect("a_subcategoryshow.aspx");
    }
}