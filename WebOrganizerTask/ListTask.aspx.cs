using Newtonsoft.Json;
using OrganizeTask;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebOrganizerTask
{
    public partial class ListTask : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Task> tasks = ReadTask();


            GridViewTasks.DataSource = tasks.FindAll(t => t.User == User.Identity.Name);
            GridViewTasks.DataBind();
        }

        protected void GridViewTasks_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string progress = DataBinder.Eval(e.Row.DataItem, "Progress").ToString();
                if (progress == "Начато")
                {
                    e.Row.CssClass = "table-success";
                }
                object endData = DataBinder.Eval(e.Row.DataItem, "DateEnd");
                if (endData == null) { return; }
                DateTime date = DateTime.Parse(endData.ToString());
                double difference = date.Subtract(DateTime.Now).TotalDays;
                if (difference <= 1 && difference > 0)
                {
                    e.Row.CssClass = "table-warning";
                }
                else if (difference < 0)
                {
                    e.Row.CssClass = "table-danger";
                }
                if (progress == "Закрыта")
                {
                    e.Row.CssClass = "table-secondary";
                }
            }
        }
        private List<Task> ReadTask()
        {
            string filePath = HostingEnvironment.MapPath("~/tasks.json");
            string json = File.ReadAllText(filePath);
            List<Task> tasks = JsonConvert.DeserializeObject<List<Task>>(json);
            return tasks;
        }
    }
}