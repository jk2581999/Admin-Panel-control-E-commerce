using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class admintc : System.Web.UI.Page
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
            DropDownList1.Items.Insert(0, "--select category--");
            con.Close();
            mycon();
            cmd = new SqlCommand("select * from subcatlist", con);
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds);
            DropDownList3.DataSource = ds;
            DropDownList3.DataTextField = "subcategory";
            DropDownList3.DataValueField = "subcat_id";
            DropDownList3.DataBind();
            DropDownList3.Items.Insert(0, "--select subcategory--");
            con.Close();


        }
    }
    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        Response.Redirect("admintcshow.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        mycon();
        cmd = new SqlCommand("select * from thirdcat where ThirdCategory=@tb", con);
        cmd.Parameters.AddWithValue("@tb", TextBox1.Text);
        da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        int a=ds.Tables[0].Rows.Count;
        if(a>0)
        {
            Response.Write("<script>('This is already exits')</script>");

        }
        else
        {
            mycon();
            cmd = new SqlCommand("insert into thirdcat values(@ct,@sc,@tc,@st)", con);
            cmd.Parameters.AddWithValue("@ct", DropDownList1.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@sc", DropDownList3.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@tc", TextBox1.Text);
            cmd.Parameters.AddWithValue("@st",DropDownList4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('successfully saved')</script>");

        }
            }
}