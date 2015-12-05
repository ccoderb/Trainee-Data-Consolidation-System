using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;
using System.IO;

public partial class Report : System.Web.UI.Page
{
    static string constr = WebConfigurationManager.ConnectionStrings["projconn"].ConnectionString;
    SqlConnection cn = new SqlConnection(constr);

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            this.cAcceptdate.Visible = false;
            this.cSubdate.Visible = false;
            SqlDataAdapter da = new SqlDataAdapter("SELECT name as dmk from addst", cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            this.ddlName.DataSource = ds;
            this.ddlName.DataTextField = "dmk";
            this.ddlName.DataBind();
        }

    }
    protected void ibSubdate_Click(object sender, ImageClickEventArgs e)
    {
        this.cSubdate.Visible = true;
    }
    protected void tbSubdate_TextChanged(object sender, EventArgs e)
    {

    }

    protected void cSubdate_SelectionChanged(object sender, EventArgs e)
    {

        this.tbSubdate.Text = cSubdate.SelectedDate.ToShortDateString();
        cSubdate.Visible = false;
    }

    protected void tbAcceptdate_TextChanged(object sender, EventArgs e)
    {

    }
    protected void ibAcceptdate_Click(object sender, ImageClickEventArgs e)
    {
        cAcceptdate.Visible = true;
    }
    protected void cAcceptdate_SelectionChanged(object sender, EventArgs e)
    {
        if (cAcceptdate.SelectedDate > cSubdate.SelectedDate)
        {
            this.tbAcceptdate.Text = cAcceptdate.SelectedDate.ToShortDateString();
            cAcceptdate.Visible = false;
            lCerror.Visible = false;

        }
        else
            lCerror.Visible = true;
        lCerror.Text = "Accepted date must be after Submitted date";
    }

    protected void bSave_Click(object sender, EventArgs e)
    {
        if (cbConfirm.Checked)
        {
            SqlCommand cmd2 = new SqlCommand("UPDATE addst SET subdate= '" + cSubdate.SelectedDate + "' ,accdate=  '" + cAcceptdate.SelectedDate + "' WHERE name='" + ddlName.Text + "'", cn);
            cn.Open();
            cmd2.ExecuteNonQuery();
            cn.Close();
            if (fuReport.HasFile)
            {
                
                string fileext = Path.GetExtension(fuReport.PostedFile.FileName);
                string filename = Path.GetFileName(fuReport.FileName);   
                fuReport.SaveAs(Server.MapPath("~/" + "Reports/" + ddlName.SelectedItem+fileext));
            }
            if (fuCode.HasFile)
            {
                string fileext = Path.GetExtension(fuCode.PostedFile.FileName);
                string filename = Path.GetFileName(fuCode.FileName);    
                fuCode.SaveAs(Server.MapPath("~/" + "Codes/" + ddlName.SelectedItem+fileext));
            }
            if (fuCerti.HasFile)
            {
              
                string fileext = Path.GetExtension(fuCerti.PostedFile.FileName);
                string filename = Path.GetFileName(fuCerti.FileName);
                     
                fuCerti.SaveAs(Server.MapPath("~/" + "Certificates/" + ddlName.SelectedItem+fileext));
            }

            Response.Redirect("Grid.aspx");
        }
        else
        {
            lCberror.Text = "Confirm before saving";
            lCberror.Visible = true;

        }
    }
}