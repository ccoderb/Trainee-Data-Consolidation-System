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

public partial class Edit : System.Web.UI.Page
    
{
    static string constr = WebConfigurationManager.ConnectionStrings["projconn"].ConnectionString;
    SqlConnection cn = new SqlConnection(constr);

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!(Page.IsPostBack))
        {
            this.cStartdate.Visible = false;
            this.cEnddate.Visible = false;
            SqlDataAdapter da = new SqlDataAdapter("SELECT name as dmk from addst", cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            this.ddlName.DataSource = ds;
            this.ddlName.DataTextField = "dmk";
            this.ddlName.DataBind();
        }
          /*  SqlDataAdapter da2 = new SqlDataAdapter(" SELECT address , institute ,course,year,startdate,enddate,duration,contactno,discipline,referenceno from addst WHERE name='"+ddlName.SelectedItem+"'",cn);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
             this.tbAddress.Text= ds2.Tables[0].Rows[0]["address"].ToString();
             tbAddress.DataBind();
            tbInstitute.Text=ds2.Tables[0].Rows[0]["institute"].ToString();
            tbInstitute.DataBind();
            ddlCourse.DataTextField=ds2.Tables[0].Rows[0]["course"].ToString();
            ddlCourse.DataBind();
            ddlYear.DataTextField=ds2.Tables[0].Rows[0]["year"].ToString();
            ddlYear.DataBind();
            tbStartdate.Text=ds2.Tables[0].Rows[0]["startdate"].ToString();
            tbStartdate.DataBind();
            tbEnddate.Text=ds2.Tables[0].Rows[0]["enddate"].ToString();
            tbEnddate.DataBind();
            ddlDuration.DataTextField =ds2.Tables[0].Rows[0]["duration"].ToString();
            ddlDuration.DataBind();
            tbContactno.Text=ds2.Tables[0].Rows[0]["contactno"].ToString();
            tbContactno.DataBind();
            tbDiscipline.Text=ds2.Tables[0].Rows[0]["discipline"].ToString();
            tbDiscipline.DataBind();
            tbReferenceno.Text = ds2.Tables[0].Rows[0]["referenceno"].ToString();
            tbReferenceno.DataBind();
        //} */
    }
    protected void bSubmit_Click(object sender, EventArgs e)
    {
        

       SqlDataAdapter da2 = new SqlDataAdapter(" SELECT address , institute ,course,year,startdate,enddate,duration,contactno,discipline,referenceno from addst WHERE name='" + ddlName.SelectedItem.Value + "'", cn);
        DataSet ds2 = new DataSet();
        da2.Fill(ds2);
        this.tbAddress.Text = ds2.Tables[0].Rows[0]["address"].ToString();
        tbAddress.DataBind();
        tbInstitute.Text = ds2.Tables[0].Rows[0]["institute"].ToString();
        tbInstitute.DataBind();
        ddlCourse.DataTextField ="course";
        ddlCourse.DataBind();
        ddlCourse.SelectedIndex = -1;
        ddlCourse.Items.FindByValue(ds2.Tables[0].Rows[0]["course"].ToString()).Selected = true;
        ddlYear.DataTextField = "year";
        ddlYear.DataBind();
        ddlYear.SelectedIndex = -1;
        ddlYear.Items.FindByValue(ds2.Tables[0].Rows[0]["year"].ToString()).Selected = true;
        tbStartdate.Text = ds2.Tables[0].Rows[0]["startdate"].ToString();
        tbStartdate.DataBind();
        tbEnddate.Text = ds2.Tables[0].Rows[0]["enddate"].ToString();
        tbEnddate.DataBind();
        ddlDuration.DataTextField = "duration";
        ddlDuration.DataBind();
        ddlDuration.SelectedIndex = -1;
        ddlDuration.Items.FindByText(ds2.Tables[0].Rows[0]["duration"].ToString()).Selected = true; 
        tbContactno.Text = ds2.Tables[0].Rows[0]["contactno"].ToString();
        tbContactno.DataBind();
        tbDiscipline.Text = ds2.Tables[0].Rows[0]["discipline"].ToString();
        tbDiscipline.DataBind();
        tbReferenceno.Text = ds2.Tables[0].Rows[0]["referenceno"].ToString();
        tbReferenceno.DataBind();
        
    }
    protected void ibStartdate_Click(object sender, ImageClickEventArgs e)
    {
        this.cStartdate.Visible = true;
    }


    protected void tbStartdate_TextChanged(object sender, EventArgs e)
    {

    }

    

       protected void cStartdate_SelectionChanged(object sender, EventArgs e)
        {
            this.tbStartdate.Text = cStartdate.SelectedDate.ToShortDateString();
            cStartdate.Visible = false;
        }
       protected void ibEnddate_Click(object sender, ImageClickEventArgs e)
       {
           cEnddate.Visible = true;
       }
       protected void tbEnddate_TextChanged(object sender, EventArgs e)
       {

       }
       protected void cEnddate_SelectionChanged(object sender, EventArgs e)
       {
           if (cEnddate.SelectedDate > cStartdate.SelectedDate)
           {
               this.tbEnddate.Text = cEnddate.SelectedDate.ToShortDateString();
               cEnddate.Visible = false;
               lCerror.Visible = false;

           }
           else
               lCerror.Visible = true;
               lCerror.Text="end date must be after start date";
       }
      

       protected void ibEnddate_Click1(object sender, ImageClickEventArgs e)
       {

       }
      
       protected void bSave_Click(object sender, EventArgs e)
       {
           if (cbConfirm.Checked)
           {
               lCberror.Visible = false;
               SqlCommand cmd1 = new SqlCommand("UPDATE addst SET address='" + this.tbAddress.Text     + "',institute='" + tbInstitute.Text + "',course='" + ddlCourse.SelectedItem + "',year='" + ddlYear.SelectedItem + "',startdate='" + cStartdate.SelectedDate + "' ,enddate= '" + cEnddate.SelectedDate + "' ,duration= '" + ddlDuration.SelectedItem + "' ,contactno= '" + tbContactno.Text + "' ,discipline= '" + tbDiscipline.Text + "' ,referenceno= '" + tbReferenceno.Text + "'  WHERE name='" + ddlName.Text + "'", cn);
               cn.Open();
               cmd1.ExecuteNonQuery();
               cn.Close();
           }
           else
           {
               lCberror.Text = "Confirm before saving";
               lCberror.Visible = true;

           }
       }



       protected void bHome_Click(object sender, EventArgs e)
       {
           Response.Redirect("MainMenu.aspx");
       }
}