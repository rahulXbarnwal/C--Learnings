using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IndexersDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            Session["Session1"] = "Session 1 Data";
            Session["Session2"] = "Session 2 Data";

            Response.Write("Session 1 Data = " + Session[0].ToString());
            Response.Write("<br/>");
            Response.Write("Session 2 Data = " + Session["Session2"].ToString());
            */

            /*
            Company company = new Company();
            Response.Write("Name of Employee With Id = 2: " + company[2]);
            Response.Write("<br/>"); 
            Response.Write("Name of Employee With Id = 5: " + company[5]);
            Response.Write("<br/>");
            Response.Write("Name of Employee With Id = 8: " + company[8]);
            Response.Write("<br/>");

            Response.Write("Changing names of employees with Ids 2, 5 & 8");
            Response.Write("<br/>");
            Response.Write("<br/>");

            // because of the "employeeId" indexer, I am able to use company object like an array

            company[2] = "2nd Employee Name Changed";
            company[5] = "5th Employee Name Changed";
            company[8] = "8th Employee Name Changed";

            Response.Write("Name of Employee With Id = 2: " + company[2]);
            Response.Write("<br/>");
            Response.Write("Name of Employee With Id = 5: " + company[5]);
            Response.Write("<br/>");
            Response.Write("Name of Employee With Id = 8: " + company[8]);
            Response.Write("<br/>");
            */

            Company company = new Company();
            Response.Write("Before Update: ");
            Response.Write("<br/>");
            Response.Write("Total Male Employees: " + company["Male"]);
            Response.Write("<br/>");
            Response.Write("Total Female Employees: " + company["Female"]);

            Response.Write("<br/>");
            Response.Write("<br/>");

            company["Male"] = "Female";
            Response.Write("After Update: ");
            Response.Write("<br/>");
            Response.Write("Total Male Employees: " + company["Male"]);
            Response.Write("<br/>");
            Response.Write("Total Female Employees: " + company["Female"]);
        }
    }
}