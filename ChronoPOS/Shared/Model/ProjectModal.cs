using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Model
{
    public class NavMenuItem
    {
        public string MainMenu { get; set; } = string.Empty;

        public List<string> SubMenu { get; set; } = new();
    }

    public struct AppTheme
    {
        public int Id { get; set; }
        public string ThemeName { get; set; }
        public string ColorCode { get; set; }
    }

    public class FileUploadData
    {
        public byte[] Buffer = Array.Empty<byte>();

        public string FileName { get; set; } = string.Empty;

        public string ContentType { get; set; } = string.Empty;
    }
}
