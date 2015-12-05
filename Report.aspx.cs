using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;
public partial class Default2 : System.Web.UI.Page
{
    static string constr = WebConfigurationManager.ConnectionStrings["projconn"].ConnectionString;
    SqlConnection cn = new SqlConnection(constr);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT name as dmk from addst", cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            this.ddlName.DataSource = ds;
            this.ddlName.DataTextField = "dmk";
            this.ddlName.DataBind();
        }

    }
    protected void bShow_Click(object sender, EventArgs e)
    {
    //    lFilename.Visible = true;
                lFilename.Text=@"<\na href=Reports/hello.txt>link</a>";
        
    }
}