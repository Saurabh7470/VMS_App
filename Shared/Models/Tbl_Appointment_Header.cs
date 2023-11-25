using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS_App.Shared.Models
{
    public class Tbl_Appointment_Header
    {
        public Guid Id { get; set; }

        public string AppointmentCode { get; set; }
        
        public DateTime FromDate { get; set; }
        
        public DateTime ToDate { get; set; }
        
        public string AppointmentType { get; set; }
        
        public Guid Visitor_Id { get; set; }
        
        public Guid EmployeeID { get; set; }
        
        public string Location { get; set; }
        
        public int Status { get; set; }
        
        public int Accesory { get; set; }
        
        public DateTime SaftyClearence { get; set; }
        
        public DateTime PassGenerated { get; set; }
        
        public DateTime BadgeGenerated { get; set; }
        
        public DateTime Entered { get; set; }
        
        public DateTime MeetingComplete { get; set; }
        
        public DateTime ExitOn { get; set; }
        
        public int Del_Flag { get; set; }
        
        public string CreatedOn { get; set; }
        
        public string CreatedBy { get; set; }
        
        public string UpdatedOn { get; set; }
        
        public string UpdatedBy { get; set; }

    }
}
