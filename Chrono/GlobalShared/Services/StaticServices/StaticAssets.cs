using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalShared.Services.StaticServices
{
    public readonly struct MenuSection
    {
        public const string Main = "Table View";
        //Ordering  
        public const string Order = "Orders";
        public const string Table = "Table";

        //Setup
        public const string Items = "Items";
        public const string Category = "Category";
        public const string Discount = "Discount";

        //Setting
        public const string Permission = "Permission";
        public const string Printers = "Printers";
    }

    public readonly struct MainMenuSection
    {
        public const string Ordering = "Ordering";
        public const string Setup = "Setup";
    }

    public readonly struct NotifierObjectName
    {
        public const string SignalR = "SignalR";
    }

    public readonly struct NotifierActionName
    {
        public const string ThemeUpdateAction = "ThemeUpdateAction";
    }

    public readonly struct FileUploadUIDesign
    {
        public const string DragDrop = "dragdrop";
    }

    public readonly struct ModalStyle
    {
        public const string Full = "pu-dialog-full";

        public const string Medium = "pu-dialog-medium";

        public const string Small = "pu-dialog-small";

        public const string Auto = "pu-dialog-auto";
    }
}
