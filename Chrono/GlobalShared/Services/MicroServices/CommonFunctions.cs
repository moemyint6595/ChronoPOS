using Chrono_APIAccess;
using ChronoEntity.Entities;
using Microsoft.JSInterop;
using E = ChronoEntity;

namespace GlobalShared.Services.MicroServices
{
    public class CommonFunctions
    {
        private readonly GlobalVariables Gva;
        private readonly IJSRuntime JSRuntime;
        private readonly APIContext D;
        public readonly APIFunctions APIFuns;
        public CommonFunctions(GlobalVariables _gva, IJSRuntime _jsRuntime, APIContext _apiContext) 
        { 
            Gva = _gva;
            JSRuntime = _jsRuntime;
            D = _apiContext;
            APIFuns = new APIFunctions(D,Gva);
        }

        public void JSConsole(string? title = null, object? data = null )
        {
            JSRuntime.InvokeVoidAsync("console.log", $"{title} => ", data ?? "Debug Console loging");
        }

        public async Task CalBodyHeight()
        {
            await JSRuntime.InvokeVoidAsync("CommonJSFunctions.CalculateContentHeight");
        }

        public async Task ExpendToggle()
        {
            await JSRuntime.InvokeVoidAsync("CommonJSFunctions.NavMenuExpendToggle");
        }
    }

    public class APIFunctions(APIContext _d, GlobalVariables _gva)
    {
        private readonly APIContext D = _d;
        private readonly GlobalVariables Gva = _gva;

        public async Task GetAllData()
        {
            await Task.WhenAll(GetItem(),GetCategory(),GetSubCategory(),GetDiscount());
        }
        public async Task GetCategory()
        {
            try
            {
                if (IsDataUpdated(nameof(Category))) return;
                var response = await D.Category.GetAsync();
                if (response is null) return;
                if (response.Status == E.Status.Succcess && response.Result is not null)
                {
                    Gva.Categories = response.Result.ToList();
                    FinishedGetdata(nameof(Category));
                }
            }
            finally
            {

            }
        }

        public async Task GetSubCategory()
        {
            try
            {
                if (IsDataUpdated(nameof(SubCategory))) return;
                var response = await D.SubCategory.GetAsync();
                if (response is null) return;
                if (response.Status == E.Status.Succcess && response.Result is not null)
                {
                    Gva.SubCategories = response.Result.ToList();
                    FinishedGetdata(nameof(SubCategory));
                }
            }
            finally
            {

            }
        }

        public async Task GetItem()
        {
            try
            {
                if (IsDataUpdated(nameof(Item))) return;
                var response = await D.Item.GetAsync();
                if (response is null) return;
                if (response.Status == E.Status.Succcess && response.Result is not null)
                {
                    Gva.Items = response.Result.ToList();
                    FinishedGetdata(nameof(Item));
                }
            }
            finally
            {

            }
        }

        public async Task GetDiscount()
        {
            try
            {
                if (IsDataUpdated(nameof(Discount))) return;
                var response = await D.Discount.GetAsync();
                if (response is null) return;
                if (response.Status == E.Status.Succcess && response.Result is not null)
                {
                    Gva.Discounts = response.Result.ToList();
                    FinishedGetdata(nameof(Discount));
                }
            }
            finally
            {

            }
        }

        public void ToRefreshTable(string tableName)
        {
            UpdateDataHandler[tableName] = false;
        }

        public void FinishedGetdata(string tableName)
        {
            UpdateDataHandler[tableName] = true;
        }

        public bool IsDataUpdated (string tableName)
        {
            return UpdateDataHandler[tableName];
        }

        private readonly Dictionary<string, bool> UpdateDataHandler = new Dictionary<string, bool>()
        {
            {nameof(Category), false },
            {nameof(SubCategory), false },
            {nameof(Item), false },
            {nameof(Discount), false },
        };
    }
}
