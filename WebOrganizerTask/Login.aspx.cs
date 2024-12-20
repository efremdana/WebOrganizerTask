using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebOrganizerTask.ServiceReference1;

namespace WebOrganizerTask
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (!Page.IsValid)
                    return;
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            ServiceClient client = new ServiceClient();
            if (client.Authenticate(UserName.Text, Password.Text))
            {
                FormsAuthentication.SetAuthCookie(UserName.Text, false);
                string url = Request.QueryString["ReturnUrl"];
                if (url != null) { Response.Redirect(url); }
                else Response.Redirect("~/Main.aspx");
            }
            else
            {
                CustomValidator customValidator = new CustomValidator();
                customValidator.IsValid = false;
                customValidator.ErrorMessage = "Неверное имя пользователя или пароль";
                Page.Validators.Add(customValidator);
            }
        }
    }
}