using System;

namespace NotificationDemo.Services
{
    public class SMSNotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"[SMS] {message}");
        }
    }
}
