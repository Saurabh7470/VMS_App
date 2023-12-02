using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS_App.Shared.Models
{
    public class Tbl_IdentityType
    {
        [Key]
        public Guid Id { get; set; }

        public string? Idtype { get; set; }

        public string? Description { get; set; }

        public int? DelFlag { get; set; }


    }
}
