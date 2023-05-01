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

        //create a new instance of clsStock
        clsStock AnStock = new clsStock();
        //get the data from the session object
        AnStock = (clsStock)Session["AnStock"];
        //display the Item for this entry

        //Response.Write("ItemNo : " + AnStock.ItemNo + "<br />");

        Response.Write("DateAdded : " + AnStock.DateAdded.Date.ToShortDateString() + "<br />");

        Response.Write("ItemDesc : " + AnStock.ItemDesc.ToString() + "<br />");

        Response.Write("ItemName : " + AnStock.ItemName.ToString() + "<br />");

        Response.Write("Price : " + AnStock.Price.ToString() + "<br />");

        if (AnStock.Avaliable)
        {
            Response.Write("Avaliable : Yes<br />");
        }
        else
        {
            Response.Write("Avaliable : No<br />");
        }


        if (AnStock.Active)
        {
            Response.Write("Active : Yes<br />");
        }
        else
        {
            Response.Write("Active : No<br />");
        }

    }
}