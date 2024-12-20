using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.IO;
using Newtonsoft.Json;
using System.Web.Hosting;

namespace OrganizeTask
{
    public class Task
    {
        private string name = null;
        private DateTime? dateStart = null;
        private DateTime? dateEnd = null;
        private string progress = null;
        private string periodicity = null;
        private string importance = null;
        private List<Resource> resources = new List<Resource>();
        private List<Person> persons = new List<Person>();

        public string User { get; set; }
        public Guid? ID { get; set; }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public DateTime? DateStart
        {
            get { return dateStart; }
            set
            {
                dateStart = value;
            }
        }
        public DateTime? DateEnd
        {
            get { return dateEnd; }
            set
            {
                dateEnd = value;
            }
        }
        public string Progress
        {
            get { return progress; }
            set { progress = value; }
        }
        public string Periodicity
        {
            get { return periodicity; }
            set { periodicity = value; }
        }
        public string Importance
        {
            get { return importance; }
            set { importance = value; }
        }

        public List<Resource> Resourses
        {
            get { return resources; }
            set { resources = value; }
        }
        public List<Person> Persons
        {
            get { return persons; }
            set { persons = value; }
        }

        public Task()
        {
            ID = Guid.NewGuid();
        }

        public Task(string name, DateTime? dateStartNew, DateTime? dateEndNew, string progress, string periodicity, string importance)
        {
            ID = Guid.NewGuid();
            Name = name;
            Progress = progress;
            Periodicity = periodicity;
            Importance = importance;

            if (dateStartNew != null)
                DateStart = dateStartNew;

            if (dateEndNew != null)
                DateEnd = dateEndNew;
        }
        public static void WriteTask(Task task)
        {
            string absolutePath = HostingEnvironment.MapPath("~/tasks.json");
            string json = File.ReadAllText(absolutePath);
            List<Task> tasks = JsonConvert.DeserializeObject<List<Task>>(json);
            Predicate<Task> isList = t => t.ID == task.ID;
            if (tasks == null)
            {
                tasks = new List<Task>() { task };
                json = JsonConvert.SerializeObject(tasks, Formatting.Indented);
                File.WriteAllText(absolutePath, json);
                return;
            }
            Task taskFind = tasks.Find(isList);
            if (taskFind == null)
            {
                tasks.Add(task);
                json = JsonConvert.SerializeObject(tasks, Formatting.Indented);
                File.WriteAllText(absolutePath, json);
            }
            else
            {
                //taskFind.Resourses = task.Resourses;
                //taskFind.Persons = task.Persons;
                //taskFind.Progress = task.Progress;
                for (int i = 0; i < tasks.Count; i++)
                {
                    if (tasks[i].ID == task.ID)
                        tasks[i] = task;
                }
                json = JsonConvert.SerializeObject(tasks, Formatting.Indented);
                File.WriteAllText(absolutePath, json);
            }
        }

        public static Task ReadTask(string IDTask)
        {
            string absolutePath = HostingEnvironment.MapPath("~/tasks.json");
            string json = File.ReadAllText(absolutePath);
            List<Task> tasks = JsonConvert.DeserializeObject<List<Task>>(json);
            Predicate<Task> isList = t => t.ID.ToString() == IDTask;
            Task task = tasks.Find(isList);
            return task;
        }
        public override string ToString()
        {
            return Name;
        }

    }
}
