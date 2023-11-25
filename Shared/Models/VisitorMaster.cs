using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace VMS_App.Shared.Models
{
    public class VisitorMaster
    {
        public UniqueId id { get; set; }

        public string visitorCode { get; set; }

        public string Name { get; set; }

        public DateTime DOB { get; set; }

        public string MobileNumber { get; set; }

        public string Email { get; set; }

        public string PhotoGraph { get; set; }

        public string Id_type { get; set; }

        public string Personal_id { get; set; }

        public string personall_file { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string PinCode { get; set; }

        public string Company { get; set; }

        public int Status { get; set; }

        public int Del_flag { get; set; }

        public string Created_On { get; set; }

        public string Created_by { get; set; }

        public string Updated_on { get; set; }

        public string Updated_by { get; set; }
    }
}
