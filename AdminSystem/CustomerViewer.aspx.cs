using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClsCustomer AnCustomer = new ClsCustomer();

        AnCustomer = (ClsCustomer)Session["AnCustomer"];
        Response.Write("Customer ID: " + AnCustomer.Customer_ID + "<br/>");
        Response.Write("Firstname: " + AnCustomer.Firstname + "<br/>");
        Response.Write("Lastname: " + AnCustomer.Lastname + "<br/>");
        Response.Write("Date of Birth: " + AnCustomer.Date_of_Birth + "<br/>");
        Response.Write("Email: " + AnCustomer.Email + "<br/>");
        Response.Write("Address: " + AnCustomer.Address + "<br/>");

    }
}