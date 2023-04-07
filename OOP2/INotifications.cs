using System;

namespace OOP2
{
    //Task5
    interface INotifications
    {
        void SendMessage();
    }
    class Email : INotifications
    {
        public void SendMessage()
        {
            Console.WriteLine("You have new Email");
        }
    }
    class SMS : INotifications
    {
        public void SendMessage()
        {
            Console.WriteLine("You have new SMS");
        }
    }
    class Messanger : INotifications
    {
        public void SendMessage()
        {
            Console.WriteLine("You have new  --_(*_*)_--  ");
        }
    }


}
