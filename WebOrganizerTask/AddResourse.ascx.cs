using OrganizeTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebOrganizerTask
{
    public partial class AddResourse1 : System.Web.UI.UserControl
    {
        public event EventHandler AddResourceButtonClicked;

        private Resource resourse;
        public Resource Resourse
        {
            get { return resourse; }
            set { resourse = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (!Page.IsValid)
                    return;
            }
            else
            {
                resourse = new Resource();
            }
        }

        protected void ButtonAddResourse_Click(object sender, EventArgs e)
        {
            string nameResourse = ResourceNameText.Text;
            try
            {
                double quantity = Double.Parse(QuantityText.Text);
                Resourse = new Resource(nameResourse, quantity);
            }
            catch(FormatException)
            {
                Resourse = new Resource(nameResourse);
            }
            AddResourceButtonClicked(this, EventArgs.Empty);
        }
    }
}