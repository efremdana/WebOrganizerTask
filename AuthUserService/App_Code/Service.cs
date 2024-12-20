using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Hosting;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AuthUserService" in code, svc and config file together.
public class Service : IService
{
    public bool Authenticate(string username, string password)
    {
        List<User> users = ReadUsers();
        if (users.Find(u => u.UserName == username && u.Password == password) == null)
            return false;
        return true;
    }
    private List<User> ReadUsers()
    {
        string filePath = HostingEnvironment.MapPath("~/App_Data/users.json");
        string json = File.ReadAllText(filePath);
        List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
        return users;
    }

}

public class User
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
}
