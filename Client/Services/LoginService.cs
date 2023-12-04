using VMS_App.Shared.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Microsoft.JSInterop;
using System.Threading.Tasks; 

namespace VMS_App.Client.LoginService
{
    public class LoginService
    {

        private static List<Tbl_user> Users = new List<Tbl_user>
        {
          new Tbl_user {Id = 1, Username="Saurabh", Password="password", UserType="Visitor", Contact="7554554", Email="Saurabh@gamail.com"},
          new Tbl_user {Id = 1, Username="Suyash", Password="password", UserType="Admin", Contact="7554554", Email="Saurabh@gamail.com"},
          new Tbl_user {Id = 1, Username="Purnima", Password="password", UserType="Hod", Contact="7554554", Email="Saurabh@gamail.com"}
        };

        public Tbl_user AuthenticatedUser { get; set; }

        public bool ValidUser(string Username, string Password)
        {
            var User = Users.FirstOrDefault(u => u.Username == Username && u.Password == Password);
            if (User != null)
            {
                AuthenticatedUser = User;
                return true;
            }
            return false;
        }

        public void Logout()
        {
            AuthenticatedUser.Equals(null);
        }

    }
}
