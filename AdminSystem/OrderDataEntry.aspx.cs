using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    public object AnOrder { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {

    }












    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsOrders AnOrders = new clsOrders();
        AnOrders.CustomerName = txtCostumerNo.Text;
        
        AnOrders.OrderId = Convert.ToInt32(txtOrderId.Text);

        AnOrders.Total = Convert.ToInt32(txtTotalPrice.Text);

        AnOrders.OrderDate = Convert.ToDateTime(txtDate.Text);

        AnOrders.Active = chkDelivered.Checked;

        AnOrders.DeliveryAddress = txtAdressD.Text;

        AnOrders.PostCode = txtPostCode.Text;

        Session["AnOrders"] = AnOrders;
        Response.Redirect("OrderViewer.aspx");

    }

    

    protected void Button1_Click(object sender, EventArgs e)
    {

        clsOrders AnOrders = new clsOrders();

        Int32 OrderId;

        Boolean Found = false;

        OrderId = Convert.ToInt32(txtOrderId.Text);

        if (Found == true)
        {
            txtCostumerNo.Text = AnOrders.CustomerName;
            txtAdressD.Text = AnOrders.DeliveryAddress;
            txtPostCode.Text = AnOrders.PostCode;
            txtDate.Text = AnOrders.OrderDate.ToString();
            txtTotalPrice.Text = AnOrders.Total.ToString();
            chkDelivered.Checked = AnOrders.Active;


        }
    }
}

   