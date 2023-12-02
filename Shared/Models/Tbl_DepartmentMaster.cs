using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS_App.Shared.Models
{
    public class Tbl_DepartmentMaster
    {
        public int Id { get; set; }
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string HOD { get; set; }
        public int Del_Flag { get; set; }
        public string CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }

    }
}
