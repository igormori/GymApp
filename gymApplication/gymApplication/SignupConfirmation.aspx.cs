﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gymApplication
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String getstr = Request.QueryString["response"].ToString();
            if(getstr == "Success")
            {
                String s = "Welcome ";
                s += Session["Username"];
                s+= "</br>"+"Account has been created Successfully";

                Messagesignup.Text = "<h1>"+s+"</h1>";
                Messagesignup.ForeColor = System.Drawing.Color.Green;
            }


        }
    }
}