using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Services
{
    public class CommonFunctions
    {
        private GlobalVariables Gva;
        private readonly IJSRuntime JSRuntime;
        public CommonFunctions(GlobalVariables _gva, IJSRuntime _jsRuntime) 
        { 
            Gva = _gva;
            JSRuntime = _jsRuntime;
        }

        public void JSConsole(string? title = null, object? data = null )
        {
            JSRuntime.InvokeVoidAsync("console.log", $"{title} => ", data ?? "Debug Console loging");
        }
    }
}
