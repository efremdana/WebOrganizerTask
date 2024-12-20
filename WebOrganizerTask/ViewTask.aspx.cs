using OrganizeTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebOrganizerTask
{
    public partial class ViewTask : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string IDTask = Request.QueryString["IDTask"];
            Task task = Task.ReadTask(IDTask);
            if (task.Progress == "Добавлена")
            {
                ButtonTask.Text = "Начать";
                ButtonTask.CssClass = "btn btn-primary";
            }
            else if (task.Progress == "Начато")
            {
                ButtonTask.Text = "Завершить";
                ButtonTask.CssClass = "btn btn-success";
            }
            else
            {
                ButtonTask.Text = "Закрыта";
                ButtonTask.CssClass = "btn btn-secondary disabled";
            }
            DetailsViewTask.DataSource = new List<Task> { task };
            GridViewResources.DataSource = task.Resourses;
            GridViewPersons.DataSource = task.Persons;
            DetailsViewTask.DataBind();
            GridViewResources.DataBind();
            GridViewPersons.DataBind();
        }

        protected void ButtonTask_Click(object sender, EventArgs e)
        {
            string IDTask = Request.QueryString["IDTask"];
            Task task = Task.ReadTask(IDTask);
            if (ButtonTask.Text == "Начать")
            {
                task.Progress = "Начато";
                Task.WriteTask(task);
                Response.Redirect("~/ListTask.aspx");
            }
            else if (ButtonTask.Text == "Завершить")
            {
                task.Progress = "Закрыта";
                Task.WriteTask(task);
                Response.Redirect("~/ListTask.aspx");
            }
        }
    }
}