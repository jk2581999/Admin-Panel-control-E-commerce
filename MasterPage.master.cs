using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList2.Text = "select page";
        }
    }
      protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect(DropDownList2.Text);
    }
    
}
