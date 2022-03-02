
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Adodemo 
{
    public partial class WebForm1: System.Web.UI.Page
    {
        protected void Page_load(object sender ,EventArgs e)
        {

            String CS = "Data source=.,database= Sample ;integrated sequrity = SSPI";
            sqlconnection con = new sqlconnection(cs);
            sqlCommand cmd = new sqlCommand("Select * from tblproduct", con);
            Gridview1.datasource = cmd.ExecuteReader();
            GridView1.databind();
            con.close();
        }
    }
    }
