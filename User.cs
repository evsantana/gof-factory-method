namespace FactoryMethod_Notifications
{
    public class User
    {
        public User()
        {
        }

        public User(string name, string phone, string whatsapp, string email)
        {
            Name = name;
            Phone = phone;
            Whatsapp = whatsapp;
            Email = email;
        }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Whatsapp { get; set; }
        public string Email { get; set; }
    }
}
