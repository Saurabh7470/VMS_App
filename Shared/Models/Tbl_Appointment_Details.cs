using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS_App.Shared.Models
{
    public class Tbl_Appointment_Details
    {

        public Guid Id { get; set; }

        public Guid? AppointmentId { get; set; }

        public string? ActivityType { get; set; }

        public string? Description { get; set; }

        public string? Remark { get; set; }

        public int? DelFlag { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public string? UpdatedBy { get; set; }

    }
}
