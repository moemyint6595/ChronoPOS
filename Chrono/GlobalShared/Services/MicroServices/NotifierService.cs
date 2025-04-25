namespace GlobalShared.Services.MicroServices
{
    public class NotifierService
    {
        public async Task Update(string objname = "", string action = "", object? obj = null)
        {
            if (Listen != null)
            {
                Listen.Invoke(objname, action, obj);
            }
            if (ListenAsync != null)
            {
                await ListenAsync.Invoke(objname, action, obj);
            }
        }

        public event Func<string, string, object?, Task>? ListenAsync;
        public Action<string, string, object?>? Listen;
    }
}
