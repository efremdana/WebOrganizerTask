using OrganizeTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebOrganizerTask
{
    public partial class AddPerson1 : System.Web.UI.UserControl
    {
        public event EventHandler AddPersonButtonClicked;
        private Person person;
        public Person Person 
        {
            get { return person; } 
            set { person = value; } 
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
                person = new Person();
            }
        }

        protected void ButtonAddPerson_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameText.Text;
            string lastName = LastNameText.Text;
            string phone = PhoneText.Text;
            string email = EmailText.Text;
            Person = new Person(firstName, lastName, phone, email);
            AddPersonButtonClicked(this, EventArgs.Empty);
        }
    }
}