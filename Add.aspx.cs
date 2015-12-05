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

public partial class Default2 : System.Web.UI.Page
    
{
    static string constr = WebConfigurationManager.ConnectionStrings["projconn"].ConnectionString;
    SqlConnection cn = new SqlConnection(constr);

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!(Page.IsPostBack))
        {
            this.cStartdate.Visible = false;
            this.cEnddate.Visible = false;
        } 
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
      // protected void iPhoto_SelectionChanged(object sender, EventArgs e)
     //  {
      //     this.iPhoto.ImageUrl = fuPhoto.FileName;
     //  }

       protected void ibEnddate_Click1(object sender, ImageClickEventArgs e)
       {

       }
       protected void bUpload_Click(object sender, EventArgs e)
       {
           //if(fuPhoto.HasFile)
           {
              // if(fuPhoto.PostedFile.ContentLength<102400)
               {
                   string filename=Path.GetFileName(fuPhoto.FileName);
                //   fuPhoto.SaveAs(Server.MapPath("")+"\images\" + filename + ".jpg");      
               //    fuPhoto.SaveAs(Server.MapPath("~/"+"Images/"+filename));
                   fuPhoto.SaveAs(Server.MapPath("~/"+"Images/"+tbName.Text+".jpg"));   
                       
                       
                       
                       
                       
                       //Images/"+filename+".jpg");
               }
           }

       }
       protected void bSave_Click(object sender, EventArgs e)
       {
           if (cbConfirm.Checked)
           {
               lCberror.Visible = false;
               SqlCommand cmd1 = new SqlCommand("insert into addst (name,address,institute,course,year,startdate,enddate,duration,contactno,discipline,referenceno) values ('" + this.tbName.Text + "' ,'" + this.tbAddress.Text     + "','" + tbInstitute.Text + "','" + ddlCourse.SelectedItem + "','" + ddlYear.SelectedItem + "','" + cStartdate.SelectedDate + "' , '" + cEnddate.SelectedDate + "' , '" + ddlDuration.SelectedItem + "' , '" + tbContactno.Text + "' , '" + tbDiscipline.Text + "' , '" + tbReferenceno.Text + "')", cn);
               cn.Open();
               cmd1.ExecuteNonQuery();
               cn.Close();
               Response.Redirect("Projectinfo.aspx");
           }
           else
           {
               lCberror.Text = "Confirm before saving";
               lCberror.Visible = true;

           }
       }
      
}