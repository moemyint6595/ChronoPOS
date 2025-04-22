using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalShared.Helpers
{
    public class GlobalResizeHelper
    {
        public Action<int,int> action;

        public GlobalResizeHelper(Action<int,int> action)
        {
            this.action = action;
        }

        [JSInvokable]
        public void GlobalResizeCaller(int width, int height) 
        { 
            action.Invoke(width, height);
        }
    }
}
