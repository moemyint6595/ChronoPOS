using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chrono.Shared.Pages.Home
{
    public partial class Main
    {
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender) 
            {
                R.ComFn.CalBodyHeight();
            }
        }
    }
}
