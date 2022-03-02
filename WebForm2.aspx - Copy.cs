using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS= ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))

            {

                 SqlCommand cmd = new SqlCommand("Select Product, Name", con);
                cmd.connection = con;
                int totalrows = cmd.ExecuteQuery();
                Response.Write("totalrows= "+ totalRowsAffected.ToString());

          

                

        }
    }
}