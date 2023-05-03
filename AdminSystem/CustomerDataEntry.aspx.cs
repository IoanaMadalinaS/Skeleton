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
    protected void BtnOK_Click1(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();
        //
        Customer_ID = Convert.ToInt32(txtCustomer_ID.Text);
        Firstname = txtFirstname.Text;
        Lastname = txtLastname.Text;
        Date_Of_Birth = Convert.ToDateTime(txtDate_of_Birth.Text);
        Email = txtEmail.Text;
        Address = txtAddress.Text;
        
        Session["AnCustomer"] = AnCustomer;
        Response.Redirect("CustomerViewer.aspx");
    }



    protected void btnCANCEL_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();
        Int32 Customer_ID;
        Boolean Found = false;

        if (Int32.TryParse(txtCustomer_ID.Text, out Customer_ID))
        {
            Found = AnCustomer.Find(Customer_ID);
            if (Found == true)
            {
                txtCustomer_ID.Text = AnCustomer.Customer_ID.ToString();
                txtFirstname.Text = AnCustomer.Firstname;
                txtLastname.Text = AnCustomer.Lastname;
                txtDate_of_Birth.Text = AnCustomer.Date_Of_Birth.ToString();
                txtEmail.Text = AnCustomer.Email;
                txtAddress.Text = AnCustomer.Address;
                ChkActive.Checked = AnCustomer.Active;
            }
        }
    }
}


   