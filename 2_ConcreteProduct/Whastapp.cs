using FactoryMethod_Notifications.Product;

namespace FactoryMethod_Notifications.ConcreteProduct
{
    public class Whastapp : Notification
    {
        public Whastapp()
        {
            response = $"Whastapp send";
        }

        public Whastapp(string name, string whatsapp)
        {
            response = $"Whastapp send to {name} - {whatsapp}";
        }


    }
}
