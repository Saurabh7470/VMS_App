using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace VMS_App.Shared.Models
{
    public class Tbl_VisitorMaster
    {
        public Guid Id { get; set; }
        
        public string VisitorCode { get; set; }
        
        public string Name { get; set; }

        public DateTime? DBO { get; set; } = DateTime.Today;
        
        public string MobileNo { get; set; }
        
        public string Email { get; set; }
        
        public string Photograph { get; set; }
        
        public string Id_Type { get; set; }
        
        public string Personal_Id { get; set; }
        
        public string PersonalId_File { get; set; }
        
        public string Address { get; set; }
        
        public string City { get; set; }
        
        public string State { get; set; }
        
        public string Country { get; set; }
        
        public string Pincode { get; set; }
        
        public string Company { get; set; }
        
        public int Status { get; set; }
        
        public int Del_Flag { get; set; }
        
        public string CreatedOn { get; set; }
        
        public string CreatedBy { get; set; }
        
        public string UpdatedOn { get; set; }
        
        public string UpdatedBy { get; set; }
    }
}
