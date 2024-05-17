using FactoryMethod_Notifications.Enum;
using FactoryMethod_Notifications.Product;

namespace FactoryMethod_Notifications.Creator
{
    public abstract class NotificationFactoryMethod
    {
        public abstract Notification CreateNotification(Notifications type, User user);
    }
}
