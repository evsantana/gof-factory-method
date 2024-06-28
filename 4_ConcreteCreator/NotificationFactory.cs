using FactoryMethod_Notifications.ConcreteProduct;
using FactoryMethod_Notifications.Creator;
using FactoryMethod_Notifications.Enum;
using FactoryMethod_Notifications.Product;

namespace FactoryMethod_Notifications._4_ConcreteCreator
{
    public class NotificationFactory : NotificationFactoryMethod
    {
        private User _user;
        private readonly Dictionary<Notifications, Func<Notification>> Notifies;

        public NotificationFactory()
        {
            //Dictionary to map instances according to the enum type
            Notifies = new Dictionary<Notifications, Func<Notification>>
            {
                {Notifications.Email, () => new Email(_user.Name, _user.Email) },
                {Notifications.SMS, () => new SMS(_user.Name, _user.Phone) },
                {Notifications.Whatsapp, () => new Whastapp(_user.Name, _user.Whatsapp) },
            };
        }

        public override Notification CreateNotification(Notifications type, User user)
        {
            _user = user;
            var notification = Notifies[type];

            return notification();
        }

    }
}
