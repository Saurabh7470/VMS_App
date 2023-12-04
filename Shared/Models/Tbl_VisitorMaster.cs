using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace VMS_App.Shared.Models
{
    public class Tbl_VisitorMaster
    {
        [Key]
        public Guid Id { get; set; }

        public string? VisitorCode { get; set; }

        public string? Name { get; set; }

        public DateTime? Dbo { get; set; }

        public string? MobileNo { get; set; }

        public string? Email { get; set; }

        public string? Photograph { get; set; }

        public string IdType { get; set; }

        public string? PersonalId { get; set; }

        public string? PersonalIdFile { get; set; }

        public string? Address { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }

        public string? Country { get; set; }

        public string? Pincode { get; set; }

        public string? Company { get; set; }

        public int? Status { get; set; }

        public int? DelFlag { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public string? UpdatedBy { get; set; }

    }
}
