using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS_App.Shared.Models
{
    public class Tbl_user
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string UserType { get; set; }

        public string Email { get; set; }

        public string Contact { get; set; }
    }
}
