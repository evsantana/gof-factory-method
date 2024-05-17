using FactoryMethod_Notifications.Product;

namespace FactoryMethod_Notifications.ConcreteProduct
{
    public class SMS : Notification
    {
        private User _user;

        public SMS()
        {
            //response = teste;
            response = $"SMS send";
        }

        public SMS(string name, string phone)
        {
            response = $"SMS send to {name} - {phone}";
        }

    }
}
