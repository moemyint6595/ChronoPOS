using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTVPro.Shared.Pages.Order
{
    public partial class Orders
    {
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender) 
            {
                ComFn.CalBodyHeight();
                ComFn.JSConsole("Gva categories", Gva.Categories);
                ComFn.JSConsole("Gva SubCategories", Gva.SubCategories);
                ComFn.JSConsole("Gva Items", Gva.Items);
                ComFn.JSConsole("Gva Discounts", Gva.Discounts);
            }
        }
    }
}
