using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTVPro.Shared.Pages.Category
{
    public partial class Category
    {
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                ComFn.CalBodyHeight();
            }
        }
    }
}
