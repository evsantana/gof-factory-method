using FactoryMethod_Notifications;
using FactoryMethod_Notifications._4_ConcreteCreator;
using FactoryMethod_Notifications.Enum;
using FactoryMethod_Notifications.Product;

Console.WriteLine("--------------");

try
{

    User user = new User()
    {
        Email = "user@email.com",
        Name = "User 1",
        Phone = "+551899589585",
        Whatsapp = "+551191117444"
    };

    NotificationFactory notificationFactory = new NotificationFactory();
    Notification notification;

    notification = notificationFactory.CreateNotification(Notifications.SMS, user);
    Console.WriteLine(notification.Send());

    Console.WriteLine("--------------");

    notification = notificationFactory.CreateNotification(Notifications.Email, user);
    Console.WriteLine(notification.Send());

    Console.WriteLine("--------------");

    Notification notificationWhastapp = notificationFactory.CreateNotification(Notifications.Whatsapp, user);
    Console.WriteLine(notificationWhastapp.Send());

    Console.WriteLine("--------------");


}
catch (Exception ex)
{
    Console.WriteLine("Erro: " + ex.Message);
}