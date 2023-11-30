using VMS_App.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VMS_App.Server.Services
{
    public static class LoginServices 
    {
       private static List<Tbl_user> Users = new List<Tbl_user>();
       
        public static void AddUsers(List<Tbl_user> Users)
        {
            Users.Add(new Tbl_user() { Id = 1, Username = "Saurabh", Password = "Password", Contact = "7898455", Email = "Saurabh@gmail.com", UserType = "Visitor" });
            Users.Add(new Tbl_user() { Id = 1, Username = "Purnima", Password = "Password", Contact = "7898455", Email = "Purnima@gmail.com", UserType = "Security" });
            Users.Add(new Tbl_user() { Id = 1, Username = "Suyash", Password = "Password", Contact = "7898455", Email = "Suyash@gmail.com", UserType = "Admin" });
        }
       
        public static bool ValidUser(string Username, string password) 
        {
          Tbl_user user = Users.Find(u => u.Username == Username);

            if (user == null) return false;
            return user != null && password == user.Password;
        }
    }
}
