using GlobalShared.Services.StaticServices;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalShared.Model
{
    public class NavMenuItem
    {
        public int MenuId { get; set; }
        public SubMenuItem MainMenu { get; set; } = new();
        public List<SubMenuItem> SubMenu { get; set; } = [];
    }

    public class SubMenuItem
    {
        public string Name { get; set; } = string.Empty;
        public string Route { get; set; } = string.Empty;
        public bool LastMenu { get; set; }
        public RenderFragment Icon { get; set; } = SVGService.NavDefaultIcon(20, 20);
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
