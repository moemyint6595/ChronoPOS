namespace GlobalShared.Services.MicroServices
{
    public class NotifierService
    {
        public async Task Update(string objname = "", string action = "", object? obj = null)
        {
            if (Notify != null)
            {
                Notify.Invoke(objname, action, obj);
            }
            if (NotifyAsync != null)
            {
                await NotifyAsync.Invoke(objname, action, obj);
            }
        }
        public event Func<string, string, object?, Task>? NotifyAsync;
        public Action<string, string, object?>? Notify;
    }
}
