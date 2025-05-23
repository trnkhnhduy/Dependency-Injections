using System;

namespace NotificationDemo.Services
{
    public class EmailNotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"[Email] {message}");
        }
    }
}
