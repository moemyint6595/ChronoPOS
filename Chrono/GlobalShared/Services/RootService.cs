using GlobalShared.Services.MicroServices;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Chrono_APIAccess;

namespace GlobalShared.Services
{
    public class RootService
    {
        public readonly IJSRuntime JSRuntime;
        public readonly NavigationManager Nav;

        public readonly GlobalVariables Gva;
        public readonly APIContext D;
        public readonly CommonFunctions ComFn;
        public readonly LanguageService Lang;
        public readonly LocalStorageService LS;
        public readonly NotifierService Notifier;
        public readonly SignalRService SignalR;
        public RootService(IJSRuntime _JSRuntime, NavigationManager _Nav)
        {
            JSRuntime = _JSRuntime;
            Nav = _Nav;
            Gva = new GlobalVariables();
            D = new APIContext(Gva.APIEndPoint);
            ComFn = new CommonFunctions(Gva,JSRuntime,D);
            Lang = new LanguageService(); 
            LS = new LocalStorageService(JSRuntime);
            Notifier = new NotifierService();
            SignalR = new SignalRService(Gva.APIEndPoint);
        }
    }
}
