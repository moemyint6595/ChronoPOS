using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrono.Shared.Pages.Table
{
    public partial class Table
    {
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender) 
            {
                await R.ComFn.CalBodyHeight();
            }
        }
    }
}
