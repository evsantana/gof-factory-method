using FactoryMethod_Notifications.Product;

namespace FactoryMethod_Notifications.ConcreteProduct
{
    public class Email : Notification
    {

        public Email()
        {
            response = $"E-mail send";
        }

        public Email(string name, string email)
        {
            response = $"E-mail send to {name} - {email}";
        }
    }
}
