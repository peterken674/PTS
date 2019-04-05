using System;

public partial class _Default : System.Web.UI.Page
{
    private customerwebservice.PTSCustomerWebService service;
    /// <summary>
    /// Action on page load.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        service = new customerwebservice.PTSCustomerWebService();
    }
    /// <summary>
    /// Action on login button click.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        int id = service.Authenticate(txtUsername.Text, txtPassword.Text);
        if (id > 0)
        {
            Session["id"] = id;
            Response.Redirect("ProjectDetails.aspx");
        }
        else
        {
            lblMessage.Text = "Incorrect login details, please try again.";
        }
    }

}