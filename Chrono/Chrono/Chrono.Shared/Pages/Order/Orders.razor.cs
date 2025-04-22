using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrono.Shared.Pages.Order
{
    public partial class Orders
    {
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender) 
            {
                R.ComFn.CalBodyHeight();
                R.ComFn.JSConsole("Gva categories", R.Gva.Categories);
                R.ComFn.JSConsole("Gva SubCategories", R.Gva.SubCategories);
                R.ComFn.JSConsole("Gva Items", R.Gva.Items);
                R.ComFn.JSConsole("Gva Discounts", R.Gva.Discounts);
            }
        }
    }
}
