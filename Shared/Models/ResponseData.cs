using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS_App.Shared.Models
{
    public class ResponseData
    {
        public bool Success { get; set; } = false;

        public int StatusCode { get; set; }
        
        public string Message { get; set; } = string.Empty;
        
        public object Data { get; set; }
    }
}
