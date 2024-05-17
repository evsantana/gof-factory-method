namespace FactoryMethod_Notifications.Product
{
    public abstract class Notification
    {
        protected string response;

        public string Send()
        {
            return response;
        }
    }
}
