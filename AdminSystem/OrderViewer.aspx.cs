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
        clsOrders AnOrders = new clsOrders();

        AnOrders = (clsOrders)Session["AnOrders"];

        Response.Write(AnOrders.CostumerName);

        Response.Write(AnOrders.OrderId);
        Response.Write(AnOrders.DeliveryAddress);

        Response.Write(AnOrders.OrderDate);

        Response.Write(AnOrders.PostCode);

        Response.Write(AnOrders.Active);



    }
}
