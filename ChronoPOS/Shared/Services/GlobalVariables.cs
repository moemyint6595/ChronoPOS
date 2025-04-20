using E = ChronoEntity;

namespace Shared.Services
{
    public class GlobalVariables
    {
        public string MyString { get; private set; } = "MMZ 1996";
        public string APIEndPoint { get; private set; } = "https://192.168.100.173:2002";

        public List<E.Entities.Category> Categories = [];
        public List<E.Entities.SubCategory> SubCategories = [];
        public List<E.Entities.Item> Items = [];
        public List<E.Entities.Discount> Discounts = [];
    }

    public readonly struct MenuSection
    {
        //Ordering  
        public const string Order = "Orders";

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
        public const string ThemeUpdate = "ThemeUpdate";
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
