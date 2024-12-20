using OrganizeTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebOrganizerTask
{
    public partial class NewTask : System.Web.UI.Page
    {
        private Task newTaskUser;

        private string IDTask;

        protected void Page_Load(object sender, EventArgs e)
        {

            AddTask.AddTaskButtonClicked += ButtonAddTask_Click;
            AddResourse.AddResourceButtonClicked += ButtonAddResourse_Click;
            AddPerson.AddPersonButtonClicked += ButtonAddPerson_Click;
            IDTask = Request.QueryString["IDTask"];
            if (IDTask != null)
            {
                Task task = Task.ReadTask(IDTask);
                NewTaskLabel.Text += task.ToString();
                NewResoursesLabel.Text += string.Join(",", task.Resourses);
                NewPersonsLabel.Text += string.Join(",", task.Persons);
            }
        }

        protected void ButtonAddTask_Click(object sender, EventArgs e)
        {
            this.newTaskUser = AddTask.Task;
            newTaskUser.User = User.Identity.Name;
            Task.WriteTask(newTaskUser);
            Response.Redirect($"~/NewTask.aspx?IDTask={newTaskUser.ID}");
        }

        protected void ButtonAddResourse_Click(object sender, EventArgs e)
        {
            if (IDTask != null)
            {
                Resource resourse = AddResourse.Resourse;
                newTaskUser = Task.ReadTask(IDTask);
                if (newTaskUser == null)
                    Response.Redirect($"~/NewTask.aspx");
                newTaskUser.Resourses.Add(resourse);
                Task.WriteTask(newTaskUser);
                Response.Redirect(Request.Url.ToString());
            }
        }

        protected void ButtonAddPerson_Click(object sender, EventArgs e)
        {
            if (IDTask != null)
            {
                Person person = AddPerson.Person;
                Task task = Task.ReadTask(IDTask);
                if (task == null)
                    Response.Redirect("~/NewTask.aspx");
                task.Persons.Add(person);
                Task.WriteTask(task);
                Response.Redirect(Request.Url.ToString());
            }
        }

        protected void ButtonFinish_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Main.aspx");
        }
    }
}