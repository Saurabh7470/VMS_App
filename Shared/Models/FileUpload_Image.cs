using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS_App.Shared.Models
{
    public class SaveFile
    {
        public SaveFile()
        {
            Files = new List<FileData>();
        }
        public List<FileData> Files { get; set; }
    }

    public class FileData
    {
        public byte[] ImageBytes { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public long FileSize { get; set; }
    }
}
