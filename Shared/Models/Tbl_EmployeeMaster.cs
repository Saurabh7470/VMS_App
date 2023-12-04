using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS_App.Shared.Models
{
    public class Tbl_EmployeeMaster
    {
        [Key]
        public Guid Id { get; set; }

        public string? EmpNumber { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Mobile { get; set; }

        public Guid? DepartmentId { get; set; }

        public string? Grade { get; set; }

        public string? Designation { get; set; }

        public int? Status { get; set; }

        public int? DelFlag { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public string? UpdatedBy { get; set; }

       

        public string? DeptCode { get; set; }

        public string? DeptName { get; set; }

        public string? Hod { get; set; }

       

       


    }
}
