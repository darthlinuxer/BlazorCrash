namespace BlazorCrash.Web.Services
{
    public class MessageService
    {
        public event Action<string> OnMessageReceived;

        public void SendMessage(string message)
        {
            OnMessageReceived?.Invoke(message);
        }
    }
}
