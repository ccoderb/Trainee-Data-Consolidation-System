using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;


public partial class Grid : System.Web.UI.Page
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
        // if(!Page.IsPostBack)
        {
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM addst WHERE name= '" + ddlName.SelectedItem + "'", cn);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            this.gvTable.DataSource = ds2; this.gvTable.DataBind();

        }

    }

    protected void bHome_Click(object sender, EventArgs e)
    {

        Response.Redirect("MainMenu.aspx");
    }
}
