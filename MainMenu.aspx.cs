﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
           
    }

    protected void bAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("Add.aspx");
    }
    protected void bGrid_Click(object sender, EventArgs e)
    {
        Response.Redirect("Grid.aspx");
    }
    protected void bEdit_Click(object sender, EventArgs e)
    {
        Response.Redirect("Edit.aspx");
    }
}