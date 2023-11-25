using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS_App.Shared.Models
{
    public class Tbl_Appointment_Details
    {
        public Guid Id { get; set; }

        public Guid Appointment_Id { get; set; }

        public string Activity_Type { get; set; }

        public string Description { get; set; }

        public string Remark { get; set; }

        public int Del_Flag { get; set; }

        public string CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public string UpdatedOn { get; set; }

        public string UpdatedBy { get; set; }

    }
}
