using OrganizeTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebOrganizerTask
{
    public partial class AddTask1 : System.Web.UI.UserControl
    {
        public event EventHandler AddTaskButtonClicked;
        private Task task;
        public Task Task 
        { 
            get { return task; }
            set { task = value; }
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
                task = new Task();
            }
        }

        protected void ButtonAddTask_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;
            string nameTask = TaskNameText.Text;
            string frequency = FrequencyDownList.SelectedValue;
            string importance = ImportanceDownList.SelectedValue;
            DateTime? startDate;
            DateTime? endDate;
            try
            {
                startDate = DateTime.Parse(StartDateText.Text);
            }
            catch (FormatException)
            {
                startDate = null;
            }
            try
            {
                endDate = DateTime.Parse(EndDateText.Text);
            }
            catch (FormatException)
            {
                endDate = null;
            }
            task = new Task(nameTask, startDate, endDate, "Добавлена", frequency, importance);
            if (AddTaskButtonClicked != null)
            {
                AddTaskButtonClicked(this, EventArgs.Empty);
            }
        }
    }
}