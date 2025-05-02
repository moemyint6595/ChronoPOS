using E = ChronoEntity;

using GlobalShared.Services.StaticServices;

namespace GlobalShared.Services.MicroServices
{
    public class GlobalVariables
    {
        public string MyString { get; private set; } = "MMZ 1996";
        public string APIEndPoint { get; private set; } = "https://localhost:7035";

        public string CurrentPage = MenuSection.Order;

        public List<E.Entities.Category> Categories = [];
        public List<E.Entities.SubCategory> SubCategories = [];
        public List<E.Entities.Item> Items = [];
        public List<E.Entities.Discount> Discounts = [];
    }

   
}
