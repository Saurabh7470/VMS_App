using System.Collections.Generic;

namespace VMS_App.Client.LoginService
{
    public class Image
    {
        public Image() 
        {
            Files = new List<FileData>();
        }
        public List<FileData> Files { get; set; }

        
    }

    public class FileData
    {
        public byte[] imageByte { get; set; }

        public string Filename { get; set; }

        public string Filetype { get; set; }

        public long FileSize { get; set; }

        public string imagUrl { get; set; }

    }
}
