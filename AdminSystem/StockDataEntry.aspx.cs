using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new istance of Item
        clsStock AnStock = new clsStock();

        //capturing item name
        string ItemName = txtItemName.Text;

        //capturing item description
        string ItemDesc = txtItemDesc.Text;

        //capturing the DateAdded
        string DateAdded = txtDateAdded.Text;

        //capturing item price
        string Price = txtPrice.Text;

        string Error = "";

        Error = AnStock.Valid(ItemName, ItemDesc, DateAdded, Price);

        if(Error == "")
        {
            AnStock.ItemName = ItemName;

            AnStock.ItemDesc = ItemDesc;

            AnStock.DateAdded = Convert.ToDateTime(DateAdded);

            AnStock.Price = Convert.ToDecimal(Price);

            //capturing active 
            AnStock.Active = false;
            if (chkActive.Checked)
            {
                AnStock.Active = true;
            }

            //Capturing available
            AnStock.Avaliable = false;
            if (chkAvailable.Checked)
            {
                AnStock.Avaliable = true;
            }

            //store the item name in the session object
            Session["AnStock"] = AnStock;
            //navigate to the viewer page
            Response.Redirect("StockViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

        
    }

    protected void txtItemName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtItemDesc_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtDateAdded_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtAvaliable_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtFind_Click(object sender, EventArgs e)
    {
        clsStock AnStock = new clsStock();

        Int32 ItemNo;

        Boolean Found = false;

        ItemNo = Convert.ToInt32(txtItemNo.Text);

        Found = AnStock.Find(ItemNo);

        if (Found == true)
        {
            txtItemName.Text = AnStock.ItemName;
            txtItemDesc.Text = AnStock.ItemDesc;
            txtDateAdded.Text = AnStock.DateAdded.Date.ToString();
            txtPrice.Text = AnStock.Price.ToString();
            chkActive.Checked = AnStock.Active;
            chkAvailable.Checked = AnStock.Avaliable;
        }
    }
}