using System;

namespace NotificationDemo.Services
{
    public class PushNotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"[Push Notification] {message}");
        }
    }
}
