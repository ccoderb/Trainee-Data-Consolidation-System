using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

public partial class Report : System.Web.UI.Page
{

    static string constr = WebConfigurationManager.ConnectionStrings["projconn"].ConnectionString;
    SqlConnection cn = new SqlConnection(constr);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!(Page.IsPostBack))
        {
            this.cSubdate.Visible = false;
            this.cAcceptdate.Visible = false;
        }
        SqlDataAdapter da = new SqlDataAdapter(" SELECT name,id from addst", cn);

        DataSet ds = new DataSet();
        da.Fill(ds);
        this.ddlName.DataSource = ds;
        this.ddlName.DataTextField = "name";
        this.ddlName.DataBind();



    }
  
    protected void ibSubdate_Click(object sender, ImageClickEventArgs e)
    {
        cSubdate.Visible = true;
    }
    protected void ibAcceptdate_Click(object sender, ImageClickEventArgs e)
    {
        cAcceptdate.Visible = true;
    }
    protected void tbSubdate_TextChanged(object sender, EventArgs e)
    {

    }
    protected void tbAcceptdate_TextChanged(object sender, EventArgs e)
    {
       

    }
    protected void cSubdate_SelectionChanged(object sender, EventArgs e)
    {
        this.tbSubdate.Text = cSubdate.SelectedDate.ToShortDateString();
        cSubdate.Visible = false;
    }
    protected void bSave_Click(object sender, EventArgs e)
    {
        SqlCommand cmd3 = new SqlCommand("INSERT INTO addst (subdate,accdate) VALUES ('" + cSubdate.SelectedDate + "' , '" + cAcceptdate.SelectedDate + "')", cn);
        cn.Open();
        cmd3.ExecuteNonQuery();
        cn.Close();

    }
    protected void cAcceptdate_SelectionChanged(object sender, EventArgs e)
    {
        this.tbAcceptdate.Text = cAcceptdate.SelectedDate.ToShortDateString();
        cAcceptdate.Visible = false;

    }
}